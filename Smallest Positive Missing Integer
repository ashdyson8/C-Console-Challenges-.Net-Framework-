Smallest positive integer missing from the array 
Input -> 3, 4, -8 ,4 ,5 , 6, 9, 1, -11, 15 ------> output = 2


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
            int[] arr = { 3, 4, -8,4,5, 6,2, 9, 1, -11, 15 };

            int n = arr.Length;

            Console.WriteLine(findMissingPositive(arr, n));
            Console.ReadKey();
        }
        static int findMissingPositive(int[] arr, int n)
        {
            int m = 1;

            HashSet<int> x = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
             
                if (m < arr[i])
                {
                    x.Add(arr[i]);
                }

                else if (m == arr[i])
                {
                   
                    m = m + 1;

                    while (x.Contains(m))
                    {
                        x.Remove(m);

                        
                        m = m + 1;
                    }
                }
            }
            return m;
        }
        
    }
}
