/*
    Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

        2, 3, 7 -> 7
        44 5 78 -> 78
        22 3 9 -> 22
*/

/* 
    1 способ вычислять максимум на этапе ввода
    2 способ с использованием массива(заполнение и поиск максимума). Есть возможность увеличить количество чисел, изменив N = 3
*/

Console.WriteLine("Каким способом будем решать? Введите 1 или 2");
int test = Convert.ToInt32(Console.ReadLine());
switch (test)
{
    case 1:
        {
            sposob1();
            break;
        }
    case 2:
        {
            sposob2();
            break;
        }
    default:
        {
            Console.WriteLine("Ошибка! Такого способа решения нет");
            break;
        }
}



int Max(int x, int y)
{
    if (x <= y)
    {
        return y;
    }
    else
    {
        return x;
    }

}



void sposob1()
{
    int max;
    Console.WriteLine("Введите первое число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int B = Convert.ToInt32(Console.ReadLine());
    max = Max(A, B);
    Console.WriteLine("Введите третье число: ");
    int C = Convert.ToInt32(Console.ReadLine());
    max = Max(max, C);
    Console.WriteLine($"Максимум равен {max}");
}



void sposob2()
{
    int N = 3;
    int[] Array = new int[N];
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine($"Введите {(i + 1)} число: ");
        Array[i] = Convert.ToInt32(Console.ReadLine());

    }

    int max = 0;
    for (int i = 1; i < N; i++)
    {
        max = Max(Array[i - 1], Array[i]);

    }
    Console.WriteLine($"Максимум равен {max}");
}

