using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_1
{
    public class Employee
    {
        public string Name { get; set; }
        public int IdNumber { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public Employee()
        {
            Name = string.Empty;
            Department = string.Empty;
            Position = string.Empty;
            IdNumber = 0;
        }

        public Employee(string name, int id)
        {
            Name = name;
            IdNumber = id;
            Department = string.Empty;
            Position = string.Empty;
        }

        public Employee(string name, int id, string department, string position)
        {
            Name = name;
            IdNumber = id;
            Department = department;
            Position = position;
        }
    }
}
