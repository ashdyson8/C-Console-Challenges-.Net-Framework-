﻿using System;
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
            var numbers = new List<int> { 1, 4, 5, 5, 8, 9, 2, 2, 9, 8, 3, 5 };

            var distinctList = CalculateDistinct(numbers);
            foreach (var distinct in distinctList)
            {
                Console.WriteLine(distinct);
            }
        }

        public static List <int> CalculateDistinct(List<int> ints)
        {
            var results = new List<int>();

            for (int i = 0; i < ints.Count; i++)  
            {
                if (!results.Contains(ints[i])) { results.Add(ints[i]); }
            }
            return results;
        }
    }   
}