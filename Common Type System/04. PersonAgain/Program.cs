namespace PersonAgain
{
    public class MainClass
    {
        public static void Main()
        {
            var georgi = new Person("Georgi", 25u);
            var gergana = new Person(25u);

            System.Console.WriteLine(georgi);
            System.Console.WriteLine(gergana);
        }
    }
}
