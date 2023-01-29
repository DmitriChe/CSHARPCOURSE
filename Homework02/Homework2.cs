// Задача 10. Напишите программу, которая принимает на вход трёхзначное число  и на выходе показывет вторую цифру этого числа.
using static MyLibrary;

public static class Homework02
{
    /// <summary>
    /// Решение задачи №10 из ДЗ2
    /// </summary>
    public static void Task10()
    {
        int number = GetNumber();
        int result = GetDigit(number, 2);
        PrInt(result);
    }
    /// <summary>
    /// Решение задачи №13 из ДЗ2
    /// </summary>
    public static void Task13()
    {
        int number = GetNumber();
        if (number > 99)
        {
            PrInt(GetDigit(number, 3));
        }
        else
        {
            Console.WriteLine("В этом числе нет третьей цифры :(");
        }
    }
    /// <summary>
    /// Решение задачи №15 из ДЗ2
    /// </summary>
    public static void Task15()
    {
        int number = GetNumber();
        if (number < 1 || number > 7)
        {
            Console.WriteLine("Такого дня недели нет! В неделе только 7 дней :)");
        }
        else
        {
            Console.WriteLine(IsHolyday(number));
        }
    }
}


