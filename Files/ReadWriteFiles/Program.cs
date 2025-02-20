using System;
using System.IO;

class Program
{
    static void Main()
    {
        const string filename = "TestFile.txt";

        // TODO 1: WriteAllText overwrites a file with the given content
        if (!File.Exists(filename))
        {
            File.WriteAllText(filename, "This is a text file. ");
        }

        // TODO 3: AppendAllText adds text to an existing file
        File.AppendAllText(filename, "300 LVL Second semester course");

        // TODO 4: A FileStream can be opened and written to until closed
        using (StreamWriter sw = File.AppendText(filename))
        {
            sw.WriteLine("Line 1");
            sw.WriteLine("Line 2");
            sw.WriteLine("Line 3");
        }

        // TODO 2: ReadAllText reads all the content from a file
        string content = File.ReadAllText(filename);
        Console.WriteLine(content); // Fixed 'console' to 'Console'
    }
}
