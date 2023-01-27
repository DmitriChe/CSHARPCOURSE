/*
Задача 1: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int a = new Random().Next(10);
int b = new Random().Next(10);
int c = new Random().Next(10);

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine(c);
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine(c);
    }
}

