namespace AnimalKingdom
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Launch
    {
        public static void Main()
        {
            Dog[] dogArr =
            {
                new Dog("Sharo", 4, true),
                new Dog("Balkan", 5, true),
                new Dog("La Chupacabra", 1, false)
            };

            Cat[] cats = new Cat[]
            {
                new Tomcat("Tom", 5),
                new Kitten("Fluff", 4),
                new Tomcat("Topcat", 4)
            };

            Frog[] frogs =
            {
                new Frog("Frogger", 1, true),
                new Frog("Frogmeister", 1, true),
                new Frog("Frogette", 1, true)
            };

            //Tomcat[] tomcats =
            //{
            //    new Tomcat("Tom", 5),
            //    new Tomcat("Silvester", 4),
            //    new Tomcat("Topcat", 4)
            //};

            //Kitten[] kittens =
            //{
            //    new Kitten("Kittycat", 3),
            //    new Kitten("Pussycat", 2),
            //    new Kitten("Fluff", 4),
            //};

            double dogAvgAge = Animal.GetAvgAge(dogArr);
            double catAvgAge = Animal.GetAvgAge(cats);
            double frgAvgAge = Animal.GetAvgAge(frogs);

            Console.WriteLine(dogAvgAge);
            Console.WriteLine(catAvgAge);
            Console.WriteLine(frgAvgAge);
        }
    }
}
