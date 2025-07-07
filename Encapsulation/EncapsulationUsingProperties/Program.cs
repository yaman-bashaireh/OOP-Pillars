namespace EncapsulationUsingProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.AccNo = "A_123";
            Console.WriteLine(account.AccNo);
            Console.WriteLine(account.Balance);
        }
    }
}