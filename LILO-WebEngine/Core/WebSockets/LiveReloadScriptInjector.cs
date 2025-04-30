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
                baseUrl.Replace("http://", "ws://").Replace("https://", "wss://")).Replace("{{WEBSERVER_URL}}",baseUrl);
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
            // 3. Provide a UI to control reload behavior
            // 4. Show API state and logs
            return @"
<script>
(function() {
    // LILO WebEngine LiveReload Client
    class LiveReloadClient {
        constructor(url) {
            this.url = url + 'ws';
            this.baseUrl = `{{WEBSERVER_URL}}`;
            this.reconnectDelay = 1000;
            this.maxReconnectDelay = 30000;
            this.reconnectTimer = null;
            this.socket = null;
            this.isEnabled = true;
            this.logsCache = [];
            this.maxLogEntries = 100;
            this.isPanelVisible = false;
            this.autoScrollLogs = true;
            
            // Default file extension actions
            this.fileExtensions = {
                css: 'reload-css',
                js: 'reload-page',
                html: 'reload-page',
                htm: 'reload-page',
                jpeg: 'ignore',
                jpg: 'ignore',
                png: 'ignore',
                gif: 'ignore',
                svg: 'ignore',
                pdf: 'ignore'
            };
            
            // Create UI
            this.createUI();
            
            // Connect to server
            this.connect();
            
            // Log this action
            this.addLogEntry('info', 'LiveReload initialized');
        }
        
        connect() {
            if (!this.isEnabled) return;
            
            this.socket = new WebSocket(this.url);
            
            this.socket.onopen = () => {
                this.reconnectDelay = 1000;
                this.addLogEntry('success', 'WebSocket connected');
                this.sendMessage('ping');
                this.updateConnectionStatus(true);
            };
            
            this.socket.onclose = () => {
                this.updateConnectionStatus(false);
                this.scheduleReconnect();
            };
            
            this.socket.onerror = (error) => {
                this.addLogEntry('error', 'WebSocket error: ' + error);
                this.socket.close();
                this.updateConnectionStatus(false);
            };
            
            this.socket.onmessage = (event) => {
                this.handleMessage(event.data);
            };
        }
        
        scheduleReconnect() {
            if (!this.isEnabled) return;
            
            clearTimeout(this.reconnectTimer);
            this.reconnectTimer = setTimeout(() => {
                this.addLogEntry('info', 'Reconnecting...');
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
                        this.addLogEntry('success', 'Connection established: ' + message.data.id);
                        break;
                    case 'reload':
                        this.addLogEntry('info', 'Manual reload triggered');
                        if (this.isEnabled) this.reloadPage();
                        break;
                    default:
                        // Unknown message type
                        this.addLogEntry('info', 'Unknown message: ' + message.type);
                        break;
                }
            } catch (error) {
                this.addLogEntry('error', 'Error parsing message: ' + error);
            }
        }
        
        handleFileChange(data) {
            const path = data.path;
            const extension = path.split('.').pop().toLowerCase();
            const action = this.fileExtensions[extension] || 'reload-page';
            
            this.addLogEntry('info', `File changed: ${path} (${action})`);
            
            if (!this.isEnabled) {
                this.addLogEntry('warning', 'Auto-reload disabled, skipping action');
                return;
            }
            
            switch(action) {
                case 'reload-css':
                    this.reloadCSS();
                    break;
                case 'reload-page':
                    this.reloadPage();
                    break;
                case 'ignore':
                    // Do nothing for ignored extensions
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
            this.addLogEntry('success', 'CSS reloaded');
        }
        
        reloadPage() {
            window.location.reload();
        }
        
        sendMessage(type, data = {}) {
            if (this.socket && this.socket.readyState === WebSocket.OPEN) {
                this.socket.send(JSON.stringify({ type, data }));
            }
        }
        
        addLogEntry(level, message) {
            const entry = {
                time: new Date(),
                level,
                message
            };
            
            // Add to log cache with max size limit
            this.logsCache.push(entry);
            if (this.logsCache.length > this.maxLogEntries) {
                this.logsCache.shift();
            }
            
            // Log to console
            console.log(`[LiveReload] ${message}`);
            
            // Update UI if visible
            this.updateLogsPanel();
        }
        
        createUI() {
            // Create styles
            const style = document.createElement('style');
            style.textContent = `
                /* Shadcn-inspired Dark UI Theme */
                :root {
                    --background: #0f0f0f;
                    --foreground: #f2f2f2;
                    --card: #1c1c1c;
                    --card-foreground: #f2f2f2;
                    --popover: #1c1c1c;
                    --popover-foreground: #f2f2f2;
                    --primary: #9333ea;
                    --primary-foreground: #f2f2f2;
                    --secondary: #27272a;
                    --secondary-foreground: #a1a1aa;
                    --muted: #27272a;
                    --muted-foreground: #a1a1aa;
                    --accent: #3a3a3c;
                    --accent-foreground: #f2f2f2;
                    --destructive: #ef4444;
                    --destructive-foreground: #f2f2f2;
                    --border: #27272a;
                    --input: #27272a;
                    --ring: #9333ea;
                    --radius: 0.5rem;
                    --font-sans: ui-sans-serif, system-ui, -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Helvetica, Arial, sans-serif;
                    
                    /* Shadcn-style sizes */
                    --height-1: 1.5rem;
                    --height-2: 2rem; 
                    --height-3: 2.5rem;
                    --height-4: 3rem;
                    
                    /* Shadcn spacing */
                    --space-1: 0.25rem;
                    --space-2: 0.5rem;
                    --space-3: 0.75rem;
                    --space-4: 1rem;
                    --space-5: 1.25rem;
                    --space-6: 1.5rem;
                    --space-8: 2rem;
                    --space-10: 2.5rem;
                    
                    /* Status colors */
                    --info-color: #3b82f6;
                    --success-color: #10b981;
                    --warning-color: #f59e0b;
                    --error-color: #ef4444;
                }
                
                #lilo-livereload-panel {
                    position: fixed;
                    bottom: 20px;
                    right: 20px;
                    z-index: 9999;
                    font-family: var(--font-sans);
                    color: var(--foreground);
                    transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
                    max-width: 580px;
                    width: calc(100% - 40px);
                    filter: drop-shadow(0 10px 8px rgb(0 0 0 / 0.04)) drop-shadow(0 4px 3px rgb(0 0 0 / 0.1));
                }
                
                #lilo-livereload-button {
                    position: fixed;
                    bottom: 20px;
                    right: 20px;
                    background-color: var(--primary);
                    color: white;
                    border: none;
                    border-radius: 50%;
                    width: 48px;
                    height: 48px;
                    cursor: pointer;
                    z-index: 10000;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                    box-shadow: 0 2px 10px rgba(147, 51, 234, 0.3);
                    transition: all 0.2s cubic-bezier(0.4, 0, 0.2, 1);
                    outline: none;
                }
                
                #lilo-livereload-button:hover {
                    background-color: #a855f7;
                    transform: scale(1.05);
                }
                
                #lilo-livereload-button:active {
                    background-color: #7e22ce;
                    transform: scale(0.95);
                }
                
                #lilo-livereload-button:focus-visible {
                    box-shadow: 0 0 0 2px var(--background), 0 0 0 4px var(--ring);
                }
                
                #lilo-livereload-button:before {
                    content: '↻';
                    font-size: 22px;
                    font-weight: bold;
                }
                
                .lilo-livereload-panel-content {
                    background-color: var(--background);
                    border-radius: var(--radius);
                    box-shadow: 0 4px 25px rgba(0, 0, 0, 0.3);
                    overflow: hidden;
                    display: flex;
                    flex-direction: column;
                    border: 1px solid var(--border);
                    height: 80vh;
                    max-height: 600px;
                    min-height: 300px;
                }
                
                .lilo-livereload-header {
                    background-color: var(--card);
                    padding: 14px 16px;
                    border-bottom: 1px solid var(--border);
                    display: flex;
                    justify-content: space-between;
                    align-items: center;
                }
                
                .lilo-livereload-title {
                    font-weight: 600;
                    font-size: 16px;
                    margin: 0;
                    display: flex;
                    align-items: center;
                    gap: var(--space-2);
                }
                
                .lilo-livereload-body {
                    padding: 0;
                    flex: 1;
                    overflow: hidden;
                    display: flex;
                    flex-direction: column;
                }
                
                .lilo-livereload-tabs {
                    display: flex;
                    background-color: var(--card);
                    gap: 1px;
                    padding: 0 var(--space-1);
                    border-bottom: 1px solid var(--border);
                }
                
                .lilo-livereload-tab {
                    padding: var(--space-3) var(--space-4);
                    cursor: pointer;
                    font-size: 14px;
                    color: var(--muted-foreground);
                    border-bottom: 2px solid transparent;
                    transition: all 0.2s;
                    user-select: none;
                }
                
                .lilo-livereload-tab:hover {
                    color: var(--foreground);
                    background-color: var(--accent);
                }
                
                .lilo-livereload-tab.active {
                    color: var(--primary);
                    border-bottom-color: var(--primary);
                    font-weight: 500;
                }
                
                .lilo-livereload-tab-content {
                    display: none;
                    padding: var(--space-5);
                    overflow-y: auto;
                    flex: 1;
                }
                
                .lilo-livereload-tab-content.active {
                    display: block;
                }
                
                .lilo-livereload-settings {
                    display: grid;
                    gap: var(--space-4);
                    padding-bottom: var(--space-4);
                    border-bottom: 1px solid var(--border);
                    margin-bottom: var(--space-5);
                }
                
                .lilo-card {
                    background-color: var(--card);
                    border-radius: var(--radius);
                    padding: var(--space-4);
                    border: 1px solid var(--border);
                    margin-bottom: var(--space-4);
                }
                
                .lilo-card-header {
                    margin-bottom: var(--space-3);
                    padding-bottom: var(--space-3);
                    border-bottom: 1px solid var(--border);
                }
                
                .lilo-card-title {
                    font-size: 15px;
                    font-weight: 600;
                    margin: 0;
                    color: var(--foreground);
                }
                
                .lilo-card-description {
                    font-size: 13px;
                    color: var(--muted-foreground);
                    margin-top: var(--space-1);
                }
                
                .lilo-livereload-setting {
                    display: flex;
                    align-items: center;
                    justify-content: space-between;
                    padding: var(--space-2) 0;
                }
                
                .lilo-livereload-label {
                    font-size: 14px;
                    color: var(--foreground);
                }
                
                .lilo-livereload-switch {
                    position: relative;
                    display: inline-block;
                    width: 40px;
                    height: 20px;
                }
                
                .lilo-livereload-switch input {
                    opacity: 0;
                    width: 0;
                    height: 0;
                }
                
                .lilo-livereload-slider {
                    position: absolute;
                    cursor: pointer;
                    top: 0;
                    left: 0;
                    right: 0;
                    bottom: 0;
                    background-color: var(--muted);
                    transition: .3s;
                    border-radius: 34px;
                }
                
                .lilo-livereload-slider:before {
                    position: absolute;
                    content: '';
                    height: 16px;
                    width: 16px;
                    left: 2px;
                    bottom: 2px;
                    background-color: var(--foreground);
                    transition: .3s;
                    border-radius: 50%;
                }
                
                input:checked + .lilo-livereload-slider {
                    background-color: var(--primary);
                }
                
                input:checked + .lilo-livereload-slider:before {
                    transform: translateX(20px);
                }
                
                .lilo-livereload-extension-setting {
                    display: flex;
                    justify-content: space-between;
                    align-items: center;
                    padding: var(--space-2) 0;
                    border-bottom: 1px solid var(--border);
                }
                
                .lilo-livereload-extension-setting:last-child {
                    border-bottom: none;
                }
                
                .lilo-livereload-extension-name {
                    font-weight: 500;
                    font-size: 14px;
                }
                
                .lilo-livereload-select {
                    background-color: var(--input);
                    color: var(--foreground);
                    border: 1px solid var(--border);
                    border-radius: var(--radius);
                    padding: var(--space-1) var(--space-2);
                    font-size: 13px;
                    outline: none;
                    transition: all 0.2s;
                }
                
                .lilo-livereload-select:focus {
                    border-color: var(--ring);
                    box-shadow: 0 0 0 1px var(--ring);
                }
                
                .lilo-log-entry {
                    padding: var(--space-2) 0;
                    border-bottom: 1px solid var(--border);
                    font-size: 13px;
                    display: flex;
                }
                
                .lilo-log-time {
                    color: var(--muted-foreground);
                    font-size: 11px;
                    margin-right: var(--space-2);
                    white-space: nowrap;
                }
                
                .lilo-log-message {
                    word-break: break-word;
                }
                
                .lilo-log-info { color: var(--info-color); }
                .lilo-log-success { color: var(--success-color); }
                .lilo-log-warning { color: var(--warning-color); }
                .lilo-log-error { color: var(--error-color); }
                
                .lilo-state-info {
                    margin-bottom: var(--space-4);
                }
                
                .lilo-state-label {
                    font-weight: 500;
                    font-size: 14px;
                    margin-bottom: var(--space-2);
                    color: var(--foreground);
                }
                
                .lilo-state-value {
                    padding: var(--space-3);
                    background-color: var(--secondary);
                    border-radius: var(--radius);
                    font-family: ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, monospace;
                    font-size: 12px;
                    overflow: auto;
                    max-height: 150px;
                    color: var(--secondary-foreground);
                    word-break: break-word;
                }
                
                .lilo-btn {
                    background-color: var(--primary);
                    color: var(--primary-foreground);
                    border: none;
                    border-radius: var(--radius);
                    padding: var(--space-2) var(--space-4);
                    height: var(--height-2);
                    cursor: pointer;
                    transition: all 0.2s;
                    font-size: 13px;
                    font-weight: 500;
                    display: inline-flex;
                    align-items: center;
                    justify-content: center;
                    outline: none;
                }
                
                .lilo-btn:hover {
                    background-color: #a855f7;
                }
                
                .lilo-btn:active {
                    background-color: #7e22ce;
                }
                
                .lilo-btn:focus-visible {
                    box-shadow: 0 0 0 2px var(--background), 0 0 0 4px var(--ring);
                }
                
                .lilo-btn-secondary {
                    background-color: var(--secondary);
                    color: var(--secondary-foreground);
                }
                
                .lilo-btn-secondary:hover {
                    background-color: var(--accent);
                    color: var(--accent-foreground);
                }
                
                .lilo-btn-destructive {
                    background-color: var(--destructive);
                    color: var(--destructive-foreground);
                }
                
                .lilo-btn-destructive:hover {
                    background-color: #f87171;
                }
                
                .lilo-connection-status {
                    display: inline-block;
                    width: 8px;
                    height: 8px;
                    border-radius: 50%;
                }
                
                .lilo-connection-status.connected {
                    background-color: var(--success-color);
                    box-shadow: 0 0 5px var(--success-color);
                }
                
                .lilo-connection-status.disconnected {
                    background-color: var(--error-color);
                    box-shadow: 0 0 5px var(--error-color);
                }
                
                .lilo-actions {
                    margin-top: var(--space-6);
                    display: flex;
                    gap: var(--space-2);
                    justify-content: flex-end;
                    border-top: 1px solid var(--border);
                    padding-top: var(--space-4);
                }
                
                .lilo-badge {
                    display: inline-flex;
                    align-items: center;
                    justify-content: center;
                    border-radius: 9999px;
                    font-size: 11px;
                    font-weight: 500;
                    line-height: 1;
                    padding: 0 8px;
                    height: 18px;
                    background-color: var(--primary);
                    color: var(--primary-foreground);
                }
                
                .lilo-badge-secondary {
                    background-color: var(--secondary);
                    color: var(--secondary-foreground);
                }
                
                .lilo-empty-state {
                    padding: var(--space-8);
                    text-align: center;
                    color: var(--muted-foreground);
                }
                
                /* Scrollbars */
                .lilo-livereload-tab-content::-webkit-scrollbar {
                    width: 8px;
                }
                
                .lilo-livereload-tab-content::-webkit-scrollbar-track {
                    background-color: var(--background);
                }
                
                .lilo-livereload-tab-content::-webkit-scrollbar-thumb {
                    background-color: var(--muted);
                    border-radius: 4px;
                }
                
                .lilo-livereload-tab-content::-webkit-scrollbar-thumb:hover {
                    background-color: var(--accent);
                }
                
                /* Animations */
                @keyframes fadeIn {
                    from { opacity: 0; transform: translateY(10px); }
                    to { opacity: 1; transform: translateY(0); }
                }
                
                #lilo-livereload-panel {
                    animation: fadeIn 0.3s ease-out;
                }
                
                details {
                    margin-top: var(--space-2);
                }
                
                summary {
                    cursor: pointer;
                    color: var(--muted-foreground);
                    padding: var(--space-1) 0;
                }
                
                pre {
                    margin: var(--space-2) 0;
                    padding: var(--space-2);
                    background-color: var(--muted);
                    border-radius: var(--radius);
                    font-size: 11px;
                    overflow-x: auto;
                }
            `;
            document.head.appendChild(style);
            
            // Create button
            const button = document.createElement('button');
            button.id = 'lilo-livereload-button';
            button.title = 'LILO LiveReload';
            button.setAttribute('aria-label', 'Open LiveReload Panel');
            button.addEventListener('click', () => this.togglePanel());
            document.body.appendChild(button);
            
            // Create panel
            const panel = document.createElement('div');
            panel.id = 'lilo-livereload-panel';
            panel.style.display = 'none';
            
            panel.innerHTML = `
                <div class='lilo-livereload-panel-content'>
                    <div class='lilo-livereload-header'>
                        <h3 class='lilo-livereload-title'>
                            <span class='lilo-connection-status'></span>
                            Serix - Local
                        </h3>
                        <button id='lilo-livereload-close' class='lilo-btn lilo-btn-secondary'>Close</button>
                    </div>
                    <div class='lilo-livereload-body'>
                        <div class='lilo-livereload-tabs'>
                            <div class='lilo-livereload-tab active' data-tab='settings'>Settings</div>
                            <div class='lilo-livereload-tab' data-tab='logs'>Logs</div>
                            <div class='lilo-livereload-tab' data-tab='state'>Server State</div>
                            <div class='lilo-livereload-tab' data-tab='events'>Events</div>
                        </div>
                        
                        <!-- Settings Tab -->
                        <div class='lilo-livereload-tab-content active' data-tab-content='settings'>
                            <div class='lilo-card'>
                                <div class='lilo-card-header'>
                                    <h4 class='lilo-card-title'>LiveReload Options</h4>
                                    <p class='lilo-card-description'>Configure how LiveReload behaves in your browser</p>
                                </div>
                                <div class='lilo-livereload-settings'>
                                    <div class='lilo-livereload-setting'>
                                        <span class='lilo-livereload-label'>Enable LiveReload</span>
                                        <label class='lilo-livereload-switch'>
                                            <input type='checkbox' id='lilo-setting-enabled' checked>
                                            <span class='lilo-livereload-slider'></span>
                                        </label>
                                    </div>
                                    <div class='lilo-livereload-setting'>
                                        <span class='lilo-livereload-label'>Auto-scroll logs</span>
                                        <label class='lilo-livereload-switch'>
                                            <input type='checkbox' id='lilo-setting-autoscroll' checked>
                                            <span class='lilo-livereload-slider'></span>
                                        </label>
                                    </div>
                                </div>
                            </div>
                            
                            <div class='lilo-card'>
                                <div class='lilo-card-header'>
                                    <h4 class='lilo-card-title'>File Extension Actions</h4>
                                    <p class='lilo-card-description'>Configure how different file types are handled when they change</p>
                                </div>
                                <div id='lilo-extension-settings'>
                                    <!-- Extension settings will be populated here -->
                                </div>
                            </div>
                            
                            <div class='lilo-actions'>
                                <button id='lilo-trigger-reload' class='lilo-btn'>Trigger Manual Reload</button>
                                <button id='lilo-reset-settings' class='lilo-btn lilo-btn-secondary'>Reset Settings</button>
                            </div>
                        </div>
                        
                        <!-- Logs Tab -->
                        <div class='lilo-livereload-tab-content' data-tab-content='logs'>
                            <div id='lilo-logs-container'>
                                <!-- Logs will be populated here -->
                            </div>
                            <div class='lilo-actions'>
                                <button id='lilo-clear-logs' class='lilo-btn lilo-btn-destructive'>Clear Logs</button>
                            </div>
                        </div>
                        
                        <!-- State Tab -->
                        <div class='lilo-livereload-tab-content' data-tab-content='state'>
                            <div id='lilo-state-container'>
                                <!-- Server state will be populated here -->
                            </div>
                            <div class='lilo-actions'>
                                <button id='lilo-refresh-state' class='lilo-btn'>Refresh State</button>
                            </div>
                        </div>
                        
                        <!-- Events Tab -->
                        <div class='lilo-livereload-tab-content' data-tab-content='events'>
                            <div id='lilo-events-container'>
                                <!-- Server events will be populated here -->
                            </div>
                            <div class='lilo-actions'>
                                <button id='lilo-refresh-events' class='lilo-btn'>Refresh Events</button>
                            </div>
                        </div>
                    </div>
                </div>
            `;
            
            document.body.appendChild(panel);
            
            // Set up event handlers
            document.getElementById('lilo-livereload-close').addEventListener('click', () => this.togglePanel());
            document.getElementById('lilo-setting-enabled').addEventListener('change', (e) => {
                this.isEnabled = e.target.checked;
                if (this.isEnabled && !this.socket) {
                    this.connect();
                }
                this.addLogEntry('info', `LiveReload ${this.isEnabled ? 'enabled' : 'disabled'}`);
            });
            
            document.getElementById('lilo-setting-autoscroll').addEventListener('change', (e) => {
                this.autoScrollLogs = e.target.checked;
            });
            
            document.getElementById('lilo-trigger-reload').addEventListener('click', () => {
                this.addLogEntry('info', 'Manual reload triggered');
                this.reloadPage();
            });
            
            document.getElementById('lilo-reset-settings').addEventListener('click', () => {
                this.resetSettings();
            });
            
            document.getElementById('lilo-clear-logs').addEventListener('click', () => {
                this.logsCache = [];
                this.updateLogsPanel();
            });
            
            document.getElementById('lilo-refresh-state').addEventListener('click', () => {
                this.fetchServerState();
            });
            
            document.getElementById('lilo-refresh-events').addEventListener('click', () => {
                this.fetchServerEvents();
            });
            
            // Set up tab switching
            document.querySelectorAll('.lilo-livereload-tab').forEach(tab => {
                tab.addEventListener('click', () => {
                    // Switch tabs
                    document.querySelectorAll('.lilo-livereload-tab').forEach(t => t.classList.remove('active'));
                    tab.classList.add('active');
                    
                    // Switch content
                    const tabName = tab.getAttribute('data-tab');
                    document.querySelectorAll('.lilo-livereload-tab-content').forEach(content => {
                        content.classList.remove('active');
                    });
                    document.querySelector(`.lilo-livereload-tab-content[data-tab-content='${tabName}']`).classList.add('active');
                    
                    // Auto-fetch data for some tabs
                    if (tabName === 'state') this.fetchServerState();
                    if (tabName === 'events') this.fetchServerEvents();
                });
            });
            
            // Populate extension settings
            this.populateExtensionSettings();
        }
        
        togglePanel() {
            this.isPanelVisible = !this.isPanelVisible;
            document.getElementById('lilo-livereload-panel').style.display = this.isPanelVisible ? 'block' : 'none';
            
            if (this.isPanelVisible) {
                this.updateLogsPanel();
                // Auto-fetch initial data
                this.fetchServerState();
                this.fetchServerEvents();
            }
        }
        
        updateConnectionStatus(isConnected) {
            const statusElem = document.querySelector('.lilo-connection-status');
            if (statusElem) {
                statusElem.classList.remove('connected', 'disconnected');
                statusElem.classList.add(isConnected ? 'connected' : 'disconnected');
                statusElem.title = isConnected ? 'Connected' : 'Disconnected';
            }
        }
        
        populateExtensionSettings() {
            const container = document.getElementById('lilo-extension-settings');
            container.innerHTML = '';
            
            Object.keys(this.fileExtensions).sort().forEach(ext => {
                const setting = document.createElement('div');
                setting.className = 'lilo-livereload-extension-setting';
                
                setting.innerHTML = `
                    <div class='lilo-livereload-extension-name'>.${ext}</div>
                    <select class='lilo-livereload-select' data-ext='${ext}'>
                        <option value='reload-page' ${this.fileExtensions[ext] === 'reload-page' ? 'selected' : ''}>Reload Page</option>
                        <option value='reload-css' ${this.fileExtensions[ext] === 'reload-css' ? 'selected' : ''}>Reload CSS Only</option>
                        <option value='ignore' ${this.fileExtensions[ext] === 'ignore' ? 'selected' : ''}>Ignore</option>
                    </select>
                `;
                
                container.appendChild(setting);
                
                // Add change handler
                setting.querySelector('select').addEventListener('change', (e) => {
                    this.fileExtensions[ext] = e.target.value;
                    this.addLogEntry('info', `Changed .${ext} action to ${e.target.value}`);
                    this.saveSettings();
                });
            });
        }
        
        updateLogsPanel() {
            const container = document.getElementById('lilo-logs-container');
            if (!container || !this.isPanelVisible) return;
            
            container.innerHTML = '';
            
            if (this.logsCache.length === 0) {
                container.innerHTML = `<div class='ilo-empty-state'>No logs available yet</div>`;
                return;
            }
            
            this.logsCache.forEach(log => {
                const entry = document.createElement('div');
                entry.className = `lilo-log-entry lilo-log-${log.level}`;
                
                const time = log.time.toLocaleTimeString();
                
                entry.innerHTML = `
                    <span class='lilo-log-time'>${time}</span>
                    <span class='lilo-log-message'>${log.message}</span>
                `;
                
                container.appendChild(entry);
            });
            
            if (this.autoScrollLogs) {
                container.scrollTop = container.scrollHeight;
            }
        }
        
        async fetchServerState() {
            try {
                this.addLogEntry('info', 'Fetching server state...');
                const response = await fetch(`${this.baseUrl}api/state`);
                if (!response.ok) {
                    throw new Error(`HTTP error! status: ${response.status}`);
                }
                const xmlText = await response.text();
                // Parse XML instead of JSON
                const parser = new DOMParser();
                const xmlDoc = parser.parseFromString(xmlText, 'text/xml');
                
                // Extract data from XML
                const data = this.parseStateXml(xmlDoc);
                this.updateStatePanel(data);
            } catch (error) {
                this.addLogEntry('error', `Failed to fetch server state: ${error.message}`);
            }
        }
        
        parseStateXml(xmlDoc) {
            // Extract basic information from XML
            const getNodeValue = (nodeName) => {
                const node = xmlDoc.getElementsByTagName(nodeName)[0];
                return node ? node.textContent : 'Unknown';
            };
            
            // Parse server info
            const state = {
                name: getNodeValue('PublicName'),
                directory: getNodeValue('PublicServedDirectory'),
                port: getNodeValue('PublicLoopbackPort'),
                mode: '', // Need to determine from context
                isRunning: getNodeValue('HealthCheckResponse').includes('True'),
                healthStatus: getNodeValue('HealthCheckStatus'),
                version: getNodeValue('LibraryVersion'),
                events: []
            };
            
            // Get available ports information
            const ports = xmlDoc.getElementsByTagName('AvaillabelPorts')[0];
            if (ports) {
                state.ports = {
                    default: this.getNodeValueFromElement(ports, 'Default'),
                    fallback: this.getNodeValueFromElement(ports, 'FallBack'),
                    public: this.getNodeValueFromElement(ports, 'Public'),
                    https: this.getNodeValueFromElement(ports, 'Https')
                };
            }
            
            // Parse events
            const eventsList = xmlDoc.getElementsByTagName('WEB_ENGINE_EVENT');
            state.events = Array.from(eventsList).map(eventNode => {
                return {
                    name: this.getNodeValueFromElement(eventNode, 'Name'),
                    description: this.getNodeValueFromElement(eventNode, 'Description'),
                    time: this.getNodeValueFromElement(eventNode, 'HappeningTime'),
                    token: this.getNodeValueFromElement(eventNode, 'EventToken')
                };
            });
            
            return state;
        }
        
        // Helper function to get node value from a parent element
        getNodeValueFromElement(element, nodeName) {
            const node = element.getElementsByTagName(nodeName)[0];
            return node ? node.textContent : '';
        }
        
        async fetchServerEvents() {
            try {
                this.addLogEntry('info', 'Fetching server events...');
                const response = await fetch(`${this.baseUrl}api/events`);
                if (!response.ok) {
                    throw new Error(`HTTP error! status: ${response.status}`);
                }
                const xmlText = await response.text();
                
                // Parse XML
                const parser = new DOMParser();
                const xmlDoc = parser.parseFromString(xmlText, 'text/xml');
                
                // Extract events from XML
                const eventsList = xmlDoc.getElementsByTagName('WEB_ENGINE_EVENT');
                const events = Array.from(eventsList).map(eventNode => {
                    return {
                        name: this.getNodeValueFromElement(eventNode, 'Name'),
                        description: this.getNodeValueFromElement(eventNode, 'Description'),
                        happeningTime: this.getNodeValueFromElement(eventNode, 'HappeningTime'),
                        token: this.getNodeValueFromElement(eventNode, 'EventToken'),
                        needsToAccept: this.getNodeValueFromElement(eventNode, 'NeedsToAccept') === 'true'
                    };
                });
                
                this.updateEventsPanel(events);
            } catch (error) {
                this.addLogEntry('error', `Failed to fetch server events: ${error.message}`);
            }
        }
        
        updateStatePanel(data) {
            const container = document.getElementById('lilo-state-container');
            if (!container) return;
            
            container.innerHTML = '';
            
            // Create server info section
            this.createStateInfoSection(container, 'Server Info', {
                'Name': data.name || 'Unknown',
                'Port': data.port || 'Unknown',
                'Status': data.isRunning ? 'Running' : 'Stopped',
                'Health': data.healthStatus || 'Unknown',
                'Version': data.version || 'Unknown'
            });
            
            // Create directory section
            this.createStateInfoSection(container, 'Serving Directory', 
                data.directory || 'Unknown');
            
            // Create ports section if available
            if (data.ports) {
                this.createStateInfoSection(container, 'Available Ports', data.ports);
            }
            
            // Create recent events section (showing only top 3)
            if (data.events && data.events.length > 0) {
                const recentEvents = data.events.slice(0, 3);
                this.createStateInfoSection(container, 'Recent Events', 
                    recentEvents.map(e => `${e.name}: ${e.description}`).join('\n'));
            }
            
            this.addLogEntry('success', 'Server state updated');
        }
        
        updateEventsPanel(events) {
            const container = document.getElementById('lilo-events-container');
            if (!container) return;
            
            container.innerHTML = '';
            
            if (!events || !events.length) {
                container.innerHTML = '<p>No events available</p>';
                return;
            }
            
            // Create event entries
            events.forEach(event => {
                const eventEntry = document.createElement('div');
                eventEntry.className = 'lilo-state-info';
                
                let time = 'Unknown time';
                try {
                    time = new Date(event.happeningTime).toLocaleString();
                } catch (e) {
                    // Use the raw time string if parsing fails
                    time = event.happeningTime;
                }
                
                eventEntry.innerHTML = `
                    <div class='lilo-state-label'>${event.name} <span style='font-weight:normal;font-size:12px;color:#666'>(${time})</span></div>
                    <div class='lilo-state-value'>${this.formatDescription(event.description)}</div>
                `;
                
                container.appendChild(eventEntry);
            });
            
            this.addLogEntry('success', 'Events updated');
        }
        
        formatDescription(description) {
            // Check if description is a JSON string (from error events)
            if (description.startsWith('{') && description.endsWith('}')) {
                try {
                    const errorData = JSON.parse(description);
                    return `
                        <strong>Request:</strong> ${errorData.RequestPath || 'Unknown'}<br>
                        <strong>Error:</strong> ${errorData.Exception?.Message || 'Unknown error'}<br>
                        <strong>Time:</strong> ${new Date(errorData.Timestamp).toLocaleString()}<br>
                        ${errorData.Exception?.StackTrace ? '<details><summary>Stack Trace</summary><pre>' + errorData.Exception.StackTrace + '</pre></details>' : ''}
                    `;
                } catch (e) {
                    // If parsing fails, return the raw description
                    return description;
                }
            }
            return description;
        }
        
        createStateInfoSection(container, title, data) {
            const section = document.createElement('div');
            section.className = 'lilo-card';
            
            const header = document.createElement('div');
            header.className = 'lilo-card-header';
            header.innerHTML = `<h4 class='lilo-card-title'>${title}</h4>`;
            section.appendChild(header);
            
            const content = document.createElement('div');
            content.className = 'lilo-state-value';
            
            if (typeof data === 'object') {
                content.innerHTML = JSON.stringify(data, null, 2);
            } else {
                content.textContent = data;
            }
            
            section.appendChild(content);
            container.appendChild(section);
        }
        
        saveSettings() {
            try {
                localStorage.setItem('lilo-livereload-settings', JSON.stringify({
                    fileExtensions: this.fileExtensions,
                    isEnabled: this.isEnabled,
                    autoScrollLogs: this.autoScrollLogs
                }));
            } catch (e) {
                this.addLogEntry('error', 'Failed to save settings: ' + e.message);
            }
        }
        
        loadSettings() {
            try {
                const settings = JSON.parse(localStorage.getItem('lilo-livereload-settings'));
                if (settings) {
                    this.fileExtensions = settings.fileExtensions || this.fileExtensions;
                    this.isEnabled = settings.isEnabled !== undefined ? settings.isEnabled : true;
                    this.autoScrollLogs = settings.autoScrollLogs !== undefined ? settings.autoScrollLogs : true;
                    
                    // Update UI
                    if (document.getElementById('lilo-setting-enabled')) {
                        document.getElementById('lilo-setting-enabled').checked = this.isEnabled;
                    }
                    if (document.getElementById('lilo-setting-autoscroll')) {
                        document.getElementById('lilo-setting-autoscroll').checked = this.autoScrollLogs;
                    }
                    this.populateExtensionSettings();
                    
                    this.addLogEntry('info', 'Settings loaded');
                }
            } catch (e) {
                this.addLogEntry('error', 'Failed to load settings: ' + e.message);
            }
        }
        
        resetSettings() {
            // Reset to defaults
            this.fileExtensions = {
                css: 'reload-css',
                js: 'reload-page',
                html: 'reload-page',
                htm: 'reload-page',
                jpeg: 'ignore',
                jpg: 'ignore',
                png: 'ignore',
                gif: 'ignore',
                svg: 'ignore',
                pdf: 'ignore'
            };
            this.isEnabled = true;
            this.autoScrollLogs = true;
            
            // Update UI
            document.getElementById('lilo-setting-enabled').checked = true;
            document.getElementById('lilo-setting-autoscroll').checked = true;
            this.populateExtensionSettings();
            
            // Save to localStorage
            this.saveSettings();
            
            this.addLogEntry('info', 'Settings reset to defaults');
        }
    }
    
    // Initialize LiveReload
    window.addEventListener('load', function() {
        window.liveReloadClient = new LiveReloadClient('{{WEBSOCKET_URL}}');
        
        // Load saved settings after initialization
        setTimeout(() => {
            if (window.liveReloadClient.loadSettings) {
                window.liveReloadClient.loadSettings();
            }
        }, 100);
    });
})();
</script>
";
        }
    }
} 