using System;

namespace AtmMachine
{
    public class Program
    {
        public static decimal balance = 2000.00M;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Withdraw(-10);
            Withdraw(999.99M);
            Withdraw(999);
            Withdraw(10);
        }

        public static decimal Withdraw(decimal amount)
        {
            if(amount < 0)
            {
                Console.WriteLine("Invalid withdrawal amount of $" + amount + " was requested. Please make only non-negative withdrawals. Returning to main menu.");
                return balance;
            }
            if(amount > balance)
            {
                Console.WriteLine("Insufficient funds. A withdrawal of $" + amount + " was requested, but there is only $" + balance + " in the account. Returning to main menu.");
                return balance;
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Withdrawal of $" + amount + " was successful. You have $" + balance + " left in this account.");
                return balance;
            }
        }
        public static decimal Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalid withdrawal amount of $" + amount + " was requested. Please make only non-negative withdrawals. Returning to main menu.");
                return balance;
            }
            else
            {
                balance += amount;
                Console.WriteLine("Deposit of $" + amount + " was successful. You have $" + balance + " left in this account.");
                return balance;
            }
        }
    }
}
