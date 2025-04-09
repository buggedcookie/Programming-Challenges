using System.Reflection;

namespace Programming_Challenges.Commands.Core;

public class CommandRegistry
{
    public Dictionary<CommandInfo, Command> commandRegistry { get; private set; } =
        new Dictionary<CommandInfo, Command>();

    public void RegisterCommand<T>() where T : Command, new()
    {
        Type commandType = typeof(T);

        if (TryGetCommandInfoFromAttributes(commandType, out var info))
        {
            var command = new T()
            {
                CommandInfo = info
            };

            commandRegistry.Add(info, command);
        }
    }


    public void RegisterCommandByType(Type commandType)
    {
        if (TryGetCommandInfoFromAttributes(commandType, out var info))
        {
            Command command = (Command)Activator.CreateInstance(commandType);

            var commandInfoProperty = commandType.GetProperty(nameof(Command.CommandInfo));

            if (commandInfoProperty != null && commandInfoProperty.CanWrite)
            {
                commandInfoProperty.SetValue(command, info);
            }
            
            commandRegistry.Add(info, command);
        }
    }

    public IEnumerable<Type> FindCommandTypesInAssembly(Assembly assembly)
    {
        var types = assembly.GetTypes();
        foreach (var type in types)
        {
            if (type.IsSubclassOf(typeof(Command)))
            {
                yield return type;
            }
        }
    }

    public void RegisterAllCommandsInAssembly(Assembly assembly)
    {
        foreach (var commandType in FindCommandTypesInAssembly(assembly))
        {
            RegisterCommandByType(commandType);
        }
    }

    private bool TryGetCommandInfoFromAttributes(Type commandType, out CommandInfo? info)
    {
        info = null;
        if (commandType is { IsClass: false, IsAbstract: true, IsInterface: true }) return false;

        var definitionAttribute = commandType.GetCustomAttribute(typeof(CommandDefinitionAttribute), true)as CommandDefinitionAttribute;
        var infoAttribute = commandType.GetCustomAttribute(typeof(CommandInfoAttribute), true) as CommandInfoAttribute;

        if (definitionAttribute is null) throw new MissingCommandDefinitionException(nameof(commandType));

        info = new CommandInfo(
            definitionAttribute.Aliases?.FirstOrDefault() ?? commandType.Name,
            definitionAttribute.Aliases ?? new List<string>(),
            infoAttribute?.Description ?? "",
            infoAttribute?.Usage ?? ""
        );

        return true;
    }

    public Command? GetCommandByNameOrAlias(string commandName)
    {
        var command = commandRegistry.FirstOrDefault(kv =>
            kv.Value.CommandInfo.Name == commandName ||
            kv.Value.CommandInfo.Aliases.Contains(commandName));

        return command.Value;
    }
}