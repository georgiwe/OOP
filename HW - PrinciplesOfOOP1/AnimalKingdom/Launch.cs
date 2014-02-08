namespace AnimalKingdom
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Launch
    {
        public static void Main()
        {
            Dog[] dogArr = new Dog[]
            {
                new Dog("Sharo", 4, true),
                new Dog("Balkan", 5, true),
                new Dog("La Chupacabra", 1, false)
            };

            Kitten[] kittens = new Kitten[]
            {
                new Kitten("Kittycat", 3),
                new Kitten("Pussycat", 2),
                new Kitten("Fluff", 4),
            };

            Tomcat[] tomcats = new Tomcat[]
            {
                new Tomcat("Tom", 5),
                new Tomcat("Silvester", 4),
                new Tomcat("Topcat", 4)
            };

            Frog[] frogs = new Frog[]
            {
                new Frog("Frogger", 1, true),
                new Frog("Frogmeister", 1, true),
                new Frog("Frogette", 1, true)
            };

            double dogAvgAge = GetAvgAge(dogArr);
            double kittAvgAge = GetAvgAge(kittens);
            double frgAvgAge = GetAvgAge(frogs);

            Console.WriteLine(dogAvgAge);
            Console.WriteLine(kittAvgAge);
            Console.WriteLine(frgAvgAge);
        }

        private static double GetAvgAge(IEnumerable<Animal> arr)
        {
            return (double)arr.Select(x => x.Age).Aggregate((x, y) => x + y) / arr.Count();
        }
    }
}
