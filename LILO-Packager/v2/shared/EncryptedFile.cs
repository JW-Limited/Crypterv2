﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.shared
{
    public class EncryptedFile
    {
        public String FileName { get; set; } = null;
        public byte[] Data { get; set; } = null;
        public long Length { get; set; } = 0;
        public string Size { get; set; } = null;
        public string Encryption { get; set; } = null;
        public string Path { get; set; } = null;

        public EncryptedFile(string file) 
        {
            FileInfo fileInfo = new FileInfo(file); 

            this.FileName = fileInfo.Name;
            this.Length = fileInfo.Length;
            this.Size = GetSizeString(fileInfo.Length);
            this.Encryption = fileInfo.Extension;
            this.Path = fileInfo.FullName;
            //this.Data = File.ReadAllBytes(file);
        }

        public string GetSizeString(long size)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (size >= 1024 && order < sizes.Length - 1)
            {
                order++;
                size /= 1024;
            }
            return $"{size} {sizes[order]}";
        }
    }
}