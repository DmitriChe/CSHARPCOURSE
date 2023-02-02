using static MyLibrary;

/// <summary>
/// Метод решения задания 34 из ДЗ4
/// </summary>
public static class Homework04
{
    /// <summary>
    /// Метод решения задания 34 из ДЗ5
    /// </summary>
    public static void Task34()
    {
        Console.WriteLine($"Четных элементов в массиве: {CountEven(GenerateRandomArray(GetNumber()))}");
    }

    /// <summary>
    /// Метод решения задания 36 из ДЗ5
    /// </summary>
    public static void Task36()
    {
        Console.WriteLine($"Сумма элементов на нечетных позициях составляет: {CountOddSumm(GenerateRandomArray(GetNumber()))}");
    }

    /// <summary>
    /// Метод решения задания 38 из ДЗ5
    /// </summary>
    public static void Task38()
    {
        Console.WriteLine($"Разность экстремумов массива равна: {FindMaxMinDifference(GenerateRandomArray(GetNumber()))}");
    }
}

