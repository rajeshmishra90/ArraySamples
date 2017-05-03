using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MergeArrays
    {
        static void Main11(string[] args)
        {
            int[] first = new int[10] { 3, 9, 4, 1, 8, 0, 0, 0, 0, 0 };
            int[] second = new int[5] { 2, 5, 7, 6, 12 };

            for (int i = 0; i < second.Length; i++)
            {
                first[second.Length + i] = second[i];
            }
            first = first.OrderBy(x => x).ToArray();
        }
    }
}
