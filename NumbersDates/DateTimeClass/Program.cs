// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for working with Dates and Times
using System.Globalization;
// TODO: Use DateTime.Now property to get the current date and time


// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM


// TODO: DateOnly and TimeOnly represent just dates and times


// TODO: Dates have properties that can be inspected
Console.WriteLine(today.DayOfWeek);
Console.WriteLine(today.DayOfYear);


// TODO: Dates also have methods to change their values
now = now.AddDays(6);
now = now.AddHours(12);
now = now.AddMonths(1);
Console.WriteLine(now);

// TODO: The TimeSpan class represents a duration of time
DateTime AprilFools = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year, 1, 1);

TimeSpan interval = AprilFools - NewYears;
Console.WriteLine(interval);

// TODO: Dates can be compared using regular operators
Console.WriteLine($"(NewYears < AprilFools)");
Console.WriteLine($"(NewYears > AprilFools)");
