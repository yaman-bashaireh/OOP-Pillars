namespace Before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.AccNo = "A_123";
            account.Balance = 1000;

            account.Withdraw(500);

            account.Balance = account.Balance - 1500;

            Console.WriteLine(account.Balance);   

            account.Deposit(500);
        }
    }
}
