using System;
using System.Collections.Generic;
using System.Linq;

namespace P_Skip_SkipWhile
{
    class Program
    {
        static void Main(string[] args)

        {
            List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10};

            List<string> names = new List<string>() {"Zakir","Keya","Zahid","Mi","Setu" };

            var methodSkip = numbers.Skip(3).ToList();
            foreach (var item in methodSkip)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            var querySkip = (from num in numbers
                             select num).Skip(3).ToList();

            foreach (var item in querySkip)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            var methodSkipWhile = names.SkipWhile((value, index) => value.Length > index).ToList();

            foreach (var item in methodSkipWhile)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");
            var querySkipWhile = (from nam in names
                                  select nam).SkipWhile((value,index)=> value.Length>index).ToList();

            foreach (var item in querySkipWhile)
            {
                Console.WriteLine(item);
            }
        }
    }
}
