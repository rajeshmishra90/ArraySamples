using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MaximumAdjacentSum
    {
        static void MainAD(string[] args)
        {
            int[] data = { 3, 2, 7, 10 };
            int n = data.Length;
            Console.WriteLine(FindMaxSum(data,n));
        }

        private static int FindMaxSum(int[] data, int n)
        {
            int incl = data[0];
            int excl = 0;
            int excl_new;
            int i;

            for (i = 1; i < n; i++)
            {
                /* current max excluding i */
                excl_new = (incl > excl) ? incl : excl;

                /* current max including i */
                incl = excl + data[i];
                excl = excl_new;
            }

            /* return max of incl and excl */
            return ((incl > excl) ? incl : excl);
        }
    }
}
