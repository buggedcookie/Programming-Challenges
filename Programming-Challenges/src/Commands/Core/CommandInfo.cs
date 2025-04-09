namespace Programming_Challenges.Commands.Core;

public record CommandInfo (string Name, List<string> Aliases, string Description, string Usage);