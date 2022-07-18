/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

*/

void Task19()
{
    Console.Write("Введите число: ");
    string ntext = String.Empty;
    ntext = Console.ReadLine();
    long n = Convert.ToInt64(ntext);


    int size = NumberCount(n);
    int[] numbers = NumToArray(n, size);
    Palindrome(numbers, ntext);


    // Доп. методы:
    int NumberCount(long number)
    {
        int count = 0;
        while (number > 0)
        {
            number /= 10;
            count += 1;
        }
        return count;
    }



    int[] NumToArray(long number2, int size2)
    {
        int[] numbersArray = new int[size2];
        for (int i = size2 - 1; i >= 0; i--)
        {
            numbersArray[i] = (int)(number2 % 10);
            number2 /= 10;
        }

        return numbersArray;

    }



    void Palindrome(int[] array, string text)
    {
        bool test = true;
        int sizeArray = array.Length;

        for (int i = 0; i < sizeArray / 2; i++)
        {
            if (array[i] != array[sizeArray - i - 1])
            {
                test = false;
                break;
            }
        }

        if (test == true)
        {
            Console.WriteLine($"Введенное число: {text} - палиндром");
        }
        else
        {
            Console.WriteLine($"Введенное число: {text} - не палиндром");
        }


    }

}



/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/

void Task21()
{
    Random random = new Random();
    int size = 3;
    int[,] coords = new int[size - 1, size];

    Console.WriteLine("Заполнить вручную [1] или автоматически [2]?");
    int check = Convert.ToInt16(Console.ReadLine());
    switch (check)
    {
        case 1: ManualFill(coords, size); PrintPoint(); Distance(coords); break;
        case 2: AutoFill(coords, size); PrintPoint(); Distance(coords); break;
        default: Console.WriteLine("Ошибка"); break;
    }



    void PrintPoint()
    {
        Console.WriteLine($"A ({coords[0, 0]}, {coords[0, 1]}, {coords[0, 2]})\nB ({coords[1, 0]}, {coords[1, 1]}, {coords[1, 2]})");
    }



    int[,] AutoFill(int[,] array, int size1)
    {
        for (int i = 0; i < size1 - 1; i++)
        {
            for (int j = 0; j < size1; j++)
            {
                array[i, j] = random.Next(-10, 11);
            }
        }
        return array;
    }



    int[,] ManualFill(int[,] array, int size1)
    {
        string[] coordName = { "x", "y", "z" };
        for (int i = 0; i < size1 - 1; i++)
        {
            for (int j = 0; j < size1; j++)
            {
                Console.WriteLine($"Введите {coordName[j]}{i + 1}");
                array[i, j] = Convert.ToInt16(Console.ReadLine());
            }
        }
        return array;
    }



    void Distance(int[,] array)
    {
        double res = Math.Sqrt(Math.Pow((coords[1, 0] - coords[0, 0]), 2) + Math.Pow((coords[1, 1] - coords[0, 1]), 2) + Math.Pow((coords[1, 2] - coords[0, 2]), 2));
        double result = Math.Round(res, 5);
        Console.WriteLine($"Расстояние между точками {result}");

    }



}





/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/

void Task23()
{
    Console.Write("Введите число N: ");
    int N = Convert.ToInt16(Console.ReadLine());

    for (int i = 1; i <= N; i++)
    {
        double sqr = Math.Pow(i, 3);
        Console.Write(sqr + " ");
    }
    Console.WriteLine();
}





//Task19();
//Task21();
//Task23();