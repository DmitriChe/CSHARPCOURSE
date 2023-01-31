// Библиотека методов для ДЗ03

public static class MyLibrary
{
    public static int GetNumber()
    {
        Console.Write("Введите число: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static bool IsFiveDigits(int num)
    {
        return (num > 9999 && num < 100000);
    }

    public static bool IsPalindrom(int num)
    {
            return ((num / 10000 == num % 10) && (num % 10000 / 1000 == num % 100 / 10));
    }

    public static void PrintCubes(int num)
    {
        string result = String.Empty;
        for (int i = 1; i < num + 1; i++)
        {
            result += $"{Math.Pow(i, 3)} ";
        }
        Console.WriteLine(result);
    }
}