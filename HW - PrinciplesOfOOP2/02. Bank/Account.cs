namespace Bank
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer cust, decimal balance, decimal rate)
        {
            this.customer = cust;
            this.Balance = balance;
            this.InterestRate = rate;
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            private set
            {
                IsAmountNegative(value);

                this.interestRate = value;
            }
        }

        public string CustomerName
        {
            get
            {
                /* Check rights */
                return this.customer.Name;
            }
        }

        protected Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        
        protected decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                IsAmountNegative(value);

                this.balance = value;
            }
        }

        public virtual decimal CalculateInterest(int months)
        {
            return this.InterestRate * months;
        }

        protected static void IsAmountNegative(decimal amount)
        {
            if (amount < 0)
            {
                throw new System.ArgumentException();
            }
        }
    }
}