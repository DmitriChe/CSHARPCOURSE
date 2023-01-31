/// <summary>
/// Класс библиотеки методов для решения заданий из ДЗ03
/// </summary>
public static class MyLibrary
{
    /// <summary>
    /// Метод получает число из консоли от пользователя и приводит его к типу int
    /// </summary>
    /// <returns>возвращает целое число, введенное пользователем</returns>
    public static int GetNumber()
    {
        Console.Write("Введите число: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    /// <summary>
    /// Метод проверки целого числа на количество цифр. Должжно быть число из 5 цифр.
    /// </summary>
    /// <param name="num">получает целое число</param>
    /// <returns>возвращает булево значение: true, если число из пяти цифр или false, если нет</returns>
    public static bool IsFiveDigits(int num)
    {
        return (num > 9999 && num < 100000);
    }

    /// <summary>
    /// Метод проверки целого числа на палиндром
    /// </summary>
    /// <param name="num">получает на вход целое пятизначное число</param>
    /// <returns>возвращает булеву величину: true, если чило является палиндромом, false, если нет</returns>
    public static bool IsPalindrom(int num)
    {
            return ((num / 10000 == num % 10) && (num % 10000 / 1000 == num % 100 / 10));
    }

    /// <summary>
    /// Метод расчета и вывода кубов натуральных числе от 1 до данного
    /// </summary>
    /// <param name="num">натуральное число</param>
    public static void PrintCubes(int num)
    {
        string result = String.Empty;
        for (int i = 1; i < num + 1; i++)
        {
            result += $"{Math.Pow(i, 3)} ";
        }
        Console.WriteLine(result);
    }

    /// <summary>
    /// Метод расчета и печати расстояния между двумя точками на плоскости по их координатам
    /// </summary>
    /// <param name="x1">абсцисса первой точки</param>
    /// <param name="y1">ордината первой точки</param>
    /// <param name="x2">абсцисса второй точки</param>
    /// <param name="y2">ордината второй точки</param>
    public static void PrintDistance(int x1, int y1, int x2, int y2)
    {
        Console.WriteLine($"Расстояние: {Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2))}");
    }
}