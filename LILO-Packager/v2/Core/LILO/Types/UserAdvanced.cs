using LILO_Packager.v2.Core.LILO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.LILO.Types
{
    public class UserAdvanced : User
    {
        public string? Language { get; set; }
        public Bitmap ProfilePicture { get; set; }
        public string? Theme { get; set; }
        public UserRole UserRole { get; set; }

        public UserAdvanced()
        {

        }
        public UserAdvanced(ILILOUser user)
        {
            base.Email = user.Email;
            //base.Name = user.Name;
            base.Password = user.Password;
            base.Role = user.Role;
            base.RegistrationDate = user.RegistrationDate;

            if (File.Exists(config.Default.localUserImage)) this.ProfilePicture = (Bitmap)Bitmap.FromFile(config.Default.localUserImage);
            else ProfilePicture = Properties.Resources.icons8_male_user_96;
            this.Theme = "White";
            this.Language = "en";


            if (user.Role.ToLower() == "admin") UserRole = UserRole.Admin;
            if (user.Role.ToLower() == "user")  UserRole = UserRole.User;
        }
    }
}
