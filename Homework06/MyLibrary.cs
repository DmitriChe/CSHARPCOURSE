public static class MyLibrary
{
    /// <summary>
    /// Получает число из консоли и возвращает целое
    /// </summary>
    /// <param name="name">Смысл вводимого числа</param>
    /// <returns>Целое число из консоли от пользователя</returns>
    public static int GetInteger(string name)
    {
        Console.Write($"Введите целое число ({name}): ");
        return Convert.ToInt32(Console.ReadLine());
    }

    /// <summary>
    /// Создает массив из N введенных целых чисел
    /// </summary>
    /// <param name="size">Размер массива</param>
    /// <returns>Массив из N введенных целых чисел</returns>
    public static int[] InputInteger(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            // Console.Write($"Введите {i + 1}-е целое число массива: ");
            // array[i] = Convert.ToInt32(Console.ReadLine());
            array[i] = GetInteger($"{i + 1}-e");
        }
        return array;
    }

    /// <summary>
    /// Подсчет количества целых чисел больше нуля в массиве
    /// </summary>
    /// <param name="array">Входящий массив целых чисел</param>
    /// <returns>Число положительных целых в массиве</returns>
    public static int CountPositive(int[] array)
    {
        int countPositive = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) countPositive++;
        }
        return countPositive;
    }

    /// <summary>
    /// Вычисление точки пересечения двух прямых, заданных коэфф. k1, k2 и b1, b2
    /// </summary>
    /// <param name="k1">угловой коэфф. k1</param>
    /// <param name="b1">b1</param>
    /// <param name="k2">угловой коэфф. k2</param>
    /// <param name="b2">b2</param>
    /// <returns>Массив координат точки пересечения 2-х прямых</returns>
    public static double[] FindCrossPointCoordinates(int k1, int b1, int k2, int b2)
    {
        
        if (k1 == k2)
        {
            return new double[1];  // пустой массив, как признак того, что точки пересечения нет
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;
            double[] coords = {x, y};
            return coords;
        }
    }

    /// <summary>
    /// Вывод координат точки пересечения 2-х прямых, либо сообщения об ее отсутствии
    /// </summary>
    /// <param name="coords">Массив с координатами точки персечения 2-х прямых</param>
    public static void PrintXYcoordinates(double[] coords)
    {
        if (coords.Length != 1)
        {
            Console.WriteLine($"Точка пересечения прямых [{coords[0]}, {coords[1]}]");
        }
        else
        {
            Console.WriteLine("Нет точки пересечения");
        }
    }
}