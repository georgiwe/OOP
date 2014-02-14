namespace Bank
{
    public class Loan : Account, IDepositable
    {
        public Loan(Customer cust, decimal balance, decimal rate)
            : base(cust, balance, rate)
        {
        }

        public void DepositAmount(decimal amount)
        {
            Account.IsAmountNegative(amount);

            this.Balance += amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (months <= 2)
            {
                return 0;
            }

            if (!this.Customer.IsCompany && months <= 3)
            {
                return 0;
            }

            return base.CalculateInterest(months - 3);
        }
    }
}
