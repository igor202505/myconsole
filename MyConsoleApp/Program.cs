Console.WriteLine("Hello from MyConsoleApp!");
Console.WriteLine($"Running on .NET {Environment.Version} ({Environment.OSVersion}).");
Console.Write("Как вас зовут? ");
string? name = Console.ReadLine();
if (string.IsNullOrWhiteSpace(name))
{
    name = "незнакомец";
}
Console.WriteLine($"Привет, {name}! Всё работает.");
