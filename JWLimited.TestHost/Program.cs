using JWLimited.TestHost.Core;

namespace JWLimited.TestHost
{
    public class Program
    {
        public static string stVersion = "1.0.1";

        

        public static void Main(string[] args)
        {
            Console.Title = "JWLimited.TestHost.exe";
            Console.WriteLine($"JWLimited TestHost {stVersion}\nSelect youre Test:");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (var test in TestManager.Instance.GetAllTests())
            {
                Console.WriteLine($"--> ({test.Key}). {test.Value}");
            }
            Console.ResetColor();

            Console.Write("Input:");
            var input = Console.ReadLine();
            int.TryParse(input, out var value);

            TestManager.Instance.ExecuteTest(value).Wait();    
            
        }
    }
}
