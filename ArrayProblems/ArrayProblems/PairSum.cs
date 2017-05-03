using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    class PairSum
    {
        //http://www.geeksforgeeks.org/write-a-c-program-that-given-a-set-a-of-n-numbers-and-another-number-x-determines-whether-or-not-there-exist-two-elements-in-s-whose-sum-is-exactly-x/
        static void MainA(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(Console.ReadLine());
            int[] data = Array.ConvertAll(inputs, int.Parse);
            data = data.OrderBy(c => c).ToArray();
            int l = 0;
            int r = data.Length - 1;
            while (l < r)
            {
                int sum = data[l] + data[r];
                if (sum == x)
                {
                    Console.WriteLine($"Sum pair are {data[l]} and {data[r]}");
                    break;
                }
                else if (sum < x)
                    l++;
                else if (sum > x)
                    r--;
            }
        }
    }
}
