using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association_Aggregation
{
    internal class Department
    {
        // 1. Association Aggregation Relationship   [Has a]
        // Department has Employee or not

        public int Id { get; set; }
        public string Name { get; set; }
        public Employee[]? Employees { get; set; }

        public Department(string name)
        {
            Name = name;
        }

        public Department(string name, Employee[] employees)
        {
            Name = name;
            Employees = employees;
        }

    }
}
