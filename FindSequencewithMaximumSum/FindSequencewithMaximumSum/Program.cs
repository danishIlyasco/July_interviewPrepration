using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSequencewithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 }; 

            int currentSum = ints[0];
            int previousSum = ints[0];
            int maxSum = ints[0];
            int maxStartIndex = 0;
            int maxEndIndex = 0;

            for (int i = 0; i < ints.Length - 1; i++)
            {
                currentSum = ints[i];
                previousSum = ints[i];
                for (int j = i + 1; j < ints.Length; j++)
                {
                    currentSum += ints[j];

                    if (currentSum < previousSum)
                    {
                        if(previousSum > maxSum)
                        {
                            maxSum = previousSum;
                            maxStartIndex = i;
                            maxEndIndex = j - 1;
                        }
                    }
                    else
                    {
                        previousSum = currentSum;
                    }
                }
            }

            for (int i = maxStartIndex; i <= maxEndIndex; i++)
            {
                Console.WriteLine(ints[i]);
            }
            Console.ReadLine();
        }
    }
}
