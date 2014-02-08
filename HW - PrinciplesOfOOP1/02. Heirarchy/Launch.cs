namespace Heirarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Launch
    {
        public static void Main()
        {
            var students = new List<Student>
            {
                new Student("Robert", "Angier", 21),
                new Student("Michael", "Caine", 55),
                new Student("Alfred", "Borden", 25),
                new Student("Pete", "Dunham", 21),
                new Student("Matt", "Buckner", 15),
                new Student("Steve", "Dunham", 17),
                new Student("Leo", "Gregory", 17),
                new Student("Jeremy", "van Holden", 15),
                new Student("Richard", "Winters", 25),
                new Student("George", "Luz", 15),
            };

            var workers = new List<Worker>
            {
                new Worker("Donald", "Malarky", 7.77M, 45),
                new Worker("Floyd", "Talbert", 7.77M, 45),
                new Worker("Lewis", "Nixon", 10.55M, 45),
                new Worker("Carwood", "Lipton", 8.44M, 45),
                new Worker("Darrel", "Powers", 7.77M, 45),
                new Worker("Frank", "Perconte", 8.77M, 45),
                new Worker("Edward", "Heffron", 6.38M, 45),
                new Worker("Robert", "Sink", 17.77M, 45),
                new Worker("Warren", "Muck", 8.78M, 45),
                new Worker("Joseph", "Toye", 8.35M, 45),
            };

            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            var sortedStudents = students.OrderBy(x => x.Grade);

            var result = sortedStudents.Concat<Human>(sortedWorkers)
                                       .OrderBy(h => h.FirstName)
                                       .ThenBy(h => h.LastName);
        }
    }
}