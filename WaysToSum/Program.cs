using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaysToSum
{
    public class Result
    {
        public static Dictionary<string, List<int>> results = new Dictionary<string, List<int>>();

        public static void countWays(List<int> arr, int length, int n, int k)
        {
            if (length == 1)
            {
                if (k >= n)
                {
                    var cloneList = arr.ToList();
                    cloneList[0] = n;
                    cloneList = cloneList.OrderBy(x => x).ToList();
                    results[string.Join(" ", cloneList)] = cloneList;
                }
            }
            else
            {
                int last = arr[length - 1];
                while (last <= k && n - last >= 1)
                {
                    countWays(arr, length - 1, n - last, k);
                    last++;
                    arr[length - 1] = last;
                }
                arr[length - 1] = 1;
            }
        }

        public static int countWays(int n, int k)
        {
            List<int> arr = new List<int>();
            for (int i = 0; i < n; i++)
                arr.Add(1);

            int count = 0;
            while (arr.Count > 1)
            {
                countWays(arr, arr.Count, n, k);
                arr = arr.GetRange(0, arr.Count - 1);
            }

            foreach (var pair in results)
                Console.WriteLine(pair.Key);

            count += results.Keys.Count;

            return count;
        }
    }

    public class Solution
    {
        public static void Main(string[] args)
        {
            // n = 8, k = 3
            // 1 1 1 1 1 1 1 1
            // 1 1 1 1 1 1 2
            // 1 1 1 1 2 2
            // 1 1 1 1 1 3
            // 1 1 2 2 2
            // 1 1 1 2 3
            // 1 1 3 3
            // 1 2 2 3
            // 2 2 2 2
            // 2 3 3

            // n = 8, k = 2
            // 1 1 1 1 1 1 1 1
            // 1 1 1 1 1 1 2
            // 1 1 1 1 2 2
            // 1 1 2 2 2
            // 2 2 2 2

            // n = 2, k = 2
            // 1 1
            // 2

            // n = 5, k = 2
            // 1 1 1 1 1
            // 1 1 1 2
            // 1 2 2	

            long result = Result.countWays(2, 2);
            Console.WriteLine("-------------");
            Console.WriteLine(result);
        }
    }
}
