using LILO_Packager.v2.Core.History;
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
                    if(element.id == 0)
                    {
                        MessageBox.Show("This Operation had no output.","No Output",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        return;
                    }

                    try
                    {
                        if (File.Exists(element.outputFileName))
                        {
                            Process.Start("explorer.exe", element.outputFileName);
                        }
                        else
                        {
                            MessageBox.Show("The Output of this Operation is not existing anymore.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            dbHandler = new DatabaseHandling();
            var data = await dbHandler.GetAllEncryptedOperationsAsync();
            if (data is not null) historyElements = data;
            else
            {
                await dbHandler.InitializeDatabaseAsync(process =>
                {
                    Debug.WriteLine(process);
                });
            }
        }

        private void uiHistory_Load(object sender, EventArgs e)
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

                listViewHistory.Items.Add(item);
            }
        }

        private void bntPlugin_Click(object sender, EventArgs e)
        {
            LoadData();
            uiHistory_Load(sender, e);
        }
    }
}
