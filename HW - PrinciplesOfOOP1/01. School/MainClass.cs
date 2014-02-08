namespace SchoolStuff
{
    using System;

    public class MainClass
    {
        public static void Main()
        {
            Teacher teacher = new Teacher(
                "Raylan",
                "Givens",
                new Discipline("Mathematics", 12, 14), 
                new Discipline("Informatics", 12, 14));

            Teacher teacher2 = new Teacher(
                "Art",
                "Mullen",
                new Discipline("Mathematics", 12, 14), 
                new Discipline("Informatics", 12, 14));

            School school = new School(
                "OMG", 
                new ClassOfStudents("11Б клас", teacher),
                new ClassOfStudents("11В клас", teacher2));
        }
    }
}
