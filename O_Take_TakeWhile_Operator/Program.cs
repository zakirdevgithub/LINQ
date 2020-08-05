using System;
using System.Collections.Generic;
using System.Linq;

namespace O_Take_TakeWhile_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            var methodTake = numbers.Take(5).ToList();
           
            foreach (var item in methodTake)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------");
            
            var queryTake = (from num in numbers
                             select num).Take(5).ToList();

            foreach (var item in queryTake)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------");

            var methodTakeWhile = numbers.TakeWhile(x=> x<5).Select(x=>x).ToList();
            foreach (var item in methodTakeWhile)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------");
            var queryTakeWhile = (from num in numbers
                                  select num).TakeWhile(x => x < 5).ToList();
           
            foreach (var item in queryTakeWhile)
            {
                Console.WriteLine(item);
            }


        }
    }
}
