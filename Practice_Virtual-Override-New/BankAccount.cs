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
        decimal _balance;

        public BankAccount(string name, decimal balance)
        {
            Random rand = new Random(100000000);
            _name = name;
            _accountNumber = rand.ToString();
            _balance = balance;
        }

        public string Name { get => _name; set => _name = value; }
        public string AccountNumber { get => _accountNumber; }
        public decimal Balance { get => _balance; }
    }
}
