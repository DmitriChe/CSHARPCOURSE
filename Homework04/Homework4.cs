using static MyLibrary;

public static class Homework04
{
    public static void Task25()
    {
        int number = GetNumber();
        int power = GetNumber();
        Console.WriteLine($"Число {number} в степени {power} равно {MyPow(number, power)}");
    }
}