using System;
using System.Collections.Generic;
using System.Linq;

namespace B_IQueryable_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            //Query Syntax with IEnumerable
            IEnumerable<int> QuerySyntax = from number in numbers
                                           where number % 3 == 0
                                           select number;
            foreach (var item in QuerySyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------");
            //Method Syntax with IEnumerable
            IEnumerable<int> MethodSyntax = numbers.Where(number => number % 3 == 0);

            foreach(var item in MethodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");

            //IQueryable

            IQueryable<int> nums = numbers.AsQueryable().Where(x => x % 3 == 0);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            } 
        }

    }
}
