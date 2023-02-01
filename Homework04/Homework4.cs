using static MyLibrary;

public static class Homework04
{
    /// <summary>
    /// Метод решения задания 25 из ДЗ4
    /// </summary>
    public static void Task25()
    {
        int number = GetNumber();
        int power = GetNumber();
        Console.WriteLine($"Число {number} в степени {power} равно {MyPow(number, power)}");
    }

    /// <summary>
    /// Метод решения задания 27 из ДЗ4
    /// </summary>
    public static void Task27()
    {
        Console.WriteLine($"Сумма цифр числа: {DigitSum(GetNumber())}");
    }

    /// <summary>
    /// Метод решения задания 29 из ДЗ4
    /// </summary>
    public static void Task29()
    {
        int size = GetNumber();
        int[] arr = MakeArray(size);
        Console.WriteLine($"В десятичном представлении 15-ричное число {PrintArray(arr)} равно {ToDecimal(arr)}");
    }
}

