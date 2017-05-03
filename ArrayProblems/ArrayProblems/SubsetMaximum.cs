using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class SubsetMaximum
    {
        static void MainMax(string[] args)
        {
            int[] data = { 8, 5, 10, 7, 9, 4, 15, 12, 90, 13 };
            int k = 4;

            for (int i = 0; i <= data.Length - k; i++)
            {
                int largest = data[i];
                for (int j = 1; j < k; j++)
                {
                    if (largest < data[i + j])
                        largest = data[i + j];
                }
                Console.WriteLine(largest);
            }
        }
    }
}
