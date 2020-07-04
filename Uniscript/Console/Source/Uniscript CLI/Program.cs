using System;
using System.Diagnostics;
using System.Text;

namespace Uniscript_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(@"Uniscript 3.9.18.8 Command Line Interface
Created by Xyzdesk

To get more information about this specific type, go to xyzdesk.online/docs/3-9-18-8/about
");

            
            
            // new ln
            Console.Write(Environment.UserName + Environment.MachineName + " # (DEFAULT), Executing NU.xs1 in " + Environment.OSVersion);
            Console.WriteLine(@"");
            Console.Write(">>> ");
            // string command = Console.ReadLine();
            string command = Console.ReadLine();

            if (command == "cdir()")
            {
                Console.WriteLine("Current Directory: " + Environment.CurrentDirectory);
            }
            if(command == "help()")
            {
                
            }//
            
           
        }
    }
}
