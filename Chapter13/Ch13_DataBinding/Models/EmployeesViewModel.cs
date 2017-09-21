using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13_DataBinding.Models
{
    public class EmployeesViewModel
    {
        public HashSet<Employee> Employees { get; set; }

        public EmployeesViewModel()
        {
            Employees = new HashSet<Employee>();
            Employees.Add(new Employee { EmployeeID = 1, FirstName = "Mark", LastName = "Soughs", DOB = new DateTime(1982, 12, 28), Salary = 359340M }); 
            Employees.Add(new Employee { EmployeeID = 2, FirstName = "Job", LastName = "Soughs", DOB = new DateTime(1992, 9, 8), Salary = 53444889M }); 
        }
    }
}
