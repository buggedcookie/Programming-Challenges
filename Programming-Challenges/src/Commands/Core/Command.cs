namespace Programming_Challenges.Commands.Core;

public abstract class Command
{
    public required CommandInfo CommandInfo { get; init; }
    public abstract void OnExecuted(string label, string[] commandArguments);
}