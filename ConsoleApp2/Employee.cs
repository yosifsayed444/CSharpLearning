using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Employee
    {
        public Employee()
        {
            salary = 2000;
        }
        public Employee(int s)
        {
            salary = s;
        }
        ~Employee()
        {
            Console.WriteLine("finalizer is called ");

        }

        public const double TAX = 0.03;
        public int salary;
        public string fname;
        public string lname;
        public double wage;
        public double LoggedHours;

        public void PrintData(Employee e)
        {
            Console.WriteLine($"first name is {fname}");
            Console.WriteLine($"last name is {lname}");
            Console.WriteLine($"wage is {wage}");
            Console.WriteLine($"LoggedHours are {LoggedHours}");
            Console.WriteLine($"NetSalary is {CalculateNetSalary(e)}");
        }
        public double CalculateNetSalary(Employee e)
        {
            return  e.wage * e.LoggedHours + (e.wage * e.LoggedHours * Employee.TAX);

        }


    }
}
