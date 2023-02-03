using static MyLibrary;

public static class Homework09
{
    /// <summary>
    /// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    /// N = 5 -> "5, 4, 3, 2, 1"
    /// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
    /// </summary>
    public static void Task64()
    {
        Console.Write(PrintNNaturals(GetNaturalNumber()));
    }

    /// <summary>
    /// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    /// M = 1; N = 15 -> 120
    /// M = 4; N = 8. -> 30
    /// </summary>
    public static void Task66()
    {
        Console.WriteLine(GetNaturalsSumm(GetNaturalNumber(), GetNaturalNumber()));
    }

    /// <summary>
    /// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    /// m = 2, n = 3 -> A(m,n) = 9
    /// m = 3, n = 2 -> A(m,n) = 29
    /// </summary>
    public static void Task68()
    {
        Console.WriteLine(Akkerman(GetNaturalNumber(), GetNaturalNumber()));
    }
}