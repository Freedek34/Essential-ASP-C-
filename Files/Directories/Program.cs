using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        const string dirname = "TestDir";

        // Create a directory if it doesn't already exist
        if (!Directory.Exists(dirname))
        {
            Directory.CreateDirectory(dirname);
            Console.WriteLine($"Directory '{dirname}' created.");
        }
        else
        {
            Console.WriteLine($"Directory '{dirname}' already exists.");
        }

        // Get the path for the current directory
        string curpath = Directory.GetCurrentDirectory();
        Console.WriteLine($"Current directory is {curpath}");

        // Retrieve info about the directory
        DirectoryInfo di = new DirectoryInfo(curpath);
        Console.WriteLine($"Directory Name: {di.Name}");
        Console.WriteLine($"Parent Directory: {di.Parent}");
        Console.WriteLine($"Creation Time: {di.CreationTime}");
        Console.WriteLine("---------------");

        // Enumerate the contents of directories
        Console.WriteLine("Just directories:");
        List<string> thedirs = new List<string>(Directory.EnumerateDirectories(curpath));
        foreach (string dir in thedirs)
        {
            Console.WriteLine(dir);
        }
        Console.WriteLine("---------------");

        // Enumerate the files in the directory
        Console.WriteLine("Just files:");
        List<string> thefiles = new List<string>(Directory.EnumerateFiles(curpath));
        foreach (string file in thefiles)
        {
            Console.WriteLine(file);
        }
        Console.WriteLine("---------------");

        // Enumerate all directory contents (files and directories)
        Console.WriteLine("All directory contents:");
        List<string> thecontents = new List<string>(Directory.EnumerateFileSystemEntries(curpath));
        foreach (string entry in thecontents)
        {
            Console.WriteLine(entry);
        }
        Console.WriteLine("---------------");
    }
}
