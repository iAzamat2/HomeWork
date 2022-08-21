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



        public void Recursion(int m1, int n1)
        {
            if (m1 > n1) return;
            if (m1 % 3 == 0) Console.Write(m1 + " ");
            m1 += (m1 % 3 == 0) ? 3 : 1;
            Recursion(m1, n1);
        }



        public int SumOfRange(int m, int n, int sum)
        {
            if (m == n + 1) return sum;
            sum += m;
            m++;
            return SumOfRange(m, n, sum);
        }



        public int AckermannFunc(int m, int n)
        {
            return (m == 0) ? n + 1 :
            (n == 0) ? AckermannFunc(m - 1, 1) : AckermannFunc(m - 1, AckermannFunc(m, n - 1));
        }



    }
}