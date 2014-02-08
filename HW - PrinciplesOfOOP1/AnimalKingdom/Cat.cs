namespace AnimalKingdom
{
    public class Cat : Animal
    {
        public Cat(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Meow!");
        }
    }
}
