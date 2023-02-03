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
    /// <summary>
    /// Поиск разности экстремумов массива
    /// </summary>
    /// <param name="arr">Массив натуральных чисел</param>
    /// <returns>Разность экстремумов массива</returns>
    public static int FindMaxMinDifference(int[] arr)
    {
        int min = arr[0];
        int max = arr[0];
         for (int i = 1; i < arr.Length; i++)
         {
            if (arr[i] < min) min = arr[i];
            if (arr[i] > max) max = arr[i];
         }
         return (max - min);
    }

    /// <summary>
    /// Заполнения массива ручным вводом элементов
    /// </summary>
    /// <param name="size">Размер массива</param>
    /// <returns>Заполненный вручную массив</returns>
    public static int[] GenerateManualArray(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Введите {i}-й элмент массива: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"[{String.Join(" ", arr)}]");
        return arr;
    }

    /// <summary>
    /// Выбор типа заполнения массива и его генерация
    /// </summary>
    /// <param name="size">Размер массива</param>
    /// <returns>Сгенерированый массив</returns>
    public static int[] MakeArray(int size)
    {
        Console.WriteLine("Выберите вариант заполнения массива:\n1 - вручную;\n2 - автоматически");
        string answer = Convert.ToString(Console.ReadLine());
        if (answer == "1") return GenerateManualArray(size);
        else return GenerateRandomArray(size);
    }

    /// <summary>
    /// Ищет максимальное значение в массиве
    /// </summary>
    /// <param name="arr">Входящий массив натуральных чисел</param>
    /// <returns>Максимальное значение в массиве</returns>
    public static int FindArrMaxValue(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++) if (arr[i] > max) max = arr[i];
        return max;
    }

    /// <summary>
    /// Создает частотный словарь значений входящего массива на базе нового массива, где индекс = значению элементов входящего массива, а значение по этому индексу - числу таких значений во входящем массиве.
    /// </summary>
    /// <param name="arr">Входящий массив</param>
    /// <returns>Массив с частотой элемента, где индекс элемента массива это сам исходны элемент, а его частота - содержимое ячеки</returns>
    public static int[] BuildFrequencyArray(int[] arr)
    {
        int[] freqArray = new int[FindArrMaxValue(arr) + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            freqArray[arr[i]]++;
        }
        return freqArray;
    }

    /// <summary>
    /// Вывод на экран содержимого частотного словаря
    /// </summary>
    /// <param name="arr">Частотный словарь в виде массива</param>
    public static void PrintFrequencyArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                Console.WriteLine($"{i} --> {arr[i]} шт.");
            }
        }
    }


//     public static int[,] BuildFrequencyArray(int[] arr)
//     {
//         int countUniqueValues = arr.Length;
//         repeated = false;
//         int countRepeats = 0;

//         for (int i = 0; i < arr.Length; i++)
//         {
//             for (int j = 0; j < i; j++) // проверка половины массива до текущего элемента
//             {
//                 if (arr[j] == arr[i]) countUniqueValues -= 1;
//             }
//             for (int j = i + 1; j < arr.Length; j++)
//             {
//                 if (arr[j] == arr[i]) countUniqueValues -= 1;
//             }

//         }
//         repeated = false;
//     }
}