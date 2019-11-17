using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaysToSum
{
    public class Solution1
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
                    string strCloneList = string.Join(" ", cloneList);
                    if (!results.ContainsKey(strCloneList))
                    {
                        Console.WriteLine(strCloneList);
                        results[strCloneList] = cloneList;
                    }
                }
            }
            else
            {
                int last = arr[length - 1];
                while (last <= k && n - last >= 1)
                {
                    if (k * (length - 1) >= (n - last))
                        countWays(arr, length - 1, n - last, k);
                    last++;
                    arr[length - 1] = last;
                }
                arr[length - 1] = 1;
            }
        }

        public static int countWays(int n, int k)
        {
            results = new Dictionary<string, List<int>>();

            List<int> arr = new List<int>();
            for (int i = 0; i < n; i++)
                arr.Add(1);

            int count = 0;
            while (arr.Count >= 1)
            {
                countWays(arr, arr.Count, n, k);
                arr = arr.GetRange(0, arr.Count - 1);
            }

            count += results.Keys.Count;

            return count;
        }
    }
}