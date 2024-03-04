using LILO_Packager.v2.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Plugins.API
{
    public partial class PLuginAPI
    {
        public class Dialogs
        {
            public static Task<bool> ShowErrorMessage(Exception ec, string origin = null)
            {
                if (ec == null) return Task.FromResult(false);
                try
                {
                    MainHost.Instance().Invoke(() =>
                    {
                        MessageBox.Show(ec.Message + "\nSource:\n" + ec.Source,
                            origin ?? "Plugin Exception",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        ConsoleManager.Instance().WriteLineWithColor(ec.Message + "\nSource:\n" + ec.Source, ConsoleColor.DarkRed);

                    });
                }
                catch(Exception ex)
                {
                    ConsoleManager.Instance().WriteLineWithColor(ex.Message + "\nSource:\n" + ex.Source, ConsoleColor.DarkRed);

                    return Task.FromResult(false);
                }
                
                return Task.FromResult(true);
            }
        }
    }
    
}
