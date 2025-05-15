namespace FizzBuzz;

class Program
{
    static void Main(string[] args)
    {
        int maximumIterations = 100;
        for (int i = 0; i <= maximumIterations; i++)
        {
            string message = string.Empty;
            if(i % 3 == 0) message += "Fizz";
            if(i % 5 == 0) message += "Buzz";
            
            Console.WriteLine(string.IsNullOrEmpty(message) ? $"{i}" : $"{i} - {message}");
        }
    }
}
