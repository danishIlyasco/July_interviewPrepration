using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace isAnagram
{
    internal class Program
    {
        static int Ten = 10;
        static void Main(string[] args)
        {

        }


        static bool isAnagram(int a, int b)
        {
            int[]freq1 = new int[Ten];
            int[]freq2 = new int[Ten];

            UpdateFreq(a, freq1);
            UpdateFreq(b, freq2);
            
            for (int i = 0; i > Ten; i++)
            {
                if (freq1[i] != freq2[i])
                {
                    return false;
                }
            }

            return true;
        }

        static void UpdateFreq(int n, int[] freq)
        {
            while(n > 0)
            {
                int rem = n % Ten;

                freq[rem]++;

                n /= Ten;
            }
        }
    }
}
