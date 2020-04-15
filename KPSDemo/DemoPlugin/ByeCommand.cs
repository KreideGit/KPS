using DemoInterfaceProvider;

namespace DemoPlugin
{
    public class ByeCommand : ICommand
    {
        public string Name { get; }

        public ByeCommand()
        {
            Name = "ByeCommand";
        }
    }
}