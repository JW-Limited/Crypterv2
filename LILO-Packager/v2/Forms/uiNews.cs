using CommonMark;
using LILO_Packager.v2.Core.Updates;
using LILO_Packager.v2.Shared;
using Markdig;
using System.Diagnostics;
using System.Net.Http;

namespace LILO_Packager.v2.Forms
{
    public partial class uiNews : Form
    {
        public uiNews()
        {
            InitializeComponent();

            FileOperations.CreateDirectoryRecursively(DefaultIndexPath);
            
        }

        private string DefaultIndexPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Crypterv2\\Temp\\";

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void uiNews_Load(object sender, EventArgs e)
        {
            try
            {
                await readMeView.EnsureCoreWebView2Async();

                if (File.Exists(DefaultIndexPath + "Readme.html"))
                {
                    readMeView.Source = new Uri(DefaultIndexPath + "Readme.html");
                }

                lblVersion.Text = Program.Version;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/JW-Limited/Crypterv2";


            readMeView.Source = new Uri(url);
        }

        private void ReportBug_CLick(object sender, EventArgs e)
        {
            string url = "https://github.com/JW-Limited/Crypterv2/issues/new?assignees=&labels=&projects=&template=bug_report.md&title=Error";

            readMeView.Source = new Uri(url);
        }

        private async void bntRefrewsh(object sender, EventArgs e)
        {
            string markdownText = await Updater.Instance().GetLatestChanges(MainHost.Instance().Owner, MainHost.Instance().Repository);

            File.WriteAllText(DefaultIndexPath + "Readme.md", markdownText);

            string htmlContent = Markdown.ToHtml(markdownText);

            string cssContent = @"
            body {
                  font-family: sans-serif;
                  margin: 0;
                  padding: 20px;
                  box-shadow: 0px 3px 6px rgba(0, 0, 0, 0.12);
                  overflow-x: hidden;
                }

                h1, h2, h3 {
                  color: #007bff;
                  font-weight: 600;
                  margin-top: 20px;
                  margin-bottom: 10px;
                }

                p {
                  margin: 10px;
                  line-height: 1.5;
                }

                img {
                  max-width: 100%;
                  height: auto;
                  margin-bottom: 10px;
                  position: relative;
                  transition: all 0.5s ease-in-out;
                }
                
                div{
                  border-radius: 10px;
                  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.12);
                  padding: 30px;
                }

                img:hover {
                  transform: scale(1.1);
                  box-shadow: 0 10px 10px rgba(0, 0, 0, 0.05);
                }

                /* Add a subtle glow effect on hover */

                .image-glow {
                  position: absolute;
                  top: 0;
                  left: 0;
                  width: 100%;
                  height: 100%;
                  opacity: 0;
                  background-color: #007bff;
                  border-radius: 5px;
                  transition: opacity 0.5s ease-in-out;
                }

                img:hover .image-glow {
                  opacity: 0.7;
                }
                li {
                  margin-bottom: 10px;
                  transition: all 0.5s ease-in-out;
                }

                /* Hover effect */

                li:hover {
                  background-color: #f2f2f2;
                  box-shadow: 0px 10px 20px rgba(0, 0, 0, 0.07);
                  transform: scale(1.1);
                }

                /* Glow effect on hover */

                .glow {
                  position: absolute;
                  top: 0;
                  left: 0;
                  width: 100%;
                  height: 100%;
                  opacity: 0;
                  background-color: #007bff;
                  border-radius: 5px;
                  transition: opacity 0.5s ease-in-out;
                }

                li:hover .glow {
                  opacity: 0.7;
                }
                a {
                  color: #007bff;
                  text-decoration: none;
                }

                a:hover {
                  color: #0056b3;
                }

                .read-me-container {
                  max-width: 960px;
                  margin: 0 auto;
                  padding: 30px 0;
                  border-radius: 10px;
                  background-color: #fff;
                  box-shadow: 0px 3px 6px rgba(0, 0, 0, 0.12);
                }

                @keyframes slide-in {
                  from {
                    transform: translateX(-200px);
                    opacity: 0;
                  }
                  to {
                    transform: translateX(0px);
                    opacity: 1;
                  }
                }

                .read-me-container.animate {
                  animation: slide-in 0.5s ease-in-out forwards;
                }

                @media (max-width: 768px) {
                  .read-me-container {
                    max-width: 90%;
                  }
                }
                                                        
            ";

            htmlContent = "<style>" + cssContent + "</style>" + htmlContent;

            File.WriteAllText(DefaultIndexPath + "Readme.html", htmlContent);

            readMeView.NavigateToString(htmlContent);
        }
    }

}
