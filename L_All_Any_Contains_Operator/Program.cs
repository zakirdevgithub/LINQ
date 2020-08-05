using System;
using System.Collections.Generic;
using System.Linq;


namespace L_All_Any_Contains_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var isAll = numbers.All(x => x % 2 == 0);
            Console.WriteLine($"All= {isAll}");

            var isAny = numbers.Any(x => x % 2 == 0);
            Console.WriteLine($"Any={isAny}");

            var isContains = numbers.Contains(2);
            Console.WriteLine($"Contains={isContains}");

        }


    }
}
