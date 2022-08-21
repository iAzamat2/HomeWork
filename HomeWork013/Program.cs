using FunctionsOfArray;

FunctionsOfArrayClass ar = new FunctionsOfArrayClass();



/*
Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
M = 1; N = 9. -> "3, 6, 9" 
M = 13; N = 20. -> "15, 18"

*/

void Task64()
{
    Random random = new Random();
    int m = random.Next(1, 100);
    int n = random.Next(m, 100);

    Console.WriteLine($"M = {m}, N = {n}");
    ar.Recursion(m, n);
}





/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

void Task66()
{
    Random random = new Random();
    int m = random.Next(1, 100);
    int n = random.Next(m, 100);
    int sum = 0;

    Console.WriteLine($"M = {m}, N = {n}");
    int result = (m + n) * (n - m + 1) / 2;
    Console.WriteLine($"[ Формула ] Cумма натуральных элементов в промежутке от {m} до {n} равна: {result}");
    Console.WriteLine($"[ Рекурсия ] Cумма натуральных элементов в промежутке от {m} до {n} равна: {ar.SumOfRange(m, n, sum)}");
}





/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

         {| n + 1,                  m = 0
A(m, n)= {| A(m - 1, 1),            n = 0
         {| A(m - 1, A(m, n - 1)),  m, n > 0

*/

void Task68()
{
    Random random = new Random();
    int m = random.Next(0, 4);
    int n = random.Next(0, 6);

    Console.WriteLine($"A({m}, {n}) = {ar.AckermannFunc(m, n)}");
}





//Task64();
//Task66();
//Task68();

