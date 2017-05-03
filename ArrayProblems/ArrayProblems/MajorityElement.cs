using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MajorityElement
    {
        static void MainB(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int[] data = Array.ConvertAll(inputs, int.Parse);
            Dictionary<int, int> dataCount = new Dictionary<int, int>();
            int number = 0;
            bool isFound = false;
            for (int i = 0; i < data.Length; i++)
            {
                if (dataCount.ContainsKey(data[i]))
                {
                    dataCount[data[i]] += 1;
                }
                else
                {
                    dataCount.Add(data[i], 1);
                }
                if (dataCount[data[i]] > data.Length / 2)
                {
                    isFound = true;
                    number = data[i];
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine(number);
            }
            else
                Console.WriteLine("None");
        }
    }
}
