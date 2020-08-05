using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Select_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
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
            var studentData = (from std in student
                               select new Student()
                              {
                                Id = std.Id,
                                Name = std.Name,
                                Email = std.Email
                              }).ToList();
           
            foreach (var item in studentData)
            {
                Console.WriteLine($"Id={item.Id} Name:{item.Name} Email:{item.Email}");
            }

            Console.WriteLine("--------------------------");

            var findNameAndEmailOfId2 = (from std in student
                                         where std.Id == 2
                                         select new Student()
                                         {
                                             Name=std.Name,
                                             Email=std.Email
                                         }).ToList();
            foreach (var item in findNameAndEmailOfId2)
            {
                Console.WriteLine($"Name:{item.Name} Email:{item.Email}");
            }

            //With Anonymous Class
            var anonyousClass = (from std in student
                                 select new
                                 {
                                     Id=std.Id,
                                     Name=std.Name,
                                     Email=std.Email
                                 }).ToList();

            foreach (var item in anonyousClass)
            {
                Console.WriteLine($"Id={item.Id} Name={item.Name} Email={item.Email}");
            }

            Console.WriteLine("Method Syntax");

            //Method Syntax
            var findSpecificId = student.Where(x => x.Id == 2).Select(x => new Student()
            {
                Id=x.Id,
                Name=x.Name,
                Email=x.Email
            }).ToList();

            foreach (var item in findSpecificId)
            {
                Console.WriteLine($"Id={item.Id} Name={item.Name} Email={item.Email}");
            }

            //Method Syntax with Anonymous Class
            var findSpecificIdWithAnonymous = student.Where(x => x.Id == 4).Select(x => new 
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email
            }).ToList();

            foreach (var item in findSpecificIdWithAnonymous)
            {
                Console.WriteLine($"Id={item.Id} Name={item.Name} Email={item.Email}");
            }
        }
    }
}
