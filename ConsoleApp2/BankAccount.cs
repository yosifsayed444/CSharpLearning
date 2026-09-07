using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class BankAccount
    {
        public BankAccount() {

            Console.WriteLine("Constructor is created");
        }

        public BankAccount(string bankName, string accountNumber, string branchName, string branchAddress, decimal balance)
        {
            BankName = bankName;
            AccountNumber = accountNumber;
            BranchName = branchName;
            BranchAddress = branchAddress;
            Balance = balance;
        }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }
        public decimal Balance { get; set; }


        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount:C} to account {AccountNumber}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from account {AccountNumber}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive and less than or equal to the current balance.");
            }
        }
    }
}
