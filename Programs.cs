using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 1, 2, 4 };
            int[] b = { 16, 48, 64 };

            int n = a.Length;
            int m = b.Length;

            findNumbers(a, n, b, m);

            Console.ReadKey();
        }

        static int __gcd(int a, int b)
        {
            if (b == 0)
                return a;
            return __gcd(b, a % b);
        }

        static int lcm(int x, int y)
        {
            int temp = (x * y) / __gcd(x, y);
            return temp;
        }

        static void findNumbers(int[] a, int n,
                        int[] b, int m)
        {

            int lcmA = 1, gcdB = 0;

            
            for (int i = 0; i < n; i++)
                lcmA = lcm(lcmA, a[i]);

            for (int i = 0; i < m; i++)
                gcdB = __gcd(gcdB, b[i]);

                        if (gcdB % lcmA != 0)
            {
                Console.Write("-1");
                return;
            }

            
            int num = lcmA;
            while (num <= gcdB)
            {
                if (gcdB % num == 0)
                    Console.Write(num + " ");
                num += lcmA;
            }
        }
    }
}
