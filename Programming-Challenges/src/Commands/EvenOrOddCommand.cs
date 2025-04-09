using Programming_Challenges.Commands.Core;

namespace Programming_Challenges.Commands;


[CommandDefinition("EvenOrOdd", "EOO")]
[CommandInfo("Is a number even or odd\"", "EvenOrOdd <number>")]
public class EvenOroDdCommand : Command
{
    public override void OnExecuted(string label, string[] commandArguments)
    {
        try
        {
            int number = int.Parse(commandArguments[0]);
            
            if (number % 2 == 0)
            {
                Console.WriteLine($"\n >>> {number} is even. \n");
            }
            else
            {
                Console.WriteLine($"\n >>> {number} is odd. \n");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
    }
}