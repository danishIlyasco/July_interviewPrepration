using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixPrintedDiagonalWise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int row_Input = Convert.ToInt32(Console.ReadLine());
            int column_Input = Convert.ToInt32(Console.ReadLine());

            int[][] ints = new int[row_Input][];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = new int[column_Input];
            }

            int start_row = row_Input - 1;
            int start_col = 0;

            int count = 1;

            bool isDiagonal = false;

            while (start_row >= 0 && start_col <= column_Input - 1)
            {
                int r = start_row;
                int c = start_col;

                while (r < row_Input && c < column_Input)
                {
                    ints[r][c] = count;
                    r++;
                    c++;
                    count++;
                }

                if (isDiagonal)
                {
                    start_col++;
                }
                else
                {
                    start_row--;
                }

                if(start_col == start_row)
                {
                    isDiagonal = true;
                }
            }


            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints[i].Length; j++)
                {
                    Console.Write("{0}  ", ints[i][j]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
