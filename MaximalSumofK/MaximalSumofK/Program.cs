using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSumofK
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n = Convert.ToInt32(Console.ReadLine());

            var k = Convert.ToInt32(Console.ReadLine());

            k = k - 1;

            var nArray = new int[n];

            for (int i = 0;i < n;i++)
            {
                nArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxStartSumIndex = 0;
            int maxEndSumIndex = 0;
            int sumStartIndex = 0;
            int sumEndIndex = 0;
            int counter = 0;
            int maxPreviousSum = 0;
            int currentSum = 0;
            bool isFirstKElements = true;

            for (int i = 0; i < nArray.Length; i++)
            {
                counter++;
                if (counter < k)
                {
                    currentSum += nArray[i];
                    
                }
                else if(counter == k)
                {
                    if(isFirstKElements)
                    {
                        currentSum += nArray[i];
                        isFirstKElements = false;
                    }
                    else
                    {
                        currentSum += nArray[i] - nArray[i - k];
                    }

                    sumStartIndex = i -k;
                    sumEndIndex = i;

                    if(currentSum > maxPreviousSum)
                    {
                        maxPreviousSum = currentSum;
                        maxStartSumIndex = sumStartIndex;
                        maxEndSumIndex = sumEndIndex;
                    }
                    counter--;
                }
            }

            for (int i = maxStartSumIndex; i <= maxEndSumIndex; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
