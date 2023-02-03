public static class MyLibrary
{
    public static int[,] FillArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Random.Shared.Next(0, 100);
            }
        }
        return array;
    }

    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j], 4}");
            }
            Console.WriteLine();
        }
    }


    public static void PrintPicture(int[,] picture)
    {
        for (int i = 0; i < picture.GetLength(0); i++)
        {
            for (int j = 0; j < picture.GetLength(1); j++)
            {
                if (picture[i, j] == 1)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }


    public static int[,] FillPicture(int[,] picture, int x, int y)
    {
        if (picture[x, y] == 0)
        {
            picture[x, y] = 1;
            FillPicture(picture, x - 1, y);
            FillPicture(picture, x, y + 1);
            FillPicture(picture, x + 1, y);
            FillPicture(picture, x, y - 1);
        }
        return picture;
    }

    public static int Factorial(int x)
    {
        if (x != 1)
        {
            return x * Factorial(x - 1);
        }
        return x;
    }

    public static int Factorial2(int x)
    {
        if (x == 1) return x;
        else return x * Factorial(x - 1);
    }

    public static int Fibonacci(int num)
    {
        if (num == 1 || num == 2) return 1;
        return (Fibonacci(num - 1) + Fibonacci(num - 2));
    }

    public static string StringOfNumbers(int a, int b)
    {   if (a == b) return $"{a}";
        else if (a < b) return $"{a}" + StringOfNumbers(a + 1, b);
        else return String.Empty; 
    }

    /// <summary>
    /// Сумма чисел от 1 до n
    /// </summary>
    /// <param name="n">конец суммируемого ряда</param>
    /// <returns>сумма от 1 до n</returns>
    public static int SummOfNumbers(int n)
    {   if (n == 1) return 1;
        else return n + SummOfNumbers(n - 1);
    }

    public static int Power(int a, int n)
    {   
        if (n == 0) return 1;
        else return a * Power(a, n - 1);
    }
}