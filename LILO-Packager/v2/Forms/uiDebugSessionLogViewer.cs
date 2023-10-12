using Aqua.EnumerableExtensions;
using LILO_Packager.v2.Core.Debug.Types;
using LILO_Packager.v2.Core.LILO;

namespace LILO_Packager.v2.Forms
{
    public partial class uiDebugSessionLogViewer : Form
    {
        DebugSession _session;

        public uiDebugSessionLogViewer(DebugSession session)
        {
            _session = session;

            InitializeComponent();
        }

        public List<LogEntry> logEntries;

        private void uiDebugSessionLogViewer_Load(object sender, EventArgs e)
        {
            lblSessionName.Text = _session.SessionName;
            lblCreated.Text = "Session from: " + _session.CreatedAt;
            lblCrashed.Text = "Crashed: " + _session.Crashed.ToString();

            var analyzer = new LogParser(new FileLogReader(_session.FileName));
            Task.Run(() =>
                {
                    var logANA = new Crypterv2.LogAnalyzer.LogAnalyzer();
                    var summa = logANA.AnalyzeLog(File.ReadAllText(_session.FileName));

                    summa.CategorizeLogEntries();
                    summa.GenerateDiagnosticSummary();

                    mainText.Text += "LogEntries: " + summa.CategoryCounts.Count + " - " + summa.LogEntries.Count + "\n";
                    mainText.Text += summa.DiagnosticSummary + "\n\n";


                    foreach (var line in File.ReadLines(_session.FileName))
                    {
                        mainText.Text += "*- " + line + "\n";
                    }
                    pnlLoading.Visible = false;
                });
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bntOPen_Click(object sender, EventArgs e)
        {
            EmailHelper.OpenDefaultEmailClient("Joey_West@thekingjw.onmicrosoft.com", "Report Session", "An Error Accoured", _session.FileName);
            this.Close();
        }

        private void lblSessionName_Click(object sender, EventArgs e)
        {

        }

        private void bntAnalyze_Click(object sender, EventArgs e)
        {

        }
    }
}