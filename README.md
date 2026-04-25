# myconsole

Простое консольное приложение на C# (.NET 8) — учебный проект для отработки воркфлоу
с git и Devin.

## Требования

- [.NET SDK 8.0+](https://dotnet.microsoft.com/download/dotnet/8.0)

## Запуск

Интерактивный режим (программа спросит имя):

```powershell
dotnet run --project MyConsoleApp
```

С именем через аргумент командной строки:

```powershell
dotnet run --project MyConsoleApp -- Игорь
```

## Структура

```
myconsole/
├── README.md
└── MyConsoleApp/
    ├── MyConsoleApp.csproj
    └── Program.cs
```
