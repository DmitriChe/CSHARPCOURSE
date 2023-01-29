/// <summary>
/// Библиотека методов для ДЗ2
/// </summary>
public static class MyLibrary
{
    /// <summary>
    /// Метод получения целого числа от пользователя
    /// </summary>
    /// <returns>Целое число</returns>
    public static int GetNumber()
    {
        int number;
        Console.Write("Введите целое число: ");
        return number = Convert.ToInt32(Console.ReadLine());
    }
    /// <summary>
    /// Метод выводит на экран целое число, как ответ на задачу  
    /// </summary>
    /// <param name="number">Целое число</param>
    public static void PrInt(int number)
    {
        Console.WriteLine($"Ответ: {number}");
    }
    /// <summary>
    /// Метод выводит цифру числа, стоящую на указанно месте
    /// </summary>
    /// <param name="number">Целое число</param>
    /// <param name="place">место интересующей цифры (вторая цифра, третья и т.д.)</param>
    /// <returns>Цифра данного числа, стоящая на указанном месте</returns>
    public static int GetDigit(int number, int place)
    {
        while (number >= Math.Pow(10, place))
        {
            number /= 10;
        }
        return number % 10;
    }
    /// <summary>
    /// Метод определяет праздничный день недели по цифре этого дня
    /// </summary>
    /// <param name="number">Номер дня недели</param>
    /// <returns>Ответ "да" или "нет"</returns>
    public static string IsHolyday(int number)
    {
        if (number < 6)
        {
            return "нет";
        }
        return "да";
    }
}
