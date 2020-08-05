using System;
using System.Collections.Generic;
using System.Linq;

namespace G_OrderBy_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {1,4,10,5,6,7,8,3,9,2 };

            var query=(from number in numbers
                      orderby number
                      select number).ToList();
           
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------");
           
            var evenQuery = (from number in numbers
                             where number%2==0
                             orderby number
                             select number).ToList();

            foreach (var item in evenQuery)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------");

            var method = numbers.OrderBy(number => number).ToList();
            
            foreach (var item in method)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------");

            var evenMethod = numbers.Where(number=> number%2==0).OrderBy(number => number).ToList();

            foreach (var item in evenMethod)
            {
                Console.WriteLine(item);
            }

            List<Student> student = new List<Student>()
            {
                new Student(){Id=0, Name="Zakir", Email="zakir@gmail.com"},
                new Student(){Id=1, Name="Zahid", Email="zahid@gmail.com"},
                new Student(){Id=2, Name="Keya", Email="keya@gmail.com"},
                new Student(){Id=3, Name="Mitu", Email="mitu@gmail.com"},
                new Student(){Id=4, Name="Setu", Email="setu@gmail.com"},
                new Student(){Id=5, Name="Rakib", Email="rakib@gmail.com"}
            };

            var studentQuery = (from std in student
                                orderby std.Name
                                select std).ToList();

            foreach (var item in studentQuery)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("------------------------");

            var studentMethod = student.OrderBy(obj => obj.Name).ToList();


            foreach (var item in studentMethod)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
