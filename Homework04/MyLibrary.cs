public static class MyLibrary
{
    public static int GetNumber()
    {
        Console.WriteLine("Введите целое число: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int MyPow(int a, int b)
    {
        int result = 1;
        for (int i = 1; i <= b; i++)
        {
            result *= a;
        }
        return result;
    }
}