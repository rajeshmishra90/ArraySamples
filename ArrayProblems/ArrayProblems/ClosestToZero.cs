using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class ClosestToZero
    {
        static void MainArr(string[] args)
        {
            int[] arr = { 1, 60, -10, 70, -80, 85 };
            int n = arr.Length;
            int l = 0;
            int r = 0;
            int closestDiff = (arr[0] + arr[1]);
            for (int i = 0; i < n; i++)
            {
                int currentSum = 0;
                for (int j = i + 1; j < n; j++)
                {
                    currentSum = arr[i] + arr[j];
                    
                    if (Math.Abs(closestDiff) > Math.Abs(currentSum))
                    {
                        closestDiff = currentSum;
                        l = arr[i];
                        r = arr[j];
                    }
                }
            }
            Console.WriteLine($"Numbers are {l} and {r}");
        }
    }
}
