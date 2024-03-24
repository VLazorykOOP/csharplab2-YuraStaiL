using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    public class TwoDimensionalArray
    {
        public new int[,] array;

        public TwoDimensionalArray()
        {
            this.array = this.Input();
        }

        public int[,] Input()
        {
            Console.WriteLine("Розмірність масиву ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            this.array = a;
            return a;
        }

        public void Print()
        {
            for (int i = 0; i < this.array.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < this.array.GetLength(1); ++j)
                    Console.Write("{0,5} ", this.array[i, j]);
        }

        public double FindAvg()
        {
            int sum = 0;
            foreach (int x in this.array)
            {
                sum += x;
            }

            return (double)sum / this.array.Length;
        }

        public void SwapColumns()
        {
            int rows = this.array.GetLength(0);
            int cols = this.array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols / 2; j++)
                {
                    // Зберігаємо значення поточного елемента
                    int temp = this.array[i, j];
                    int newCol = cols - j - 1;
                    // Замінюємо поточний елемент значенням іншого стовпця
                    this.array[i, j] = this.array[i, newCol];
                    // Замінюємо інший стовпець значенням поточного елемента
                    this.array[i, newCol] = temp;
                }
            }
        }
    }
}
