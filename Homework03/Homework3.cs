// Методы по заданиям
using static MyLibrary;

/// <summary>
/// Класс содержит методы с решениеми заданий из ДЗ 03
/// </summary>
public static class Homework03
{
    /// <summary>
    /// Метод задачи 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    ///    14212 -> нет
    ///    12821 -> да
    ///    23432 -> да
    /// </summary>
    public static void Test01()
    {
        int number = GetNumber();

        if (IsFiveDigits(number))
        {
            if (IsPalindrom(number))
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
        }
        else
        {
            Console.WriteLine("Число не пятизначное... Пока!");
        }
    }
    
    /// <summary>
    /// Метод задачи 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
    /// A (0,0); B (1,1), -> ~1.4
    /// A (2,4); B (0,7) -> ~3.6
    /// </summary>
    public static void Test02()
    {
        int x1 = GetNumber();
        int y1 = GetNumber();
        int x2 = GetNumber();
        int y2 = GetNumber();
        PrintDistance(x1, y1, x2, y2);
    }

    /// <summary>
    /// Метод задачи 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    /// 3 -> 1, 8, 27
    /// 5 -> 1, 8, 27, 64, 125
    /// </summary>
    public static void Test03()
    {
        int number = GetNumber();
        PrintCubes(number);
    }
}
