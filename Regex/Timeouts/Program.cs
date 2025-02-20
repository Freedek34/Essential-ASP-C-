using System;
using System.Text.RegularExpressions;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        const int MAX_REGEX_TIME = 15000; // Timeout value in milliseconds
        const string thestr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab";

        // Use a Stopwatch to show elapsed time
        Stopwatch sw;

        // Use a Timeout value when executing RegEx to guard against bad input
        TimeSpan Timeout = TimeSpan.FromMilliseconds(MAX_REGEX_TIME);

        // Run the expression and output the result
        try
        {
            sw = Stopwatch.StartNew();
            Regex CapWords = new Regex(@"(a+a+)+b", RegexOptions.None, Timeout);
            MatchCollection mc = CapWords.Matches(thestr);
            sw.Stop();

            Console.WriteLine($"Found {mc.Count} matches in {sw.ElapsedMilliseconds} ms:");

            foreach (Match match in mc)
            {
                Console.WriteLine($"'{match.Value}' found at position {match.Index}");
            }
        }
        catch (RegexMatchTimeoutException e)
        {
            Console.WriteLine($"The Regex took too long to execute! Timeout was set to {e.MatchTimeout.TotalMilliseconds} ms.");
        }
    }
}
