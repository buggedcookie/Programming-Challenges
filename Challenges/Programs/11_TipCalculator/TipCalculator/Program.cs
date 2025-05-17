namespace TipCalculator;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Random random = new Random();
            int price = random.Next(1, 100);
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("You paid : " + price + "$");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter tip percentage: ");
            Console.ResetColor();
            
            var input = Console.ReadLine() ?? string.Empty;
            if(input == "--exit") break;
            input = input.Replace("%", "");

            if (float.TryParse(input, out var tipPercentageAmount))
            {
                // ---% of --- ( 25 / 100 * price)
                var tipAmount = tipPercentageAmount / 100 * price;
                
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"You paid {price}$ with a tip of {MathF.Round(tipAmount, 3)}$ ({tipPercentageAmount}%)");
                Console.ResetColor();
            }
            
        }
    }
}