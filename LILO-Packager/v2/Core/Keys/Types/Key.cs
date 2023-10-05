using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Keys.Types
{
    public class Key
    {
        private readonly byte[] _key;

        public Key(byte[] key)
        {
            _key = key;
        }

        public byte[] Encrypt(string plaintext)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = _key;
                aes.IV = new byte[aes.BlockSize / 8];

                using (var encryptor = aes.CreateEncryptor())
                using (var memoryStream = new MemoryStream())
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    using (var streamWriter = new StreamWriter(cryptoStream))
                    {
                        streamWriter.Write(plaintext);
                    }

                    return memoryStream.ToArray();
                }
            }
        }

        public string Decrypt(byte[] ciphertext)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = _key;
                aes.IV = new byte[aes.BlockSize / 8];

                using (var decryptor = aes.CreateDecryptor())
                using (var memoryStream = new MemoryStream(ciphertext))
                using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                using (var streamReader = new StreamReader(cryptoStream))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }
    }


}
