/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int A = 1;
int B = N;
for (int i = A; i <= B; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i+", ");

    }
}
Console.Write("\b\b.");
Console.WriteLine();
