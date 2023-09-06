using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertainSumOfNeighbours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 4, 3, 1, 4, 2, 5, 8 };
            int Sum = 11;
            int startIndex = 0;
            int endIndex = 0;
            int currentSum = ints[0];
            bool found = false;



            for (int i = 1; i < ints.Length; i++)
            {
                currentSum += ints[i];
                endIndex++;

                if (currentSum == Sum)
                {
                    found = true;
                    break;
                }

                if (currentSum > Sum)
                {
                MinusIt:
                    if (currentSum - ints[startIndex] > Sum)
                    {
                        currentSum = currentSum - ints[startIndex];
                        startIndex++;
                        goto MinusIt;
                    }
                    else if (currentSum - ints[startIndex] == Sum)
                    {
                        found = true;
                        startIndex++;
                        break;
                    }
                    else
                    {
                        currentSum -= ints[startIndex];
                        startIndex++;
                    }
                }
            }

            if (found)
            {
                Console.WriteLine("{0} {1}", startIndex, endIndex);
            }
            else
            {
                Console.WriteLine("Couldn't found");
            }

            Console.ReadKey();
        }
    }
}
