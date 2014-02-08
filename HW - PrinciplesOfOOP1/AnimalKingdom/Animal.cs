namespace AnimalKingdom
{
    using System.Collections.Generic;
    using System.Linq;

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

        public static double GetAvgAge(IEnumerable<Animal> arr)
        {
            return (double)arr.Select(x => x.Age).Aggregate((x, y) => x + y) / arr.Count();
        }

        public virtual void MakeSound()
        {
            System.Console.WriteLine("Animal sound!");
        }

        public override string ToString()
        {
            return "Animal sound!";
        }
    }
}