using FunctionsOfArray;

namespace Tasks
{
    public class tasks
    {
        FunctionsOfArrayClass ar = new FunctionsOfArrayClass();



        // Task 56
        public void MinSumRowsArray(int[,] array)
        {
            int columns = array.GetLength(1);
            int rows = array.GetLength(0);
            int sum = 0;
            double minSum = Double.PositiveInfinity;
            int min_i = 0;
            Console.WriteLine();
            Console.WriteLine("Cумма элементов для каждой строки:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum += array[i, j];
                }
                Console.Write(sum + "; ");
                if (sum < minSum)
                {
                    minSum = sum;
                    min_i = i;
                }
                sum = 0;
            }

            Console.Write("\b\b ");
            Console.WriteLine("\n");
            Console.WriteLine($"Номер строки с наименьшей суммой элементов ({minSum}): {min_i + 1} строка");
        }



        // Task 58
        public void ProductElementsArray(int[,] array1, int[,] array2)
        {
            int rows1 = array1.GetLength(0);
            int columns1 = array1.GetLength(1);
            int rows2 = array2.GetLength(0);
            int columns2 = array2.GetLength(1);
            if (rows1 != rows2 && columns1 != columns2)
            {
                Console.WriteLine("Ошибка! Несовпадают размерности массивов");
            }
            else
            {
                int[,] arrayProduct = new int[rows1, columns1];

                for (int i = 0; i < rows1; i++)
                {
                    for (int j = 0; j < columns1; j++)
                    {
                        arrayProduct[i, j] = array1[i, j] * array2[i, j];
                    }
                }
                ar.PrintArray(arrayProduct);
            }

        }



        // Task 61
        public void ProductArray(int[,] array1, int[,] array2)
        {
            int n = array1.GetLength(0); // строки 1 массива
            int k = array1.GetLength(1); // столбцы 1, строки 2
            int m = array2.GetLength(1); // столбцы 2

            int[,] arrayProduct = new int[n, m];

            int ProductSum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int l = 0; l < k; l++)
                    {
                        ProductSum += array1[i, l] * array2[l, j];
                    }
                    arrayProduct[i, j] = ProductSum;
                    ProductSum = 0;
                }
            }
            ar.PrintArray(arrayProduct);
        }
    }
}