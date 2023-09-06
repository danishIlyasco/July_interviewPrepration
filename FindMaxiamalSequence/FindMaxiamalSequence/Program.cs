using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxiamalSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 1, 2, 3, 2, 2, 2, 1 };

            int maxStartIndex = 0;
            int maxEndIndex = 0;
            int startIndex = 0;
            int endIndex = 0;
            bool iscontinue = false;
            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (ints[i] == ints[i + 1])
                {
                    if(!iscontinue)
                    {
                        startIndex = i;
                        iscontinue = true;
                    }
                    endIndex = i + 1;
                }
                else
                {
                    if (maxEndIndex - maxStartIndex < endIndex - startIndex)
                    {
                        maxStartIndex = startIndex; maxEndIndex = endIndex;
                    }

                    startIndex = 0;
                    endIndex = 0;
                    iscontinue = false;
                }
            }

            for (int i = maxStartIndex; i <= maxEndIndex; i++)
            {
                Console.Write(ints[i]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
