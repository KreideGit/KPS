using DemoInterfaceProvider;

namespace DemoPlugin
{
    public class HelloCommand : ICommand
    {
        public string Name { get; }

        public HelloCommand()
        {
            Name = "HelloCommand";
        }
    }
}