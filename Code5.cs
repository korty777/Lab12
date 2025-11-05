using System;

public class Settings
{
    private static readonly string configFilePath;

    static Settings()
    {
        configFilePath = "C:\\ProgramData\\MyApp\\config.txt";
    }

    public static void PrintConfigPath()
    {
        Console.WriteLine($"Путь к файлу конфигурации: {configFilePath}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Settings.PrintConfigPath();
        Console.ReadLine();
    }
}
