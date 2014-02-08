namespace Heirarchy
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, int workHs)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHs;
        }

        public decimal WeekSalary { get; private set; } // who sets the salary?

        public int WorkHoursPerDay { get; private set; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (5M * this.WorkHoursPerDay);
        }
    }
}