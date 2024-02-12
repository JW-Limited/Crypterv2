using JWLimited.Cryptography;
using LILO_Packager.v2.Forms;

namespace LILO_Packager.v2.Core.Service
{
    public class FileTaskInformation
    {
        public static FileTaskInformation Create(IServiceValues values, FileOperation fileOperation)
        {
            var _fti = new FileTaskInformation();
            _fti.BeforeFileOperation = values.FileInput;
            _fti.AfterFileOperation = values.FileOutput;
            _fti.FileOperationType = fileOperation;

            return _fti;
        }

        public string BeforeFileOperation { get; set; }
        public string AfterFileOperation { get; set; }
        public FileOperation FileOperationType { get; set; }
    }
}
