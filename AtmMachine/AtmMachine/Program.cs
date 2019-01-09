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
            Console.WriteLine("Welcome to this ATM.\n");
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
                    Console.WriteLine("\nUnexpected error caught: " + e.Message);
                }
                switch (selection)
                {
                    case 1:
                        //view current balance
                        View();
                        break;
                    case 2:
                        //deposit
                        Console.WriteLine("\nPlease enter your deposit amount.");
                        userInput = Console.ReadLine();
                        decimal.TryParse(userInput, out decimal deposit);
                        try { Deposit(deposit); }
                        catch (Exception e)
                        {
                            Console.WriteLine("Invalid deposit was requested - " + e.Message);
                            Console.WriteLine("Returning to main menu.");
                        }
                        break;
                    case 3:
                        //withdraw
                        Console.WriteLine("\nPlease enter your withdrawal amount.");
                        userInput = Console.ReadLine();
                        decimal.TryParse(userInput, out decimal withdrawal);
                        try { Withdraw(withdrawal); }
                        catch (Exception e)
                        { 
                            Console.WriteLine("Invalid withdrawal was requested - " + e.Message);
                            Console.WriteLine("Returning to main menu.");
                        }
                        break;
                    case 4:
                        //exit
                        continueState = false;
                        break;
                    default:
                        //unexpected menu choice
                        Console.WriteLine("\nInvalid input. Please select either 1, 2, 3, or 4.");
                        break;
                }
            }
        }

        public static decimal Withdraw(decimal amount)
        {
            if(amount < 0)
            {   
                throw new System.ArgumentException("Parameter cannot be negative", "amount");
            }
            if(amount > balance)
            {
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
