using Programming_Challenges.Commands.Core;

namespace Programming_Challenges.Commands;

[CommandDefinition("factorial", "fac", "!")]
[CommandInfo("Is a number even or odd\"", "Factorial <number> <full:true/false>")]
public class FactorialCommand : Command
{
    public override void OnExecuted(string label, string[] commandArguments)
    {
        try
        {
            int number = int.Parse(commandArguments[0]);

            if (commandArguments.Length > 1 && bool.Parse(commandArguments[1]))
            {
                Console.WriteLine(FactorialFull(number));
            }
            else
            {
                Console.WriteLine(Factorial(number));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public int Factorial(int n)
    {
        if (n < 0) Console.WriteLine("\n >>> Number must be a non-negative integer. \n");

        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }

    public string FactorialFull(int n)
    {
        if (n < 0) Console.WriteLine("\n >>> Number must be a non-negative integer. \n");

        string message = $"!{n} = ";
        int result = Factorial(n);
        for (int i = n; i >= 0; i--)
        {
            if(i != n && i != 0) message += " + ";
            if (i != 0)
                message += i.ToString();
            else message += $" = {result}";
        }

        return message;
    }
}