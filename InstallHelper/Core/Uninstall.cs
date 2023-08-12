using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallHelper.Core
{
    public class Uninstall
    {
        public static void Start()
        {
            var path = Environment.CurrentDirectory;
            string[] files = Directory.GetFiles(path);

            foreach(var dir in Directory.GetDirectories(path)) 
            {
                Console.WriteLine("Deleting Directory: " + dir);
                Directory.Delete(dir, true);
            }

            foreach (string file in files)
            {
                if (file.EndsWith("InstallHelper.exe") || file.EndsWith("InstallHelper.dll")) continue;

                Console.WriteLine("Deleting File: " + file);
                File.Delete(file);
            }

            Console.WriteLine("\n\nUnistallation Completed.");
            Console.ReadKey();
        }
    }
}
