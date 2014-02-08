namespace SchoolStuff
{
    using System.Collections.Generic;

    public interface ICommentable
    {
        void AddComment(string comment);

        void DeleteCommentAtIndex(int index);

        string GetCommentAtIndex(int index);

        IEnumerable<string> GetAllComments();
    }
}
