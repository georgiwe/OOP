namespace AnimalKingdom
{
    public class Frog : Animal
    {
        public Frog(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Ribbit!");
        }
    }
}
