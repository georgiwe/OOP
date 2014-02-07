using System;

public class Student
{
    private string first;
    private string last;
    private int age;

    public Student(string first, string last, int age)
    {
        this.FirstName = first;
        this.LastName = last;
        this.Age = age;
    }

    public string FirstName
    {
        get
        {
            return this.first;
        }

        private set
        {
            if (string.IsNullOrEmpty(value) ||
                string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException();
            }

            value = value.Trim();

            this.first = char.ToUpper(value[0]) + value.Substring(1).ToLower();
        }
    }

    public string LastName
    {
        get
        {
            return this.last;
        }

        private set
        {
            if (string.IsNullOrEmpty(value) ||
                string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException();
            }

            value = value.Trim();

            this.last = char.ToUpper(value[0]) + value.Substring(1).ToLower();
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }

        private set
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentException();
            }

            this.age = value;
        }
    }

    public override string ToString()
    {
        return string.Format("{0} {1}", this.first, this.last);
    }
}