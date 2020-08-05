using System;
using System.Collections.Generic;
using System.Linq;

namespace F_OfType_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> MyObject = new List<Object>() { "Zakir", "Zahid", "Limon", "Pranto", 1, 2, 3, 4, 5.5, 6.3, 7.4, 8, 9, 10 };


            //Query Syntax
            var findString = (from str in MyObject
                              where str is string
                              select str).ToList();
           
            foreach (var item in findString)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------");
            var findFloat = (from num in MyObject
                              where num is double
                              select num).ToList();

            foreach (var item in findFloat)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------");
            //Method Syntax
            var stringFind = MyObject.OfType<string>().ToList();
            foreach (var item in stringFind)
            {
                Console.WriteLine(item);
            }

            var IntFind = MyObject.OfType<int>().ToList();
            foreach (var item in IntFind)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");
            var even = MyObject.OfType<int>().Where(x => x % 2 == 0).ToList();
            foreach (var item in even)
            {
                Console.WriteLine(item);
            }

        }
    }
}
