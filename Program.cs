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
            List<List<object>> List = new List<List<object>>();

            List<object> List1 = new List<object>();
            List1.Add(101);
            List1.Add(102);
            List1.Add(103);

            List<object> List2 = new List<object>();
            List2.Add("Test1");
            List2.Add("Test2");
            List2.Add("Test3");

            List.Add(List1);
            List.Add(List2);

            foreach (List<object> objectList in List)
            {
                foreach  (object obj in objectList)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
       

    }
}