namespace Bank
{
    public class Program
    {
        public static void Main()
        {
            Deposit loan = new Deposit(new Customer("wew", false), 130m, 1m);

            loan.DepositAmount(13m);

            loan.WithdrawAmount(13);
        }
    }
}