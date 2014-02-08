namespace AnimalKingdom
{
    public abstract class Animal : ISound
    {
        public Animal(string name, int age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public bool IsMale { get; private set; }

        public virtual void MakeSound()
        {
            System.Console.WriteLine("Animal sound!");
        }
    }
}
