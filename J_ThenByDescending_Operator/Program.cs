using System;
using System.Collections.Generic;
using System.Linq;

namespace J_ThenByDescending_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>()
            {
                new Student(){Id=0, FirstName="Zakir", LastName="Hossain", Age=25, Email="zakir@gmail.com"},
                new Student(){Id=1, FirstName="Keya", LastName="Rahman", Age=24, Email="keya@gmail.com"},
                new Student(){Id=2, FirstName="Zakir", LastName="Rahman", Age=23, Email="zakir@gmail.com"},
                new Student(){Id=3, FirstName="Keya", LastName="Hossain", Age=35, Email="keya@gmail.com"},
                new Student(){Id=4, FirstName="Zakir", LastName="Hossain", Age=15, Email="zakir@gmail.com"},
                new Student(){Id=5, FirstName="Keya", LastName="Rahman", Age=14, Email="keya@gmail.com"},
                new Student(){Id=6, FirstName="Zakir", LastName="Rahman", Age=13, Email="zakir@gmail.com"},
                new Student(){Id=7, FirstName="Keya", LastName="Hossain", Age=15, Email="keya@gmail.com"},

            };

            //Method Syntax
            var studentMethodSingle = student.OrderBy(std => std.FirstName).ThenByDescending(std => std.Age).ToList();

            foreach (var item in studentMethodSingle)
            {
                Console.WriteLine($"Id={item.Id} FirstName={item.FirstName} LastName={item.LastName} Age={item.Age} Email={item.Email}");
            }

            Console.WriteLine("------------------------------------");
            var studentMethodMultiple = student.OrderBy(std => std.FirstName).ThenByDescending(std => std.LastName).ThenByDescending(std => std.Age).ToList();

            foreach (var item in studentMethodMultiple)
            {
                Console.WriteLine($"Id={item.Id} FirstName={item.FirstName} LastName={item.LastName} Age={item.Age} Email={item.Email}");
            }

            Console.WriteLine("-----------------------------------");
            //Query Syntax

            var studentQuerySingle = (from std in student
                                      orderby std.FirstName, std.LastName descending
                                      select std).ToList();

            foreach (var item in studentQuerySingle)
            {
                Console.WriteLine($"FirstName={item.FirstName} LastName={item.LastName}");
            }

            Console.WriteLine("-----------------------------------");


            var studentQueryMultiple = (from std in student
                                        orderby std.FirstName, std.LastName ascending, std.Age descending
                                        select std).ToList();

            foreach (var item in studentQueryMultiple)
            {
                Console.WriteLine($"FirstName={item.FirstName} LastName={item.LastName} Age={item.Age}");
            }
        }
    }
}
