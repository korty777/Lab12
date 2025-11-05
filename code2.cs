using System;

namespace ConsoleApp7
{
    class ProgramConfig
    {
        public const string ProgramName = "C#";
        public const string Developer = "Иван Иванов";
        public const string Version = "1.1.1";
        public static void ShowInfo()
        {
            Console.WriteLine($"Название программы: {ProgramName}");
            Console.WriteLine($"Версия: {Version}");
            Console.WriteLine($"Разработчик: {Developer}");
        }
    }
    class code2
    {
        static void Main()
        {
            ProgramConfig.ShowInfo();
        }
    }
}