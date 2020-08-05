using System;
using System.Collections.Generic;
using System.Linq;

namespace D_SelectMany_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() {"Zakir","Zahid" };

            var query = (from name in names
                         from ch in name
                         select ch).ToList();
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            var method = names.SelectMany(ch => ch).ToList();
            foreach (var item in method)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------");
            List<Employee> employee = new List<Employee>()
            {
                new Employee(){Id=0, Name="Zakir", sector=new List<string>(){"Front-End","Back-End","Database" } },
                new Employee(){Id=1, Name="Keya", sector=new List<string>(){"Front-End","Mobile","Server" } },
                new Employee(){Id=2, Name="Jewel", sector=new List<string>(){"Mobile","Marketing","UI" } }
            };

            var methodResult = employee.SelectMany(x => x.sector).ToList();
            foreach(var item in methodResult)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");

            var queryResult = (from emp in employee
                               from sec in emp.sector
                               select sec).ToList();

            foreach (var item in queryResult)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------");
            List<Employee> person = new List<Employee>()
            {
                new Employee(){Id=0, Name="Zakir", Language=new List<Programming>(){ new Programming() { Technology = new List<string>() { "C#", "C++", "Java" } } } },
                new Employee(){Id=1, Name="Zahid", Language=new List<Programming>(){ new Programming() { Technology = new List<string>() { "Java", "JavaScript", "C" } } } },
                new Employee(){Id=2, Name="Jewel", Language=new List<Programming>(){ new Programming() { Technology = new List<string>() { "Python", "C++", "Asp" } } } },
                new Employee(){Id=3, Name="Sohel", Language=new List<Programming>(){ new Programming() { Technology = new List<string>() { "C#", "Angular", "Dart" } } } },

            };

            var queryClass = (from obj in person
                              from lang in obj.Language
                              from tech in lang.Technology
                              select tech).ToList();
            foreach (var item in queryClass)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------");
            var methodClass = person.SelectMany(x => x.Language).SelectMany(x => x.Technology).ToList();
            foreach (var item in methodClass)
            {
                Console.WriteLine(item);
            }


       }
    }
}
