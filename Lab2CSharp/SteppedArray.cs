using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    public class SteppedArray
    {
        public int[][] array;

        public SteppedArray()
        {
            this.array = Input();
        }

        public int[][] Input()
        {
            Console.WriteLine("Розмірність масиву ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                a[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }

            this.array = a;
            return a;
        }

        public void Print()
        {
            for (int i = 0; i < this.array.Length; ++i, Console.WriteLine())
                for (int j = 0; j < this.array[i].Length; ++j)
                    Console.Write("{0,5} ", this.array[i][j]);
        }

        public int[] GreaterThanCnt(int value)
        {
            int [] counts = new int[this.array.Length];
            for (int i = 0; i < this.array.Length; ++i, Console.WriteLine())
                for (int j = 0; j < this.array[i].Length; ++j)
                    if (this.array[i][j] > value)
                        counts[i]++;

            return counts;
        }
    }
}
