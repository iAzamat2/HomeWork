﻿/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine("Введите число");
int test = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(( test%2==0) ? $"{test} - чётное число" : $"{test} - нечётное число");