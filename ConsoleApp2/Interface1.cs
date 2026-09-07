using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    
    internal interface IBasicCarFunctions
    {
        void Start();
        void Stop();
        void Accelerate();
        void Brake();
    }
    internal interface IAdvancedCarFunctions : IBasicCarFunctions
    {
        void TurnOnAirConditioner();
        void TurnOffAirConditioner();
    }
    internal abstract class BasicCarFunctions {

        abstract public void Start();
        abstract public void Stop();


    }

    class Car : IBasicCarFunctions , IAdvancedCarFunctions 
    {
        public Car() { }

        public string Name { get; set; }
        public void Start() { }
        public void Stop() { }
        public void Accelerate() { }
        public void Brake() { }

        public void TurnOnAirConditioner() { }
        public void TurnOffAirConditioner() { }
    }

    class Truck : BasicCarFunctions
    {
        public Truck() { }
        public override void Start() { }
        public override void Stop() { }
    }

    interface IAccountFees 
    { 
        public decimal MonthlyFees { get; set; }
        void BankFees();
        void SendStatementsViaEmail(string email);
        decimal AnnualFees();
    }
    class CurrentAccount : IAccountFees
    {
        public string AccountNumber { get; set; }
        public decimal MonthlyFees { get; set; }
        public void BankFees() 
        {
            Console.WriteLine("Bank fees applied.");
        }
        public void SendStatementsViaEmail(string email) {

            Console.WriteLine($"Sending email {email}");
        }
        public decimal AnnualFees() 
        { 
            decimal annualFees = MonthlyFees * 12;
            return annualFees;
        }
    }
    class SavingsAccount : IAccountFees
    {
        public string AccountNumber { get; set; }
        public decimal MonthlyFees { get; set; }
        public void BankFees()
        {
            Console.WriteLine("Bank fees applied.");
        }
        public void SendStatementsViaEmail(string email)
        {
            Console.WriteLine($"Sending email {email}");
        }
        public decimal AnnualFees()
        {
            decimal annualFees = MonthlyFees * 12;
            return annualFees;
        }
    }
} 