using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var height = 12;

            long[][] pascal = new long[height][];
            
            for(int row = 0; row < height; row++)
            {
                pascal[row] = new long[row + 1];
            }

            pascal[0][0] = 1;
            for (int row = 0; row < pascal.Length - 1; row++)
            {
                for(int column = 0; column < pascal[row].Length; column++)
                {
                    pascal[row + 1][column] += pascal[row][column];
                    pascal[row + 1][column + 1] += pascal[row][column];
                }
            }

            for (int row = 0; row < pascal.Length; row++)
            {
                string str = string.Empty;
                Console.Write("".PadLeft((height - row) * 2));
                for (int column = 0;column < pascal[row].Length;column++)
                {
                    Console.Write("{0,3} ", pascal[row][column]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }


    }
}
