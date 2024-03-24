using System.Reflection;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("One dimensional: ");
            OneDimensionalArray one = new OneDimensionalArray();
            Console.WriteLine("You entered: ");
            one.Print();
            double avg1 = one.FindAvg();
            Console.WriteLine("\navg value one dimensional array: {0}", avg1);

            Console.WriteLine("Two dimensional: ");
            TwoDimensionalArray two = new TwoDimensionalArray();
            Console.WriteLine("You entered: ");
            two.Print();
            double avg2 = two.FindAvg();

            Console.WriteLine("\navg value two dimensional array: {0}", avg2);
        }

        static void Task2()
        {
            Console.WriteLine("One dimensional: ");
            OneDimensionalArray one = new OneDimensionalArray();
            Console.WriteLine("You entered: ");
            one.Print();
            int max = one.Max();
            Console.WriteLine("\nMax element value = {0}", max);
            Console.WriteLine("Індекси, не максимальних елементів");
            int[] array = one.Array;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] != max)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static void Task3()
        {
            Console.WriteLine("Two dimensional: ");
            TwoDimensionalArray two = new TwoDimensionalArray();
            Console.WriteLine("You entered: ");
            two.Print();
            two.SwapColumns();
            Console.WriteLine("Після перестановки:");
            two.Print();
        }

        static void Task4()
        {
            Console.WriteLine("Stepped array: ");
            SteppedArray stepped = new SteppedArray();
            Console.WriteLine("You entered: ");
            stepped.Print();
            Console.WriteLine("Число для порівняння:");
            int comparisonValue = int.Parse(Console.ReadLine());

            int [] countGreaterThan = stepped.GreaterThanCnt(comparisonValue);
            for (int i = 0; i < countGreaterThan.Length; i++)
            {
                Console.WriteLine($"Рядок: {i} - {countGreaterThan[i]} елементів більше за {comparisonValue}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2 CSharp\nStudent: Yurii Faryna\nGroup: 341B");
            bool exit = false;
            do
            {
                Console.WriteLine("Напишіть номер завдання(1...4) (0 для виходу) :");
                string task = Console.ReadLine();
              
                switch (task)
                {
                    case "0":
                        exit = true;
                        Console.WriteLine("Bye");
                        break;
                    case "1":
                        Console.WriteLine("Task 1");
                        Task1();
                        break;
                    case "2":
                        Console.WriteLine("Task 2");
                        Task2();
                        break;
                    case "3":
                        Console.WriteLine("Task 3");
                        Task3();
                        break;
                    case "4":
                        Console.WriteLine("Task 4");
                        Task4();
                        break;
                    default:
                        Console.WriteLine("Виберіть вірний номер завдання (1-4).");
                        break;
                }
                Console.WriteLine();
              
            } while (!exit);
        }
    }
}
