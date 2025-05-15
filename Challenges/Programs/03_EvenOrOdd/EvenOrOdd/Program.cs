namespace EvenOrOdd;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Please enter a number (or type 'exit' to quit): ");

            var input = Console.ReadLine() ?? string.Empty;

            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase) || input.Equals("quit", StringComparison.OrdinalIgnoreCase))
                break;

            if (int.TryParse(input, out var number))
            {
                var message = (number % 2 == 0 ? "Even" : "Odd");
                PrintMessage($"{number} is {message}", ConsoleColor.Green);
            }
            else
            {
                PrintMessage($"\"{input}\" is not a valid number", ConsoleColor.Red);
            }
        }
    }

    static void PrintMessage(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}

