namespace Zork_Common
{
    public struct CommandContext
    {
        public string CommandString { get; }

        public Command Command { get; }

        public CommandContext(string commandString, Command command)
        {
            CommandString = commandString;
            Command = command;
        }
    }
}



