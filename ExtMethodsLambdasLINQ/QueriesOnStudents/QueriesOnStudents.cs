using System;
using System.Linq;
using System.Collections.Generic;

public class QueriesOnStudents
{
    public static void Main()
    {
        Student[] students =  
        {
            new Student("georgi", "prodanov", 25),
            new Student("galena", "radomirova", 23),
            new Student("velizara", "avgustinova", 17),
            new Student("georgi", "stavrev", 25),
            new Student("velizara", "hristova", 23),
            new Student("maria", "prodanova", 24),
            new Student("hristo", "vladimirov", 66)
        };

        var alphabetical = from student in students
                           where student.FirstName.CompareTo(student.LastName) < 0
                           select student;

        var between = from student in students
                      where student.Age >= 18 && student.Age <= 24
                      select student;

        var extMeths = students
            .OrderByDescending(s => s.FirstName)
            .ThenByDescending(s => s.LastName)
            .Select(s => s);

        var linqQueries = from student in students
                          orderby student.FirstName descending, student.LastName descending
                          select student;
    }
}