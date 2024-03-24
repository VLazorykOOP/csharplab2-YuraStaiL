using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    public class OneDimensionalArray
    {
        private int[] array;
        
        public OneDimensionalArray()
        {
            this.array = this.Input();
        }
        public int[] Input()
        {
            Console.WriteLine("Розмірність масиву ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            this.array = a;
            return a;
        }

        public void Print()
        {
            for (int i = 0; i < this.array.Length; ++i)
                Console.Write("{0,5} ", this.array[i]);
        }

        public double FindAvg()
        {
            int sum = 0;
            foreach (int x in this.array)
            {
                sum += x;
            }

            return (double) sum / this.array.Length;
        }

        public int Max()
        {
            int max = this.array[0];
            for (int i = 1; i < this.array.Length; ++i)
                if (this.array[i] > max) max = this.array[i];

            return max;
        }

        public int[] Array
        {
            get { return this.array; }
        }
    }
}
