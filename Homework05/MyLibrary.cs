public static class MyLibrary
{
    /// <summary>
    /// Преобразует число, введенное пользователем в консоли в целое
    /// </summary>
    /// <returns>Целое число</returns>
    public static int GetNumber()
    {
        Console.Write("Введите число: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    /// <summary>
    /// Генерирует массив трехзначных натуральных чисел
    /// </summary>
    /// <param name="size">Количество элементов массива</param>
    /// <returns>Массив трехзначных натуральных чисел</returns>
    public static int[] GenerateRandomArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = Random.Shared.Next(100, 999);
        }
        Console.WriteLine($"[{String.Join(", ", array)}]");
        return array;
    }

    /// <summary>
    /// Считает количество четных элементов в массиве
    /// </summary>
    /// <param name="arr">Массив натуральных чисел</param>
    /// <returns>Число четных элементов массива</returns>
    public static int CountEven(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0) count++;
        }
        return count;
    }

    /// <summary>
    /// Подсчет суммы элементов массива, стоящих на нечетных позициях
    /// </summary>
    /// <param name="arr">Массив натуральных чисел</param>
    /// <returns>Сумма элементов массива, стоящих на нечетных позициях</returns>
    public static int CountOddSumm(int[] arr)
    {
        int oddSumm = 0;
        for (int i = 1; i < arr.Length; i+=2) oddSumm += arr[i];
        return oddSumm;
    }
}