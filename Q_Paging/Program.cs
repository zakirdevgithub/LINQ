using System;
using System.Collections.Generic;
using System.Linq;

namespace Q_Paging
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPage = 5;
            do
            {
                Console.WriteLine("Enter Page Number: ");
                if (int.TryParse(Console.ReadLine(), out int pageNumber))
                {
                    var page = GetEmployee().Skip((pageNumber - 1) * totalPage).Take(totalPage);
                    foreach (var item in page)
                    {
                        Console.WriteLine($"Id={item.Id} Name={item.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a Valid Page Number");
                }
            } while (true);

            
        }
        public static List<Employee> GetEmployee()
        {
            return new List<Employee>()
            {
                new Employee(){Id=0, Name="Zakir"},
                new Employee(){Id=1, Name="Keya"},
                new Employee(){Id=2, Name="Zahid"},
                new Employee(){Id=3, Name="Mitu"},
                new Employee(){Id=4, Name="Setu"},
                new Employee(){Id=5, Name="Rozina"},
                new Employee(){Id=6, Name="Jahangir"},
                new Employee(){Id=7, Name="Rubaiya"},
                new Employee(){Id=8, Name="Afsheen"},
                new Employee(){Id=9, Name="Rafi"},
                new Employee(){Id=10, Name="Ariful"},
                new Employee(){Id=11, Name="Ataur"},
                new Employee(){Id=12, Name="Rafiza"},
                new Employee(){Id=13, Name="Joy"},
                new Employee(){Id=14, Name="Sakib"},
                new Employee(){Id=15, Name="Shimu"},
                new Employee(){Id=16, Name="Siam"},
                new Employee(){Id=17, Name="Bithi"},
                new Employee(){Id=18, Name="Tithi"},
                new Employee(){Id=19, Name="Moni"},
                new Employee(){Id=20, Name="Mukta"},
                new Employee(){Id=21, Name="Mamun"},
                new Employee(){Id=22, Name="Amina"},
                new Employee(){Id=23, Name="Sabbir"},
                new Employee(){Id=24, Name="Sakib"},
                new Employee(){Id=25, Name="Sadiul"},
                new Employee(){Id=26, Name="Sadia"},
                new Employee(){Id=27, Name="Jihad"},
                new Employee(){Id=28, Name="Nila"},
                new Employee(){Id=29, Name="Rakib"},
            };
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
