namespace ArrayProblems
{
    public class MinimumDistance
    {
        private static void MainMD(string[] args)
        {
            int[] arr1 = { 3, 5, 4, 2, 6, 5, 6, 6, 5, 4, 8, 3 };
            int x = 3;
            int y = 6;
            int prev = 0;
            int min_dist = int.MaxValue;
            int i;
            for (i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == x || arr1[i] == y)
                {
                    prev = i;
                    break;
                }
            }

            for (; i < arr1.Length; i++)
            {
                if (arr1[i] == x || arr1[i] == y)
                {

                    if (arr1[prev] != arr1[i] && (i - prev) < min_dist)
                    {
                        min_dist = i - prev;
                        prev = i;
                    }
                    else
                    {
                        prev = i;
                    }
                }
            }

            System.Console.WriteLine(min_dist);
        }
    }
}