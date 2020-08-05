using System;
using System.Collections.Generic;
using System.Linq;

namespace K_Reverse_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //numbers.Reverse();

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("-------------------------------------");

            //var IntReversed = numbers.AsEnumerable().Reverse();
            //Or 
            var IntReversed = numbers.AsQueryable().Reverse();
            foreach (var item in IntReversed)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------");
            //Mixed Syntax
            var querySyntax = (from num in numbers
                               select num).Reverse();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }


        }
    }
}
