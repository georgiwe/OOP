namespace Grouping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students; // using the same class from ex 09 through 17 via referrence to the assembly

    public class GroupingMain
    {
        public static void Main()
        {
            // Prob 18
            List<Student> students = new List<Student>()
            {
                new Student("Boyd", "Crowder", "483841", "+35928888888", new List<int>() { 3, 4, 5, 6 }, new Group("Chemistry", 2), "boydc@undrgnd.com"),
                new Student("Billy-Bob", "Crowe", "432444", "+3591122212", new List<int>() { 3, 2, 2, 3 }, new Group("Math", 2), "bbc@aol.com"),
                new Student("Jeremiah", "Serd", "112006", "+35923213", new List<int>() { 3, 2, 2, 3 }, new Group("Physics", 3), "jeremiahserd@yahoo.com"),
                new Student("Jedadiah", "Merd", "121212", "+555", new List<int>() { 3, 6, 2, 2 }, new Group("Math", 4), "jedadiah@abv.bg"),
            };

            var groupedByGroupName = from stud in students
                                     group stud by stud.Group.DepartmentName;

            foreach (var group in groupedByGroupName)
            {
                Console.WriteLine(group.Key);

                foreach (Student student in group)
                {
                    Console.WriteLine("   " + student);
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            // Prob 19
            var usingExts = students.GroupBy(s => s.Group.DepartmentName);

            foreach (var group in usingExts)
            {
                Console.WriteLine(group.Key);

                foreach (Student student in group)
                {
                    Console.WriteLine("   " + student);
                }

                Console.WriteLine();
            }
        }
    }
}