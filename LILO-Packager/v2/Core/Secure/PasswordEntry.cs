using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Secure
{
    public class PasswordEntry
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public DateTime DateAdded { get; set; }
        public string Source { get; set; }
    }
}
