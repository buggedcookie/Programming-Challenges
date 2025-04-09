using System.Reflection;
using Programming_Challenges.Commands.Core;

namespace Programming_Challenges;

class Program
{
    static void Main(string[] args)
    {
        CommandRegistry commandRegistry = new();
        Assembly assembly = Assembly.GetExecutingAssembly();
        
        commandRegistry.RegisterAllCommandsInAssembly(assembly);

        CommandProcessor commandProcessor = new CommandProcessor(commandRegistry);
        
        Console.WriteLine(">>> Write \"exit\" to exit.");
        do
        {
            Console.Write(" User > ");
            string input = Console.ReadLine();
            if(input == "exit") break;

            if (string.IsNullOrEmpty(input)) continue;
            
            commandProcessor.ProcessCommand(input);
        } while (true);
    }
}
/*
 * === Notes for Myself ===
 * A Command System?
 * --- CommandInfo class -> Contains : CommandName, CommandAliases, CommandDescription, CommandUsage, CommandVersion
 * --- CommandRegistry class -> Is like a "database" it contains are the "searching" stuff to find a command and execute it
 * --- CommandProcessor -> Process the string into a command, it uses the CommandRegistry to find a command
 * --- CommandActivator -> Since I might use Reflection to activate Commands and list them... I may need an Activator that setup each commands etc...
 * --- CommandBase or ICommand -> I don't know if I'll use an abstract class or an interface yet maybe... both? (Would that make sense?)
 * --- CommandDefinitionAttribute -> Defines the Name and Aliases of a Command : [CommandDefinition("Name", "Alias1", "Alias2", "Alias3...")]
 * --- CommandInfoAttribute -> Defines additional information about the Command like Description, Version, Usage etc...
 * --- CommandLocator -> Finds all the command within the assembly
 */