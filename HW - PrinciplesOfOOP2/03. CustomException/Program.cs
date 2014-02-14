namespace CustomException
{
    using System;
    using System.Globalization;

    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 1 || num > 100)
            {
                throw new InvalidRangeException<int>("Value is outside the range", 1, 100);
            }

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var start = new DateTime(1980, 1, 1);
            var end = new DateTime(2013, 12, 31);

            if (date < start || date > end)
            {
                throw new InvalidRangeException<DateTime>("Value is outside the range", start, end);
            }
        }
    }
}
