using System;

class Calculator
{
    public static double plus(double a, double b)
    {
        return a + b;
    }

    public static double minus(double a, double b)
    {
        return a - b;
    }

    public static double umnozhenie(double a, double b)
    {
        return a * b;
    }

    public static double delenie(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Ошибка: делить на 0 нельзя!");
            return 0;
        }
        return a / b;
    }
}
class code1
{
    static void Main()
    {
        double x = 10;
        double y = 7;

        Console.WriteLine($"10 + 5 = {Calculator.plus(10, 5)}");
        Console.WriteLine($"10 - 5 = {Calculator.minus(10, 5)}");
        Console.WriteLine($"10 * 5 = {Calculator.umnozhenie(10, 5)}");
        Console.WriteLine($"10 / 5 = {Calculator.delenie(10, 5)}");
        Console.WriteLine($"10 / 0 = {Calculator.delenie(10, 0)}");
    }
}