namespace Programming_Challenges.Commands.Core;

public class MissingCommandDefinitionException : Exception
{
    public MissingCommandDefinitionException() : base() {}
    public MissingCommandDefinitionException(string message) : base($"{message} has no definitions (Name Or Aliases) please define command definition by adding a command definition attribute to the class.") { }
}