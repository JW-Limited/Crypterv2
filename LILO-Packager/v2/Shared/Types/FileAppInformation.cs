using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Shared.Types
{
    public class FileAppInformation
    {
        public string Name { get; set; } = null;
        public string Description { get; set; } = null;
        public string DefaultApp { get; set; } = null;
        public string OpenCommand { get; set; } = null;
        public string Extension { get; set; } = null;
    }
}
