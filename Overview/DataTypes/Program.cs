// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for .NET Data Types

// Declare some types with values
int a = 1;
char c = 'A';
float f = 123.45f;
decimal d = 400.85m;
int b = default;
bool tf = default;

Console.WriteLine($"{a}, {b}, {tf}, {c}, {f}, {d}");

// TODO: implicit type conversion
Console.WriteLine($"{c + a}");  // Output will be an integer (ASCII value of 'A' + 1)
Console.WriteLine($"{(char)(c + a)}"); // Proper type casting to char

// TODO: Create an instance of a struct (which is a value type)
s s1 = new s(); // Proper struct initialization
s1.a = 65; // Using the ASCII value for 'S'
s1.b = false; // Assuming 'b' is a boolean

// Corrected expressions inside interpolated strings:
Console.WriteLine($"c + a = {c + a}"); // Adds the ASCII value of 'A' and the integer 1
Console.WriteLine($"f + c = {f + c}"); // Adds a float and a char (char will be cast to int)
Console.WriteLine($"f + a = {f + a}"); // Adds a float and an integer

// Perform an operation on a struct (passing by reference to modify it)
void StructOp(ref s theStruct) {  // Use 'ref' to modify the original struct
    // Modify the struct properties inside the function
    theStruct.a = 10;
    theStruct.b = true;
    Console.WriteLine($"{theStruct.a}, {theStruct.b}");
}

Console.WriteLine("Structs are passed by copy, since they are value types:");
Console.WriteLine($"{s1.a}, {s1.b}");
StructOp(ref s1);  // Pass by reference
Console.WriteLine($"{s1.a}, {s1.b}");  // The changes will reflect here

// TODO: Create an object instance of a class (which is a reference type)
MyClass cl = new MyClass();  // Create an instance of the class

// Perform an operation on the class
void ClassOp(MyClass theClass) {
    // Modify some of the properties of the class inside the function
    theClass.a = 10;
    theClass.b = true;
    Console.WriteLine($"{theClass.a}, {theClass.b}");
}

Console.WriteLine("Objects are passed by reference, since they are reference types:");
Console.WriteLine($"{cl.a}, {cl.b}");
ClassOp(cl);
Console.WriteLine($"{cl.a}, {cl.b}");

// These are declared at the bottom of the file because C# requires
// top-level statements to come before type declarations
class MyClass {
    public int a;
    public bool b;
}

struct s {
    public int a;
    public bool b;
}
