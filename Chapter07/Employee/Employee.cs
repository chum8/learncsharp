using System;
using static System.Console;

namespace Packt.CS7
{
    public class Employee : Person
    {
        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }
        public new void WriteToConsole()
        {
            WriteLine($"{Name}\n   Birth date : {DateOfBirth:dddd, d MMMM yyyy}\n   Hire Date : {HireDate:dddd, d MMMM yyyy}\n   Badge : {EmployeeCode}");
        }
        public override string ToString()
        {
            return $"{Name}'s code is {EmployeeCode}";
        }
    }
}
