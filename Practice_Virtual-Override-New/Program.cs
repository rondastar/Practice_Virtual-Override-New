namespace Practice_Virtual_Override_New
{
    // Ronda Rutherford
    // Practice - Virtual, Overriding, and New
    // May 6, 2023
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount ca = new CheckingAccount("Ronda", 6.54, 50);
            ca.Deposit(500);
            ca.Withdraw(1000);
            SavingsAccount sa = new SavingsAccount("Saver", 1000.50, .03);
            sa.Deposit(500);
            Console.WriteLine(ca.ToString());
            Console.WriteLine(sa.ToString());

        } // Main
    } // class
} // namespace