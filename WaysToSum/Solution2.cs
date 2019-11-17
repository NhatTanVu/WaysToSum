using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaysToSum
{
    public class Solution2
    {
        public static Dictionary<string, List<int>> results = new Dictionary<string, List<int>>();

        public static int countWays(int n, int k)
        {
            results = new Dictionary<string, List<int>>();

            int maxNumOfDigits = n, pos = maxNumOfDigits - 1;
            List<int> arr = new List<int>();
            for (int i = 0; i < maxNumOfDigits; i++)
                arr.Add(1);
            
            while (pos >= 0)
            {
                int counter = 0;
                while (counter <= Math.Pow(k, pos + 1))
                {
                    for (int j = 1; j <= k; j++)
                    {
                        arr[0] = j;
                        int sum = 0;
                        arr.ForEach(x => sum += x);
                        if (sum == n)
                        {
                            var cloneList = arr.OrderBy(x => x).ToList();
                            var strCloneList = string.Join(" ", cloneList);
                            if (!results.ContainsKey(strCloneList))
                            {
                                results[strCloneList] = cloneList;
                                Console.WriteLine(strCloneList);
                            }
                        }
                        counter++;
                    }

                    if (pos > 0)
                    {
                        int l = 1;
                        while (l < pos && arr[l] == k)
                        {
                            arr[l] = 1;
                            l++;
                        }
                        if (arr[l] < k)
                        {
                            arr[l]++;
                        }
                    }
                }

                for (int i = 0; i <= pos; i++)
                    arr[i] = 1;
                arr.RemoveAt(arr.Count - 1);
                pos--;
            }

            return results.Keys.Count;
        }
    }
}