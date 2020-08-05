using System;
using System.Linq;
using System.Collections.Generic;

namespace U_ElementAt_ElementAtOrDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Method Syntax
            var FourthElement = numbers.ElementAt(3);
            Console.WriteLine(FourthElement);

            //var EleventhElement = numbers.ElementAt(10); Error
            var EleventhElement = numbers.ElementAtOrDefault(10);
            Console.WriteLine(EleventhElement);

            Console.WriteLine("-------------------------");
            //Query Syntax
            var queryElementAt = (from num in numbers
                                  select num).ElementAt(8);

            var queryElementAtOrDefault = (from num in numbers
                                           select num).ElementAtOrDefault(10);

            Console.WriteLine(queryElementAt);
            Console.WriteLine(queryElementAtOrDefault);

        }
    }
    
}
