using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
public abstract class Course
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }
    protected Course(string title, string description, string author, decimal price)
    {
        Title = title;
        Description = description;
        Author = author;
        Price = price;
    }
    public virtual void DisplayCourseInfo()
    {
        Console.WriteLine($"Курс: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Описание: {Description}");
        Console.WriteLine($"Цена: {Price} руб.");
    }
    public abstract void StartLearning();
    public abstract string GetCourseType();
    public virtual decimal CalculateDiscount(int percent)
    {
        return Price * (100 - percent) / 100;
    }
}
public class VideoCourse : Course
{
    public int VideoCount { get; set; }
    public TimeSpan TotalDuration { get; set; }

    public VideoCourse(string title, string description, string author, decimal price,
                      int videoCount, TimeSpan totalDuration)
                      : base(title, description, author, price)
    {
        VideoCount = videoCount;
        TotalDuration = totalDuration;
    }

    public override void StartLearning()
    {
        Console.WriteLine($"Начинаем видеокурс '{Title}'");
        Console.WriteLine($"Количество видео: {VideoCount}");
        Console.WriteLine($"Общая продолжительность: {TotalDuration.TotalHours:0.0} часов");
        Console.WriteLine("Запуск видеоплеера...");
    }

    public override string GetCourseType()
    {
        return "Видеокурс";
    }

    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo();
        Console.WriteLine($"Тип: {GetCourseType()}");
        Console.WriteLine($"Количество видео: {VideoCount}");
        Console.WriteLine($"Общая продолжительность: {TotalDuration:hh\\:mm\\:ss}");
    }
}
public class TextCourse : Course
{
    public int ChapterCount { get; set; }
    public int TotalTextVolume { get; set; }

    public TextCourse(string title, string description, string author, decimal price,
                     int chapterCount, int totalTextVolume)
                     : base(title, description, author, price)
    {
        ChapterCount = chapterCount;
        TotalTextVolume = totalTextVolume;
    }
    public override void StartLearning()
    {
        Console.WriteLine($"Начинаем текстовый курс '{Title}'");
        Console.WriteLine($"Количество глав: {ChapterCount}");
        Console.WriteLine($"Объем текста: {TotalTextVolume} символов");
        Console.WriteLine("Открытие текстового читателя...");
    }
    public override string GetCourseType()
    {
        return "Текстовый курс";
    }
    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo();
        Console.WriteLine($"Тип: {GetCourseType()}");
        Console.WriteLine($"Количество глав: {ChapterCount}");
        Console.WriteLine($"Объем текста: {TotalTextVolume} символов");
    }
}
public class InteractiveCourse : Course
{
    public int ExerciseCount { get; set; }
    public string CheckingSystem { get; set; }
    public InteractiveCourse(string title, string description, string author, decimal price,
                           int exerciseCount, string checkingSystem)
                           : base(title, description, author, price)
    {
        ExerciseCount = exerciseCount;
        CheckingSystem = checkingSystem;
    }
    public override void StartLearning()
    {
        Console.WriteLine($"Начинаем интерактивный курс '{Title}'");
        Console.WriteLine($"Количество упражнений: {ExerciseCount}");
        Console.WriteLine($"Система проверки: {CheckingSystem}");
        Console.WriteLine("Запуск интерактивной среды");
    }
    public override string GetCourseType()
    {
        return "Интерактивный курс";
    }
    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo();
        Console.WriteLine($"Тип: {GetCourseType()}");
        Console.WriteLine($"Количество упражнений: {ExerciseCount}");
        Console.WriteLine($"Система проверки: {CheckingSystem}");
    }
}
public interface IVideoService
{
    void PlayVideo();
    void AdjustPlaybackSpeed(double speed);
    void DownloadVideo();
}
public interface ITextService
{
    void SearchText(string keyword);
    void ChangeFontSize(int size);
    void BookmarkPage(int page);
}
public interface IInteractiveService
{
    void SubmitExercise(string exerciseId, string solution);
    void GetHint(string exerciseId);
    void CheckProgress();
}
class Program
{
    static void Main()
    {
        var videoCourse = new VideoCourse("C# для начинающих", "Основы программирования на C#",
                                         "Иван Петров", 2999, 45, TimeSpan.FromHours(12));

        var textCourse = new TextCourse("Алгоритмы и структуры данных", "Теория алгоритмов",
                                       "Анна Сидорова", 1999, 15, 150000);

        var interactiveCourse = new InteractiveCourse("Практика C#", "Практические задания по C#",
                                                     "Петр Иванов", 3999, 30, "AutoCodeChecker");
        Console.WriteLine("Информация о курсах:);
        videoCourse.DisplayCourseInfo();
        Console.WriteLine();

        textCourse.DisplayCourseInfo();
        Console.WriteLine();

        interactiveCourse.DisplayCourseInfo();
        Console.WriteLine();

        Console.WriteLine("Процесс обучения:");
        videoCourse.StartLearning();
        Console.WriteLine();

        textCourse.StartLearning();
        Console.WriteLine();

        interactiveCourse.StartLearning();
    }
}