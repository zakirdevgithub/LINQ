using System;
using System.Linq;
using System.Collections.Generic;

namespace X_Single_SingleOrDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>() { 1 };
            var num = number.Single();
            Console.WriteLine(num);

            List<int> numbers = new List<int>() { };
            var nums = numbers.SingleOrDefault();
            Console.WriteLine(nums);

        }
    }
}
