using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class FrequencySort
    {
        static void MainAP(string[] args)
        {
            int[] arr = { 2, 5, 2, 6, -1, 9999999, 5, 8, 8, 8 };
            //OldWay(arr);
        }

        private static void OldWay(int[] arr)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (freq.ContainsKey(arr[i]))
                {
                    freq[arr[i]] += 1;
                }
                else
                {
                    freq.Add(arr[i], 1);
                }
            }
            freq = freq.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in freq)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    Console.Write(item.Key + "  ");
                }
            }
        }
    }
}
