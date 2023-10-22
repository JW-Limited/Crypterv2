using LILO_Packager.v2.Core.Keys.Types;
using LILO_Packager.v2.Core.LILO.Types;
using System.Collections.Frozen;

namespace LILO_Packager.v2.Forms
{
    public partial class uiKeyManager : Form
    {
        private static object _lock = new object();
        private static uiKeyManager _instance;
        private readonly Core.Keys.Manager _manager;

        public static uiKeyManager Instance()
        {
            lock (_lock)
            {
                if (_instance is null || _instance.IsDisposed)
                {
                    _instance = new uiKeyManager();
                }

                return _instance;
            }
        }

        private uiKeyManager()
        {
            InitializeComponent();
            UserRole userRole = UserRole.User;
            var user = MainHost.Instance().loggedInUser.Role;
            if (user == "admin") { userRole = UserRole.Admin; }
            _manager = new Core.Keys.Manager(new Core.Keys.DatabaseHandler(), userRole);
        }

        private async void uiKeyManager_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "password_history.db";

            var passwords = await _manager.GetAllPasswordEntriesAsync();

            _ = Task.Run(() =>
            {

                foreach (var password in passwords)
                {
                    var item = new ListViewItem()
                    {
                        Text = password.Source,
                    };

                    item.SubItems.Add(password.Password);

                    this.Invoke(() =>
                    {
                        this.htListView1.Items.Add(item);

                        Console.WriteLine(password.Source + password.Password);

                    });

                }
            });
        }

        private async void bntCancel_Click(object sender, EventArgs e)
        {
            var passwords = await _manager.GetAllPasswordEntriesAsync();

            _ = Task.Run(() =>
            {
                try
                {
                    foreach (var password in passwords)
                    {
                        var item = new ListViewItem()
                        {
                            Text = password.Source,
                        };

                        item.SubItems.Add(new Key(new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }).Decrypt(Convert.FromBase64String(password.Password)));

                        this.Invoke(() =>
                        {
                            this.htListView1.Items.Add(item);

                            Console.WriteLine(password.Source + password.Password);

                        });

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Loading", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            });
            
        }
    }
}
