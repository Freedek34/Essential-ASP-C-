using System;

class DaysCalculator
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a date (yyyy-MM-dd) or type 'exit' to quit: ");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "exit")
                break;

            if (DateTime.TryParse(input, out DateTime enteredDate))
            {
                DateTime currentDate = DateTime.Today;
                int daysDifference = (enteredDate - currentDate).Days;

                if (daysDifference > 0)
                {
                    Console.WriteLine($"{daysDifference} days remain until {enteredDate:yyyy-MM-dd}.");
                }
                else if (daysDifference < 0)
                {
                    Console.WriteLine($"{Math.Abs(daysDifference)} days have passed since {enteredDate:yyyy-MM-dd}.");
                }
                else
                {
                    Console.WriteLine("The entered date is today!");
                }
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter a valid date in yyyy-MM-dd format.");
            }
        }
    }
}
