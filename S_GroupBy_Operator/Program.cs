using System;
using System.Linq;
using System.Collections.Generic;

namespace S_GroupBy_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Id=0, Name="Zakir", GroupId=1},
                new Student(){Id=1, Name="Zahid", GroupId=1},
                new Student(){Id=2, Name="Limon", GroupId=2},
                new Student(){Id=3, Name="Pranto", GroupId=2},
                new Student(){Id=4, Name="Rakib", GroupId=3},
                new Student(){Id=5, Name="Shuvo", GroupId=3},
                new Student(){Id=6, Name="Shovon"}
            };

            List<Category> categories = new List<Category>()
            {
                new Category(){Id=0, Group="Group A", StudentId=1},
                new Category(){Id=1, Group="Group B", StudentId=2},
                new Category(){Id=2, Group="Group C", StudentId=3},
                new Category(){Id=3, Group="Group D", StudentId=4}
            };

            var MethodGroup = categories.GroupJoin(students, 
                cat => cat.StudentId, std => std.GroupId, (cat, std) => new { cat, std });

            foreach (var item in MethodGroup)
            {
                Console.WriteLine(item.cat.Group);
               
                foreach (var it in item.std)
                {
                    Console.WriteLine(it.Name);
                }
            }

            Console.WriteLine("----------------------------------");

            var QueryGroup = from cat in categories
                             join std in students
                             on cat.StudentId equals std.GroupId into StudentVar
                             select new { cat, StudentVar };

            foreach (var item in QueryGroup)
            {
                Console.WriteLine(item.cat.Group);

                foreach (var it in item.StudentVar)
                {
                    Console.WriteLine(it.Name);
                }
            }
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
    }
    class Category
    {
        public int Id { get; set; }
        public string Group { get; set; }
        public int StudentId { get; set; }
    }
}
