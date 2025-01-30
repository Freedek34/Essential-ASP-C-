// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

// Ask for the user's name
Console.WriteLine("What is your name?");
string response = Console.ReadLine(); // Read user input

// Print the response
Console.WriteLine($"Enjoy the course, {response}");

// Get operating system info
OperatingSystem thisOs = Environment.OSVersion;
Console.WriteLine($"Platform: {thisOs.Platform}");
Console.WriteLine($"Version: {thisOs.VersionString}");
