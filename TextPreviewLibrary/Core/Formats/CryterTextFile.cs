
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace TextPreviewLibrary.Core.Formats
{
    public class CrypterTextFile
    {
        public string FileName { get; set; }
        public Color TextColor { get; set; }
        public Font TextFont { get; set; }
        public bool Locked { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public static void SetInstanceToFile(CrypterTextFile file, string dir)
        {
            if (File.Exists(dir)) File.Delete(dir);

            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(file, jsonOptions);

            File.WriteAllText(dir, json);

        }

        public static CrypterTextFile GetInstanceFromFile(string file)
        {
            if (File.Exists(file))
            {
                string json = File.ReadAllText(file);
                return JsonSerializer.Deserialize<CrypterTextFile>(json) ?? new CrypterTextFile();
            }
            else
            {
                throw new FileNotFoundException();
            }

        }


    }
}


/*
 * 
        
 */