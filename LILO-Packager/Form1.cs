using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Media;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Transitions;
using LILO.Shell;
using Guna.UI2.WinForms;

namespace LILO_Packager;

public partial class mainUI : Form
{
    private BackgroundWorker bgw = new BackgroundWorker();
    private PictureBox[] PreviewBoxes => new[] { picbox };


    public mainUI()
    {
        InitializeComponent();

        lblStats.Text = "Drag a File in the Grey Area.";

        bgw.DoWork += Bgw_DoWork;
        bgw.ProgressChanged += Bgw_ProgressChanged;
    }

    public static ArrayList arlist = new ArrayList();
    public static string LicenseFile;
    public static bool FileDroped = false;
    public Image filePreview;

    public int[] size = new int[]
       {
          969,
          744
       };
    public int[] sizeHider = new int[]
       {
          969,
          446
       };


    private async void panel2_DragDrop(object sender, DragEventArgs e)
    {
        var files = e.Data.GetData(DataFormats.FileDrop) as string[];
        arlist.AddRange(c: files);
        arlist.Add(files.All<string>);
        LicenseFile = files[0];

        FileDroped = true;

        await AnimateAndOpenListBox();
    }

    private async Task<Cursor> CreateCursorFromImage(Image image)
    {
        Bitmap bitmap = new Bitmap(image.Width, image.Height);

        using (Graphics g = Graphics.FromImage(bitmap))
        {
            g.DrawImage(image, 0, 0);
        }

        Icon icon = Icon.FromHandle(bitmap.GetHicon());

        Cursor cursor = new Cursor(icon.Handle);

        return cursor;
    }

    private async Task<Bitmap> setBackground()
    {
        var bit = new ImageProcessing.Templates(filePreview as Bitmap);
        previewImage.BackgroundImage = filePreview;
        return bit.BlurredImage().Result;
    }

    private async void panel2_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop) && !FileDroped)
        {
            e.Effect = DragDropEffects.All;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string firstFile = files[0];

            // Load the file preview image
            if (File.Exists(firstFile))
            {
                try
                {
                    filePreview = Image.FromFile(firstFile);

                    // Set the cursor to the file preview image
                    Cursor.Current = await CreateCursorFromImage(filePreview);
                }
                catch (Exception ex)
                {
                    // Error loading the file preview, handle it accordingly
                }
            }
        }


    }

    private async Task AnimateAndOpenListBox()
    {
        await AnimateForm();
        await Task.Delay(500);
    }

    private async Task AnimateForm()
    {
        const int animationDuration = 400;
        const int animationSteps = 34;
        const int animationStepsHider = 60;

        int initialHeight = this.Height;
        int targetHeight = initialHeight - 210;

        for (int i = 1; i <= animationSteps; i++)
        {
            double progress2 = (double)i / animationStepsHider;
            double progress = (double)i / animationSteps;
            int currentHeight = (int)(initialHeight - (progress * (initialHeight - targetHeight)));
            double easedProgress = QuadraticEaseInOut(progress2);

            int targetHiderHeight = (int)(hider.Height * (1 - easedProgress));
            int currentHiderHeight = hider.Height - (hider.Height - targetHiderHeight) / 2;

            this.Height = currentHeight;
            hider.Height = currentHiderHeight;
            await Task.Delay(animationDuration / animationSteps);
        }

        this.Height = targetHeight;
        hider.Visible = false;
    }

    private double QuadraticEaseInOut(double progress)
    {
        return progress < 0.5 ? 2 * progress * progress : 1 - Math.Pow(-2 * progress + 2, 2) / 2;
    }


    private void SetButtonColor(Guna2Button[] bnt, Color col, Color fon)
    {
        foreach (var b in bnt)
        {
            b.FillColor = col;
            b.ForeColor = fon;
        }
    }

    private async void dropDraged_Tick(object sender, EventArgs e)
    {
        if (FileDroped)
        {
            timer1.Stop();
            lblPath.Text = LicenseFile;
            bntEncrypt.Enabled = true;
            bnt_Decrypt.Enabled = true;
            bntCorp.Enabled = true;
            lblStats.Text = "Choose an Option.";
            bntChoose_File.Visible = false;
            dragPanel.Visible = false;
            bntDirectory.Visible = false;

            try
            {
                Task.Run(() =>
                {
                    lblText.Text = "LILO Crypter - Loading Preview...";
                    var img = setBackground().Result;

                    panelPreview.BackgroundImage = img;
                    panelPreview2.BackgroundImage = img;

                    var col = new ImageProcessing.ColorManagment.ColorDetector(img);
                    var main = col.DetectMainColor().Result;
                    var opo = col.GetOppositeColor(main).Result;


                    SetButtonColor(new Guna2Button[] { bntChoose_File, bntEncrypt, bnt_Decrypt, guna2Button1, bntDirectory }, opo, main);

                    lblText.Text = "LILO Crypter";
                });

            }
            catch (Exception)
            {
                lblText.Text = "LILO Crypter - Preview Unavailable";
            }


            await AnimateAndOpenListBox();
        }
    }

    private void ResetToInitialState()
    {
        lblPath.Text = "";
        bntEncrypt.Enabled = false;
        bnt_Decrypt.Enabled = false;
        bntCorp.Enabled = false;
        lblStats.Text = "Drag a File in the Grey Area.";
        bntChoose_File.Visible = true;
        dragPanel.Visible = true;
        hider.Height = sizeHider[1];
        this.Height = size[1];
        hider.Visible = true;
        FileDroped = false;
        bntDirectory.Visible = true;
        arlist.Clear();
        timer1.Start();
    }

    private void bntChoose_File_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.CheckFileExists = true;
        ofd.AutoUpgradeEnabled = true;
        ofd.ShowHiddenFiles = true;
        ofd.CheckPathExists = true;
        ofd.SupportMultiDottedExtensions = true;
        ofd.Multiselect = true;
        if (ofd.ShowDialog() == DialogResult.OK)
        {
            LicenseFile = ofd.FileName;

            arlist.AddRange(ofd.FileNames);

            FileDroped = true;
        }
    }

    private void bntDirectory_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog()
        {
            AddToRecent = true,
            AutoUpgradeEnabled = true,
            Description = "Archivierungs Ordner auswählen.",
            OkRequiresInteraction = true,
            ShowHiddenFiles = true,
            ShowNewFolderButton = true,
            ShowPinnedPlaces = true,
            UseDescriptionForTitle = true,
        };

        if (fbd.ShowDialog() == DialogResult.OK)
        {
            LicenseFile = fbd.SelectedPath;

            arlist.Add(fbd.SelectedPath);

            FileDroped = true;
        }
    }

    public void inProgress(bool progressV)
    {
        bntExit.Visible = progressV;
    }

    public static void decrypt(string key)
    {
        try
        {
            Services.DecryptFile(LicenseFile, LicenseFile + "_ready.rar", key);
            File.Move(LicenseFile + "_ready.rar", ".\\temp\\tool.rar");
        }
        catch (Exception ey)
        {
            MessageBox.Show(ey.Message);
        }
    }

    private void bnt_Decrypt_Click(object sender, EventArgs e)
    {
        if (txtKey.Texts is not null)
        {
            try
            {
                progress.Visible = true;

                Task.Run(() =>
                {
                    Services.DecryptFileAsync(LicenseFile, LicenseFile.Replace(".lsf", ""), txtKey.Texts, proges =>
                    {
                        UpdateProgress(proges);
                    }, error =>
                    {
                        MessageBox.Show(error.Message, "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }, currentTask =>
                    {
                        lblText.Text = $"LILO Cypher - {currentTask}";

                        if (currentTask == "success")
                        {
                            bntExit.Visible = true;
                            lblText.Text = "LILO Cypher";
                            //inProgress(true);
                            taskBarProgress.Value = 0;
                            taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;
                            progress.Visible = false;
                            progressSpinner.Visible = false;
                        }
                    });
                });

                lblStats.Text = "Success";


            }
            catch (Exception ey)
            {
                lblStats.Text = ey.Message;
            }
        }
        else
        {
            lblStats.Text = "Please Insert a valid Key.";
        }
    }

    private void bntEncrypt_Click(object sender, EventArgs e)
    {
        if (txtKey.Texts is not null)
        {

            lblStats.Text = "Encrypt youre File.";
            progress.Visible = true;

            try
            {
                inProgress(true);

                Task.Run(() =>
                {
                    Services.EncryptFileAsync(LicenseFile, LicenseFile + ".lsf", txtKey.Texts,
                    proges =>
                    {
                        UpdateProgress(proges);
                    },
                    error =>
                    {
                        MessageBox.Show(error.Message, "Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }, currentTask =>
                    {
                        lblText.Text = $"LILO Cypher - {currentTask}";

                        if (currentTask == "success")
                        {
                            bntExit.Visible = true;
                            lblText.Text = "LILO Cypher";
                            //inProgress(true);
                            taskBarProgress.Value = 0;
                            taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;
                            progress.Visible = false;
                            progressSpinner.Visible = false;
                        }
                    });
                });

                lblStats.Text = "Success";
                inProgress(false);
            }
            catch (Exception ey)
            {
                inProgress(false);

                lblStats.Text = ey.Message;
            }
        }
        else
        {
            lblStats.Text = "Please Insert a valid Key.";
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }


    public static int opa = 100;
    private void header_Paint(object sender, PaintEventArgs e)
    {

    }

    private void panelJW_Paint(object sender, PaintEventArgs e)
    {

    }

    private void Bgw_ProgressChanged(object? sender, ProgressChangedEventArgs e) => progress.Value = e.ProgressPercentage;
    private void Bgw_DoWork(object? sender, DoWorkEventArgs e)
    {

    }

    private async void guna2Button1_Click(object sender, EventArgs e)
    {

        bntExit.Visible = false;

        try
        {
            WebClient client = new WebClient();
            var User_PSW = await client.DownloadDataTaskAsync("https://pastebin.com/raw/EmRwJPSE");
            var key = Encoding.ASCII.GetString(User_PSW);

            progressSpinner.Visible = true;
            progress.Visible = true;

            if (!LicenseFile.EndsWith(".lsf"))
            {
                lblStats.Text = "Encrypting your File.";
                await Task.Run(() =>
                {

                    Services.CompressAndEncryptFileAsync(LicenseFile, LicenseFile + ".lsf", key, progress =>
                    {
                        UpdateProgress(progress);
                    }, error =>
                    {
                        ShowError("Encryption Error", error.Message);
                    }, currentTask =>
                    {
                        lblText.Text = $"LILO Cypher - {currentTask}";

                        if (currentTask == "success")
                        {
                            bntExit.Visible = true;
                            lblText.Text = "LILO Cypher";
                            //inProgress(true);
                            taskBarProgress.Value = 0;
                            taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;
                            progress.Visible = false;
                            progressSpinner.Visible = false;
                        }
                    });
                });

                lblStats.Text = "Encryption Successful";
            }
            else
            {
                lblStats.Text = "Decrypting your File.";
                bntExit.Visible = false;
                await Task.Run(() =>
                {
                    Services.DecryptAndDecompressFileAsync(LicenseFile, LicenseFile.Replace(".lsf", ""), key, progress =>
                    {
                        UpdateProgress(progress);
                    }, error =>
                    {
                        ShowError("Decryption Error", error.Message);
                    }, currentTask =>
                    {
                        lblText.Text = $"LILO Cypher - {currentTask}";

                        if (currentTask == "success")
                        {
                            bntExit.Visible = true;
                            lblText.Text = "LILO Cypher";
                            //inProgress(true);
                            taskBarProgress.Value = 0;
                            progressSpinner.Visible = false;
                            taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;
                            progress.Visible = false;
                        }
                    });
                });

                lblStats.Text = "Decryption Successful";
            }

        }
        catch (Exception ex)
        {
            inProgress(false);
            lblStats.Text = ex.Message;
        }
    }

    private void UpdateProgress(double progres)
    {
        progress.Value = Convert.ToInt32(progres);
        taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.Normal;
        taskBarProgress.Value = Convert.ToInt32(progres);
    }

    private void ShowError(string title, string message)
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void hider_Paint(object sender, PaintEventArgs e)
    {

    }

    private void bntClose(object sender, EventArgs e)
    {
        ResetToInitialState();
    }

    private void mouseHover(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        var form = new Form()
        {
            BackgroundImage = previewImage.BackgroundImage,
            BackgroundImageLayout = ImageLayout.Zoom,
            Size = new Size(512, 512)
        };

        form.ShowDialog();
    }


}
