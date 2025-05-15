namespace PalindromeChecker;

class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.Write("Enter a text to check if it is a Palindrome (or write \"--exit\" to exit) : ");
            
            string input = Console.ReadLine() ?? string.Empty;
            if (input == "--exit") break;
            bool isPalindrome = IsPalindrome(input);
            
            
            Console.ForegroundColor = (isPalindrome ? ConsoleColor.Green : ConsoleColor.Red);
            
            Console.WriteLine($">>> {input} " + (isPalindrome ? "is" : "is not") + " a palindrome. (String.Reverse)");
            Console.WriteLine($">>> {input} " + (IsPalindromeButManually(input) ? "is" : "is not") + " a palindrome. (Manually)");
            
            Console.WriteLine($">>> {input} == {GetPalindrome(input)}");
            
            Console.ResetColor();
        }
    }

    static string GetPalindrome(string input)
    {
        return string.Join("", input.Reverse());
    }
    
    static bool IsPalindrome(string input)
    {
        string reversedInput = string.Join("", input.Reverse());
        return input == reversedInput;
    }

    static bool IsPalindromeButManually(string input)
    {
        char[] charArray = input.ToCharArray();
        char[] charArrayReverse = new char[charArray.Length];
        
        for (int i = 0; i < charArray.Length; i++)
        {
            charArrayReverse[i] = charArray[charArray.Length-1 - i];
        }
        
        return input == string.Join("", charArrayReverse);
    }
}