using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MissingNumber
    {
        static void MainMN(string[] args)
        {
            int[] data = { 7, 3, 4, 5, 5, 6, 2 };
            Array.Sort(data);
            int rnum = 0;
            int missing = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (i > 0 && data[i - 1] == data[i])
                {
                    rnum = data[i];
                }
                if (missing == 0 && i + 1 != data[i])
                    missing = i + 1;
            }
            Console.WriteLine($"Missing :{missing} and Repeat is {rnum}");
        }
    }
}
