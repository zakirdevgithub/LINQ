using System;
using System.Collections.Generic;
using System.Linq;

namespace M_Distinct_Except_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> letter1 = new List<string>() {"A","B","C","D","Z","K","A","B","C","D" };
            List<string> letter2 = new List<string>() {"A","B","C","D" };

            //Distinct remove duplicate
            var msd = letter1.Distinct().ToList();
            foreach (var item in msd)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            var qsd = (from lett in letter1
                       select lett).Distinct().ToList();

            foreach (var item in qsd)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            var mse = letter1.Except(letter2).ToList();
            foreach (var item in mse)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            var qse = (from lett in letter1
                       select lett).Except(letter2).ToList();

            foreach (var item in qse)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            List < Student > student1 = new List<Student>()
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

            var methodDis = student1.Select(x => x.Name).Distinct().ToList();

            foreach (var item in methodDis)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            var queryDis = (from std in student1
                            select std.Name).Distinct().ToList();

            foreach (var item in queryDis)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            var methodEx = student1.Select(x => x.Name).Except(student2.Select(x => x.Name)).ToList();
            foreach (var item in methodEx)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("----------------------------");


            var queryEx = (from std in student1
                           select std.Name).Except(student2.Select(x=> x.Name)).ToList();

            foreach (var item in queryEx)
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
