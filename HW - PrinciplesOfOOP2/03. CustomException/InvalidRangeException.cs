namespace CustomException
{
    public class InvalidRangeException<T> : System.ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string msg, T start, T end)
            : base(msg + string.Format(" [{0}, {1}]", start, end))
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException()
            : base()
        {
        }

        public T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            set { this.end = value; }
        }
    }
}
