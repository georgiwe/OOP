namespace SchoolStuff
{
    public class Student : Person
    {
        public Student(string firstName, string lastName, int num)
            : base(firstName, lastName)
        {
            this.Number = num;
        }

        public int Number { get; private set; }
    }
}