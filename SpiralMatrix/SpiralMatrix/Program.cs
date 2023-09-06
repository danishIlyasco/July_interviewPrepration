using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input_row = Convert.ToInt32(Console.ReadLine());
            int input_col = Convert.ToInt32(Console.ReadLine());

            int[][] spiralMat = new int[input_row][];

            for (int i = 0; i < spiralMat.Length; i ++)
            {
                spiralMat[i] = new int[input_col];
            }

            Program.printSpiral( spiralMat, input_row, input_col, 1, 0, 0);

            for (int i = 0; i < spiralMat.Length; i++)
            {
                for (int j = 0; j < spiralMat[i].Length; j++)
                {
                    Console.Write("{0}  ", spiralMat[i][j].ToString().PadLeft(2));
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public static void printSpiral(int[][] spiralMat, int rows, int col, int count, int currentRowPosition, int currentColPosition)
        {

            if (rows == 0 || col == 0)
            {
                return;
            }

            int ring = 2 * (rows) + 2 * (col - 2);
            int a = 0;

            a = (ring + 4) / 4;
            
            for (int i = 1; i < a; i++)
            {
                spiralMat[currentRowPosition][currentColPosition] = count;
                currentRowPosition++;
                count++;
            }

            spiralMat[currentRowPosition][currentColPosition] = count;

            for (int i = 1; i <= a - 1; i++)
            {
                currentColPosition++;
                count++;
                spiralMat[currentRowPosition][currentColPosition] = count;
            }

            for (int i = 1; i <= a - 1; i++)
            {
                currentRowPosition--;
                count++;
                spiralMat[currentRowPosition][currentColPosition] = count;
            }

            for (int i = 1; i <= a - 2; i++)
            {
                currentColPosition--;
                count++;
                spiralMat[currentRowPosition][currentColPosition] = count;
            }

            count++;

            printSpiral(spiralMat, rows - 2, col - 2, count, currentRowPosition + 1, currentColPosition);
        }
    }
}
