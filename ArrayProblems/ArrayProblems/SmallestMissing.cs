using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class SmallestMissing
    {
        static void MainSM(string[] args)
        {
            int[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 10 };
            int n = data.Length;
            int m = 11;

            for (int i = 0; i <= m - 1; i++)
            {
                if (i == m - 1 || data[i] != i)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}
