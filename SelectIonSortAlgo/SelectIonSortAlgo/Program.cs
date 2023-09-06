using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectIonSortAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] ints = { 1, 2, 3, 10, 8, 20, 30, 4 , 7, 3};

            long toreplaceindex = 0;
            long minimum = ints[0];
            long miniMumIndex = 0;
            

            for(int i = 0; i < ints.Length - 1; i++)
            {
                minimum = ints[i];
                miniMumIndex = i;
                for (int j = i + 1 ; j < ints.Length; j++)
                {
                    if (ints[j] < minimum)
                    {
                        minimum = ints[j];
                        miniMumIndex = j;
                    }
                }

                long val = ints[i];
                ints[i] = minimum;
                ints[miniMumIndex] = val;
            }

            for (int i = 0; i < ints.Length; i ++)
            {
                Console.WriteLine(ints[i]);
            }

            Console.ReadLine();
        }
    }
}
