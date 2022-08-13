namespace FunctionsOfArray
{
    public class FunctionsOfArrayClass
    {
        public void AutoFillTwoArray(double[,] array, int startNumber = -10, int finishNumber = 10)
        {
            finishNumber++;
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.NextDouble(startNumber, finishNumber);
                }
            }
        }



        public void PrintTwoArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(Math.Round(array[i, j], 1) + "\t");
                }
                Console.WriteLine();
            }
        }



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



    }



    static class RandomExtension
    {
        public static double NextDouble(this Random r, double min, double max)
        {
            return min + r.NextDouble() * (max - min);
        }

        public static double NextDouble(this Random r, double max)
        {
            return r.NextDouble() * max;
        }
    }



    // Random r = new Random();
    // r.NextDouble(-20, 20);
    // r.NextDouble(20);



}