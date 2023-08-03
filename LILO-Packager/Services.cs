using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace LILO_Packager;
public class Services
{

    // Encrypt a byte array into a byte array using a key and an IV
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

    // Encrypt a string into a string using a password
    //    Uses Encrypt(byte[], byte[], byte[])
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

    // Encrypt bytes into bytes using a password
    //    Uses Encrypt(byte[], byte[], byte[])
    public static byte[] EncryptByte(byte[] clearData, string Password)
    {
        PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
            new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
        return Encrypt(clearData, pdb.GetBytes(32), pdb.GetBytes(16));
    }

    // Encrypt a file into another file using a password
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

    // Decrypt a byte array into a byte array using a key and an IV
    public static byte[] Decrypt(byte[] cipherData,
                                byte[] Key, byte[] IV)
    {
        // Create a MemoryStream that is going to accept the
        // decrypted bytes
        MemoryStream ms = new MemoryStream();
        // Create a symmetric algorithm.
        // We are going to use Rijndael because it is strong and
        // available on all platforms.
        // You can use other algorithms, to do so substitute the next
        // line with something like
        //     TripleDES alg = TripleDES.Create();
        Rijndael alg = Rijndael.Create();
        // Now set the key and the IV.
        // We need the IV (Initialization Vector) because the algorithm
        // is operating in its default
        // mode called CBC (Cipher Block Chaining). The IV is XORed with
        // the first block (8 byte)
        // of the data after it is decrypted, and then each decrypted
        // block is XORed with the previous
        // cipher block. This is done to make encryption more secure.
        // There is also a mode called ECB which does not need an IV,
        // but it is much less secure.
        alg.Key = Key;
        alg.IV = IV;
        // Create a CryptoStream through which we are going to be
        // pumping our data.
        // CryptoStreamMode.Write means that we are going to be
        // writing data to the stream
        // and the output will be written in the MemoryStream
        // we have provided.
        CryptoStream cs = new CryptoStream(ms,
            alg.CreateDecryptor(), CryptoStreamMode.Write);
        // Write the data and make it do the decryption
        cs.Write(cipherData, 0, cipherData.Length);
        // Close the crypto stream (or do FlushFinalBlock).
        // This will tell it that we have done our decryption
        // and there is no more data coming in,
        // and it is now a good time to remove the padding
        // and finalize the decryption process.
        cs.Close();
        // Now get the decrypted data from the MemoryStream.
        // Some people make a mistake of using GetBuffer() here,
        // which is not the right way.
        byte[] decryptedData = ms.ToArray();
        return decryptedData;
    }

    // Decrypt a string into a string using a password
    //    Uses Decrypt(byte[], byte[], byte[])
    public static string DecryptString(string cipherText, string Password)
    {
        // First we need to turn the input string into a byte array.
        // We presume that Base64 encoding was used
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        // Then, we need to turn the password into Key and IV
        // We are using salt to make it harder to guess our key
        // using a dictionary attack -
        // trying to guess a password by enumerating all possible words.
        PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
            new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65,
            0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
        // Now get the key/IV and do the decryption using
        // the function that accepts byte arrays.
        // Using PasswordDeriveBytes object we are first
        // getting 32 bytes for the Key
        // (the default Rijndael key length is 256bit = 32bytes)
        // and then 16 bytes for the IV.
        // IV should always be the block size, which is by
        // default 16 bytes (128 bit) for Rijndael.
        // If you are using DES/TripleDES/RC2 the block size is
        // 8 bytes and so should be the IV size.
        // You can also read KeySize/BlockSize properties off
        // the algorithm to find out the sizes.
        byte[] decryptedData = Decrypt(cipherBytes,
           pdb.GetBytes(32), pdb.GetBytes(16));
        // Now we need to turn the resulting byte array into a string.
        // A common mistake would be to use an Encoding class for that.
        // It does not work
        // because not all byte values can be represented by characters.
        // We are going to be using Base64 encoding that is
        // designed exactly for what we are trying to do.
        return System.Text.Encoding.Unicode.GetString(decryptedData);
    }

    // Decrypt bytes into bytes using a password
    //    Uses Decrypt(byte[], byte[], byte[])
    public static byte[] Decrypt(byte[] cipherData, string Password)
    {
        // We need to turn the password into Key and IV.
        // We are using salt to make it harder to guess our key
        // using a dictionary attack -
        // trying to guess a password by enumerating all possible words.
        PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
            new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
        // Now get the key/IV and do the Decryption using the
        //function that accepts byte arrays.
        // Using PasswordDeriveBytes object we are first getting
        // 32 bytes for the Key
        // (the default Rijndael key length is 256bit = 32bytes)
        // and then 16 bytes for the IV.
        // IV should always be the block size, which is by default
        // 16 bytes (128 bit) for Rijndael.
        // If you are using DES/TripleDES/RC2 the block size is
        // 8 bytes and so should be the IV size.
        // You can also read KeySize/BlockSize properties off the
        // algorithm to find out the sizes.
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

    public static async Task DecryptAndDecompressFileAsync(string fileIn, string fileOut, string password, Action<int> progressCallback, Action<Exception> errorCallback, Action<string> taskCallback)
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
            File.Delete(fileIn);
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
