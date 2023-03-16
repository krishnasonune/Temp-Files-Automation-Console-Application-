using System;
using System.IO;
using Automate;

namespace AutomateProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Temp Files Automatation";
            Console.BackgroundColor = ConsoleColor.Black;

            //if you have single path directly pass the path in method 
            string path = Path.GetTempPath();
            Automation automate = new Automation();

            automate.DeleteAllTempFiles(path);
            automate.DeleteAllTempDirectories(path);

            //else make array of path and traverse it in this way
            // string[] paths = { @"Path 1", @"Path 2" };

            // for (int i = 0; i < paths.Length; i++)
            // {
            //     automate.DeleteAllTempFiles(paths[i]);
            //     automate.DeleteAllTempDirectories(paths[i]);
            // }


            System.Console.WriteLine("Task Executed Successfully");

            Console.ReadLine();
        }
    }
}