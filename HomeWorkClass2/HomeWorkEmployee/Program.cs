using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Antonov", "Vitalii");
            employee.Post = "developer";
            employee.Exp = 2;

            Console.WriteLine("Salary {0} {1}, {2}", employee.Name, employee.FamilyName, employee.Post.ToUpper());
            employee.ShowSalary();

            Console.ReadKey();
        }
    }
}
