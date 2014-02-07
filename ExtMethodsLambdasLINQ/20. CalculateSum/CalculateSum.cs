namespace CalculateSum
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var res = THEmethod(1, x => Pow(++x, -1m));

            Console.WriteLine(res);
        }

        private static decimal THEmethod(int firstTerm, Func<decimal, decimal> incrN)
        {
            decimal result = 0;
            decimal oldRes = 0;
            decimal diff = 1;
            decimal oldDiff = -1;

            for (decimal cnt = 0, i = firstTerm; cnt < 10000; i = incrN(i), diff = Math.Abs(oldRes - result))
            {
                oldDiff = diff;
                oldRes = result;
                result += i;
                cnt++;
            }

            return result;
        }

        private static decimal Pow(decimal num, decimal pow)
        {
            if (pow == 0) return 1m;
            if (pow == 1) return num;

            bool negative = pow < 0;

            pow = -pow;
            decimal result = num;

            for (int i = 1; i < pow; i++)
            {
                result *= num;
            }

            if (negative) return 1 / result;
            else return result;
        }
    }
}