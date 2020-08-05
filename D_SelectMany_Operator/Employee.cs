using System;
using System.Collections.Generic;
using System.Text;

namespace D_SelectMany_Operator
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> sector { get; set; }
        public List<Programming> Language { get; set; }
    }

    class Programming
    {
        public List<string> Technology { get; set; }
    }
}
