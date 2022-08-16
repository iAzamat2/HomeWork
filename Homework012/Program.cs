using FunctionsOfArray;
using Tasks;

FunctionsOfArrayClass ar = new FunctionsOfArrayClass();
tasks ts = new tasks();



/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

*/

void Task54()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];

    Console.Clear();
    ar.FillArray(array);
    Console.WriteLine("Исходная матрица:");
    ar.PrintArray(array);
    Console.WriteLine();


    Console.WriteLine("Выберете метод и порядок сортировки: ");
    Console.WriteLine("1) Сортировка пузырьком (по возрастанию),\n2) Сортировка пузырьком (по убыванию),");
    Console.WriteLine("3) Быстрая сортировка (по возрастанию),\n4) Быстрая сортировка (по убыванию).");
    int choice = Convert.ToInt16(Console.ReadLine());
    switch (choice)
    {
        case 1: ar.SortArray(array); break;
        case 2: ar.SortArray(array, sortReverse: true); break;
        case 3: ar.QuickSort(array); break;
        case 4: ar.QuickSort(array, sortReverse: true); break;
        default: Console.WriteLine("Ошибка в индексе"); break;
    }
    Console.WriteLine();
    ar.PrintArray(array);

}





/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт
номер строки с наименьшей суммой элементов: 1 строка

*/

void Task56()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];

    ar.FillArray(array, 1, 9);
    ar.cls();
    Console.WriteLine("Сгенерированный массив: ");
    ar.PrintArray(array);
    ts.MinSumRowsArray(array);
}





/*
Задача 61: Задайте две матрицы. Напишите 
программу, которая будет находить произведение 
двух матриц.

*/

void Task61()
{
    Random random = new Random();
    int n = random.Next(4, 8);
    int k = random.Next(4, 8);
    int m = random.Next(4, 8);
    int[,] array1 = new int[n, k];
    int[,] array2 = new int[k, m];

    ar.FillArray(array1, 1, 9);
    ar.FillArray(array2, 1, 9);
    ar.cls();
    Console.WriteLine("Сгенерированные массивы: ");
    ar.PrintArray(array1);
    Console.WriteLine();
    ar.PrintArray(array2);
    Console.WriteLine();
    ts.ProductArray(array1, array2);
}





/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)

*/

void Task60()
{
    Random random = new Random();
    int n = random.Next(2, 4);
    int k = random.Next(2, 4);
    int m = random.Next(2, 4);
    int[,,] array = new int[n, k, m];
    ar.FillArray2(array);
}





/*
Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7

*/

void Task62()
{
    Random random = new Random();
    int m = random.Next(4, 8);
    int n = random.Next(4, 8);
    int[,] array = new int[m, n];

    ar.SpiralFillArray(array);
    ar.PrintArray(array);
}





/*
Задача 58: Задайте две матрицы. 
"Напишите программу, которая будет находить произведение двух матриц."

Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

и

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49

*/

void Task58()
{
    Random random = new Random();
    int n = random.Next(4, 8);
    int m = random.Next(4, 8);

    int[,] array1 = new int[n, m];
    int[,] array2 = new int[n, m];

    ar.FillArray(array1, 1, 9);
    ar.FillArray(array2, 1, 9);

    Console.WriteLine("Сгенерированные массивы: ");
    ar.PrintArray(array1);
    Console.WriteLine();
    ar.PrintArray(array2);
    Console.WriteLine();

    Console.WriteLine("Результат: ");
    ts.ProductElementsArray(array1, array2);
}





//Task54();
//Task56();
//Task61();
//Task60();
//Task62();
//Task58();