using FunctionsOfArray;
using Tasks;

FunctionsOfArrayClass ar = new FunctionsOfArrayClass();
tasks ts = new tasks();

/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/

void Task47()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    double[,] array = new double[rows, columns];

    ar.AutoFillTwoArray(array, -10, 10);
    ar.cls();
    Console.WriteLine($"m = {rows}, n = {columns}");
    Console.WriteLine("Сгенерированный массив: ");
    ar.PrintTwoArray(array);
}





/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1, 3 -> 3
1, 7 -> такого числа в массиве нет

*/

void Task50()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];

    ar.FillArray(array, 0, 9);
    ar.cls();
    Console.WriteLine("Сгенерированный массив: ");
    ar.PrintArray(array);
    ts.ExistenceCheck(array);
}





/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/

void Task52()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];

    ar.FillArray(array, 1, 9);
    ar.cls();
    Console.WriteLine("Сгенерированный массив: ");
    ar.PrintArray(array);
    ts.AvgColumnsArray(array);
}





//Task47();
//Task50();
//Task52();