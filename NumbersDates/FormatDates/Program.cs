using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Define a date
        DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

        // 'd' Short date: mm/dd/yyyy (or dd/mm depending on locale)
        Console.WriteLine($"{AprFools:d}");

        // 'D' Full date: mm/dd/yyyy (or dd/mm depending on locale)
        Console.WriteLine($"{AprFools:D}");

        // 'f' Full date, short time
        Console.WriteLine($"{AprFools:f}");

        // 'F' Full date, long time
        Console.WriteLine($"{AprFools:F}");

        // 'g' General date and time
        Console.WriteLine($"{AprFools:g}");

        // 'G' General date and time
        Console.WriteLine($"{AprFools:G}");

        // Format using a specific CultureInfo
        Console.WriteLine(AprFools.ToString("d", CultureInfo.CreateSpecificCulture("de-DE")));

        // Defining custom date and time formats
        Console.WriteLine($"{AprFools:dddd, MMMM d, yyyy}");  // Example: "Tuesday, April 1, 2025"
        Console.WriteLine($"{AprFools:ddd, h:mm:ss tt}");     // Example: "Tue, 1:23:30 PM"
        Console.WriteLine($"{AprFools:MMM d, yyyy}");         // Example: "Apr 1, 2025"
    }
}
