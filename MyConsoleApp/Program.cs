if (args.Length > 0 && (args[0] == "--help" || args[0] == "-h"))
{
    Console.WriteLine("MyConsoleApp — простое консольное приложение.");
    Console.WriteLine();
    Console.WriteLine("Использование:");
    Console.WriteLine("  dotnet run --project MyConsoleApp                    — интерактивный режим");
    Console.WriteLine("  dotnet run --project MyConsoleApp -- <имя>           — вывести приветствие для <имя>");
    Console.WriteLine("  dotnet run --project MyConsoleApp -- --help | -h     — показать эту справку");
    return;
}

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

string timeGreeting = DateTime.Now.Hour switch
{
    >= 5 and < 12 => "Доброе утро",
    >= 12 and < 18 => "Добрый день",
    >= 18 and < 23 => "Добрый вечер",
    _ => "Доброй ночи"
};

Console.WriteLine($"{timeGreeting}, {name}! Всё работает.");
