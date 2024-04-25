using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class Bank_Account
    {
        private double _balance;

        public double Deposit(double amount)
        {
            Console.WriteLine($"simulating a deposit of (amount,0:c)to your account");

            return _balance = amount;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }

}