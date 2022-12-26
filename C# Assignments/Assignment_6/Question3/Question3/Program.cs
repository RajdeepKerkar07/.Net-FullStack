using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICIBank icici_cust = new ICICIBank(12345678, "ICICI Customer", 50000);
            icici_cust.Withdraw(6000, icici_cust.UnderBalance, icici_cust.BalanceZero);
            icici_cust.Deposit(4000);
            icici_cust.Withdraw(60000, icici_cust.UnderBalance, icici_cust.BalanceZero);

            HDFCBank hdfc_cust = new HDFCBank(14, "HDFC Customer", 44000);
            hdfc_cust.Withdraw(43001, hdfc_cust.UnderBalance, hdfc_cust.BalanceZero);
        
        }
    }
}