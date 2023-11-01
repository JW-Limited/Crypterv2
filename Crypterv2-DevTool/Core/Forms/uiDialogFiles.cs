using Crypterv2.DevTool.Core.Plugins;
using Crypterv2_DevTool.Core.Forms;
using LILO_Packager.v2.Core.Keys;
using Sipaa.Framework;
using System.Collections.ObjectModel;
using System.Data;

namespace Crypterv2.DevTool.Core.Forms
{
    public partial class uiDialogFiles : Form
    {
        private static uiDialogFiles _dialogFiles;
        private ObservableCollection<string> _Dependencies;
        private ObservableCollection<string> BackUp;
        private bool DialogCanceled = false;

        public static uiDialogFiles GetHandle(ObservableCollection<string> dependencies)
        {
            if (_dialogFiles is null || _dialogFiles.IsDisposed)
            {
                _dialogFiles = new uiDialogFiles(dependencies);
            }

            return _dialogFiles;
        }

        public uiDialogFiles(ObservableCollection<string> dependencies)
        {
            InitializeComponent();

            _Dependencies = dependencies;
            BackUp = dependencies;
            _Dependencies.CollectionChanged += (s, e) =>
            {
                uiDialogFiles_Load(s, e);
            };

        }

        public ObservableCollection<string> GetDependencies()
        {
            base.StartPosition = FormStartPosition.CenterParent;
            base.ShowDialog();

            return DialogCanceled ? BackUp : _Dependencies;
        }

        private void uiDialogFiles_Load(object sender, EventArgs e)
        {
            if (_Dependencies is null || _Dependencies.Count == 0)
            {
                return;
            }

            listViewHistory.Items.Clear();

            for (global::System.Int32 i = 0; i < _Dependencies.Count; i++)
            {
                if (!File.Exists(_Dependencies[i])) continue;

                var dependencyListItem = new ListViewItem()
                {
                    Text = $"{_Dependencies[i].GetHashCode()}".Remove(2),
                    Tag = _Dependencies[i],
                };

                dependencyListItem.SubItems.Add(new FileInfo(_Dependencies[i]).Name);
                dependencyListItem.SubItems.Add(GetFileType(new FileInfo(_Dependencies[i]).Extension));

                listViewHistory.Items.Add(dependencyListItem);
            }
        }

        private string GetFileType(string type)
        {
            var fileTypes = new Dictionary<string, string>()
            {
                { ".dll", "Library" },
                { ".pdb", "Library" },
                { ".exe", "Application" },
                { ".msix", "Application" },
                { ".com", "Application" },
                { ".png", "MediaResource" },
                { ".jpg", "MediaResource" },
                { ".ico", "MediaResource" },
                { ".config", "Configuration File" },

                // Document files
                { ".pdf", "Document" },
                { ".docx", "Document" },
                { ".xlsx", "Spreadsheet" },
                { ".pptx", "Presentation" },
                { ".txt", "Text File" },
                { ".odt", "Open Document Text" },
                { ".ods", "Open Document Spreadsheet" },
                { ".epub", "E-Book" },
                { ".mobi", "E-Book" },
                { ".rtf", "Rich Text Format" },
                { ".tex", "LaTeX Document" },

                // Audio files
                { ".mp3", "Audio" },
                { ".wav", "Audio" },
                { ".flac", "Audio" },
                { ".ogg", "Audio" },
                { ".aac", "Audio" },
                { ".m4a", "Audio" },

                // Video files
                { ".mp4", "Video" },
                { ".avi", "Video" },
                { ".mkv", "Video" },
                { ".mov", "Video" },
                { ".webm", "Video" },
                { ".mpeg", "Video" },
                { ".mpg", "Video" },
                { ".ts", "Video" },
                { ".m2ts", "Video" },

                // Compressed files
                { ".zip", "Compressed File" },
                { ".rar", "Compressed File" },
                { ".7z", "Compressed File" },
                { ".gz", "Compressed File" },
                { ".bz2", "Compressed File" },
                { ".tar", "Compressed File" },

                // Other file types
                { ".html", "Web Page" },
                { ".css", "Cascading Style Sheet" },
                { ".js", "JavaScript" },
                { ".json", "JavaScript Object Notation" },
                { ".csv", "Comma-Separated Values" },
                { ".sql", "Structured Query Language" },
                { ".jar", "Java Archive" },
                { ".war", "Web Application Archive" },
                { ".apk", "Android Package Kit" },
                { ".ipa", "iOS App" },
                { ".dmg", "Disk Image" },
                { ".iso", "Disc Image" },
                { ".vbs", "Visual Basic Script" },
                { ".bat", "Batch File" },
                { ".ps1", "PowerShell Script" },
                { ".xml", "Extensible Markup Language" },
                { ".yaml", "YAML Ain't Markup Language" },
                { ".json5", "JSON5" },
                { ".ini", "Initialization File" },
                { ".log", "Log File" },
            };

            if (fileTypes.ContainsKey(type))
            {
                try
                {
                    return fileTypes[type];
                }
                catch (Exception) 
                {
                    return "Unknown";
                }
            }

            return "Unknown";
        }
        

        private void bntOk_Click(object sender, EventArgs e)
        {
            DialogCanceled = true;

            _Dependencies.Clear();
            this.Close();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "Select Dependencies";
            ofd.Filter = "Compatible Files|*";
            ofd.Multiselect = true;
            ofd.AddToRecent = true;
            ofd.ShowHiddenFiles = true;
            ofd.RestoreDirectory = true;
            ofd.AutoUpgradeEnabled = true;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Task.Run(async () =>
                {
                    this.Invoke(new Action(async () =>
                    {
                        bntCancel.Enabled = false;
                        bntOk.Enabled = false;
                        guna2Button1.Enabled = false;
                        pnlLoad.Visible = true;
                    }));


                    await AddDependenciesAsync(ofd.FileNames);

                    this.Invoke(() =>
                    {
                        bntCancel.Enabled = true;
                        bntOk.Enabled = true;
                        guna2Button1.Enabled = true;
                        pnlLoad.Visible = false;
                    });
                });
                
            }
        }

        private async Task AddDependenciesAsync(IEnumerable<string> dependencies)
        {
            var tasks = dependencies.Select(async (dependency) =>
            {
                if (!File.Exists(dependency))
                {
                    throw new FileNotFoundException($"The dependency file '{dependency}' does not exist.");
                }

                _Dependencies.Add(dependency);
            });

            await Task.WhenAll(tasks);
        }
    }
}
