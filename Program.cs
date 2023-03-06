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
            //else make array of path and traverse it in this way
            string[] paths = { @"Enter your path here", @"Enter your path here" };

            Automation automate = new Automation();

            for (int i = 0; i < paths.Length; i++)
            {
                automate.DeleteAllTempFiles(paths[i]);
                automate.DeleteAllTempDirectories(paths[i]);
            }

            System.Console.WriteLine("Task Executed Successfully");

            Console.ReadLine();
        }
    }
}