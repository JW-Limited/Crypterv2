using LILO_Packager.v2.Core.AsyncTasks;
using LILO_Packager.v2.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace LILO_Packager.v2.Forms
{
    public partial class uiCustomProcess : Form
    {
        public Core.AsyncTasks.AsyncTask _Task { get; set; }
        public uiCustomProcess(Core.AsyncTasks.AsyncTask task)
        {
            InitializeComponent();
            _Task = task;
        }

        private void uiCustomProcess_Load(object sender, EventArgs e)
        {
            this.Text = _Task.Name;
            this.lblMessage.Text = TaskModesHandler.GetTaskValue(_Task.Mode);
            _Task.StatusUpdated += (sender, e) =>
            {
                this.Text = _Task.Name + " - " + e.ToString();
            };
            _Task.TaskCompleted += (sender, e) =>
            {
                this.Close();
            };
            _Task.TaskFailed += (sender, e) =>
            {
                ConsoleManager.Instance().WriteLineWithColor(sender + e, ConsoleColor.DarkRed);

                var dialogtest = new uiCustomDialog(
                    new Core.Dialogs.MessageDialogPreference(
                        "Error - " + _Task.Name,
                        "An Error happend while the Application was in iddle Mode.\n\n" + e,
                        Core.Dialogs.Dialog.Authorization,
                        Core.Dialogs.DialogButtons.OkCancel,
                        Core.Dialogs.DialogIcon.Error,
                        result => { })
                    );
                dialogtest.ShowDialog();
                this.Invoke(() =>
                {
                    base.Close();
                });
            };

            var timer = new System.Windows.Forms.Timer();
            timer.Tick += async (sender, e) =>
            {
                timer.Stop();

                Task.Run(() =>
                {
                    _Task.ExecuteAsync(new Progress<int>(progressValue =>
                    {
                        this.Invoke(delegate
                        {
                            progress.Value = progressValue;
                        });
                    }));
                });
            };

            timer.Interval = 500;
            timer.Start();
        }

        private void progress_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
