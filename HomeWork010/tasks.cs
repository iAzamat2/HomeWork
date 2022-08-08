//using FunctionsOfArray;

namespace Tasks
{
    public class tasks
    {
        //FunctionsOfArrayClass ar = new FunctionsOfArrayClass();


        // Task 41
        public void sposob1(string raz = " ")
        {
            int count = 0;
            Console.Write($"Введите числa через это разделитель ({raz}): ");
            int[] str = Console.ReadLine().Split(raz).Select(int.Parse).ToArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 0) count++;
            }
            Console.WriteLine($"Пользователь ввел: {count} чисел(а) больше 0");
        }



        public void sposob2(string exitKey = "q")
        {
            int count = 0;
            string userString = String.Empty;
            List<int> numbers = new List<int>();
            numbers.Clear();

            do
            {
                Console.WriteLine($"Введите число и нажмите клавишу Enter: ({exitKey} - выход)");
                userString = Console.ReadLine();
                if (userString != exitKey)
                {
                    numbers.Add(Convert.ToInt32(userString));
                }
            } while (userString != exitKey);

            numbers.TrimExcess();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0) count++;
            }
            Console.WriteLine($"Пользователь ввел: {count} чисел(а) больше 0");
        }



        public void sposob3()
        {
            int count = 0;
            Console.WriteLine("Введите количество чисел, которые будут введены: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Введите {i + 1} число и нажмите клавишу Enter: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if (numbers[i] > 0) count++;
            }
            Console.WriteLine($"Пользователь ввел: {count} чисел(а) больше 0");
        }



        // Task 43
        public void Intersection(double b1 = 0, double k1 = 0, double b2 = 0, double k2 = 0)
        {
            if (b1 == 0 || k1 == 0 || b2 == 0 || k2 == 0)
            {
                string[] kofName = { "b1", "k1", "b2", "k2" };
                double[] kofValue = new double[kofName.Length];
                double x;
                double y;

                for (int i = 0; i < kofName.Length; i++)
                {
                    Console.Write($"Введите значение {kofName[i]}: ");
                    kofValue[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Данные введены успешно:)");

                if (kofValue[1] != kofValue[3])
                {
                    Console.WriteLine($"Находим точку пересечения двух прямых, заданных уравнениями: y = {kofValue[1]}x + {kofValue[0]} и y = {kofValue[3]}x + {kofValue[2]}");
                    x = (kofValue[2] - kofValue[0]) / (kofValue[1] - kofValue[3]);
                    y = kofValue[1] * x + kofValue[0];
                    Console.WriteLine($"Искомая точка A({Math.Round(x, 2)}, {Math.Round(y, 2)})");
                }
                else if (kofValue[1] == kofValue[3] && kofValue[0] == kofValue[2])
                {
                    Console.WriteLine($"Две прямые, заданные уравнениями: y = {kofValue[1]}x + {kofValue[0]} и y = {kofValue[3]}x + {kofValue[2]} совпадают");
                }
                else if (kofValue[1] == kofValue[3])
                {
                    Console.WriteLine($"Две прямые, заданные уравнениями: y = {kofValue[1]}x + {kofValue[0]} и y = {kofValue[3]}x + {kofValue[2]} не пересекаются (параллельны)");
                }
            }
            else
            {
                double x;
                double y;

                if (k1 != k2)
                {
                    Console.WriteLine($"Находим точку пересечения двух прямых, заданных уравнениями: y = {k1}x + {b1} и y = {k2}x + {b2}");
                    x = (b2 - b1) / (k1 - k2);
                    y = k1 * x + b1;
                    Console.WriteLine($"Искомая точка A({Math.Round(x, 2)}, {Math.Round(y, 2)})");
                }
                else if (k1 == k2 && b1 == b2)
                {
                    Console.WriteLine($"Две прямые, заданные уравнениями: y = {k1}x + {b1} и y = {k2}x + {b2} совпадают");
                }
                else if (k1 == k2)
                {
                    Console.WriteLine($"Две прямые, заданные уравнениями: y = {k1}x + {b1} и y = {k2}x + {b2} не пересекаются (параллельны)");
                }
            }
        }



    }
}