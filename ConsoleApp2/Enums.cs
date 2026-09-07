using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{

    public enum Country
    {
        Egypt,
        Usa,
        Uk,
        Germany,
        France,
        Canada,
        Spain
    }
    public enum Language
    {
        Arabic,
        English,
        French,
        Spanish,
        German
    }

    public enum Status
    {
        Approval,
        Pending,
        Rejected

    }
    public enum  Months :byte
    {
        Jan =1 ,
        Feb =2 ,
        Mar =3 ,
        Apr =4 ,
        May =5 ,
        Jun =6 ,
        Jul =7 ,
        Aug =8 ,
        Sep =9 ,
        Oct =10 ,
        Nov =11 ,
        Dec =12
    }
    public class PersonFromEnum
    {
        public string name { get; set; }

        public decimal salary { get; set; }

        public int hoursWorked { get; set; }
        public int hourlyrate { get; set; }

        public PersonFromEnum(string name, decimal salary, Country country, Language language, Status status, Months months, int hoursWorked, int hourlyrate    )
        {
            this.name = name;
            this.salary = salary;
            Country = country;
            Language = language;
            Status = status;
            Months = months;
            this.hoursWorked = hoursWorked;
            this.hourlyrate = hourlyrate;
        }

        public Country Country { get; set; }

        public Language Language { get; set; }

        public Status Status { get; set; }

        public Months Months { get; set; }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"Language: {Language}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Months: {Months}");
            Console.WriteLine($"Months: {(byte)Months}");
            Console.WriteLine($"Salary after overtime: {OverTime.CalculateOverTime(this, hoursWorked, hourlyrate)}");
        }
    }
    public class OverTime
    {
        public static decimal CalculateOverTime(PersonFromEnum person, decimal hoursWorked, decimal hourlyRate)
        {
            return hoursWorked * hourlyRate + person.salary * 0.1m;
        }
    }
}
