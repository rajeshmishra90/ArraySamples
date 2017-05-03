using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class ArrayRotation
    {
        static void MainAR(string[] args)
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7 };
            int d = 2;
            int n = input.Length;
            input = Rotate(input, n, d);
        }

        private static int[] Rotate(int[] input, int n, int d)
        {
            int[] reverse = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i < d)
                {
                    reverse[(n - d) + i] = input[i];
                }
                else
                {
                    reverse[i - d] = input[i];
                }
            }
            return reverse;
        }
    }
}
