using System;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using LILO_WebEngine.Core.Middleware;
using LILO_WebEngine.Core.Local;
using LILO_WebEngine.Core.Local.Types;
using LILO_WebEngine.Core.Handler;

namespace LILO_WebEngine.Core.WebSockets
{
    public class LiveReloadScriptInjector
    {
        private static readonly Lazy<LiveReloadScriptInjector> _instance = new(() => new LiveReloadScriptInjector());
        public static LiveReloadScriptInjector Instance => _instance.Value;
        
        private readonly string _liveReloadScript;
        
        private LiveReloadScriptInjector()
        {
            _liveReloadScript = GenerateLiveReloadScript();
        }
        
        /// <summary>
        /// Injects the live reload script into HTML content
        /// </summary>
        public string InjectScriptIntoHtml(string html, string baseUrl)
        {
            if (string.IsNullOrEmpty(html))
                return html;

            // Simple check if this is an HTML document
            if (!html.Contains("<html") && !html.Contains("<HTML"))
                return html;
                
            // Find the closing </body> tag and insert our script before it
            var closeBodyIndex = html.LastIndexOf("</body>", StringComparison.OrdinalIgnoreCase);
            if (closeBodyIndex >= 0)
            {
                return html.Insert(closeBodyIndex, GetLiveReloadScript(baseUrl));
            }
            
            // If no </body> tag, try to insert before </html>
            var closeHtmlIndex = html.LastIndexOf("</html>", StringComparison.OrdinalIgnoreCase);
            if (closeHtmlIndex >= 0)
            {
                return html.Insert(closeHtmlIndex, GetLiveReloadScript(baseUrl));
            }
            
            // If neither tag is found, append to the end
            return html + GetLiveReloadScript(baseUrl);
        }
        
        /// <summary>
        /// Returns the live reload script with the WebSocket URL replaced
        /// </summary>
        public string GetLiveReloadScript(string baseUrl)
        {
            // Replace the placeholder with the actual WebSocket URL
            return _liveReloadScript.Replace("{{WEBSOCKET_URL}}", 
                baseUrl.Replace("http://", "ws://").Replace("https://", "wss://"));
        }
        
        /// <summary>
        /// Helper method to check if a file path appears to be HTML
        /// </summary>
        public bool IsLikelyHtml(string path)
        {
            return string.IsNullOrEmpty(Path.GetExtension(path)) || 
                   path.EndsWith(".html", StringComparison.OrdinalIgnoreCase) ||
                   path.EndsWith(".htm", StringComparison.OrdinalIgnoreCase);
        }
        
        /// <summary>
        /// Gets the WebSocket base URL from a request
        /// </summary>
        public string GetBaseUrlFromRequest(HttpListenerRequest request)
        {
            var scheme = request.Url.Scheme;
            var host = request.Url.Host;
            var port = request.Url.Port;
            
            return $"{scheme}://{host}:{port}/";
        }
        
        /// <summary>
        /// Reads HTML file content and injects the live reload script
        /// </summary>
        public async Task<string> InjectScriptIntoHtmlFile(string filePath, string baseUrl)
        {
            try
            {
                string html = await File.ReadAllTextAsync(filePath);
                return InjectScriptIntoHtml(html, baseUrl);
            }
            catch (Exception ex)
            {
                LogError($"Error injecting script into HTML file: {ex.Message}");
                return null;
            }
        }
        
        private void LogError(string message)
        {
            try
            {
                EngineEventHandler.Instance.AddEvent(new WEB_ENGINE_EVENT
                {
                    Name = "LiveReload Error",
                    Description = message,
                    NeedsToAccept = false,
                    HappeningTime = DateTime.Now
                });
            }
            catch
            {
                // Ignore errors in error logging
            }
        }
        
        private string GenerateLiveReloadScript()
        {
            // This script will:
            // 1. Connect to the WebSocket server
            // 2. Listen for file change events
            // 3. Reload the page when CSS files change
            // 4. Reload the page when other files change
            return @"
<script>
(function() {
    // LILO WebEngine LiveReload Client
    class LiveReloadClient {
        constructor(url) {
            this.url = url + 'ws';
            this.reconnectDelay = 1000;
            this.maxReconnectDelay = 30000;
            this.reconnectTimer = null;
            this.socket = null;
            this.fileExtensions = {
                css: 'reload-css',
                js: 'reload-page',
                html: 'reload-page',
                htm: 'reload-page'
            };
            this.connect();
            this.addConsoleMessage('LiveReload enabled');
        }
        
        connect() {
            this.socket = new WebSocket(this.url);
            
            this.socket.onopen = () => {
                this.reconnectDelay = 1000;
                this.addConsoleMessage('LiveReload connected');
                this.sendMessage('ping');
            };
            
            this.socket.onclose = () => {
                this.scheduleReconnect();
            };
            
            this.socket.onerror = (error) => {
                this.addConsoleMessage('LiveReload error: ' + error);
                this.socket.close();
            };
            
            this.socket.onmessage = (event) => {
                this.handleMessage(event.data);
            };
        }
        
        scheduleReconnect() {
            clearTimeout(this.reconnectTimer);
            this.reconnectTimer = setTimeout(() => {
                this.addConsoleMessage('LiveReload reconnecting...');
                this.connect();
            }, this.reconnectDelay);
            
            // Exponential backoff
            this.reconnectDelay = Math.min(this.reconnectDelay * 1.5, this.maxReconnectDelay);
        }
        
        handleMessage(data) {
            try {
                const message = JSON.parse(data);
                
                switch(message.type) {
                    case 'fileChange':
                        this.handleFileChange(message.data);
                        break;
                    case 'pong':
                        // Handle ping response
                        break;
                    case 'connection':
                        this.addConsoleMessage('LiveReload connection established');
                        break;
                    case 'reload':
                        this.addConsoleMessage('Manual reload triggered');
                        this.reloadPage();
                        break;
                    default:
                        // Unknown message type
                        break;
                }
            } catch (error) {
                this.addConsoleMessage('Error parsing message: ' + error);
            }
        }
        
        handleFileChange(data) {
            const path = data.path;
            const extension = path.split('.').pop().toLowerCase();
            const action = this.fileExtensions[extension] || 'reload-page';
            
            this.addConsoleMessage(`File changed: ${path} (${action})`);
            
            switch(action) {
                case 'reload-css':
                    this.reloadCSS();
                    break;
                case 'reload-page':
                    this.reloadPage();
                    break;
            }
        }
        
        reloadCSS() {
            const links = document.querySelectorAll('link[rel=stylesheet]');
            links.forEach(link => {
                const url = new URL(link.href);
                url.searchParams.set('_liveReload', Date.now());
                link.href = url.toString();
            });
            this.addConsoleMessage('CSS reloaded');
        }
        
        reloadPage() {
            window.location.reload();
        }
        
        sendMessage(type, data = {}) {
            if (this.socket && this.socket.readyState === WebSocket.OPEN) {
                this.socket.send(JSON.stringify({ type, data }));
            }
        }
        
        addConsoleMessage(message) {
            console.log(`[LiveReload] ${message}`);
        }
    }
    
    // Initialize LiveReload
    window.addEventListener('load', function() {
        window.liveReloadClient = new LiveReloadClient('{{WEBSOCKET_URL}}');
    });
})();
</script>
";
        }
    }
} 