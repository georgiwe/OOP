namespace Students
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fn;
        private string tel;
        private List<int> marks;
        private Group group;
        private string email;

        public Student(
            string firstName, string lastName, string fn, string tel, List<int> marks, Group group, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacNum = fn;
            this.Tel = tel;
            this.Marks = marks;
            this.Email = email;
            this.Group = group;
        }

        public Group Group
        {
            get
            {
                return this.group;
            }

            set
            {
                this.group = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.NullOrEmpty(value); // TODO: add more checks

                this.email = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.NullOrEmpty(value);

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.NullOrEmpty(value);

                this.lastName = value;
            }
        }

        public string FacNum
        {
            get
            {
                return this.fn;
            }

            set
            {
                this.NullOrEmpty(value);

                this.fn = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }

            set
            {
                this.NullOrEmpty(value); // TODO: Add check for letters

                this.tel = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return new List<int>(this.marks);
            }

            private set
            {
                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.group.GroupNum;
            }

            set
            {
                this.group.GroupNum = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        private void NullOrEmpty(string str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException();
            }
        }
    }
}