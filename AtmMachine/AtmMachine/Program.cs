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
        // Functionality 1-3 return the current balance as a decimal value.
        public static decimal balance = 2000.00M;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this ATM.");
            bool continueState = true;
            while (continueState)
            {
                Console.WriteLine("Please select the number of one of the following: ");
                Console.WriteLine("1. View current balance ");
                Console.WriteLine("2. Deposit funds ");
                Console.WriteLine("3. Withdraw funds ");
                Console.WriteLine("4. Exit");

                string userInput = Console.ReadLine();
                int selection = 0;
                try
                {
                    Int32.TryParse(userInput, out selection);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected error caught: " + e.Message);
                }
                switch (selection)
                {
                    case 1:
                        //view current balance
                        break;
                    case 2:
                        //deposit
                        break;
                    case 3:
                        //withdraw
                        break;
                    case 4:
                        //exit
                        continueState = false;
                        break;
                    default:
                        break;
                }
                continueState = false;
            }
            
        }

        public static decimal Withdraw(decimal amount)
        {
            if(amount < 0)
            {
                Console.WriteLine("Invalid withdrawal amount of $" + amount + " was requested. Please make only non-negative withdrawals. Returning to main menu.");
                throw new System.ArgumentException("Parameter cannot be negative", "amount");
            }
            if(amount > balance)
            {
                Console.WriteLine("Insufficient funds. A withdrawal of $" + amount + " was requested, but there is only $" + balance + " in the account. Returning to main menu.");
                throw new System.ArgumentException("Parameter cannot be less than $" + balance, "amount");
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
                throw new System.ArgumentException("Parameter cannot be negative", "amount");
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
