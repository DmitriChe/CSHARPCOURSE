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

    public static void Test03()
    {
        int number = GetNumber();
        PrintCubes(number);
    }
}
