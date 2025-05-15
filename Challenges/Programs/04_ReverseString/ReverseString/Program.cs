namespace ReverseString;

class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.Write("Enter a text to reverse it (or write \"--exit\" to exit) : ");
            
            string input = Console.ReadLine() ?? string.Empty;
            if (input == "--exit") break;
            
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine($">>> Reversed String : {GetReversedString(input)} (string.Reverse())");
            Console.WriteLine($">>> Reversed String : {GetReversedStringButManually(input)} (Custom, using for loop)");
            
            Console.ResetColor();
        }
    }
    
    static string GetReversedString(string input)
    {
        return string.Join("", input.Reverse());
    }

    static string GetReversedStringButManually(string input)
    {
        char[] charArray = input.ToCharArray();
        char[] charArrayReverse = new char[charArray.Length];
        
        for (int i = 0; i < charArray.Length; i++)
        {
            charArrayReverse[i] = charArray[charArray.Length-1 - i];
        }
        
        return string.Join("", charArrayReverse);
    }
}