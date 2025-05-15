namespace Echo;

class Program
{
    static void Main(string[] args)
    {
        string input;
        do
        {
            Console.Write(">>> User Input: ");
            input = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(">>> Echo : " + input);
            
        } while (input != "--quit");
    }
}