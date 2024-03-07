using Paket;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Shared
{
    public class LifeManagement
    {
        public bool NewInstanceIsNeeded { get; set; } = false;
        internal HttpListener lifeListener { get; set; } = null;

        internal LifeManagement()
        {
            lifeListener = new HttpListener();
        }

        public static async Task<LifeManagement> Create()
        {
            var mng = new LifeManagement();
            await mng.Initialize();
            var rs = await mng.Start();

            if (!rs) throw new BadInitializeResponse(nameof(mng));
            return mng;
        }

        public static bool IsAlive()
        {
            try
            {
                string ret = string.Empty;
                var uri = new Uri($"http://Localhost:10890/hello");
                HttpClient client = new HttpClient();
                client.Timeout = new TimeSpan(1000);
                var response = client.GetAsync(uri).Result;
                using (var streamReader = new StreamReader(response.Content.ReadAsStream())) ret = streamReader.ReadToEnd();
                if (ret == "hello") return true;
            }
            catch(Exception ex) { }
            

            return false;
        }


        internal async Task<bool> Initialize()
        {
            try
            {
                lifeListener.Prefixes.Add("http://Localhost:10890/");

                return true;
            }
            catch (Exception ex)
            {
                ConsoleManager.Instance().WriteLineWithColor(ex.Message, ConsoleColor.DarkMagenta);
            }

            return false;
        }

        internal async Task<bool> Start()
        {
            lifeListener.Start();

            if (lifeListener.IsListening) 
            {
                var lifeThread = new Thread(async () =>
                {
                    while (true || !NewInstanceIsNeeded)
                    {
                        var context = await lifeListener.GetContextAsync();

                        try
                        {
                            await RequestHandler(context);
                        }
                        catch(Exception ex)
                        {
                            ConsoleManager.Instance().WriteLineWithColor("[LIFE-THREAD] - " + ex.Message, ConsoleColor.DarkMagenta);
                        }
                    }
                });

                lifeThread.Start();

                return true;
            }

            return false;
        }

        public async Task RequestHandler(HttpListenerContext context)
        {
            var path = context.Request.Url.AbsolutePath.ToLower();

            switch (path)
            {
                case "/hello":
                    await SendResponse(context, "hello");
                    break;
                case "/kill":
                    await StopListenerAsync();
                    break;
                default:
                    await SendResponse(context, "Unknown command", HttpStatusCode.BadRequest);
                    break;
            }
        }

        private async Task StopListenerAsync()
        {
            NewInstanceIsNeeded = true;

            MainHost.Instance().OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:9001")));
            MainHost.Instance().PresedExit = true;
            Process.Start("powershell.exe", ".\\cloud_assets\\closeInstances.ps1");

            Application.Exit();
        }


        internal async Task SendResponse(HttpListenerContext context, string message, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            context.Response.StatusCode = (int)statusCode;
            byte[] content = Encoding.UTF8.GetBytes(message);
            context.Response.ContentLength64 = content.Length;
            await context.Response.OutputStream.WriteAsync(content, 0, content.Length);
            context.Response.Close();
        }

        ~LifeManagement()
        {

        }
    }
}
