using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxConsectiveIncreasingSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
            //int[] ints = { 9, 6, 200, 202, 209, 11, 13, 5, 24, 29 };
            //int[] ints = { 9 };

            List<int> maxSequence = new List<int>();
            if (ints.Length > 1)
            {
                SequenceFinder(0, ints, 1, ref maxSequence);
            }

            foreach (int i in maxSequence)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        static void SequenceFinder(int firstElementIndex, int[] sequence, int startIndex, ref List<int> maxSequence)
        {
            List<int> CurrentSequence = new List<int>();
            CurrentSequence.Add(firstElementIndex);

            if (firstElementIndex != sequence.Length - 1)
            {
                int current = firstElementIndex;
                for (int j = startIndex; j < sequence.Length; j++)
                {
                    if (sequence[current] < sequence[j])
                    {
                        current = j;
                        CurrentSequence.Add(j);
                    }
                    else if (sequence[firstElementIndex] < sequence[j])
                    {
                        SequenceFinder(firstElementIndex, sequence, j, ref maxSequence);
                    }
                }

                if (CurrentSequence.Count > maxSequence.Count)
                {
                    maxSequence = CurrentSequence;
                }

                SequenceFinder(firstElementIndex + 1, sequence, firstElementIndex + 1 + 1, ref maxSequence);
            }
        }
    }
}
