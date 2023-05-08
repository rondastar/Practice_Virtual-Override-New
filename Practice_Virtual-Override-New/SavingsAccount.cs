using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Virtual_Override_New
{
    internal class SavingsAccount : BankAccount
    {
        double _interest;

        public SavingsAccount(string name, double balance, double interest = .03) : base(name, balance)
        {
            _interest = interest;
        }

        public double Interest { get => _interest; set => _interest = value; }

        public override bool Deposit(double amount)
        {
            bool depositedAmount = base.Deposit(amount);
            if (depositedAmount)
            {
                Balance += (amount * _interest);
            }
            return depositedAmount;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Interest Rate: {_interest * 10}%";
        }
    } // class
} // namespace
