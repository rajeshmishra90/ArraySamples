using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class ArrayUnion
    {
        static void MainSR(string[] args)
        {
            int[] arr1 = { 1, 2, 4, 5, 6 };
            int[] arr2 = { 2, 3, 5, 7 };
            int m = arr1.Length;
            int n = arr2.Length;

            int i = 0, j = 0;
            while (i < m && j < n)
            {
                if (arr1[i] < arr2[j])
                {
                    Console.WriteLine(arr1[i]);
                    i++;
                }
                else if (arr1[i] > arr2[j])
                {
                    Console.WriteLine(arr2[j]);
                    j++;
                }
                else
                {
                    Console.WriteLine(arr1[i]);
                    i++;
                    j++;
                }
            }

            while (i < m)
            {
                Console.WriteLine(arr1[i]);
                i++;
            }

            while (j < n)
            {
                Console.WriteLine(arr2[j]);
                j++;
            }

        }
    }
}
