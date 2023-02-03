public static class MyLibrary
{

    /// <summary>
    /// Получает число из консоли и возврщает его как натуральное
    /// </summary>
    /// <returns>Натуральное число, введенное пользователем</returns>
    public static int GetNaturalNumber()
    {
        Console.Write("Введите натуральное число: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    /// <summary>
    /// Возвращает натуральные числа от N до 1
    /// </summary>
    /// <param name="num">Натуральное число (начало последовательности)</param>
    /// <returns>Натуральное число</returns>
    public static string PrintNNaturals(int num)
    {
        if (num == 1) return $"1";
        else return $"{num} " + PrintNNaturals(num - 1);
    }

    /// <summary>
    /// Подсчет суммы натуральных чисел от M до N
    /// </summary>
    /// <param name="m">Натуральное число - начало натурального ряда</param>
    /// <param name="n">Натуральное число - конец натурального ряда</param>
    /// <returns>Сумма натуральных чисел от M до N</returns>
    public static int GetNaturalsSumm(int m, int n)
    {
        if (m > n)
        {
            return GetNaturalsSumm(n, m);
        }
        else if (m == n) return m;
        else return m + GetNaturalsSumm(m + 1, n);
    }

    /// <summary>
    /// Функция Аккермана
    /// </summary>
    /// <param name="m">Положительное целое</param>
    /// <param name="n">Положительное целое</param>
    /// <returns>Целое число, результат вычисления функции Аккермана</returns>
    public static int Akkerman(int m, int n)
    {
        if (m == 0) return (n + 1);
        else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
        else return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}