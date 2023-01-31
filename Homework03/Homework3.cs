// Методы по заданиям
using static MyLibrary;

public static class Homework03
{
    public static void Test01()
    {
        int number = GetNumber();

        if (IsFiveDigits(number))
        {
            if (IsPalindrom(number))
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
        }
        else
        {
            Console.WriteLine("Число не пятизначное... Пока!");
        }
    }

    public static void Test02()
    {
        int x1 = GetNumber();
        int y1 = GetNumber();
        int x2 = GetNumber();
        int y2 = GetNumber();
        PrintDistance(x1, y1, x2, y2);
    }
    
    public static void Test03()
    {
        int number = GetNumber();
        PrintCubes(number);
    }
}
