using System;
using System.Collections.Generic;
using System.Linq;

namespace E_Where_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() {"Zakir","Keya","Zahid","Jahangir" };

            var query = (from name in names
                         where name.Length > 5
                         select name).ToList();
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            var method = names.Where(x => x.Length > 5).ToList();
            foreach (var item in method)
            {
                Console.WriteLine(item);
            }

            List<Student> students = new List<Student>()
            {
                new Student(){Id=0, Name="Zakir", Email="zakir@gmail.com"},
                new Student(){Id=1, Name="Zahid", Email="zahid@gmail.com"},
                new Student(){Id=2, Name="Keya", Email="keya@gmail.com"},
                new Student(){Id=3, Name="Mitu", Email="mitu@gmail.com"},
                new Student(){Id=4, Name="Setu", Email="setu@gmail.com"},
                new Student(){Id=5, Name="Rakib", Email="rakib@gmail.com"}
            };

            var queryResult = (from student in students
                               where student.Id == 0 || student.Id==2
                               select student).ToList();

            foreach(var item in queryResult)
            {
                Console.WriteLine($"Name: {item.Name} Email: {item.Email}");
            }

            Console.WriteLine("-------------------------------");

            var methodResult = students.Where(x => x.Id == 0 || x.Id == 2).ToList();
           
            foreach (var item in methodResult)
            {
                Console.WriteLine($"Name: {item.Name} Email: {item.Email}");
            }


        }
    }
}
