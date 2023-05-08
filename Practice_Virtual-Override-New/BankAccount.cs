using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice_Virtual_Override_New
{
    internal class BankAccount
    {
        string _name;
        string _accountNumber;
        double _balance;

        public BankAccount(string name, double balance)
        {
            Random rand = new Random();
            _accountNumber = rand.Next(100000000, 1000000000).ToString();
            _name = name;
            _balance = balance;
        }
        public string Name { get => _name; set => _name = value; }
        public string AccountNumber { get => _accountNumber; }
        public double Balance { get => _balance; protected set => _balance = value; }

        public virtual bool Deposit(double amount)
        {
            if(amount >= 0)
            {
                Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool Withdraw(double amount)
        {
            if (amount >= 0 && _balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType()} - {Name} - {AccountNumber} - Balance: ${Balance}";
        }
    } // class
} // namespace
