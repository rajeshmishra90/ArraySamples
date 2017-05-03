using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class PivotedBinarySearch
    {
        static void MainD(string[] args)
        {
            int[] arr = { 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            int n = arr.Length;
            int key = 3;
            int i = search(arr, 0, n - 1, key);
            if (i != -1) Console.WriteLine($"Index: {i}");
            else Console.WriteLine("Key not found");
        }

        private static int search(int[] arr, int low, int high, int key)
        {
            if (low > high) return -1;
            int mid = (low + high) / 2;
            if (arr[mid] == key) return mid;

            if (arr[low] <= arr[mid])
            {
                if (key >= arr[low] && key <= arr[mid])
                {
                    return search(arr, low, mid - 1, key);
                }
                else
                {
                    return search(arr, mid + 1, high, key);
                }
            }

            if(key >= arr[mid] && key <= arr[high])
            {
                return search(arr, mid + 1, high, key);
            }

            return search(arr, low, mid - 1, key);
        }
    }
}
