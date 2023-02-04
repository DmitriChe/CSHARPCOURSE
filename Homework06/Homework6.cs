using static MyLibrary;

public static class Homework06
{
    /// <summary>
    /// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    /// 0, 7, 8, -2, -2 -> 2
    /// 1, -7, 567, 89, 223-> 3
    /// </summary>
    public static void Task41()
    {
        Console.WriteLine($"Количество чисел больше нуля: {CountPositive(InputInteger(GetInteger("размер массива")))}");
    }

    /// <summary>
    /// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    /// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    /// </summary>
    public static void Task43()
    {
        PrintXYcoordinates(FindCrossPointCoordinates(GetInteger("k1"), GetInteger("b1"), GetInteger("k2"), GetInteger("b2")));
    }
}