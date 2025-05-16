namespace StringModification;

class Program
{
    private static string _var = "Hello World!";
    static void Main(string[] args)
    {
        /* ToDo:
         * (Using Built-In)
         * Length : Done
         * Indexing : Done
         * Contains, : Done
         * StartsWith : Done
         * EndsWith : Done
         * Replace : Done
         * Reverse : Done
         * Interpolation : Done
         * Character Frequency : Done
         * Escape Characters : Done
         * Split, Join : Done
         */
        
        ShowHelp();
        while (true)
        {
            Console.Write(" (write \"!exit\" to exit or \"!help\" to get help) >>> ");
            string input = Console.ReadLine() ?? string.Empty;
            if (input == "!exit") break;
            
            GetCommand(input);
        }
        
        
        
        Console.WriteLine("Good bye!");
    }

    public static void GetCommand(string input)
    {
        var args = input.Split(' ');
        switch (args[0])
        {
            case "!get" : ShowMessage($"The variable is set to : {_var}"); 
                break;
            case "!define":
                _var = input.Replace(args[0], "");
                break;
            case "!getLength":
                ShowMessage($">>> {_var} is {_var.Length} characters.");
                break;
            case "!getIndex": ShowMessage($">>> Index Of : {args[1]} : {_var.IndexOf(char.Parse(args[1]))} "); // Ain't handling errors here, nope.
                break;
            case "!contains": ShowMessage($">>> {_var} does {(_var.Contains(args[1]) ? "" : "not")} contain {args[1]} ");
                break;
            case "!startsWith": ShowMessage($">>> {_var} does {(_var.StartsWith(args[1]) ? "" : "not")} start with {args[1]}");
                break;
            case "!endsWith": ShowMessage($">>> {_var} does {(_var.EndsWith(args[1]) ? "" : "not")} start with {args[1]}");
                break;
            case "!reverse": ShowMessage($">>> Reversed version of {_var} is : {string.Join("", _var.Reverse())}");
                break;
            case "!charFrequency":
                GetCharacterFrequency(_var);
                break;
            case "!clear": Console.Clear();
                break;
            case "!help": ShowHelp();
                break;
            default: ShowHelp();
                break;
        }
    }
    
    static Dictionary<char, int> GetCharacterFrequency(string input)
    {
        Dictionary<char, int> frequency = new Dictionary<char, int>();

        foreach (var c in input)
        {
            if (frequency.ContainsKey(c))
            {
                frequency[c]++;
            }
            else
            {
                frequency.Add(c, 1);
            }
        }

        foreach (var c in frequency)
        {
            ShowMessage($"\t {c.Key}: {c.Value} chars \t");
        }
        return frequency;
    }
    
    static void ShowMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    
    public static void ShowHelp()
    {
        ShowMessage(
            """
                !define <text>         → Define a string to work with.
                !getLength             → Show how many characters are in the current string.
                !getIndex <char>       → Get the position of the first occurrence of a character.
                !contains <text>       → Check if the string contains the given text.
                !startsWith <text>     → See if the string starts with the given text.
                !endsWith <text>       → See if the string ends with the given text.
                !reverse               → Show the string in reverse order.
                !charFrequency         → Count how often each character appears in the string.
                !clear                 → Clear the console.
                !exit                  → Exit the program.
                !help                  → Show this list of commands.
            """);
    }
    
}