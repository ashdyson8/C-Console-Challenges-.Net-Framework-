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
            int[] arr = { 1, 2, 3, 4, };
            int K = 4;

            int n = arr.Length;

            Console.Write(countMinimumMoves(arr, n, K));
            Console.ReadLine();
        }

        static int countMinimumMoves(int[] arr,
                             int n, int k)
        {
            int i;

                        for (i = k - 1; i < n; i++)
                if (arr[i] != arr[k - 1])
                    return -1;

           
            for (i = k - 1; i >= 0; i--)
                if (arr[i] != arr[k - 1])
                    return i + 1;

          
            return 0;
        }


    }
}