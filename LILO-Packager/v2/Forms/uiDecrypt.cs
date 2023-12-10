using Guna.UI2.WinForms;
using LILO_Packager.v2.Core.AsyncTasks;
using LILO_Packager.v2.Core.Dialogs;
using LILO_Packager.v2.Core.History;
using LILO_Packager.v2.Core.Service;
using LILO_Packager.v2.Shared;
using Telerik.Windows.Documents.Model.Drawing.Charts;

namespace LILO_Packager.v2.Forms;
public partial class uiDecrypt : Form
{
    private static uiDecrypt _encrypt;
    private static object _lock = new object();
    public Color SignalColor = Color.FromArgb(94, 148, 255);
    public static List<string> _arFiles = new List<string>();
    public int fileCounter = 1;
    public Shared.FileOperations sharedFile = new();
    private DatabaseHandling dbHandler; 
    private TaskStatus CurrentTask = new();

    public static uiDecrypt Instance(DatabaseHandling handler)
    {
        lock (_lock)
        {
            if (_encrypt is null)
            {
                _encrypt = new uiDecrypt(handler);
            }

            return _encrypt;
        }
    }

    public uiDecrypt(DatabaseHandling handler)
    {
        this.dbHandler = handler;

        InitializeComponent();

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
        Decrypting,
        DeCompress,
        Ready
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
        var files = e.Data.GetData(DataFormats.FileDrop) as string[];
        _arFiles.AddRange(files);
        //_arFiles.Add(files.All<string>);

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

    public void MarkStatus(TaskStatus status)
    {
        Label[] lblList =
        {
            lblComb,
            lblDecrypt,
            lblFile,
            lblReady
        };

        Guna2CirclePictureBox[] pnlList =
        {
            pnlComb,
            pnlDecrypt,
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
            case TaskStatus.Decrypting:
                lblDecrypt.ForeColor = SignalColor;
                pnlDecrypt.FillColor = SignalColor;
                break;
            case TaskStatus.Ready:
                lblReady.ForeColor = SignalColor;
                pnlReady.FillColor = SignalColor;
                break;
            case TaskStatus.DeCompress:
                lblComb.ForeColor = SignalColor;
                pnlComb.FillColor = SignalColor;
                break;
        }

    }

    private void uiDecrypt_Load(object sender, EventArgs e)
    {
        MarkStatus(TaskStatus.FileChoose);
    }

    public string GetPasswordFrromUser()
    {
        if (pswDialog.ShowDialog() == DialogResult.OK)
        {
            return pswDialog.Input;
        }

        return null;
    }

    private void UpdateProgress(double progres)
    {
        progress1.Value = Convert.ToInt32(progres);
        taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.Normal;
        taskBarProgress.Value = Convert.ToInt32(progres);
    }

    public async void ControlEnable(bool disable,string decryptedFile)
    {
        if (disable && decryptedFile is not null)
        {
            var info = new FileInfo(decryptedFile);

            if (decryptedFile.Replace(".lsf", "").Contains("collected_files"))
            {
                var items = await dbHandler.GetAllEncryptedOperationsAsync();

                foreach (var env in items)
                {
                    if ($"{env.outputFileName}" == decryptedFile)
                    {

                        try
                        {
                            Directory.CreateDirectory(decryptedFile.Replace(".lsf", "").Replace(".zip", ""));

                            var handler = new Shared.MultiplefileHandling();
                            var tempZip = info.FullName.Replace(info.Name, "") + $"{new Random().NextInt64(1111111, 9999999)}_collected_files.zip";
                            var musltifileHandler = new Shared.MultiplefileHandling();
                            var asyncTask = new Core.AsyncTasks.AsyncTask("Mainhost - Task", TaskMode.Copying, async (progress) =>
                            {

                                var unzipProgress = new Progress<int>(progressPercentage =>
                                {
                                    progress?.Report(progressPercentage);
                                });


                                await handler.UnzipFilesAsync(decryptedFile.Replace(".lsf", ""), decryptedFile.Replace(".lsf", "").Replace(".zip", ""), unzipProgress);
                            });

                            var uiAsyncTask = new uiCustomProcess(asyncTask);
                            uiAsyncTask.ShowDialog();

                            File.Delete(decryptedFile.Replace(".lsf", ""));
                        }
                        catch(Exception ex) 
                        {
                            ShowError("File Operation",ex.Message + decryptedFile.Replace(".lsf", "").Replace(".zip", ""));
                        }
                        
                    }
                }
            }
        }

        pnlChild.Enabled = disable;
        guna2Button1.Visible = disable;
        pnlFiles.Enabled = disable;
        bntOpen.Enabled = disable;

        progress1.Visible = !disable;
        bntCancel.Visible = !disable;
    }

    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        var psw = GetPasswordFrromUser();
        var current = new TaskStatus();

        var logged = false;
        var previousFile = "";

        if (psw is not null or "")
        {
            ControlEnable(false,null);

            try
            {

                foreach (string item in _arFiles)
                {
                    await Task.Run(async() =>
                    {
                        if (item != previousFile)
                        {
                            previousFile = item;
                            logged = false;
                        }

                        if (!logged)
                        {
                            await dbHandler.InsertEncryptedOperationAsync("Decryption", "libraryBased", "v2", item, item.Replace(".lsf", ""), $"{new Random().NextInt64(11111, 99999)}");
                            logged = true;
                        }

                        var values = new ServiceValues()
                        {
                            CurrentWorkingTask = async currentTask =>
                            {

                                if (currentTask.StartsWith("Decompress") && current is not TaskStatus.DeCompress)
                                {
                                    MarkStatus(TaskStatus.DeCompress);

                                    current = TaskStatus.DeCompress;
                                }

                                if (currentTask.StartsWith("Decrypting") && current is not TaskStatus.Decrypting)
                                {
                                    MarkStatus(TaskStatus.Decrypting);

                                    current = TaskStatus.Decrypting;
                                }


                                if (currentTask == "success")
                                {

                                    var info = new FileInfo(item);
                                    MarkStatus(TaskStatus.Ready);
                                    taskBarProgress.Value = 0;
                                    taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;

                                    ControlEnable(true, item);
                                    _arFiles.Remove(item);
                                    chblistFiles.Items.Remove("  " + info.Name);
                                    fileCounter--;
                                }
                            },
                            FileInput = item,
                            FileOutput = item.Replace(".lsf", ""),
                            Password = psw,
                            FileType = FileType.File,
                            ErrorCallback = HandleError,
                            ProgressCallback = HandleProgessChange,
                        };

                        var serviceHandler = new Services(values);
                        var response = await serviceHandler.DecryptAndDecompressFileAsync();

                    });
                }

            }
            catch (Exception ey)
            {
                ControlEnable(true,null);

                ShowError("Error", ey.Message);
            }
        }
        else
        {
            ShowError("Error", "Please Insert a valid Key.");
        }
    }

    private void ShowError(string title, string message)
    {
        ConsoleManager.Instance().WriteLineWithColor($"({title}) - {message}");

        try
        {
            OkDialog.Show(message, title, DialogIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(message + "\n\n" + ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void HandleError(Exception error)
    {
        MessageBox.Show("Encryption Error", error.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

        ConsoleManager.Instance().WriteLineWithColor($"(Encryption Error) - {error.Message}");

        try
        {
            OkDialog.Show(error.Message, "Encryption Error", DialogIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(error.Message + "\n\n" + ex.Message, "Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void HandleProgessChange(ProgressCallBackValues values)
    {
        MainHost.Instance().taskBarProgress.TargetForm = MainHost.Instance();
        MainHost.Instance().taskBarProgress.State = Guna2TaskBarProgress.TaskbarStates.Normal;

        progress.Maximum = (int)values.TotalBytes;
        progress.Value = (int)values.BytesRead;

        MainHost.Instance().taskBarProgress.Value = values.Procentage;
    }

    private void bntOpen_Click(object sender, EventArgs e)
    {
        var files = sharedFile.GetFilesFromDialogFilter(Shared.FilterType.EncryptedFiles);

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
}
