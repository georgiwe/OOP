namespace Bank
{
    public class Customer
    {
        private string name;
        private bool isCompany;

        public Customer(string name, bool isCompany)
        {
            this.Name = name;
            this.IsCompany = isCompany;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException();
                }

                this.name = value;
            }
        }

        public bool IsCompany
        {
            get
            {
                return this.isCompany;
            }

            private set
            {
                this.isCompany = value;
            }
        }
    }
}