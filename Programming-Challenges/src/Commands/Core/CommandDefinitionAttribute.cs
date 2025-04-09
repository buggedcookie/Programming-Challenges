namespace Programming_Challenges.Commands.Core;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class CommandDefinitionAttribute : Attribute
{
    public readonly List<string> Aliases = new List<string>();

    public CommandDefinitionAttribute(params string[] aliases)
    {
        Aliases.AddRange(aliases);
    }
}