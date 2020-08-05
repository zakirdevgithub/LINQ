using System;
using System.Collections.Generic;
using System.Linq;

namespace T_Left_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Id=0, Name="Zakir", GroupId=1},
                new Student(){Id=1, Name="Zahid", GroupId=2},
                new Student(){Id=2, Name="Limon", GroupId=3},
                new Student(){Id=3, Name="Pranto", GroupId=4},
                new Student(){Id=4, Name="Rakib", GroupId=5},
                new Student(){Id=5, Name="Shuvo", GroupId=6},
                new Student(){Id=6, Name="Shovon", GroupId=7}
            };

            List<Category> categories = new List<Category>()
            {
                new Category(){Id=0, Group="Group A", StudentId=1},
                new Category(){Id=1, Group="Group B", StudentId=2},
                new Category(){Id=2, Group="Group C", StudentId=3},
                new Category(){Id=3, Group="Group D", StudentId=4}
            };

            var QueryLeftJoin = (from std in students
                                 join cat in categories
                                 on std.GroupId equals cat.StudentId into StudentGroups
                                 from stdgroup in StudentGroups.DefaultIfEmpty()
                                 select new { StudentName = std.Name, StudentGroup = stdgroup != null ? stdgroup.Group : "NA" }).ToList();

            foreach (var item in QueryLeftJoin)
            {
                Console.WriteLine($"Student Name={item.StudentName} Group={item.StudentGroup}");
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
