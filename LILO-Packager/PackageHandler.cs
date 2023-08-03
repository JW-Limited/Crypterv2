using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager;
internal class PackageHandler
{
    private static void GetCommand()
    {
        Console.Write("Do you want to continue in Console > (Y/N) : ");

        var command = Console.ReadLine();

        if (command == "")
        {
            GetCommand();
        }
        else if (command == "exit" && command == "Exit")
        {
            Environment.Exit(69);
        }
        else
        {
            
        }
    }
}
