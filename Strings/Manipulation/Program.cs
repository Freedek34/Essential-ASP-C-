using System;

class Program
{
    static void Main()
    {
        // Example file for manipulating string content

        string str1 = "The quick brown fox jumps over the lazy dog.";
        string str2 = "This is a string";
        string str3 = "THIS is a STRING";
        string[] strs = { "one", "two", "three", "four" };

        // TODO: Length of a string 
        Console.WriteLine(str1.Length);

        // TODO: Access individual characters
        Console.WriteLine(str1[14]);

        // TODO: Iterate over a string like any other sequence of values
        foreach (char ch in str1)
        {
            Console.Write(ch);
            if (ch == 'b')
            {
                Console.WriteLine();
                break;
            }
        }

        // TODO: String Concatenation         
        string outstr;
        outstr = String.Concat(strs);
        Console.WriteLine(outstr);

        // TODO: Joining strings together with Join
        outstr = String.Join(", ", strs); // Added space after commas for better readability
        Console.WriteLine(outstr);

        outstr = String.Join("----", strs);
        Console.WriteLine(outstr);

        // TODO: String Comparison

        // Equals just returns a regular Boolean
        bool isEqual = str2.Equals(str3);
        Console.WriteLine($"Are str2 and str3 equal? {isEqual}");

        // Compare will perform an ordinal comparison and return:
        // < 0 : first string comes before second in sort order
        // 0 : first and second strings are in the same position in sort order
        // > 0 : first string comes after the second in sort order
        int comparisonResult = String.Compare(str2, str3);
        Console.WriteLine($"Comparison result: {comparisonResult}");

        // TODO: Replacing content
        string replacedString = str1.Replace("brown", "red");
        Console.WriteLine(replacedString);
    }
}
