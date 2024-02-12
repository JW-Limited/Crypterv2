using JWLimited.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWLimited.TestHost.Core
{
    public enum TestableClasses
    {
        Cryptography_Encryptv2 = 1,
        Cryptography_Decryptv2 = 2,
    }

    public class TestManager
    {
        public static TestManager Instance { get => instance.Value; }
        private static Lazy<TestManager> instance = new Lazy<TestManager>(() => new TestManager());

        public TestManager() 
        {
        }

        public async Task ExecuteTest(int test)
        {
            if(test == 1)
            {
                try
                {
                    Console.Clear();

                    Console.Write("--> Input a file to encrypt: ");
                    var input = Console.ReadLine();
                    

                    if (File.Exists(input))
                    {
                        Console.Write("\n--> Input password to encrypt: ");
                        var psw = Console.ReadLine();

                        var serviceValues = new ServiceValues()
                        {
                            FileInput = input,
                            FileType = FileType.File,
                            Password = psw,
                            CurrentWorkingTask = status =>
                            {
                                Console.WriteLine("[SERVICE] " + status);
                            },
                            FileOutput = input + ".sflx",
                            ProgressCallback = progress =>
                            {
                                Console.Title = $"Working: {progress.Message} - {progress.Procentage}({progress.BytesRead}/{progress.TotalBytes})";
                            }
                        };

                        var crypto = JWLimited.Cryptography.CryptographyManager.Create(serviceValues);
                        var result = await crypto.EncryptFileWithService((e) => Console.WriteLine(e));

                        Console.WriteLine("The task ended.");
                        Console.ReadKey();
                        Program.Main(null);
                    }

                    else
                    {
                        ExecuteTest(1);
                    }
                
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Failed to encrypt: {ex.Message}");
                    Console.ReadKey();
                    Program.Main(null);
                }
            }
        }

        public Dictionary<int,string> GetAllTests()
        {
            int i = 1;
            return Enum.GetValues(typeof(TestableClasses)).Cast<TestableClasses>()
            .Select(feature => new KeyValuePair<int,string>(i++, feature.ToString()))
            .ToDictionary();
        }
    }
}
