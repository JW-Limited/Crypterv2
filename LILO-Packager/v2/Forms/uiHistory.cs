using LILO_Packager.v2.Core;
using LILO_Packager.v2.Core.History;
using LILO_Packager.v2.shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Forms
{
    public partial class uiHistory : Form
    {
        private string NameDisplayed = "History";
        private DatabaseHandling dbHandler;
        private List<HistoryElement> historyElements;

        private static uiHistory _instance;
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
            LoadData();

            this.FormClosing += (sender, e) =>
            {
                _instance = null;
            };

            InitializeComponent();
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
                        }
                        else
                        {
                            MessageBox.Show("The Output of this Operation is not existing anymore.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void listViewBerechtigungen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private async void LoadData()
        {
            Console.WriteLine("Connecting to Database");

            dbHandler = new DatabaseHandling();
            var data = await dbHandler.GetAllEncryptedOperationsAsync();
            if (data is not null) historyElements = data;
            else
            {
                await dbHandler.InitializeDatabaseAsync(process =>
                {
                    Console.WriteLine(process);
                });
            }
        }

        private async void uiHistory_Load(object sender, EventArgs e)
        {
            if (FeatureManager.IsFeatureEnabled(FeatureFlags.HistoryElementQuering))
            {
                this.listViewHistory.Items.Clear();
                listViewHistory.DoubleClick += ListViewHistory_DoubleClick;
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
                }
            }

            Thread.Sleep(300);

            pnlLoginLoad.Visible = false;
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
                                MessageBox.Show("This Operation had no output.", "No Output", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                                    MessageBox.Show("The Output of this Operation is not existing anymore.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                ConsoleManager.Instance().WriteLineWithColor(ex.Message,ConsoleColor.DarkRed);
            }
        }
    }
}
