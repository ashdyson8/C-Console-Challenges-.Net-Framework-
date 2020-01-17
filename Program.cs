using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 9, 1, 4, 3 };
            List<int> ar = new List<int>(arr);

            Console.WriteLine(getMinimumOps(ar));
            Console.ReadKey();
        }
        static int getMinimumOps(List<int> ar)
        {
           
            int n = ar.Count;

          
            int small = ar.Min();

            
            int large = ar.Max();

           
            int[,] dp = new int[n, large + 1];

            for (int j = small; j <= large; j++)
            {
                dp[0, j] = Math.Abs(ar[0] - j);
            }

         
            for (int i = 1; i < n; i++)
            {
                int minimum = int.MaxValue;
                for (int j = small; j <= large; j++)
                {

                   
                    minimum = Math.Min(minimum, dp[i - 1, j]);
                    dp[i, j] = minimum + Math.Abs(ar[i] - j);
                }
            }

            int ans = int.MaxValue;
            for (int j = small; j <= large; j++)
            {
                ans = Math.Min(ans, dp[n - 1, j]);
            }
            return ans;
        }

    }
}