public static class MyLibrary
{
    /// <summary>
    /// Запрашивает число у пользователя и преобразует его в целое
    /// </summary>
    /// <returns>Целое число, введенное пользователем</returns>
    public static int GetNumber()
    {
        Console.Write("Введите целое число: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    /// <summary>
    /// Возведение заданного числа в заданную степень
    /// </summary>
    /// <param name="a">Число</param>
    /// <param name="b">Степень</param>
    /// <returns>Значение числа, возведенного в степень</returns>
    public static int MyPow(int a, int b)
    {
        int result = 1;
        for (int i = 1; i <= b; i++)
        {
            result *= a;
        }
        return result;
    }

    /// <summary>
    /// Подсчет суммы цифр числа
    /// </summary>
    /// <param name="num">Число для подсчета его цифр</param>
    /// <returns>Сумма цифр числа</returns>
    public static int DigitSum(int num)
    {
        int digit_sum = 0;
        while (num > 9)
        {
            digit_sum += num % 10;  //берем последнюю цифру
            num /= 10;  // и отсекаем ее
        }
        digit_sum += num;
        return digit_sum;
    }

    /// <summary>
    /// Генерация массива целых псевдослучайных чисел от 0 до 14
    /// </summary>
    /// <param name="size">количество элементов массива</param>
    /// <returns>массив целых псевдослучайных чисел от 0 до 14</returns>
    public static int[] MakeArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(0, 14);
        }
        return array;
    }

    /// <summary>
    /// Преобразование входящего массива натуральных чисел в стоку для вывода
    /// </summary>
    /// <param name="arr">Массив натуральных чисел</param>
    /// <returns>Строка значений элементов массива</returns>
    public static string PrintArray(int[] arr)
    {
        string stringArr = String.Empty;
        for (int i = 0; i < arr.Length; i++)
        {
            // Console.Write($"{arr[i]} ");
            stringArr += $"{arr[i]} ";
        }
        return stringArr;
    }
    
    /// <summary>
    /// Перевод пятнадцатиричного числа в дестичное
    /// </summary>
    /// <param name="arr">Массив случайных натуральных чисел от 0 до 14 (разряды 15-ричного числа)</param>
    /// <returns>Десятичное число</returns>
    public static int ToDecimal(int[] arr)
    {
        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            result += Convert.ToInt32(arr[i] * Math.Pow(15, arr.Length - i - 1));
        }
        return result;
    }
}