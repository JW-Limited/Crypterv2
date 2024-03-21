using JWLimited.TestHost.Core;
using System.Diagnostics;

namespace JWLimited.TestHost
{
    public class Program
    {
        public static string stVersion = "1.0.1";
        private static ConsoleColor defaultConsoleColor = ConsoleColor.Gray;
        private static ConsoleColor selectedOptionColor = ConsoleColor.Cyan;
        private static ConsoleColor submenuColor = ConsoleColor.DarkGreen;
        private static ConsoleColor errorColor = ConsoleColor.Red;

        public static void Main(string[] args)
        {
            Console.Title = "JWLimited.TestHost.exe";
            Console.WriteLine($"JWLimited TestHost {stVersion}\nSelect youre Test:");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (var test in TestManager.Instance.GetAllTests())
            {
                Console.WriteLine($"--> [{test.Key}] - {test.Value}");
            }
            Console.ResetColor();

            Console.Write("Input:");
            var input = Console.ReadLine();

            if (input == "help")
            if (input == "path") Process.Start("explorer.exe", Path.GetDirectoryName(Environment.ProcessPath));
            if (input == "version") Console.WriteLine($"JW LIMITED - TestHost {stVersion}v");
            if (input == "exit") Environment.Exit(100);

            int.TryParse(input, out var value);
            try
            {
                TestManager.Instance.ExecuteTest(value).Wait();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ex.ToString(), ex.StackTrace, ex.InnerException);
                Console.ResetColor();
                Task.Delay(1000).Wait();
                Console.Clear();

                File.WriteAllText($".\\TestHost_Error{ex.GetHashCode()}.err", ex.ToString() + ex.StackTrace + ex.InnerException);
                Process.Start("explorer.exe", $".\\TestHost_Error{ex.GetHashCode()}.err");

                Main(args);
            }
        }

    } 
}
