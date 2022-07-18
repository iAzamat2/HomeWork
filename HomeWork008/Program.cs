/*
Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

void Task25()
{
    Console.Write("Введите число A (основание степени): ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число B (показатель степени): ");
    int b = Convert.ToInt32(Console.ReadLine());

    int res = 1;

    for (int i = 1; i <= b; i++)
    {
        res = res * a;
    }

    Console.WriteLine($"{a}^{b} = {res}");

}





/*
Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

*/

void Task27()
{

    Console.Write("Введите число: ");
    long n = Convert.ToInt64(Console.ReadLine());

    SumOfNumbers(n);



    void SumOfNumbers(long number2)
    {
        int summa = 0;
        string text = number2.ToString();

        while (number2 > 0)
        {
            summa += (int)(number2 % 10);
            number2 /= 10;
        }

        Console.WriteLine($"Сумма цифр числа {text} равна {summa}");

    }

}





/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит отсортированный по модулю массив.

-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
6, 1, -33       -> [1, 6, -33]

*/

void Task29()
{
    int size = 8;
    int[] array = new int[size];

    AutoFillArray(array);
    Console.WriteLine("Сгенерированный массив: ");
    PrintArray(array);
    Console.WriteLine("Отсортированный (по модулю) массив: ");
    SortArrayAbs(array);
    PrintArray(array);



    int[] AutoFillArray(int[] array0)
    {
        for (int i = 0; i < array0.Length; i++)
        {
            Random random = new Random();
            array0[i] = random.Next(-10, 11);
        }
        return array0;
    }



    void PrintArray(int[] array0)
    {
        Console.Write("[");
        for (int i = 0; i < array0.Length; i++)
        {
            Console.Write(array0[i] + ", ");
        }
        Console.Write("\b\b]");
        Console.WriteLine();
    }



    int[] SortArrayAbs(int[] array0)
    {
        int temp;
        for (int i = 0; i < array0.Length - 1; i++)
        {
            for (int j = i + 1; j < array0.Length; j++)
            {
                if (Math.Abs(array0[i]) > Math.Abs(array0[j]))
                {
                    temp = array0[i];
                    array0[i] = array0[j];
                    array0[j] = temp;
                }
                else if ((Math.Abs(array0[i]) == Math.Abs(array0[j])) && (array0[i] > array0[j]))
                {
                    temp = array0[i];
                    array0[i] = array0[j];
                    array0[j] = temp;
                }
            }
        }
        return array0;
    }

}





//Task25();
//Task27();
//Task29();
