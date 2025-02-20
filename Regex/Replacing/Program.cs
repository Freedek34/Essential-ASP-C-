using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string teststr1 = "The quick brown Fox jumps over the lazy Dog";
        Regex CapWords = new Regex(@"\b[A-Z][a-z]*\b"); // Match words starting with uppercase letters

        // Replace matched words with "***"
        string result = CapWords.Replace(teststr1, "***");

        Console.WriteLine("Original String: " + teststr1);
        Console.WriteLine("After Replacement: " + result);

        // Replacement function using MatchEvaluator
        string MakeUpper(Match m)
        {
            string s = m.Value;
            return (m.Index == 0) ? s : s.ToUpper();
        }

        string upperstr = CapWords.Replace(teststr1, new MatchEvaluator(MakeUpper));

        Console.WriteLine("Original String: " + teststr1);
        Console.WriteLine("Modified String: " + upperstr);
    }
}
