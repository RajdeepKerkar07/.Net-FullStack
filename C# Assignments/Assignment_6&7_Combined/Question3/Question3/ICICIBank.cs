using System;

namespace Question3
{
    public class ICICIBank : Account
    {
        public ICICIBank() : base() { }

        public bool UnderBalance(double amount) { return false; }
        public bool BalanceZero(double amount)
        {
            if (balance <= 0 || balance - amount <=0)
            {
                Console.WriteLine("Transaction cannot be continued as balance is/will be insufficient/zero in Account \n");
                return true;
            }
            else
                return false;
        }
    }
}
