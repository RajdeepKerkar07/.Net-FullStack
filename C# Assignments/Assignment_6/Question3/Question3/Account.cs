using System;

namespace Question3
{
    public delegate bool UnderBalance(double amount);
    public delegate bool BalanceZero(double amount);

    public class Account
    {
        public int acNumber;
        public string customerName;
        public double balance;

        public Account(int acNo, string cName, double bal)
        {
            acNumber = acNo;
            customerName = cName;
            balance = bal;
            Console.WriteLine("Account created");
            displayBalance();
        }
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited Rs.{amount}");
            displayBalance();
        }

        public void Withdraw(double amount, UnderBalance ub, BalanceZero bz)
        {
            if (!bz(amount))
            {
                if (!ub(amount))
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrawn Rs.{amount}");
                    displayBalance();
                }
            }
        }

        public void displayBalance()
        {
            Console.WriteLine("-----Printing Details-----");
            Console.WriteLine($"Name: {customerName}, Balance: Rs.{balance} \n");
        }
    }
}
