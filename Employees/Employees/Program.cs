using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {

            int sizeListOfEmployee=1;
            Company company = new Company();

            Employee employee = new Employee(1,"Tazhibek","Aknur",Positions.worker);

            company.AddEmployee(employee);
            company.ShowAllEmployees();

            for (int i = 1; i < sizeListOfEmployee; i++) {
                string lastName = Console.ReadLine();
                string name = Console.ReadLine();
                Positions (int)position = Convert.ToInt32(Console.ReadLine());

            }
            Console.ReadLine();
                }

        
    }
}
