using System;
using System.Linq;
using System.Collections.Generic;

namespace V_First_FirstOrDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            var num = numbers.First();
            Console.WriteLine(num);

            var num2 = numbers.Where(x => x > 5).First();
            Console.WriteLine(num2);

            var num3 = numbers.First(x => x > 5);
            Console.WriteLine(num3);

            var num4 = numbers.FirstOrDefault(x => x == -1);
            Console.WriteLine(num4);

            Console.WriteLine("-----------------------------------");

            List<Student> student = new List<Student>()
            {
                new Student(){Id=0, Name="Zakir", Email="zakir@gmail.com"},
                new Student(){Id=1, Name="Zahid", Email="zahid@gmail.com"},
                new Student(){Id=2, Name="Keya", Email="keya@gmail.com"},
                new Student(){Id=3, Name="Mitu", Email="mitu@gmail.com"},
                new Student(){Id=4, Name="Setu", Email="setu@gmail.com"},
                new Student(){Id=5, Name="Rakib", Email="rakib@gmail.com"}
            };

            var methodSyntax = student.FirstOrDefault(x => x.Id == 2);
            Console.WriteLine(methodSyntax.Name);

            var querySyntax = (from std in student
                               select std).FirstOrDefault(x=> x.Id==2);
            Console.WriteLine(querySyntax.Name);

        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    
}
