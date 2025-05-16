namespace LeapYearChecker;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Write("Please enter a year (or write \"--exit\" to exit): ");
            
            var input = Console.ReadLine() ?? string.Empty;
            

            if (input == "--exit") break;
            if (input == "--clear")
            {
                Console.Clear();
                continue;
            }
            if (input == "--test")
            {
                for (int i = 1; i <= 9999; i++)
                {
                    WriteLeapYear(i);
                }
            }

            if (int.TryParse(input, out var year) && year > 0 && year <= 9999)
            { 
                WriteLeapYear(year);
            }
            else
            {
                Console.WriteLine("Please enter a valid year.");
            }
        }
    }

    static void WriteLeapYear(int year)
    {
        bool isLeapYearDateTime = DateTime.IsLeapYear(year);
        bool isLeapYear = IsLeapYear(year);
        bool match = isLeapYearDateTime == isLeapYear;
        
        
        Console.ForegroundColor = match ? ConsoleColor.Green : ConsoleColor.Red;
        
        Console.WriteLine($"{year} is {(isLeapYear ? "a": "not")} a leap year. (Using Custom Method)");
        Console.WriteLine($"{year} is {(isLeapYearDateTime ? "a": "not")} a leap year. (Using DateTime)");
        
        if (!match) Console.WriteLine("Something went wrong, different results from both methods."); // This shouldn't happen -> Just comparing my code to some other codes
        Console.ResetColor();
    }
    static bool IsLeapYear(int year)
    {
        bool byFour = year % 4 == 0;
        bool byHundred = year % 100 == 0;
        bool byFourHundred = year % 400 == 0;
        
        // Leap year = Divisible by 4 AND (not divisible by 100 OR divisible by 400)
        return byFour && (!byHundred || byFourHundred);
    }
}