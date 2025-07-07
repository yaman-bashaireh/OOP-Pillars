namespace Readonly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("A_123");

            account.Deposit(1000);

            account.Withdraw(300);

            account.Deposit(-10);

            account.Withdraw(1200);

            account.Deposit(3000);
        }
    }
}
