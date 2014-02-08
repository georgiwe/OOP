namespace SchoolStuff
{
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private List<ClassOfStudents> classes;

        public School(string name, params ClassOfStudents[] classes)
        {
            this.Name = name;
            this.classes = new List<ClassOfStudents>();
            this.classes.AddRange(classes);
        }

        public string Name { get; private set; }

        public List<ClassOfStudents> GetAllClasses()
        {
            return new List<ClassOfStudents>(this.classes);
        }

        public void AddCLass(ClassOfStudents classs)
        {
            this.classes.Add(classs);
        }

        public void RemoveClass(ClassOfStudents classs)
        {
            this.classes.Remove(classs);
        }

        public string GetAllTeachers()
        {
            var sb = new StringBuilder(this.Name + "'s teachers:\n\n");

            foreach (var classs in this.classes)
            {
                foreach (var teacher in classs.GetAllTeachers())
                {
                    sb.AppendLine(teacher.ToString());
                }
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            var sb = new StringBuilder(this.Name + "'s classes:\n");

            foreach (var classs in this.classes)
            {
                sb.AppendLine("   " + classs);
            }

            return sb.ToString();
        }
    }
}
