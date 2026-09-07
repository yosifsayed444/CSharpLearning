using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    
    public struct EmployeeStruct
    {
        public string fname;
        public string lname;
        public double wage;
        public double LoggedHours;
        public EmployeeStruct(int id)
        {
            fname = "";
            lname = "";
            wage = 0.0;
            LoggedHours = 0.0;
        }
        public void PrintData(EmployeeStruct e)
        {
            Console.WriteLine($"Employee Name: {e.fname} {e.lname}");
            Console.WriteLine($"Employee Wage: {e.wage}");
            Console.WriteLine($"Employee Logged Hours: {e.LoggedHours}");
            Console.WriteLine($"Employee Total Salary: {e.wage * e.LoggedHours}");
        }
    }
}
