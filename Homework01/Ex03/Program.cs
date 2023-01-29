/*
Задача 3: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите целое положительное число:");
int n = System.Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine("Результат:");
while (i <= n)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}

