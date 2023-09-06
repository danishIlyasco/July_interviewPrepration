using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateMatrixOfInputSize
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int row =Convert.ToInt16(Console.ReadLine());
            int col =Convert.ToInt16(Console.ReadLine());

            int[,] mat = new int[row,col];

            int count = 1;

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    mat[j, i] = count;
                    count++;
                }
            }

            for (int i = 0;i < row; i++)
            {
                for(int j = 0;j < col; j++)
                {
                    Console.Write("{0} ", mat[i, j]);
                    
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
