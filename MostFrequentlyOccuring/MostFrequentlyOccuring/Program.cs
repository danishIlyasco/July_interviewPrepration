using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentlyOccuring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            for (int i = 1; i < ints.Length; i++)
            {
                int key = ints[i];
                int j = i - 1;

                while(ints[j] > key && j > 0)
                {
                    ints[j + 1] = ints[j];
                    j = j - 1;
                    ints[j + 1] = key;
                }
            }

            int maxCount = 1;
            int count = 1;
            int maxCountElement = ints[0];
            int currentElement = ints[0];
           
            for (int i = 1; i < ints.Length; i++)
            {
                if(currentElement == ints[i])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxCountElement = currentElement;
                        currentElement = ints[i];
                        count = 1;
                    }
                }
            }

            Console.WriteLine("{0} times {1}", maxCount, maxCountElement);
            Console.ReadLine();
         }
    }
}
