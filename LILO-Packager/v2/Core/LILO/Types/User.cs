using LILO_Packager.v2.Core.LILO.Interfaces;

namespace LILO_Packager.v2.Core.LILO.Types
{
    public class User : ILILOUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

}
