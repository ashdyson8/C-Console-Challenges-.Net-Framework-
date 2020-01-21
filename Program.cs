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
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            double factorial = Factorial(number);
            Console.WriteLine("factorial of " + number.ToString() + "=" + factorial.ToString());
            Console.ReadLine();

        }
        public static double Factorial (int number)
        {
            if (number == 0)
                return 1;

            return number * Factorial(number - 1);
        }

    }
}