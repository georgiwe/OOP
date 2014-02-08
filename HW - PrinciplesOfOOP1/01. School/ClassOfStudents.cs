namespace SchoolStuff
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ClassOfStudents : ICommentable
    {
        private List<Teacher> teachers;

        public ClassOfStudents(string id, params Teacher[] teachers)
        {
            this.teachers = new List<Teacher>();
            this.ID = id;
            this.teachers.AddRange(teachers);
        }

        public string ID { get; private set; }

        public List<string> Comments { get; set; }

        public void AddComment(string comment)
        {
            if (this.Comments.Count == 0)
            {
                this.Comments = new List<string>();
            }

            this.Comments.Add(comment);
        }

        public void DeleteCommentAtIndex(int index)
        {
            this.Comments.RemoveAt(index);
        }

        public string GetCommentAtIndex(int index)
        {
            return this.Comments[index];
        }

        public IEnumerable<string> GetAllComments()
        {
            return this.Comments;
        }

        public List<Teacher> GetAllTeachers()
        {
            return new List<Teacher>(this.teachers);
        }

        public void AddTeacher(Teacher teach)
        {
            this.teachers.Add(teach);
        }

        public void RemoveTeacher(Teacher teach)
        {
            this.teachers.Remove(teach);
        }

        public string GetTeachers()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.ID + " teachers:");

            foreach (var teacher in this.teachers)
            {
                sb.AppendLine("   " + teacher);
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return "Class name: " + this.ID;
        }
    }
}
