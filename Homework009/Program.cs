using FunctionsOfArray;
using Tasks;


FunctionsOfArrayClass ar = new FunctionsOfArrayClass();
tasks ts = new tasks();



/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/

void Task34()
{

    int size = 12;
    int[] array = new int[size];

    ar.AutoFillArray(array, 100, 999);
    Console.WriteLine("Сгенерированный массив: ");
    ar.PrintArray(array);

    Console.WriteLine($"Количество чётных чисел в массиве: {ts.CountEvenNumbers(array)}");



}





/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

*/

void Task36()
{

    int size = 12;
    int[] array = new int[size];

    ar.AutoFillArray(array, -100, 100);
    Console.WriteLine("Сгенерированный массив: ");
    ar.PrintArray(array);

    Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна: {ts.SumNotEvenPos(array)}");

}





/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.

[3,21 7,04 22,93 -2,71 78,24] -> 75,53

*/

void Task38()
{

    int size = 12;
    double[] array = new double[size];

    ar.AutoFillArrayReal(array, -100, 100);
    Console.WriteLine("Сгенерированный массив: ");
    ar.PrintArrayReal(array);

    Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {ts.DifferenceMinMax(array)}");



}





//Task34();
//Task36();
Task38();
