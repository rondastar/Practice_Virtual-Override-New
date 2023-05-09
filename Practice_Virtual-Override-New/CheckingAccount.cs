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

        public override bool Deposit(double amount)
        {
            if (amount >= 0)
            {
                Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Withdraw(double amount)
        {
            if (amount >= 0 && Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                // Applies overdraft fee if  if withdrawal was attempted with insufficient funds or invalid amount was entered
                Balance -= _overdraftFee;
                return false;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $" - Overdraft Fee: ${OverdraftFee}";
        }
    } // class
} // namespace
