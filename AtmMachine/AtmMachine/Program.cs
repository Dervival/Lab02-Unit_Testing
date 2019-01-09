using System;

namespace AtmMachine
{
    public class Program
    {
        // This ATM program has the following functionality - 
        // 1. View balance (displays the current value of balance without changing it)
        // 2. Withdraw money
        // 3. Add money
        // 4. Exit
        // Functionality 1-3
        public static decimal balance = 2000.00M;
        public static void Main(string[] args)
        {
            bool continueState = true;
            while (continueState)
            {
                continueState = false;
            }
            
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
                Console.WriteLine("Deposit of $" + amount + " was successful. You currently have $" + balance + " in this account.");
                return balance;
            }
        }
        public static decimal View()
        {
             Console.WriteLine("You currently have $" + balance + " in this account.");
             return balance;
        }
    }
}
