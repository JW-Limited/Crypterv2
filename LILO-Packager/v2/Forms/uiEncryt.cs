using Guna.UI2.WinForms;
using LILO_Packager.v2.Core;
using LILO_Packager.v2.Core.AsyncTasks;
using LILO_Packager.v2.Core.Dialogs;
using LILO_Packager.v2.Core.History;
using LILO_Packager.v2.Core.Keys;
using LILO_Packager.v2.Core.LILO.Types;
using LILO_Packager.v2.Core.Service;
using LILO_Packager.v2.Plugins.Model;
using LILO_Packager.v2.Shared;
using Telerik.Windows.Documents.Model.Drawing.Charts;

namespace LILO_Packager.v2.Forms;
public partial class uiEncryt : Form
{
    private static uiEncryt _encrypt;
    private readonly Manager _keyManager;
    public Shared.FileOperations sharedFile = new();
    private static object _lock = new object();
    public Color SignalColor = Color.FromArgb(94, 148, 255);
    public static List<string> _arFiles = new List<string>();
    public int fileCounter = 1;
    private PluginEntry Extension;
    private DatabaseHandling dbHandler;
    private TaskStatus CurrentTask = new ();

    public static uiEncryt Instance(PluginEntry extension,DatabaseHandling handler)
    {
        lock (_lock)
        {
            if (_encrypt is null)
            {
                _encrypt = new uiEncryt(extension,handler);
            }

            return _encrypt;
        }
    }

    public uiEncryt(PluginEntry extension, DatabaseHandling handler)
    {
        InitializeComponent();
        _keyManager = new Manager(new DatabaseHandler(),UserRole.User);
        this.Extension = extension;

        dbHandler = handler;

        this.FormClosing += (sender, e) =>
        {
            if (fileCounter == 1)
            {
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                _encrypt = null;
            }
        };
    }

    public enum TaskStatus
    {
        FileChoose,
        Encrypting,
        Compress,
        Ready
    }

    public void MarkStatus(TaskStatus status)
    {
        Label[] lblList =
        {
            lblComb,
            lblEnrcypt,
            lblFile,
            lblReady
        };

        Guna2CirclePictureBox[] pnlList =
        {
            pnlComb,
            pnlEncrypt,
            pnlFile,
            pnlReady
        };

        foreach (var item in pnlList)
        {
            item.FillColor = Color.Gray;
        }

        foreach (var item in lblList)
        {
            item.ForeColor = Color.Gray;
        }

        switch (status)
        {
            case TaskStatus.FileChoose:
                lblFile.ForeColor = SignalColor;
                pnlFile.FillColor = SignalColor;
                break;
            case TaskStatus.Encrypting:
                lblEnrcypt.ForeColor = SignalColor;
                pnlEncrypt.FillColor = SignalColor;
                break;
            case TaskStatus.Ready:
                lblReady.ForeColor = SignalColor;
                pnlReady.FillColor = SignalColor;
                break;
            case TaskStatus.Compress:
                lblComb.ForeColor = SignalColor;
                pnlComb.FillColor = SignalColor;
                break;
        }

    }

    private async void panel2_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            e.Effect = DragDropEffects.All;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        }
    }

    private async void panel2_DragDrop(object sender, DragEventArgs e)
    {
        if (e.Data.GetData(DataFormats.FileDrop) is string[] files)
        {
            _arFiles.AddRange(files);

            foreach (var file in files)
            {
                if (file is not null)
                {
                    if (File.Exists(file))
                    {
                        _arFiles.Add(file);
                        var info = new FileInfo(file);
                        chblistFiles.Items.Add("  " + info.Name);
                        chblistFiles.SetItemCheckState(fileCounter - 1, CheckState.Checked);
                        fileCounter++;
                    }
                    else
                    {
                        ConsoleManager.Instance().WriteLineWithColor($"File: {file} is not availlabel or require higher rights.");
                        OkDialog.Show($"File: {file} is not availlabel or require higher rights.", "System IO Exception", DialogIcon.Error);
                    }
                }
            }
        }
    }

    private void uiEncryt_Load(object sender, EventArgs e)
    {
        MarkStatus(TaskStatus.FileChoose);
        
    }

    private void bntOpen_Click(object sender, EventArgs e)
    {
        var files = sharedFile.GetFilesFromDialog();

        if (files != null)
        {
            foreach (var file in files)
            {
                if (file is not null)
                {
                    if (File.Exists(file))
                    {
                        _arFiles.Add(file);

                        var info = new FileInfo(file);

                        chblistFiles.Items.Add("  " + info.Name);

                        chblistFiles.SetItemCheckState(fileCounter - 1, CheckState.Checked);

                        fileCounter++;
                    }
                }
            }
        }
    }

    public string GetPasswordFrromUser()
    {
        if (pswDialog.ShowDialog() == DialogResult.OK)
        {
            return pswDialog.Input;
        }

        return null;
    }

    public void ControlEnable(bool disable)
    {
        pnlChild.Enabled = disable;
        guna2Button1.Visible = disable;
        pnlFiles.Enabled = disable;
        bntOpen.Enabled = disable;
        bntPlugin.Visible = disable;
        progress.Visible = !disable;
        bntCancel.Visible = !disable;
    }

    private void UpdateProgress(double progres)
    {
        progress.Value = Convert.ToInt32(progres);
        taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.Normal;
        taskBarProgress.Value = Convert.ToInt32(progres);
    }

    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        if(fileCounter == 2)
        {
            var psw = GetPasswordFrromUser();

            var current = new TaskStatus();
            var logged = false;
            var previousFile = "";
        

            if (psw is not null or "")
            {
                ControlEnable(false);

                try
                {
                    string item = _arFiles[0];
                    await _keyManager.AddPasswordEntryAsync(psw, DateTime.Now, item);
                    if (item != previousFile)
                    {
                        previousFile = item;
                        logged = false;
                    }

                    if (!logged)
                    {
                        await dbHandler.InsertEncryptedOperationAsync("Encryption", "libraryBased", "v2", item, item + ".lsf", $"{new Random().NextInt64(11111, 99999)}");
                        logged = true;
                    }

                    

                    _ = Task.Run(async() =>
                    {
                        var values = new ServiceValues()
                        {
                            FileInput = item,
                            FileOutput = item + ".lsf",
                            Password = psw,
                            FileType = FileType.File,
                            CurrentWorkingTask = HandleTaskChange,
                            ErrorCallback = HandleError,
                            ProgressCallback = HandleProgessChange
                        };

                        var serviceHandle = new Services(values);
                        var response = await serviceHandle.CompressAndEncryptFileAsync();

                        if (response.Item1)
                        {
                            MessageBox.Show("All Clear!");
                        }
                    });

                }
                catch (Exception ey)
                {
                    ControlEnable(true);

                    HandleError(ey);
                }
            }
            else
            {
                MessageBox.Show("Error", "Please insert a Valid - Key.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else 
        {
            if(!FeatureManager.IsFeatureEnabled(FeatureFlags.FilePackerv2)) 
            {
                FileInfo info = new FileInfo(_arFiles[0]);

                var tempZip = info.FullName.Replace(info.Name, "") + $"{new Random().NextInt64(1111111, 9999999)}_collected_files.zip";
                var musltifileHandler = new Shared.MultiplefileHandling();
                var asyncTask = new Core.AsyncTasks.AsyncTask("Mainhost - Task", TaskMode.Refresing, async (progress) =>
                {
                    var zipProgress = new Progress<int>(progressPercentage =>
                    {
                        progress?.Report(progressPercentage);
                    });

                    await musltifileHandler.ZipFilesAsync(tempZip, zipProgress, _arFiles);
                });

                var uiAsyncTask = new uiCustomProcess(asyncTask);
                uiAsyncTask.ShowDialog();

                foreach (var file in _arFiles)
                {
                    File.Delete(file);
                }

                chblistFiles.Items.Clear();
                chblistFiles.Items.Add(Path.GetFileName(tempZip));
                _arFiles.Clear();
                fileCounter = 2;
                _arFiles.Add(tempZip);
                guna2Button1_Click(sender, e);
            }
            else
            {

                FileInfo info = new FileInfo(_arFiles[0]);

                var tempZip = info.FullName.Replace(info.Name, "") + $"{new Random().NextInt64(1111111, 9999999)}_collected_files.zip";
                var musltifileHandler = new Shared.SmartFilePacker();
                var asyncTask = new Core.AsyncTasks.AsyncTask("Mainhost - Task", TaskMode.Refresing, async (progress) =>
                {
                    var zipProgress = new Progress<int>(progressPercentage =>
                    {
                        progress?.Report(progressPercentage);
                    });

                    await musltifileHandler.ZipFilesAsync(tempZip, zipProgress, _arFiles);
                });

                var uiAsyncTask = new uiCustomProcess(asyncTask);
                uiAsyncTask.ShowDialog();

                foreach (var file in _arFiles)
                {
                    File.Delete(file);
                }

                chblistFiles.Items.Clear();
                chblistFiles.Items.Add(Path.GetFileName(tempZip));
                _arFiles.Clear();
                fileCounter = 2;
                _arFiles.Add(tempZip);
                guna2Button1_Click(sender, e);
            }
        }
        
    }

    public void HandleTaskChange(string currentTask)
    {
        

        if (currentTask.StartsWith("Compress") && CurrentTask is not TaskStatus.Compress)
        {
            MarkStatus(TaskStatus.Compress);

            CurrentTask = TaskStatus.Compress;
        }

        if (currentTask.StartsWith("Encyrpting") && CurrentTask is not TaskStatus.Encrypting)
        {
            MarkStatus(TaskStatus.Encrypting);

            CurrentTask = TaskStatus.Encrypting;
        }


        if (currentTask == "success")
        {
            MarkStatus(TaskStatus.Ready);

            taskBarProgress.Value = 0;
            taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.Error;

            ControlEnable(true);
            _arFiles.Clear();
            chblistFiles.Items.Clear();
            fileCounter = 0;
        }
    }

    public void HandleError(Exception error)
    {
        MessageBox.Show("Encryption Error", error.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public void HandleProgessChange(ProgressCallBackValues values)
    {
        MainHost.Instance().taskBarProgress.TargetForm = MainHost.Instance();
        MainHost.Instance().taskBarProgress.State = Guna2TaskBarProgress.TaskbarStates.Normal;

        progress.Maximum = (int)values.TotalBytes;
        progress.Value = (int)values.BytesRead;

        MainHost.Instance().taskBarProgress.Value = values.Procentage;
    }

    private void bntCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void bntOpenPlugin_Clicj(object sender, EventArgs e)
    {
        Extension.form.StartPosition = FormStartPosition.CenterScreen;
        if (FeatureManager.IsFeatureEnabled(FeatureFlags.ShellMasterAll)) 
        {
            MainHost.Instance().OpenInApp(Extension.form);
        }
        else
        {
            Extension.form.Show();
        }
    }
}
