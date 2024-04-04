using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class BankAccount
    {
        private double _balance = 0;

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public double Deposit(double amount)
        {
            return Balance += amount;
        }
        public double Withdraw(double amount)
        {
            return Balance -= amount;
        }

        public double GetBalance()
        {
            return Balance;
        }

    }
}
