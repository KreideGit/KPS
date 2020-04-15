using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace KPSLibrary
{
    public static class KPSLoader
    {
        public static IEnumerable<T> LoadPlugin<T>(string path) where T : class
        {
            var assembly = Assembly.LoadFile(path);
            var type = typeof(T);
            IEnumerable<Type> derivedTypes = assembly.GetTypes().Where(t => t.GetInterface(type.FullName) == type);
            return derivedTypes.Select(t =>
            {
                try
                {
                    return Activator.CreateInstance(t) as T;
                }
                catch
                {
                    Console.WriteLine($"Warning: Failed to instantiate type { t.FullName }");
                    return null;
                }
            }).Where(t => t != null);
        }
    }
}