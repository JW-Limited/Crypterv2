using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Cloud.Storage
{
    public class ResolveAgent
    {
        public ResolveAgent() 
        { 
        }

        public static MatrixEntry ResolveFile(string path)
        {
            var matrix = FileIndexStorage.Instance.GetMatrixFile();

            return matrix.MatrixEntrys.First(k => k.CloudEntry.PublicFileId == File.ReadAllText(path)) ?? throw new MatrixEntryNullException();
        }


    }
}
