//using FunctionsOfArray;

namespace Tasks
{
    public class tasks
    {
        //FunctionsOfArrayClass ar = new FunctionsOfArrayClass();

        // Task 50
        public void ExistenceCheck(int[,] array)
        {
            int columns = array.GetLength(1);
            int rows = array.GetLength(0);
            Console.Write($"Введите номер столбца [1 - {columns}]: ");
            int column = Convert.ToInt16(Console.ReadLine()) - 1;
            Console.Write($"Введите номер строки [1 - {rows}]: ");
            int row = Convert.ToInt16(Console.ReadLine()) - 1;

            if ((column >= 0 && column < columns) && (row >= 0 && row < rows))
            {
                Console.WriteLine($"Элемент, расположенный в {column + 1} столбце и в {row + 1} строке, равен: {array[row, column]}");
            }
            else
            {
                Console.WriteLine($"Элемента, расположенного в {column + 1} столбце и в {row + 1} строке, не существует");
            }
        }

        // Task 52
        public void AvgColumnsArray(int[,] array)
        {
            int columns = array.GetLength(1);
            int rows = array.GetLength(0);
            double sum = 0;
            double avg = 0;
            Console.Write("Среднее арифметическое каждого столбца: ");
            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    sum += array[i, j];
                }
                avg = Math.Round((sum / rows), 1);
                Console.Write(avg + "; ");
                sum = 0;
            }
            Console.Write("\b\b ");
            Console.WriteLine();
        }

    }
}