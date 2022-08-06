namespace FunctionsOfArray
{
    public class FunctionsOfArrayClass
    {

        public int[] AutoFillArray(int[] array0, int startNumber = -10, int finishNumber = 10)
        {

            finishNumber++;
            Random random = new Random();

            for (int i = 0; i < array0.Length; i++)
            {
                array0[i] = random.Next(startNumber, finishNumber);
            }

            return array0;

        }



        public void PrintArray(int[] array0)
        {

            Console.Write("[");
            for (int i = 0; i < array0.Length; i++)
            {
                Console.Write(array0[i] + ", ");
            }
            Console.Write("\b\b]");
            Console.WriteLine();

        }



        public double[] AutoFillArrayReal(double[] array0, int startNumber = -10, int finishNumber = 10)
        {

            finishNumber++;
            Random random = new Random();

            for (int i = 0; i < array0.Length; i++)
            {
                array0[i] = random.NextDouble(startNumber, finishNumber);
            }

            return array0;

        }



        public void PrintArrayReal(double[] array0)
        {

            Console.Write("[");
            for (int i = 0; i < array0.Length; i++)
            {
                Console.Write(Math.Round(array0[i], 2) + "; ");
            }
            Console.Write("\b\b]");
            Console.WriteLine();

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