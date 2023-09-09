using System;
using System.IO;
using System.Text.Json;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using LILO_Packager.v2.Core.Updates;

namespace TextPreviewLibrary.Core.Formats
{
    public class CrypterTextFile
    {
        public string FileName { get; set; }
        public Color TextColor { get; set; }
        public Font TextFont { get; set; }
        public bool IsLocked { get; set; }
        public string Author { get; set; }
        public string RtfContent { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified { get; set; }
        public int WordCount => CountWords();
        public SemanticVersion version { get; set; }

        private int CountWords()
        {
            try
            {
                return RtfContent.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }
            catch
            {
                throw new ArgumentException(RtfContent);
            }
        }

        public bool IsDifferentFrom(CrypterTextFile otherFile)
        {
            return !Equals(this, otherFile);
        }

        public static void SaveInstanceToFile(CrypterTextFile file, string filePath)
        {
            if (File.Exists(filePath))
            {
                var existingFile = LoadInstanceFromFile(filePath);
                if (!file.IsDifferentFrom(existingFile))
                {
                    return;
                }
            }

            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(file, jsonOptions);

            File.WriteAllText(filePath, json);
        }

        public static CrypterTextFile LoadInstanceFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                try
                {
                    return JsonSerializer.Deserialize<CrypterTextFile>(json) ?? new CrypterTextFile();
                }
                catch { 
                    throw new ArgumentOutOfRangeException(nameof(json));
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}

