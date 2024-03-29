﻿using LILO_Packager.Properties;
using LILO_Packager.v2.Cloud;
using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Core;
using LILO_Packager.v2.Core.AsyncTasks;
using LILO_Packager.v2.Core.Dialogs;
using LILO_Packager.v2.Core.History;
using LILO_Packager.v2.Shared;
using LILO_Packager.v2.Shared.Api.Core;
using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LILO_Packager.v2.Forms
{
    public partial class uiHistory : Form
    {
        private readonly BroadcastChannel BroadCastChannelInstance;
        private readonly DatabaseHandling dbHandler;
        public static CancellationToken loadingAbort;

        private List<HistoryElement> historyElements;
        private static uiHistory? _instance;
        public static uiHistory Instance()
        {
            if (_instance == null)
            {
                _instance = new uiHistory();
            }

            return _instance;
        }

        private uiHistory()
        {
            dbHandler = new DatabaseHandling();

            BroadCastChannelInstance = BroadcastChannel.Instance;
            BroadCastChannelInstance.Subscribe(HistoryBroadCastObserver.Instance, "LocalHistoryProvider");

            LoadData();

            this.FormClosing += (sender, e) =>
            {
                BroadCastChannelInstance.Unsubscribe(HistoryBroadCastObserver.Instance, "LocalHistoryProvider");
                _instance = null;
                MainHost.Instance().hider.Enabled = true;

                loadingAbort.Register(() =>
                {
                    this.Invoke(delegate
                    {
                        lblText.Text = "Canceling";
                    });
                });
            };

            InitializeComponent();

            listViewHistory.DoubleClick += ListViewHistory_DoubleClick;
            loadingAbort = new CancellationToken();
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr ExtractAssociatedIcon(IntPtr hInst,
                                                            string lpIconPath, out ushort lpiIcon);

        static Icon GetFileIcon(string filePath)
        {
            ushort iconIndex;
            IntPtr hIcon = ExtractAssociatedIcon(IntPtr.Zero, filePath, out iconIndex);
            if (hIcon != IntPtr.Zero)
            {
                Icon icon = (Icon)Icon.FromHandle(hIcon).Clone();
                DestroyIcon(hIcon);
                return icon;
            }
            return null;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);




        private void ListViewHistory_DoubleClick(object? sender, EventArgs e)
        {
            var item = listViewHistory.SelectedItems[0];

            foreach (var element in historyElements)
            {
                if (item.Text == $"{element.id}")
                {
                    if (element.id == 0)
                    {
                        MessageBox.Show("This Operation had no output.", "No Output", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                    }

                    try
                    {
                        if (File.Exists(element.outputFileName))
                        {
                            MainHost.Instance().OpenInApp(new uiHistoryElementInfo(element));
                            break;
                        }
                        else
                        {
                            var matrixFile = FileIndexStorage.Instance.GetMatrixFile();
                            MatrixEntry entryCheck = null;


                            foreach (var entry in matrixFile.MatrixEntrys)
                            {
                                if (entry.File.RealPath == element.outputFileName)
                                {
                                    File.WriteAllText(entry.File.RealPath + ".llcp", entry.CloudEntry.PublicFileId);

                                    var hisEntry = new HistoryElement()
                                    {
                                        algorithmVersion = element.algorithmVersion,
                                        id = element.id,
                                        inputFileName = element.inputFileName,
                                        outputFileName = entry.File.RealPath + ".llcp",
                                        mode = element.mode,
                                        operationType = element.operationType,
                                    };

                                    entryCheck = entry;

                                    MainHost.Instance().OpenInApp(new uiHistoryElementInfo(hisEntry));
                                    break;
                                }
                            }

                            if (entryCheck is null)
                            {
                                OkDialog.Show("The Output of this Operation is not existing anymore.", "File Not Found");
                                break;
                            }


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "FileError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
        }

        private void listViewBerechtigungen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private async void LoadData()
        {
            ConsoleManager.Instance().WriteLineWithColor("[LocalHistoryProvider] Connecting to Database");

            var data = await dbHandler.GetAllEncryptedOperationsAsync();
            if (data is not null) historyElements = data;
            else
            {
                await dbHandler.InitializeDatabaseAsync(Console.WriteLine);
            }
        }

        private void uiHistory_Load(object sender, EventArgs e)
        {
            if (FeatureManager.IsFeatureEnabled(FeatureFlags.HistoryElementQuering))
            {
                pnlLoginLoad.Visible = true;

                var imagelist = new ImageList();
                imagelist.Images.Add("close", Resources.Close);
                imagelist.Images.Add("cloud", Resources.icons8_earth_planet_96);
                imagelist.Images.Add("lsf_lock", Resources.Lock);

                listViewHistory.GroupImageList = imagelist;
                listViewHistory.LargeImageList = imagelist;
                listViewHistory.SmallImageList = imagelist;
                listViewHistory.StateImageList = imagelist;

                Task.Run(() =>
                {
                    this.listViewHistory.Items.Clear();
                    try
                    {
                        if (historyElements.Count >= 100)
                        {
                            MainHost.Instance().hider.Enabled = false;
                        }

                        foreach (HistoryElement element in historyElements)
                        {
                            var item = ListItemFactory(element, imagelist);
                            if (item is null) continue;
                            listViewHistory.Items.Add(item);
                        }

                        pnlLoginLoad.Visible = false;

                        MainHost.Instance().hider.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        ConsoleManager.Instance().WriteLineWithColor(ex.Message);
                    }

                }, loadingAbort);
            }
            else
            {
                MainHost.Instance().OpenInApp(new uiFeatureNullException("FeatureNullException", "This feature isnt enabled yet."));
            }

        }

        public ListViewItem ListItemFactory(HistoryElement element, ImageList imagelist)
        {
            if (element.id == 0)
            {
                return null;
            }

            var item = new ListViewItem()
            {
                Text = $"{element.id}",
            };

            item.SubItems.Add(element.operationType);
            item.SubItems.Add(element.mode);
            item.SubItems.Add(element.algorithmVersion);
            item.SubItems.Add(element.inputFileName);
            item.SubItems.Add(element.outputFileName);

            if (!File.Exists(element.outputFileName))
            {
                var cloudMatrixFile = FileIndexStorage.Instance.GetMatrixFile();

                foreach (var itemInMatrix in cloudMatrixFile.MatrixEntrys)
                {
                    if (itemInMatrix.File.RealPath == element.outputFileName)
                    {
                        item.ForeColor = Color.RoyalBlue;
                        item.ImageKey = "cloud";
                        break;
                    }
                    else
                    {
                        item.ImageKey = "close";
                        item.ForeColor = Color.DarkGray;
                    }
                }

                if (item.ForeColor == Color.DarkGray)
                {
                    if (FeatureManager.IsFeatureEnabled(FeatureFlags.HistoryElementOnlyIfFileExist))
                    {
                        return null;
                    }
                }
            }
            else
            {
                if (element.outputFileName.EndsWith(".lsf"))
                {
                    item.ImageKey = "lsf_lock";
                }
                else
                {
                    var Hash = Cloud.CloudSyncroniztationBase.GetFileHash(element.outputFileName);
                    imagelist.Images.Add(Hash, GetFileIcon(element.outputFileName));
                    item.ImageKey = Hash;
                }

            }

            return item;
        }

        private ConsoleColor GetConsoleColorFromOperation(string operationType)
        {
            switch (operationType)
            {
                case "Encryption":
                    return ConsoleColor.Green;
                case "Decryption":
                    return ConsoleColor.Blue;
                default: return ConsoleColor.Yellow;
            }
        }

        private void bntPlugin_Click(object sender, EventArgs e)
        {
            LoadData();
            uiHistory_Load(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogtest = new uiCustomDialog(
            new Core.Dialogs.MessageDialogPreference(
                "File Operation",
                "Do you realy want to delete the file?",
                Core.Dialogs.Dialog.Authorization,
                Core.Dialogs.DialogButtons.Authorization,
                Core.Dialogs.DialogIcon.Question,
                result =>
                {
                    if (result == Core.Dialogs.DialogResults.Ok)
                    {
                        if (listViewHistory.SelectedItems.Count > 0)
                        {
                            var item = listViewHistory.SelectedItems[0];

                            foreach (var element in historyElements)
                            {
                                if (item.Text == $"{element.id}")
                                {
                                    if (element.id == 0)
                                    {
                                        MessageBox.Show("This Operation had no output that could be deleted.", "No Output", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        break;
                                    }

                                    try
                                    {
                                        if (File.Exists(element.outputFileName))
                                        {
                                            var asyncTask = new Core.AsyncTasks.AsyncTask("Mainhost - Task", TaskMode.Deleting, async (progress) =>
                                            {
                                                progress?.Report(20);
                                                File.Delete(element.outputFileName);
                                                progress?.Report(100);

                                                var sp = new SoundPlayer();
                                                sp.Stream = Properties.Resources.to_trash;
                                                sp.Play();
                                                bntPlugin_Click(sender, e);
                                            });

                                            var uiAsyncTask = new uiCustomProcess(asyncTask);
                                            uiAsyncTask.ShowDialog();

                                        }
                                        else
                                        {
                                            OkDialog.Show("The Output of this Operation is not existing anymore.", "File Not Found", DialogIcon.Error);
                                            break;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "FileError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                })
            );
            dialogtest.ShowDialog();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke(() =>
                {
                    try
                    {
                        if (listViewHistory.SelectedItems.Count > 0)
                        {
                            var item = listViewHistory.SelectedItems[0];

                            foreach (var element in historyElements)
                            {
                                if (item.Text == $"{element.id}")
                                {
                                    if (element.id == 0)
                                    {
                                        OkDialog.Show("This Operation had no output.", "No Output");
                                        break;
                                    }

                                    try
                                    {
                                        if (File.Exists(element.outputFileName))
                                        {
                                            MainHost.Instance().OpenInApp(new uiHistoryElementInfo(element));
                                        }
                                        else
                                        {
                                            OkDialog.Show("The Output of this Operation is not existing anymore.", "File Not Found", DialogIcon.Error);
                                            break;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "FileError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ConsoleManager.Instance().WriteLineWithColor(ex.Message, ConsoleColor.DarkRed);
                    }
                });
            });


        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogtest = new uiCustomDialog(
            new Core.Dialogs.MessageDialogPreference(
                "Report Bug",
                "To report a bug we need to open youre Browser and guide you to Github. Continue?",
                Core.Dialogs.Dialog.Authorization,
                Core.Dialogs.DialogButtons.OkCancel,
                Core.Dialogs.DialogIcon.Question,
                result =>
                {
                    if (result == Core.Dialogs.DialogResults.Ok)
                    {
                        string url = $"https://github.com/JW-Limited/Crypterv2/issues/new?assignees=&labels=&projects=&template=bug_report.md&title=HistoryElementError";

                        Process.Start(new ProcessStartInfo
                        {
                            FileName = url,
                            UseShellExecute = true
                        });
                    }
                })
            );
            dialogtest.ShowDialog();
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {

        }

        private void bntSync_Click(object sender, EventArgs e)
        {
            if (FeatureManager.IsFeatureEnabled(FeatureFlags.ShellMasterAll))
            {
                MainHost.Instance().OpenInApp(uiCloudSyncronization.Instance);
            }
            else
            {
                pnlLoginLoad.Visible = true;
                uiCloudSyncronization.Instance.ShowDialog();
                pnlLoginLoad.Visible = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pnlLoginLoad.Visible = true;

            Task.Run(() =>
            {
                this.Invoke(() =>
                {
                    if (textBox1.Text == "")
                    {
                        uiHistory_Load(sender, e);
                        return;
                    }

                    var SearchedÍtems = new List<HistoryElement>();
                    foreach (var item in historyElements)
                    {
                        if (item.outputFileName.Contains(textBox1.Text))
                        {
                            SearchedÍtems.Add(item);
                        }
                    }

                    listViewHistory.Items.Clear();

                    var imagelist = new ImageList();
                    listViewHistory.GroupImageList = imagelist;
                    listViewHistory.LargeImageList = imagelist;
                    listViewHistory.SmallImageList = imagelist;
                    listViewHistory.StateImageList = imagelist;

                    foreach (var sItem in SearchedÍtems)
                    {
                        var item = ListItemFactory(sItem, imagelist);
                        if (item is null) continue;
                        listViewHistory.Items.Add(item);
                    }

                    pnlLoginLoad.Visible = false;
                });

            });

        }

        private void showInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = listViewHistory.SelectedItems[0];

            foreach (var element in historyElements)
            {
                if (item.Text == $"{element.id}")
                {
                    Process.Start("explorer.exe", element.outputFileName.Replace(new FileInfo(element.outputFileName).Name, ""));
                }
            }

        }

        private void lILOWebEngineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = listViewHistory.SelectedItems[0];

            foreach (var element in historyElements)
            {
                if (item.Text == $"{element.id}")
                {
                    MainHost.Instance().OpenInApp(v2.Forms.uiWebView.Instance(new Uri($"http://localhost:{MainHost.Instance().Port}/" + element.outputFileName.Replace(new FileInfo(element.outputFileName).Name, ""))));
                }
            }

            
        }
    }
}
