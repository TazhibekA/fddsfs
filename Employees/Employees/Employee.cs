using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        public Employee(int id,string lastName, string name, Positions position)
        {
            Id = id;
            LastName = lastName;
            Name = name;
            Position = position;
        }

        public Employee()
        {
        }
        public   int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public Positions Position { get; set; }

   

    }
}
