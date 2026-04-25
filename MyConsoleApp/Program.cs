Console.WriteLine("Hello from MyConsoleApp!");
Console.WriteLine($"Running on .NET {Environment.Version} ({Environment.OSVersion}).");
Console.WriteLine($"Текущее время: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");

string? name = args.Length > 0 ? string.Join(' ', args) : null;
if (string.IsNullOrWhiteSpace(name))
{
    Console.Write("Как вас зовут? ");
    name = Console.ReadLine();
}

if (string.IsNullOrWhiteSpace(name))
{
    name = "незнакомец";
}

Console.WriteLine($"Привет, {name}! Всё работает.");
