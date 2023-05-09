using System.Security.Principal;

namespace Practice_Virtual_Override_New
{
    // Ronda Rutherford
    // Practice - Abstract Class (branch of Practice Virtual, Overriding, and New)
    // May 8, 2023
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of bank accounts
            List<BankAccount> accounts = new List<BankAccount>();
            // Create a checking, savings, and retirement account
            CheckingAccount ca = new CheckingAccount("Ronda", 6.54, 50);
            SavingsAccount sa = new SavingsAccount("Saver", 1000.50, .03);
            RetirementAccount ra = new RetirementAccount("Retiree", 10000, .08);
            // Add the accounts to the list of bank accounts
            accounts.Add(ca);
            accounts.Add(sa);
            accounts.Add(ra);
            // Deposit 500 in to all accounts
            Console.WriteLine("Testing Deposit functionality - deposit $500 in each account");
            foreach(BankAccount account in accounts)
            {
                account.Deposit(500);
                Console.WriteLine(account.ToString());
            }
            //Deposit - 50000 into all accounts
            Console.WriteLine("Testing Deposit functionality - deposit -$50000 in each account");
            foreach (BankAccount account in accounts)
            {
                account.Deposit(-50000);
                Console.WriteLine(account.ToString());
            }
            //Withdraw 200 from all accounts
            Console.WriteLine("Testing Withdraw functionality - withdraw $200 from each account");
            foreach (BankAccount account in accounts)
            {
                account.Withdraw(200);
                Console.WriteLine(account.ToString());
            }
            //Withdraw - 200000 from all accounts
            Console.WriteLine("Testing Withdraw functionality - withdraw -$200000 from each account");
            foreach (BankAccount account in accounts)
            {
                account.Withdraw(-200000);
                Console.WriteLine(account.ToString());
            }
            Console.WriteLine("Testing overdraw - withdraw $50000 from each account");
            //Try to overdraw each account
            foreach (BankAccount account in accounts)
            {
                account.Withdraw(50000);
                Console.WriteLine(account.ToString());
            }
        } // Main
    } // class
} // namespace