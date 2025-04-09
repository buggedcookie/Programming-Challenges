using Programming_Challenges.Commands.Core;

namespace Programming_Challenges.Commands;


[CommandDefinition("HelloWorld", "Hello")]
[CommandInfo("Says \"Hello World !\"", "HelloWorld")]
public class HelloWorldCommand : Command
{
    public override void OnExecuted(string label, string[] commandArguments)
    {
        Console.WriteLine("Hello World!");
    }
}