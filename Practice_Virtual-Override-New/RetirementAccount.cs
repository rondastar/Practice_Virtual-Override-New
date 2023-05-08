using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice_Virtual_Override_New
{
    internal class RetirementAccount : SavingsAccount
    {
        public RetirementAccount(string name, double balance, double interest = .03) : base(name, balance, interest)
        {

        }
        public override bool Withdraw(double amount)
        {
            Console.WriteLine("Cannot withdraw from a retirement account");
            return false;
        }

    } // class
} // namespace
