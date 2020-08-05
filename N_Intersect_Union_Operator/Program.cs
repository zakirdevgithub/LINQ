using System;
using System.Collections.Generic;
using System.Linq;

namespace N_Intersect_Union_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> letter1 = new List<string>() { "A", "B", "C", "D", "Z", "K", "A", "B", "C", "D" };
            List<string> letter2 = new List<string>() { "A", "B", "C", "D" };

            var msi = letter1.Intersect(letter2).ToList();
            foreach (var item in msi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            var qsi = (from lett in letter1
                       select lett).Intersect(letter2).ToList();

            foreach (var item in qsi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            var msu = letter1.Union(letter2).ToList();
           
            foreach (var item in msu)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            var qsu = (from lett in letter1
                       select lett).Union(letter2).ToList();

            foreach (var item in qsu)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            List<Student> student1 = new List<Student>()
            {
                new Student(){Id=0, Name="Zakir", Email="zakir@gmail.com"},
                new Student(){Id=1, Name="Zahid", Email="zahid@gmail.com"},
                new Student(){Id=2, Name="Keya", Email="keya@gmail.com"},
                new Student(){Id=3, Name="Mitu", Email="mitu@gmail.com"},
                new Student(){Id=4, Name="Setu", Email="setu@gmail.com"},
                new Student(){Id=5, Name="Jahangir", Email="jahangir@gmail.com"},
                new Student(){Id=3, Name="Mitu", Email="mitu@gmail.com"},
                new Student(){Id=4, Name="Setu", Email="setu@gmail.com"}
            };

            List<Student> student2 = new List<Student>()
            {
                new Student(){Id=0, Name="Zakir", Email="zakir@gmail.com"},
                new Student(){Id=1, Name="Zahid", Email="zahid@gmail.com"},
                new Student(){Id=2, Name="Keya", Email="keya@gmail.com"},
                new Student(){Id=3, Name="Mitu", Email="mitu@gmail.com"},
                new Student(){Id=4, Name="Setu", Email="setu@gmail.com"},
                new Student(){Id=5, Name="Rakib", Email="rakib@gmail.com"}
            };

            Console.WriteLine("----------------------------");

            var methodIntersect = student1.Select(x => x.Name).Intersect(student2.Select(x => x.Name)).ToList();
            foreach (var item in methodIntersect)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");
            var queryIntersect = (from std in student1
                                  select std.Name).Intersect(student2.Select(x => x.Name)).ToList();
            foreach (var item in queryIntersect)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            var methodUnion = student1.Select(x => x.Name).Union(student2.Select(x => x.Name)).ToList();
            foreach (var item in methodUnion)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");
            var queryUnion = (from std in student1
                                  select std.Name).Union(student2.Select(x => x.Name)).ToList();
            foreach (var item in queryUnion)
            {
                Console.WriteLine(item);
            }

        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
