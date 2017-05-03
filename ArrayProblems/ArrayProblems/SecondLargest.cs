using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class SecondLargest
    {
        static void MainFS(string[] args)
        {
            int[] arr = { 12, 13, 1, 99, 123, 10, 34, 44, 66, 111, 23, 78, 1 };
            int second = int.MaxValue;
            int first = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second)
                {
                    second = arr[i];
                }
            }
            Console.WriteLine($"Largest {first} and Second Largest {second}");
        }
    }
}
