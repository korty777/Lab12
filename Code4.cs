using System;

public class Book
{
    private readonly string isbn;
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string isbn, string title, string author)
    {
        this.isbn = isbn;
        Title = title;
        Author = author;
    }

    public void PrintBookInfo()
    {
        Console.WriteLine($"ISBN: {isbn}");
        Console.WriteLine($"Название: {Title}");
        Console.WriteLine($"Автор: {Author}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("978-5-4461-1234-5", "C# для чайников", "Петров П.П.");
        book1.PrintBookInfo();
        Console.WriteLine();

        Book book2 = new Book("978-5-1234-5678-9", "Основы программирования Java", "Сидоров А.А.");
        book2.PrintBookInfo();
        Console.ReadLine();
    }
}
