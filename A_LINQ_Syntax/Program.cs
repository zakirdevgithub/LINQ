using System;
using System.Collections.Generic;
using System.Linq;

namespace A_LINQ_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Query Syntax
            var QuerySyntax = from number in numbers
                              where number > 3
                              select number;
            //Execution
            foreach(var item in QuerySyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");

            //Method Syntax
            var MethodSyntax = numbers.Where(x => x > 3);
            
            //Execution
            foreach (var item in MethodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");

            //Mixed Syntax
            var MixedSyntax = (from number in numbers
                               select number).Min();

            //Execution
            Console.WriteLine(MixedSyntax);
            
        }
    }
}
