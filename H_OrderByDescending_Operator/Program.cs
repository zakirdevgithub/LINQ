using System;
using System.Collections.Generic;
using System.Linq;

namespace H_OrderByDescending_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 11, 33, 55, 44, 77, 22, 88, 66, 99 };
            List<string> names = new List<string>() {"Zakir","Keya","Sohel","Mitu","Setu","Jahangir","Ataur","Rubaiya" };

            List<Student> student = new List<Student>()
            {
                new Student(){Id=0, Name="Zakir", Email="zakir@gmail.com"},
                new Student(){Id=1, Name="Zahid", Email="zahid@gmail.com"},
                new Student(){Id=2, Name="Keya", Email="keya@gmail.com"},
                new Student(){Id=3, Name="Mitu", Email="mitu@gmail.com"},
                new Student(){Id=4, Name="Setu", Email="setu@gmail.com"},
                new Student(){Id=5, Name="Rakib", Email="rakib@gmail.com"}
            };

            //Query Syntax
            var numberQuery = (from num in numbers
                               orderby num descending
                               select num).ToList();

            foreach (var item in numberQuery)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");

            var nameQuery = (from nam in names
                               orderby nam descending
                               select nam).ToList();

            foreach (var item in nameQuery)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");

            var studentQuery = (from std in student
                                orderby std.Name descending
                                select std).ToList();

            foreach (var item in studentQuery)
            {
                Console.WriteLine($"Id={item.Id} Name={item.Name} Email={item.Email}");
            }

            Console.WriteLine("-----------------------------");

            //Method Syntax
            var numberMethod = numbers.OrderByDescending(number => number).ToList();
            foreach (var item in numberMethod)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------");

            var nameMethod = names.OrderByDescending(name => name).ToList();

            foreach(var item in nameMethod)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");

            var studentMethod = student.OrderByDescending(std => std.Name).ToList();

            foreach (var item in studentMethod)
            {
                Console.WriteLine($"Id={item.Id} Name={item.Name} Email={item.Email}");
            }

        }
    }
}
