namespace PersonAgain
{
    public class Person
    {
        public Person(string name, uint age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(uint age)
            : this(null, age)
        {
        }

        public string Name { get; private set; }

        public uint Age { get; private set; }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();

            if (this.Name != null)
            {
                sb.AppendFormat("Name: {0}", this.Name);
            }
            else
            {
                sb.Append("Name: Not specified");
            }

            sb.AppendLine();

            sb.AppendFormat("Age: {0}", this.Age);

            return sb.ToString();
        }
    }
}
