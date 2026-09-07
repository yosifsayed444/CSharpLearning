using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal partial class Employee
    {
        public Employee()
        {
            Console.WriteLine("Employee created.");
        }
        public void DisplayEmployeeInfo()
        {
            
        }
        public decimal CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }
}
