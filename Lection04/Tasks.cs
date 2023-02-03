using static MyLibrary;

public static class Tasks
{
    public static void Task01()
    {
        string[,] table = new string[2, 5];

        table[1, 2] = "Слово";
        Console.WriteLine(table[1, 2]);

        for (int row = 0; row < 2; row++)
        {
            for (int column = 0; column < 5; column++)
            {
                Console.Write($"{table[row, column]} - ");
            }
            Console.WriteLine();
        }
    }

    public static void Task02()
    {
        int[,] matrix = new int[3, 4];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
        
        PrintArray(FillArray(matrix));
    }

    public static void RecursivePictureFill()
    {
        int[,] picture = 
        {
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0},
            {0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0},
            {0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0},
            {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
            {0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0},
            {0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0},
            {0, 0, 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0},
        };

        PrintPicture(picture);
        Console.WriteLine();
        PrintPicture(FillPicture(picture, 4, 9));
    }

    public static void TaskFactorial()
    {
        Console.Write("Введите число для вычисления факториала: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{num}! = {Factorial2(num)}");
    }

    public static void TaskFibonacci()
    {
        for (int n = 1; n < 10; n++)
        {
            Console.WriteLine(Fibonacci(n));
        }
    }

    public static void TaskStringOfNumbers()
    {   
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(StringOfNumbers(a, b));
    }


    public static void TaskSummOfNumbers()
    {   
        Console.Write("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(SummOfNumbers(n));
    }

    public static void TaskPower()
    {   
        Console.Write("Введите число основание: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите степень числа: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Power(a, n));
    }

    /// <summary>
    /// Сборщик всевозможных слов заданной длины из 4 букв а, и, с, в
    /// </summary>
    public static void TestWordsGenerator()
    {
        // char[] letters = {'а', 'и', 'с', 'в'};
        // int n = 1;
        // for (int i = 0; i < letters.Length; i++)
        // {
        //     Console.WriteLine($"{n++, -5}{letters[i]}");
        // }

    }
}
