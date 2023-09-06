using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[6] { 10, 5, 3, 4, 8, 6 };

            for (int j = 1; j < arrayA.Length; j++)
            {
                int key = arrayA[j];
                int i = j - 1;

                while (i >= 0 && arrayA[i] > key)
                {
                    arrayA[i + 1] = arrayA[i];
                    i = i - 1;
                    arrayA[i + 1] = key;
                }
            }
            foreach(int i in arrayA)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
