/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A == B)
{
    Console.WriteLine($"Введенные числа равны: {A} = {B}");
}
else Console.WriteLine((A < B) ? $"{B} - большее, {A} - меньшее: {B} > {A}" : $"{A} - большее, {B} - меньшее: {A} > {B}");

