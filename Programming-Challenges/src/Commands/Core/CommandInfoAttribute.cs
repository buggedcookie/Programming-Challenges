namespace Programming_Challenges.Commands.Core;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class CommandInfoAttribute : Attribute
{
    public readonly string Description, Usage;

    public CommandInfoAttribute(string description, string usage)
    {
        Description = description;
        Usage = usage;
    }
}