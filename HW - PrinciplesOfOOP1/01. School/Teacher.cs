namespace SchoolStuff
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Person
    {
        private List<Discipline> taughtDiscs;

        public Teacher(string firstName, string lastName, params Discipline[] discs)
            : base(firstName, lastName)
        {
            this.taughtDiscs = new List<Discipline>();
            this.taughtDiscs.AddRange(discs);
        }

        public List<Discipline> AllTaughtDisciplines
        {
            get { return new List<Discipline>(this.taughtDiscs); }
        }
        
        public void AddDiscipline(Discipline disc)
        {
            this.taughtDiscs.Add(disc);
        }

        public void RemoveDiscipline(Discipline disc)
        {
            this.taughtDiscs.Remove(disc);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Teacher name: ");
            sb.AppendLine("   " + this.FirstName + ' ' + this.LastName);
            sb.AppendLine("Taught disciplines: ");

            foreach (var disc in this.taughtDiscs)
            {
                sb.AppendLine("   " + disc.Name);
            }

            return sb.ToString();
        }
    }
}