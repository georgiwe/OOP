namespace Bank
{
    public class Deposit : Account, IDepositable, IWithdrawable
    {
        public Deposit(Customer cust, decimal balance, decimal rate)
            : base(cust, balance, rate)
        {
        }
                
        public void DepositAmount(decimal amount)
        {
            Account.IsAmountNegative(amount);

            this.Balance += amount;
        }

        public void WithdrawAmount(decimal amount)
        {
            if (this.Balance < amount)
            {
                throw new System.InvalidOperationException();
            }

            Account.IsAmountNegative(amount);

            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterest(months);
        }
    }
}