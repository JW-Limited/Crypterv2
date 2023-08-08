using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace LILO_Packager;
public class Services
{
    public static byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
    {
        MemoryStream ms = new MemoryStream();
        Rijndael alg = Rijndael.Create();
        alg.Key = Key;
        alg.IV = IV;
        CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);
        cs.Write(clearData, 0, clearData.Length);
        cs.Close();
        byte[] encryptedData = ms.ToArray();
        return encryptedData;
    }

    public static string EncryptString(string clearText, string Password)
    {
        
        byte[] clearBytes =
          System.Text.Encoding.Unicode.GetBytes(clearText);
        PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
            new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
        byte[] encryptedData = Encrypt(clearBytes,
                 pdb.GetBytes(32), pdb.GetBytes(16));
        return Convert.ToBase64String(encryptedData);
    }

    public static byte[] EncryptByte(byte[] clearData, string Password)
    {
        PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
            new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
        return Encrypt(clearData, pdb.GetBytes(32), pdb.GetBytes(16));
    }
     
    public static void EncryptFile(string fileIn,
                string fileOut, string Password)
    {
        FileStream fsIn = new FileStream(fileIn,
            FileMode.Open, FileAccess.Read);
        FileStream fsOut = new FileStream(fileOut,
            FileMode.OpenOrCreate, FileAccess.Write);
        PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
            new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
        Rijndael alg = Rijndael.Create();
        alg.Key = pdb.GetBytes(32);
        alg.IV = pdb.GetBytes(16);
        CryptoStream cs = new CryptoStream(fsOut,
            alg.CreateEncryptor(), CryptoStreamMode.Write);
        int bufferLen = 4096;
        byte[] buffer = new byte[bufferLen];
        int bytesRead;
        do
        {
            bytesRead = fsIn.Read(buffer, 0, bufferLen);
            cs.Write(buffer, 0, bytesRead);
        } while (bytesRead != 0);
        cs.Close();
        fsIn.Close();
    }

    public static byte[] Decrypt(byte[] cipherData,
                                byte[] Key, byte[] IV)
    {
        MemoryStream ms = new MemoryStream();
        Rijndael alg = Rijndael.Create();
        alg.Key = Key;
        alg.IV = IV;
        CryptoStream cs = new CryptoStream(ms,
            alg.CreateDecryptor(), CryptoStreamMode.Write);
        cs.Write(cipherData, 0, cipherData.Length);
        cs.Close();
        byte[] decryptedData = ms.ToArray();
        return decryptedData;
    }

    public static string DecryptString(string cipherText, string Password)
    {
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
            new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65,
            0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
        byte[] decryptedData = Decrypt(cipherBytes,
           pdb.GetBytes(32), pdb.GetBytes(16));
        return System.Text.Encoding.Unicode.GetString(decryptedData);
    }

    public static byte[] Decrypt(byte[] cipherData, string Password)
    {
        PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
            new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
        return Decrypt(cipherData, pdb.GetBytes(32), pdb.GetBytes(16));
    }


    public static async Task EncryptFileAsync(string fileIn, string fileOut, string Password, Action<double> progressCallback, Action<Exception> errorCallback, Action<string> currentTask)
    {
        try
        {
            using (FileStream fsIn = new FileStream(fileIn, FileMode.Open, FileAccess.Read))
            using (FileStream fsOut = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write))
            {
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                Rijndael alg = Rijndael.Create();
                alg.Key = pdb.GetBytes(32);
                alg.IV = pdb.GetBytes(16);
                using (CryptoStream cs = new CryptoStream(fsOut, alg.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    int bufferLen = 4096;
                    byte[] buffer = new byte[bufferLen];
                    int bytesRead;
                    long totalBytesRead = 0;
                    long fileSize = fsIn.Length;

                    currentTask?.Invoke("Encyrpting Started.");

                    do
                    {
                        currentTask?.Invoke($"Encyrpting : {GetSizeString(totalBytesRead)}/{GetSizeString(fileSize)}");

                        bytesRead = await fsIn.ReadAsync(buffer, 0, bufferLen);
                        await cs.WriteAsync(buffer, 0, bytesRead);
                        totalBytesRead += bytesRead;
                        double progress = (double)totalBytesRead / fileSize * 100;
                        progressCallback?.Invoke(progress);
                    } while (bytesRead != 0);
                }
            }
        }
        catch (Exception ex)
        {
            errorCallback?.Invoke(ex);
        }
    }

    public static async Task CompressFileAsync(string fileIn, string fileOut, Action<double> progressCallback, Action<Exception> errorCallback, Action<string> currentTask)
    {
        try
        {
            using (FileStream fsIn = new FileStream(fileIn, FileMode.Open, FileAccess.Read))
            using (FileStream fsOut = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (GZipStream gzipStream = new GZipStream(fsOut, CompressionMode.Compress))
                {
                    int bufferLen = 4096;
                    byte[] buffer = new byte[bufferLen];
                    int bytesRead;
                    long totalBytesRead = 0;
                    long fileSize = fsIn.Length;

                    currentTask?.Invoke("Compressing Started.");

                    do
                    {
                        currentTask?.Invoke($"Compress : {GetSizeString(totalBytesRead)}/{GetSizeString(fileSize)}");

                        bytesRead = await fsIn.ReadAsync(buffer, 0, bufferLen);
                        await gzipStream.WriteAsync(buffer, 0, bytesRead);
                        totalBytesRead += bytesRead;
                        double progress = (double)totalBytesRead / fileSize * 100;
                        progressCallback?.Invoke(progress);
                    } while (bytesRead != 0);
                }
            }
        }
        catch (Exception ex)
        {
            errorCallback?.Invoke(ex);
        }
    }

    public static async Task DecompressFileAsync(string fileIn, string fileOut, Action<int> progressCallback, Action<Exception> errorCallback, Action<string> currentTask)
    {
        try
        {
            using (FileStream fsIn = new FileStream(fileIn, FileMode.Open, FileAccess.Read))
            using (FileStream fsOut = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (GZipStream gzipStream = new GZipStream(fsIn, CompressionMode.Decompress))
                {
                    int bufferLen = 4096;
                    byte[] buffer = new byte[bufferLen];
                    int bytesRead;
                    long totalBytesRead = 0;
                    long fileSize = fsIn.Length;

                    currentTask?.Invoke("Decompressing Started.");

                    do
                    {
                        currentTask?.Invoke($"Decompress : {GetSizeString(totalBytesRead)}/{GetSizeString(fileSize)}");

                        bytesRead = await gzipStream.ReadAsync(buffer, 0, bufferLen);
                        await fsOut.WriteAsync(buffer, 0, bytesRead);
                        totalBytesRead += bytesRead;

                        int progress = (int)((totalBytesRead / (double)fileSize) * 100);
                        progressCallback(progress);
                    } while (bytesRead != 0);
                }
            }

            progressCallback(100);
        }
        catch (Exception ex)
        {
            errorCallback?.Invoke(ex);
        }
    }

    public static string GetSizeString(long size)
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

    public static async Task DecryptFileAsync(string fileIn, string fileOut, string Password, Action<int> progressCallback, Action<Exception> errorCallback, Action<string> currentTask)
    {
        try
        {
            using (FileStream fsIn = new FileStream(fileIn, FileMode.Open, FileAccess.Read))
            using (FileStream fsOut = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write))
            {
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                Rijndael alg = Rijndael.Create();
                alg.Key = pdb.GetBytes(32);
                alg.IV = pdb.GetBytes(16);
                using (CryptoStream cs = new CryptoStream(fsOut, alg.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    int bufferLen = 4096;
                    byte[] buffer = new byte[bufferLen];
                    int bytesRead;
                    long totalBytesRead = 0;
                    long fileSize = fsIn.Length;

                    currentTask?.Invoke("Decrypting Started.");

                    do
                    {
                        currentTask?.Invoke($"Decrypting : {GetSizeString(totalBytesRead)}/{GetSizeString(fileSize)}");

                        bytesRead = await fsIn.ReadAsync(buffer, 0, bufferLen);
                        await cs.WriteAsync(buffer, 0, bytesRead);
                        totalBytesRead += bytesRead;

                        int progress = (int)((totalBytesRead / (double)fileSize) * 100);
                        progressCallback(progress);
                    } while (bytesRead != 0);
                }
            }

            progressCallback(100);
        }
        catch (Exception ex)
        {
            errorCallback?.Invoke(ex);
        }
    
    }


    public static async Task CompressAndEncryptFileAsync(string fileIn, string fileOut, string password, Action<double> progressCallback, Action<Exception> errorCallback, Action<string> taskCallback)
    {
        try
        {
            string tempFile = Path.GetDirectoryName(fileIn) + "\\~temp.tmp";
            taskCallback("Compressing File...");
            await CompressFileAsync(fileIn, tempFile, progressCallback, errorCallback, taskCallback);
            taskCallback("Encrypting File...");
            await EncryptFileAsync(tempFile, fileOut, password, progressCallback, errorCallback,taskCallback);
            taskCallback("Deleting Temp-File...");
            File.Delete(tempFile);
            taskCallback("success");
            File.Delete(fileIn);
            progressCallback(100);
        }
        catch (Exception ex)
        {
            errorCallback?.Invoke(ex);
        }
    }

    public static async Task DecryptAndDecompressFileAsync(string fileIn, string fileOut, string password, Action<int> progressCallback, Action<Exception> errorCallback, Action<string> taskCallback, bool delete = true)
    {
        try
        {
            string tempFile = Path.GetDirectoryName(fileIn) + "\\~temp.tmp";
            await DecryptFileAsync(fileIn, tempFile, password, progressCallback, errorCallback, taskCallback);
            //taskCallback("Decompress File...");
            await DecompressFileAsync(tempFile, fileOut, progressCallback, errorCallback, taskCallback);
            //taskCallback("Deleting Temp-File...");
            File.Delete(tempFile);
            taskCallback("success");
            if(delete) File.Delete(fileIn);
            progressCallback(100);
        }
        catch (Exception ex)
        {
            errorCallback?.Invoke(ex);
        }
    }

    public static async Task CompressAndEncryptDirectoryAsync(string directoryIn, string archiveFileOut, string password, Action<double> progressCallback, Action<Exception> errorCallback, Action<string> taskCallback)
    {
        try
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), "~temp");

            Directory.CreateDirectory(tempDirectory);

            await CompressDirectoryAsync(directoryIn, tempDirectory, progressCallback, errorCallback);
            await EncryptFileAsync(tempDirectory, archiveFileOut, password, progressCallback, errorCallback, taskCallback);

            Directory.Delete(tempDirectory, true);

            progressCallback(100);
        }
        catch (Exception ex)
        {
            errorCallback?.Invoke(ex);
        }
    }

    public static async Task DecryptAndDecompressArchiveAsync(string archiveFileIn, string directoryOut, string password, Action<int> progressCallback, Action<Exception> errorCallback, Action<string> taskCallback)
    {
        try
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), "~temp");

            Directory.CreateDirectory(tempDirectory);

            await DecryptFileAsync(archiveFileIn, tempDirectory, password, progressCallback, errorCallback, taskCallback);
            await DecompressDirectoryAsync(tempDirectory, directoryOut, progressCallback, errorCallback);

            Directory.Delete(tempDirectory, true);

            progressCallback(100);
        }
        catch (Exception ex)
        {
            errorCallback?.Invoke(ex);
        }
    }

    public static async Task CompressDirectoryAsync(string directoryIn, string archiveFileOut, Action<double> progressCallback, Action<Exception> errorCallback)
    {
        try
        {
            using (FileStream fsOut = new FileStream(archiveFileOut, FileMode.Create, FileAccess.Write))
            using (GZipStream gzipStream = new GZipStream(fsOut, CompressionMode.Compress))
            using (ZipArchive zipArchive = new ZipArchive(gzipStream, ZipArchiveMode.Create))
            {
                await CompressDirectoryRecursiveAsync(directoryIn, zipArchive, string.Empty, progressCallback, errorCallback);
            }

            progressCallback(100);
        }
        catch (Exception ex)
        {
            errorCallback?.Invoke(ex);
        }
    }

    public static async Task DecompressDirectoryAsync(string archiveFileIn, string directoryOut, Action<int> progressCallback, Action<Exception> errorCallback)
    {
        try
        {
            using (FileStream fsIn = new FileStream(archiveFileIn, FileMode.Open, FileAccess.Read))
            using (GZipStream gzipStream = new GZipStream(fsIn, CompressionMode.Decompress))
            using (ZipArchive zipArchive = new ZipArchive(gzipStream, ZipArchiveMode.Read))
            {
                await DecompressDirectoryRecursiveAsync(zipArchive, directoryOut, progressCallback, errorCallback);
            }

            progressCallback(100);
        }
        catch (Exception ex)
        {
            errorCallback?.Invoke(ex);
        }
    }

    private static async Task CompressDirectoryRecursiveAsync(string directory, ZipArchive zipArchive, string basePath, Action<double> progressCallback, Action<Exception> errorCallback)
    {
        string[] files = Directory.GetFiles(directory);
        string[] directories = Directory.GetDirectories(directory);

        foreach (string file in files)
        {
            string relativePath = Path.Combine(basePath, Path.GetFileName(file));

            ZipArchiveEntry entry = zipArchive.CreateEntry(relativePath);
            using (Stream entryStream = entry.Open())
            using (FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                await fileStream.CopyToAsync(entryStream);
            }

            progressCallback?.Invoke(CalculateProgress(basePath, file, directories.Length));
        }

        foreach (string subdirectory in directories)
        {
            string relativePath = Path.Combine(basePath, Path.GetFileName(subdirectory) + "/");
            ZipArchiveEntry entry = zipArchive.CreateEntry(relativePath);

            await CompressDirectoryRecursiveAsync(subdirectory, zipArchive, relativePath, progressCallback, errorCallback);
        }
    }

    private static async Task DecompressDirectoryRecursiveAsync(ZipArchive zipArchive, string directory, Action<int> progressCallback, Action<Exception> errorCallback)
    {
        foreach (ZipArchiveEntry entry in zipArchive.Entries)
        {
            string entryPath = Path.Combine(directory, entry.FullName);

            if (entryPath.EndsWith("/"))
            {
                Directory.CreateDirectory(entryPath);
            }
            else
            {
                string entryDirectory = Path.GetDirectoryName(entryPath);
                Directory.CreateDirectory(entryDirectory);

                using (Stream entryStream = entry.Open())
                using (FileStream fileStream = new FileStream(entryPath, FileMode.Create, FileAccess.Write))
                {
                    await entryStream.CopyToAsync(fileStream);
                }
            }

            progressCallback?.Invoke(CalculateProgress(entry.FullName, zipArchive.Entries.Count));
        }
    }

    private static double CalculateProgress(string currentPath, string filePath, int totalDirectories)
    {
        double directoriesProgress = (double)currentPath.Split('/').Length / totalDirectories * 100;
        double fileProgress = (double)1 / totalDirectories * 100;

        return directoriesProgress + fileProgress;
    }

    private static int CalculateProgress(string entryFullName, int totalEntries)
    {
        return (int)((entryFullName.Length + 1) / (double)totalEntries * 100);
    }


    public static void DecryptFile(string fileIn,
                string fileOut, string Password)
    {
        FileStream fsIn = new FileStream(fileIn,
                    FileMode.Open, FileAccess.Read);
        FileStream fsOut = new FileStream(fileOut,
                    FileMode.OpenOrCreate, FileAccess.Write);
        PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
            new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
        Rijndael alg = Rijndael.Create();
        alg.Key = pdb.GetBytes(32);
        alg.IV = pdb.GetBytes(16);
        CryptoStream cs = new CryptoStream(fsOut,
            alg.CreateDecryptor(), CryptoStreamMode.Write);
        int bufferLen = 4096;
        byte[] buffer = new byte[bufferLen];
        int bytesRead;
        do
        {
            bytesRead = fsIn.Read(buffer, 0, bufferLen);
            cs.Write(buffer, 0, bytesRead);
        } while (bytesRead != 0);
        cs.Close();
        fsIn.Close();
    }
}
