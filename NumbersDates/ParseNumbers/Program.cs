// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for parsing numerical data from strings

string[] NumStrs = {"  1 ", " 1.45  ", "-100", "5e+04 "};

int testint;
float testfloat;
bool result;

// TODO: The Parse method attempts to parse a string to a number and
// throws an exception if the parse is unsuccessful
foreach (string str in NumStrs) {
    try {
        testfloat = float.Parse(str);
        Console.WriteLine($"Parsed number is {testfloat}");
        testint = int.Parse(str);
        Console.WriteLine($"Parsed number is {testint}");
    } catch (FormatException) {
        Console.WriteLine($"Could not Parse {str} : {e.Message}");
    }

}

// TODO: The TryParse method returns 'true' if the parse is successful
result = int.TryParse("  1 ", out testint);

