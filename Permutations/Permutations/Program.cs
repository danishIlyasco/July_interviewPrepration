using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2 };

            List<int> list = new List<int>();


            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints.Length; j++)
                {
                    Console.WriteLine("{0}   {1}", ints[i], ints[j]);
                }
            }

            Console.ReadLine();
        }

        static void makePerms(int[] ints, ref List<int> list, int length)
        {
            if(length == ints.Length)
                return;

            for (int i = 0; i < ints.Length; i++)
            {

            }

            Console.WriteLine("{0}   {1}", ints[i], ints[j]);
        }
    }
}
