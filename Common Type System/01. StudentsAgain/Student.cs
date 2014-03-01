namespace StudentsAgain
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string permAddress;
        private string ssn;
        private string phoneNum;
        private string email;
        private uint course;

        public Student(
            string firstName, string middleName, string lastName, string permAddress,
            string ssn, string phoneNum, string email, uint course, Specialty spec,
            University uni, Faculty fac)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.PermAddress = permAddress;
            this.SSN = ssn;
            this.PhoneNumber = phoneNum;
            this.Email = email;
            this.Course = course;
            this.Specialty = spec;
            this.University = uni;
            this.Faculty = fac;
        }

        public Student(Student student)
        {
            this.FirstName = student.FirstName;
            this.MiddleName = student.MiddleName;
            this.LastName = student.LastName;
            this.SSN = student.SSN;
            this.PermAddress = student.PermAddress;
            this.PhoneNumber = student.PhoneNumber;
            this.Email = student.Email;
            this.Course = student.Course;
            this.Specialty = student.Specialty;
            this.University = student.University;
            this.Faculty = student.Faculty;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name cannot be null or whitespace.");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Middle name cannot be null or whitespace.");
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or whitespace.");
                }

                this.lastName = value;
            }
        }

        public string PermAddress
        {
            private get
            {
                return this.permAddress;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Permanent address cannot be null or whitespace.");
                }

                this.permAddress = value;
            }
        }

        public string SSN
        {
            get
            {
                return this.ssn;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("SSN cannot be null or whitespace.");
                }

                this.ssn = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNum;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Phone number cannot be null or whitespace.");
                }

                this.phoneNum = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Email cannot be null or whitespace.");
                }

                this.email = value;
            }
        }

        public uint Course
        {
            get
            {
                return this.course;
            }

            private set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Course needs to be larger than 0.");
                }

                this.course = value;
            }
        }

        public Specialty Specialty { get; private set; }

        public University University { get; private set; }

        public Faculty Faculty { get; private set; }

        public static bool operator ==(Student one, Student two)
        {
            return one.Equals(two);
        }

        public static bool operator !=(Student one, Student two)
        {
            return !(one == two);
        }

        public override bool Equals(object obj)
        {
            var compareWith = obj as Student;

            if (compareWith == null)
            {
                return false;
            }

            if (this.SSN == compareWith.SSN)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int result = 0;

            foreach (var ch in this.FirstName + this.LastName)
            {
                result += ch ^ this.phoneNum[0] ^ 14;
            }

            return result;
        }

        public override string ToString()
        {
            var result = new System.Text.StringBuilder();

            result.AppendFormat("Name: {0} {1} {2}\n", this.FirstName, this.MiddleName, this.LastName);
            result.AppendLine("SSN: " + this.SSN);
            result.AppendLine("Perm address: " + this.PermAddress);
            result.AppendLine("Phone: " + this.PhoneNumber);
            result.AppendLine("Email: " + this.Email);
            result.AppendLine("Course: " + this.Course);
            result.AppendLine("University: " + this.University);
            result.AppendLine("Faculty: " + this.Faculty);
            result.AppendLine("Specialty: " + this.Specialty);

            return result.ToString();
        }

        public object Clone()
        {
            return new Student(this);
        }

        public int CompareTo(Student other)
        {
            var namesOfFirst = this.FirstName + this.MiddleName + this.LastName;
            var namesOfOther = other.FirstName + other.MiddleName + other.LastName;

            if (namesOfFirst == namesOfOther)
            {
                return this.SSN.CompareTo(other.SSN);
            }
            else
            {
                return namesOfFirst.CompareTo(namesOfOther);
            }
        }
    }
}