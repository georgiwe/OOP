namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsMain
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Boyd", "Crowder", "483841", "+35928888888", new List<int>(){3, 4, 5, 6}, new Group( "chemistry", 2), "boydc@undrgnd.com"),
                new Student("Billy-Bob", "Crowe", "432444", "+3591122212", new List<int>(){3, 2, 2, 3}, new Group( "math", 2), "bbc@aol.com"),
                new Student("Jeremiah", "Serd", "112006", "+35923213", new List<int>(){3, 2, 2, 3}, new Group( "physics", 3), "jeremiahserd@yahoo.com"),
                new Student("Jedadiah", "Merd", "121212", "+555", new List<int>(){3, 6, 2, 2}, new Group( "math", 4), "jedadiah@abv.bg"),
            };

            // Prob 09
            var studentsFromGR2 = from student in students
                                  where student.GroupNumber == 2
                                  select student;
            // Prob 10
            IEnumerable<Student> again = students
                                        .Where(s => s.GroupNumber == 2);
                                        //.Select(s => s); // degenerate clause

            // Prob11
            IEnumerable<Student> abv = from student in students
                                       where student.Email.Contains("@abv.bg")
                                       select student;

            // Prob 12
            var fromSofia = from student in students
                        where student.Tel.Contains("+3592")
                        select student;

            // Prob 13
            var aSix = from stud in students
                       where stud.Marks.Contains(6)
                       select new { FullName = stud.ToString(), Marks = stud.Marks };

            // Prob 14
            var two2s = from stud in students
                        where stud.Marks.Count - 2 == stud.Marks.RemoveAll(m => m == 2)
                        select stud;
            // Prob 15
            var from2006 = students
                .Where(s => s.FacNum[4] == '0' && s.FacNum[5] == '6');

            // Prob 16
            var groupArray = from stud in students
                             select stud.Group;

            var join = from stud in students
                       join gr in groupArray
                       on stud.Group equals gr
                       where stud.Group.DepartmentName == "math"
                       select new { FullName = stud.ToString(), Group = gr };
        }
    }
}