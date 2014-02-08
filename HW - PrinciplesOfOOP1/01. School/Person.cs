namespace SchoolStuff
{
    using System;
    using System.Collections.Generic;

    public abstract class Person : ICommentable
    {
        /* Constructor */
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /* Properties */
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public List<string> Comments { get; private set; }

        /* Methods */
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
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
