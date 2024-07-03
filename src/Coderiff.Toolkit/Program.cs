// See https://aka.ms/new-console-template for more information

using System.Reflection;

if (args.Length == 0)
{
    var versionString = Assembly.GetEntryAssembly()?
        .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
        .InformationalVersion;

    Console.WriteLine($"coderiff v{versionString}");
    Console.WriteLine("-------------");
    Console.WriteLine("\nUsage:");
    Console.WriteLine("  coderiff <command>");
    return;
}

Console.WriteLine(string.Join(' ', args));
Console.WriteLine("TODO");