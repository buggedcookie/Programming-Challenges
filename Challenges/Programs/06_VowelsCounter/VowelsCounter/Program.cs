namespace VowelsCounter;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Write a sentence to count vowels (or write \"--exit\" to exit) : ");
            string input = Console.ReadLine() ?? string.Empty;
            
            if (input == "--quit" || input == "--exit") break;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vowels: ");
            foreach (var vowel in GetVowelsCount(input))
            {
                Console.Write($"{vowel.Key} : {vowel.Value} \n");
            }
            Console.ResetColor();
        }
    }
    
    static Dictionary<char, int> GetVowelsCount(string input)
    {

        input = input.ToLower();
        
        char[] vowels = ['a', 'e', 'i', 'o', 'u']; // Not doing 'y'
        
        Dictionary<char, int> vowelCount = new Dictionary<char, int>()
        {
            { 'a', 0 },
            { 'e', 0 },
            { 'i', 0 },
            { 'o', 0 },
            { 'u', 0 },
        };

        foreach (char character in input)
        {
            if (vowels.Contains(character))
            {
                vowelCount[character]++;
            }
        }
        return vowelCount;
    }
    
    
}