using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[2] { 1000, 999 };

            Program program = new Program();

            program.Sort(ref inputArray);

            int maxJumb = 2;
            int currentJumb = 2;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] == inputArray[i + 1])
                {
                    currentJumb += currentJumb;
                }
                else
                {
                    if (maxJumb < currentJumb)
                    {
                        maxJumb = currentJumb;
                    }
                    maxJumb = 2;
                }
            }

            for (; maxJumb <= inputArray[inputArray.Length -1]; maxJumb++)
            {
                if (!inputArray.Any(x => x % maxJumb == 0))
                {
                    break;
                }
            }

            Console.WriteLine(maxJumb);

            Console.Read();
        }

        private int[] Sort(ref int[] toSort)
        {
            for (int j = 1; j < toSort.Length; j++)
            {
                int key = toSort[j];
                int i = j - 1;
                while (i >= 0 && toSort[i] > toSort[j])
                {
                    toSort[i + 1] = toSort[i];
                    i = i - 1;
                    toSort[i + 1] = key;
                }
            }

            return toSort;
        }
    }
}
