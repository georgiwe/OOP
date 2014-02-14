namespace Bank
{
    public class Mortgage : Account, IDepositable
    {
        public Mortgage(Customer cust, decimal balance, decimal rate)
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
            if (this.Customer.IsCompany)
            {
                if (months <= 12)
                {
                    return 0.5m * base.CalculateInterest(months);
                }

                decimal interest = 0.5m * base.CalculateInterest(12);

                interest += base.CalculateInterest(months - 12);

                return interest;
            }
            else
            {
                if (months <= 6)
                {
                    return 0;
                }

                return base.CalculateInterest(months - 6);
            }
        }
    }
}