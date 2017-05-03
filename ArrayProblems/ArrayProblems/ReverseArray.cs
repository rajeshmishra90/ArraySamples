using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class ReverseArray
    {
        static void Maina1(string[] args)
        {
            int[] data = { 23, 45, 21, 65, 234, 11, 34, 9, 67, 10 };
            //OldWayReverse(data);

            BetterWayReverse(data);
        }

        private static void BetterWayReverse(int[] data)
        {
            int start = 0;
            int end = data.Length - 1;
            while (start < end)
            {
                var temp = data[start];
                data[start] = data[end];
                data[end] = temp;
                start++;
                end--;
            }
        }

        private static void OldWayReverse(int[] data)
        {
            int[] reverse = new int[data.Length];
            int k = 0;
            for (int i = data.Length - 1; i >= 0; i--)
            {
                reverse[k] = data[i];
                k++;
            }
        }
    }
}
