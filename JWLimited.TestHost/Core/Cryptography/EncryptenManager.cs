namespace JWLimited.TestHost.Core.Cryptography
{
    internal class EncryptenManager
    {
        public async Task LFS_LFSO_NMS()
        {
            string input = string.Empty;
            string psw = string.Empty;

            Console.Clear();

            while (input is "")
            {
                input = await __getInputFile(); 
            }

            while(psw is "")
            {
                psw = await __getPassword();
            }
            

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

            await Task.Run(async () =>
            {
                var crypto = JWLimited.Cryptography.CryptographyManager.Create(serviceValues);
                var result = await crypto.EncryptFileWithService((e) => Console.WriteLine(e));

                Console.WriteLine("The task ended.");
                Console.ReadKey();
            });

            Program.Main(null);
        }

        internal async Task<string> __getPassword()
        {
            Console.Write("\n--> Input password to encrypt: ");
            var psw = Console.ReadLine();

            if (psw is "" || !__securePassword(psw))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\nYoure Password is not Secure enough. Sorry :(");
                Console.ResetColor();
                await Task.Delay(1500);
                return "";
            };
            return psw;
        }

        internal bool __securePassword(string psw, 
                                       int minLength = 8, 
                                       int maxLength = 64, 
                                       bool requireUppercase = true, 
                                       bool requireLowercase = true, 
                                       bool requireDigit = true,
                                       bool requireSpecialChar = true, 
                                       bool allowCommonPasswords = false, 
                                       bool allowSequentialChars = false)
        {
            if (string.IsNullOrEmpty(psw))
                return false;

            if (psw.Length < minLength || psw.Length > maxLength)
                return false;

            if (requireUppercase && !psw.Any(char.IsUpper))
                return false;

            if (requireLowercase && !psw.Any(char.IsLower))
                return false;

            if (requireDigit && !psw.Any(char.IsDigit))
                return false;

            if (requireSpecialChar && !psw.Any(c => !char.IsLetterOrDigit(c)))
                return false;

            if (!allowCommonPasswords && CommonPasswords.Contains(psw))
                return false;

            if (!allowSequentialChars && HasSequentialChars(psw))
                return false;

            return true;
        }

        private static readonly HashSet<string> CommonPasswords = new HashSet<string>
        {
            "password", "123456", "qwerty", "abc123", 
        };

        private static bool HasSequentialChars(string psw)
        {
            for (int i = 0; i < psw.Length - 2; i++)
            {
                if (psw[i] == psw[i + 1] - 1 && psw[i + 1] == psw[i + 2] - 1)
                    return true;
            }

            return false;
        }
        internal async Task<string> __getInputFile()
        {
            Console.Clear();
            Console.WriteLine("JW LIMITED - Cryptography Library\n");
            Console.Write("--> Input a file to encrypt: ");
            var input = Console.ReadLine();
            if (!File.Exists(input))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\nThe File \"{input}\", does not exist. Sorry :(");
                Console.ResetColor();
                await Task.Delay(1500);
                return "";
            };
            return input;
        }
    }
}
    
