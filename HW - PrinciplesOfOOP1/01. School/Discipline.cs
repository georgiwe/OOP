namespace SchoolStuff
{
    using System;
    using System.Collections.Generic;

    public class Discipline : ICommentable
    {
        public Discipline(string name, int lectures, int exercises)
        {
            this.Name = name;
            this.ExercisesNumber = exercises;
            this.LecturesNumber = lectures;
        }

        public string Name { get; private set; }

        public int ExercisesNumber { get; private set; }

        public int LecturesNumber { get; private set; }

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

        public override string ToString()
        {
            return "Discipline: " + this.Name;
        }
    }
}