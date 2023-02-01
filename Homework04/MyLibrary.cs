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
}