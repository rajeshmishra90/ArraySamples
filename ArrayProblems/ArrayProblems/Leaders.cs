using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Leaders
    {
        static void MainL(string[] args)
        {
            int[] arr = { 16, 17, 4, 3, 5, 2 };

            //OldWay(arr);

            int maxNumber = arr[arr.Length - 1];
            Console.WriteLine(maxNumber);
            for (int k = arr.Length - 2; k >= 0; k--)
            {
                if (maxNumber < arr[k])
                {
                    maxNumber = arr[k];
                    Console.WriteLine(arr[k]);
                }
            }
        }

        private static void OldWay(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool isLeader = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        isLeader = false;
                        break;
                    }
                }
                if (isLeader || i == arr.Length)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
