using Programming_Challenges.Commands.Core;

namespace Programming_Challenges.Commands;


[CommandDefinition("echo")]
[CommandInfo("Echo back what you say", "echo <message>")]
public class EchoCommand : Command
{
    public override void OnExecuted(string label, string[] commandArguments)
    {
        string message = String.Join(' ', commandArguments);
        Console.WriteLine($"\n {message} \n");
    }
}