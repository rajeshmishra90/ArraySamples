using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class LargestSubArraySum
    {
        static void MainC(string[] args)
        {
            int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };
            int n = a.Length;
            int max_sum = maxSubArraySum(a, n);
            Console.WriteLine(max_sum);
        }

        private static int maxSubArraySum(int[] a, int n)
        {
            int max_so_far = a[0];
            int curr_max = a[0];

            for (int i = 1; i < n; i++)
            {
                curr_max = Math.Max(a[i], curr_max + a[i]);
                max_so_far = Math.Max(max_so_far, curr_max);
            }
            return max_so_far;
        }
    }
}
