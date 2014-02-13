namespace Bank
{
    using System;

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

        public decimal Balance
        {
            get
            {
                /* Do a rights check */
                return this.balance;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

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

        public virtual decimal CalculateInterest(int months)
        {
            return this.InterestRate * months;
        }
    }
}