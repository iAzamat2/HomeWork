//using FunctionsOfArray;

namespace Tasks
{
    public class tasks
    {


        //FunctionsOfArrayClass ar = new FunctionsOfArrayClass();


        // Task 34
        public int CountEvenNumbers(int[] array0)
        {

            int count = 0;
            for (int i = 0; i < array0.Length; i++)
            {
                if (array0[i] % 2 == 0)
                {
                    count++;
                }
            }

            return count;

        }



        // Task 36
        public int SumNotEvenPos(int[] array0)
        {

            int sum = 0;
            for (int i = 0; i < array0.Length; i++)
            {
                if (!(i % 2 == 0))
                {
                    sum += array0[i];
                }
            }

            return sum;

        }



        // Task 38
        public double DifferenceMinMax(double[] array0)
        {

            double min = double.PositiveInfinity;
            double max = double.NegativeInfinity;
            double result = 0;

            for (int i = 0; i < array0.Length; i++)
            {
                if (array0[i] > max)
                {
                    max = array0[i];
                }
                if (array0[i] < min)
                {
                    min = array0[i];
                }
            }

            result = Math.Round(Math.Abs(Math.Abs(max) - Math.Abs(min)), 2);
            return result;

        }



    }
}