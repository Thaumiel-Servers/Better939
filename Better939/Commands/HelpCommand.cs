using CommandSystem;
using System;

namespace BetterDoggie.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class HelpCommand : ICommand
    {
        public string Command { get; } = "939help";
        public string[] Aliases { get; } = Array.Empty<string>();
        public string Description { get; } = "Shows help for the Better 939 plugin";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "Upgraded SCP-939s have a boost ability that temporarily grants the ability to break down doors." +
            "To use this ability, you must set a keybind in your console (~ key) with the format: \"cmdbind <keycode> .939boost\"." +
            "For example: \"cmdbind f .939boost\" will bind your F key to the .939boost command.";
            return true;

        }
    }
}
