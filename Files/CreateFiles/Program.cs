using System;
using System.IO;

class Program
{
    static void Main()
    {
        const string filename = "TestFile.txt";

        // Creating a new file - this will overwrite any existing file
        // Use the "using" construct to automatically close the file stream
        using (StreamWriter sw = File.CreateText(filename))
        {
            sw.WriteLine("This is a text file.");
        }

        Console.WriteLine("File created successfully.");

        // Determine if the file exists
        Console.WriteLine(File.Exists(filename));

        if (File.Exists(filename))
        {
            // The delete function deletes the file
            File.Delete(filename);
            Console.WriteLine("File deleted.");
        }
        else
        {
            using (StreamWriter sw = File.CreateText(filename))
            {
                sw.WriteLine("This is a text file.");
            }
            Console.WriteLine("File recreated.");
        }

        Console.WriteLine(File.Exists(filename));
    }
}

