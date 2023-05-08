using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice_Virtual_Override_New
{
    internal class CheckingAccount : BankAccount
    {
        double _overdraftFee;
        public CheckingAccount(string name, double balance, double overdraftFee = 50) : base(name, balance)
        {
            _overdraftFee = overdraftFee;
        }

        public double OverdraftFee { get => _overdraftFee; set => _overdraftFee = value; }

        public override bool Withdraw(double amount)
        {
            bool withdrewAmount = base.Withdraw(amount);
            if (!withdrewAmount)
            {
                Balance -= _overdraftFee;
            }
            return withdrewAmount;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Overdraft Fee: ${OverdraftFee}";
        }
    } // class
} // namespace
