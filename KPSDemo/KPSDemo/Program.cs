using System;
using System.IO;
using DemoInterfaceProvider;
using KPSLibrary;

namespace KPSDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pluginPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + @"\DemoPlugin\bin\debug\netstandard2.0\DemoPlugin.dll";
            var commands = KPSLoader.LoadPlugin<ICommand>(pluginPath);
            foreach (var c in commands)
            {
                Console.WriteLine(c.Name);
            }
        }
    }
}