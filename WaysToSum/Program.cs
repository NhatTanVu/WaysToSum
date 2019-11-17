using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaysToSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileStream filestream = new FileStream("out.txt", FileMode.Create);
            var streamwriter = new StreamWriter(filestream);
            streamwriter.AutoFlush = true;
            Console.SetOut(streamwriter);
            Console.SetError(streamwriter);

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

            long result = 0;

            //Console.WriteLine("n = 2, k = 2");
            //Console.WriteLine("-------------");
            //result = Solution2.countWays(2, 2);
            //Console.WriteLine("-------------");
            //Console.WriteLine(result);
            //Console.WriteLine();

            //Console.WriteLine("n = 5, k = 2");
            //Console.WriteLine("-------------");
            //result = Solution2.countWays(5, 2);
            //Console.WriteLine("-------------");
            //Console.WriteLine(result);
            //Console.WriteLine();

            //Console.WriteLine("n = 8, k = 2");
            //Console.WriteLine("-------------");
            //result = Solution2.countWays(8, 2);
            //Console.WriteLine("-------------");
            //Console.WriteLine(result);
            //Console.WriteLine();

            //Console.WriteLine("n = 8, k = 3");
            //Console.WriteLine("-------------");
            //result = Solution2.countWays(8, 3);
            //Console.WriteLine("-------------");
            //Console.WriteLine(result);

            Console.WriteLine("n = 30, k = 30");
            Console.WriteLine("-------------");
            result = Solution1.countWays(30, 30);
            Console.WriteLine("-------------");
            Console.Write(result);
        }
    }
}
