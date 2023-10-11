using LILO_Packager.v2.Core;
using LILO_Packager.v2.Core.AsyncTasks;
using LILO_Packager.v2.Core.Dialogs;
using LILO_Packager.v2.Core.History;
using LILO_Packager.v2.Shared;
using LILO_Packager.v2.Shared.Api.Core;
using System.Diagnostics;

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
                loadingAbort.Register(() =>
                {
                    this.Invoke(delegate
                    {
                        lblText.Text = "Canceling";
                    });
                });

                _instance = null;
            };

            InitializeComponent();

            loadingAbort = new CancellationToken();
        }

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
                            OkDialog.Show("The Output of this Operation is not existing anymore.", "File Not Found");
                            break;
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

                Task.Run(() =>
                {
                    this.listViewHistory.Items.Clear();
                    listViewHistory.DoubleClick += ListViewHistory_DoubleClick;
                    int stepps = historyElements.Count;
                    int doneStepps = 0;

                    if (stepps >= 1000)
                    {
                        MainHost.Instance().hider.Enabled = false;
                    }

                    foreach (HistoryElement element in historyElements)
                    {
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
                            item.ForeColor = Color.DarkGray;
                        }

                        ConsoleManager.Instance().WriteLineWithColor("Loading: (ID)" + element.id + " (OPM)" + element.operationType + " (CORE)" + element.algorithmVersion, GetConsoleColorFromOperation(element.operationType));


                        listViewHistory.Items.Add(item);

                        doneStepps++;

                        label5.Text = $"{doneStepps * 100 / stepps}%";
                    }

                    pnlLoginLoad.Visible = false;

                    MainHost.Instance().hider.Enabled = true;
                }, loadingAbort);
            }
            else
            {
                MainHost.Instance().OpenInApp(new uiFeatureNullException("FeatureNullException", "This feature isnt enabled yet."));
            }

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
    }
}
