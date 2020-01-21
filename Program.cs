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
            string[][] JaggedArray = new string[3][];

            JaggedArray[0] = new string[3];
            JaggedArray[1] = new string[1];
            JaggedArray[2] = new string[2];

            JaggedArray[0][0] = "Bachelors";
            JaggedArray[0][1] = "Masters";
            JaggedArray[0][2] = "Doctorate";

           
            JaggedArray[1][0] = "Bachelors";

            
            JaggedArray[2][0] = "Bachelors";
            JaggedArray[2][1] = "Masters";


            for (int i = 0; i < JaggedArray.Length; i++)
            {
                string[] innerArray = JaggedArray[i];
                for (int j = 0; j < innerArray.Length; j++)
                {
                    Console.WriteLine(innerArray[j]);
                }
                Console.WriteLine();
            }

           



            Console.ReadLine();

        }
       

    }
}