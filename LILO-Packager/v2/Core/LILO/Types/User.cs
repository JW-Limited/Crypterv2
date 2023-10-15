using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Core.LILO.Exceptions;
using LILO_Packager.v2.Core.LILO.Interfaces;
using LILO_Packager.v2.Forms;
using System.Text;

namespace LILO_Packager.v2.Core.LILO.Types
{
    public class User : ILILOUser
    {
        public string Email { get; set; }
        public string Name 
        { 
            get
            {
                return CapitalizeFirstLetters(Email.Replace("@jwlmt.com", ""));
            }
        }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime RegistrationDate { get; set; }

        public async Task<ILILOUser> Login(string email, string password)
        {
            var mng = new LicenseManager();
            var res = await mng.LogInAsync(email, password);

            if (res)
            {
                return UserManager.Instance().LoadUserFromFile(Program.InstanceCacheContainer.Resolve<ILILOMainHost>().UserFile);
            }
            else 
            {
                throw new InvalidCredentialsException();
            }
        }

        public static string CapitalizeFirstLetters(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            var output = new StringBuilder();
            var firstChar = true;

            foreach (char c in input)
            {
                if (firstChar)
                {
                    output.Append(char.ToUpper(c));
                    firstChar = false;
                }
                else
                {
                    output.Append(c);
                }
            }

            return output.ToString();
        }


        public void LogOff()
        {
            MainHost.Instance().loggedInUser = null;
            File.Delete(MainHost.Instance().UserFile);
            uiLILOAccountLogin.SetInstance(null);

            MainHost.Instance().pnlSide.Visible = false;
            MainHost.Instance().hider.Visible = false;

            MainHost.Instance().OpenInApp(new uiLILOLogin());
        }
    }

}
