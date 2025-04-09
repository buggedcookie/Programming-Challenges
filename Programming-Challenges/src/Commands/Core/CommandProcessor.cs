namespace Programming_Challenges.Commands.Core;

public class CommandProcessor
{
    CommandRegistry commandRegistry;


    public CommandProcessor(CommandRegistry commandRegistry)
    {
        this.commandRegistry = commandRegistry;
    }

    public void ProcessCommand(string input)
    {
        var args = input.Split(' ');

        Command command = commandRegistry.GetCommandByNameOrAlias(args[0]);

        if (command != null)
        {
            command.OnExecuted(args[0], args.Skip(1).ToArray());
        }
        else
        {
            Console.WriteLine("\n >>> Invalid command! \n");
        }
    }
}