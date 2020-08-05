using System;
using System.Collections.Generic;
using System.Linq;

namespace R_Inner_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>()
            {
                new Student(){Id=0, Name="Zakir", StudentId=1},
                new Student(){Id=1, Name="Keya", StudentId=2},
                new Student(){Id=2, Name="Rozina", StudentId=3},
                new Student(){Id=3, Name="Rakib", StudentId=4},
                new Student(){Id=4, Name="Limon", StudentId=5}

            };

            List<Address> address =new  List<Address>()
            {
                new Address(){Id=0, HomeAddress="Kumargara Kheyaghat", AddressId=1},
                new Address(){Id=1, HomeAddress="Bahadurpur Mothurapur", AddressId=2},
                new Address(){Id=2, HomeAddress="Choto Bishakol", AddressId=3},
                new Address(){Id=3, HomeAddress="Habiganj Sylhet", AddressId=4},
                new Address(){Id=4, HomeAddress="Narikel Para Chatmohar", AddressId=5}

            };

            List<Marks> mark = new List<Marks>()
            {
                new Marks(){Id=0, Mark=70, MarkId=1},
                new Marks(){Id=1, Mark=80, MarkId=2},
                new Marks(){Id=2, Mark=90, MarkId=3},
                new Marks(){Id=3, Mark=60, MarkId=4},
                new Marks(){Id=4, Mark=50, MarkId=5}
            };

            //Join Two Table
            var methodTwoTableJoin = student.Join(address,
                                                std => std.StudentId,
                                                addr => addr.AddressId,
                                                (std, addr) => new 
                                                { 
                                                    StudentName=std.Name,
                                                    StudentAddress=addr.HomeAddress
                                                }).ToList();

            foreach (var item in methodTwoTableJoin)
            {
                Console.WriteLine($"Name={item.StudentName} Address={item.StudentAddress}");
            }

            Console.WriteLine("-------------------------------");

            var queryTwoTableJoin = (from std in student
                                    join addr in address
                                    on std.StudentId equals addr.AddressId
                                    select new
                                    {
                                        StudentName=std.Name,
                                        StudentAddress=addr.HomeAddress
                                    }).ToList();

            foreach (var item in methodTwoTableJoin)
            {
                Console.WriteLine($"Name={item.StudentName} Address={item.StudentAddress}");
            }

            Console.WriteLine("-----------------------------");

            //Join Three Table

            var joinThreeTable = (from std in student
                                  join addr in address
                                  on std.StudentId equals addr.AddressId
                                  join mrk in mark
                                  on std.StudentId equals mrk.MarkId
                                  select new
                                  {
                                      StudentName = std.Name,
                                      StudentAddress = addr.HomeAddress,
                                      StudentMark=mrk.Mark
                                  }).ToList();

            foreach (var item in joinThreeTable)
            {
                Console.WriteLine($"Name={item.StudentName} Address={item.StudentAddress} Mark={item.StudentMark}");
            }
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
    }
    class Address
    {
        public int Id { get; set; }
        public string HomeAddress { get; set; }
        public int AddressId { get; set; }
    }
    class Marks
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public int MarkId { get; set; }
    }
}
