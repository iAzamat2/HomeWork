namespace FunctionsOfArray
{
    public class FunctionsOfArrayClass
    {
        public void cls()
        {
            Console.Clear();
        }



        public void FillArray(int[,] array, int startNumber = 0, int finishNumber = 10)
        {
            finishNumber++;
            Random random = new Random();
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(startNumber, finishNumber);
                }
            }
        }



        public void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }



        // Сортировка пузырьком
        public void SortArray(int[,] array, bool sortReverse = false)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int k = 0; k < rows; k++)
            {
                for (int i = 0; i < columns - 1; i++)
                {
                    for (int j = i + 1; j < columns; j++)
                    {
                        if ((array[k, i] > array[k, j] && sortReverse == false) || (array[k, i] < array[k, j] && sortReverse == true))
                        {
                            (array[k, i], array[k, j]) = (array[k, j], array[k, i]);
                        }
                    }
                }
            }

        }



        // Быстрая сортировка
        public void QuickSort(int[,] array, bool sortReverse = false)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            int column = columns - 1;
            for (int k = 0; k < rows; k++)
            {
                SortArray0(array, 0, column, k, sortReverse);
            }
        }



        int[,] SortArray0(int[,] array, int leftIndex, int rightIndex, int k, bool sortReverse)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[k, leftIndex];
            while (i <= j)
            {
                while ((array[k, i] < pivot && sortReverse == false) || (array[k, i] > pivot && sortReverse == true))
                {
                    i++;
                }

                while ((array[k, j] > pivot && sortReverse == false) || (array[k, j] < pivot && sortReverse == true))
                {
                    j--;
                }
                if (i <= j)
                {
                    (array[k, i], array[k, j]) = (array[k, j], array[k, i]);
                    i++;
                    j--;
                }
            }
            if (leftIndex < j)
                SortArray0(array, leftIndex, j, k, sortReverse);
            if (i < rightIndex)
                SortArray0(array, i, rightIndex, k, sortReverse);
            return array;
        }



        public void FillArray2(int[,,] array, int startNumber = 10, int finishNumber = 99)
        {
            finishNumber++;

            int size = finishNumber - startNumber;
            int[] generated = new int[size];
            Random random = new Random();
            int generatedNumber = random.Next(startNumber, finishNumber);

            int n = array.GetLength(0);
            int k = array.GetLength(1);
            int m = array.GetLength(2);
            int product = n * k * m;

            if (product <= size)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < k; j++)
                    {
                        for (int l = 0; l < m; l++)
                        {
                            while (generated[generatedNumber - 10] == 1)
                            {
                                generatedNumber = random.Next(startNumber, finishNumber);
                            }
                            array[i, j, l] = generatedNumber;
                            generated[generatedNumber - 10] = 1;
                        }
                    }
                }
                PrintArray2(array);
            }
            else
            {
                Console.WriteLine($"Ошибка! Невозможно заполнить массив случайными неповторяющимися числами {product} > {size}");
            }
        }



        void PrintArray2(int[,,] array)
        {
            int n = array.GetLength(0);
            int k = array.GetLength(1);
            int m = array.GetLength(2);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    for (int l = 0; l < m; l++)
                    {
                        Console.Write($"{array[i, j, l]}({i},{j},{l})\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }



        public void SpiralFillArray(int[,] array)
        {
            int m = array.GetLength(0);
            int n = array.GetLength(1);

            int s = 1;

            //Заполняем периметр массива по часовой стрелке.
            for (int y = 0; y < n; y++)
            {
                array[0, y] = s;
                s++;
            }
            for (int x = 1; x < m; x++)
            {
                array[x, n - 1] = s;
                s++;
            }
            for (int y = n - 2; y >= 0; y--)
            {
                array[m - 1, y] = s;
                s++;
            }
            for (int x = m - 2; x > 0; x--)
            {
                array[x, 0] = s;
                s++;
            }

            //Периметр заполнен. Продолжаем заполнять массив и задаём
            //координаты ячейки, которую необходимо заполнить следующей.
            int c = 1;
            int d = 1;

            while (s < m * n)
            {
                //Движемся вправо.
                while (array[c, d + 1] == 0)
                {
                    array[c, d] = s;
                    s++;
                    d++;
                }

                //Движемся вниз.
                while (array[c + 1, d] == 0)
                {
                    array[c, d] = s;
                    s++;
                    c++;
                }

                //Движемся влево.
                while (array[c, d - 1] == 0)
                {
                    array[c, d] = s;
                    s++;
                    d--;
                }

                //Движемся вверх.
                while (array[c - 1, d] == 0)
                {
                    array[c, d] = s;
                    s++;
                    c--;
                }
            }

            //При данном решении в центре всегда остаётся незаполненная ячейка.
            //Убираем её при помощи следующего цикла.
            for (int x = 0; x < m; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (array[x, y] == 0)
                    {
                        array[x, y] = s;
                    }
                }
            }
        }



    }
}