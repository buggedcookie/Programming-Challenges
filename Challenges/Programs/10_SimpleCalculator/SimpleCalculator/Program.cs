namespace SimpleCalculator;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write(">>> Write a simple operation (Or write \"--exit\" to exit): ");
            string input = Console.ReadLine() ?? string.Empty;
            
            if(input == "--exit") break;
            if (input == "--clear")
            {
                Console.Clear();
                continue;
            }

            try
            {
               var answer = Calculator.Solve(input);
               
               Console.ForegroundColor = ConsoleColor.Green;
               if(answer != null) 
                   Console.WriteLine($"{input} = {Calculator.Solve(input)}");
               else
                   Console.WriteLine("Error, make sure there's space between numbers and operators.");
               Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e);
                Console.ResetColor();
            }
        }
    }
    
    
    
}