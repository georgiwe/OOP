namespace CalculateSum
{
    using System;

    public class CalculateSum
    {
        public static void Main()
        {
            int digitsAfterDecimal = 4;

            //var res = THEmethod(2, 0, (n, p) => Pow(n, p), (n) => (n) , (p) => (p - 1));

            //var res = THEmethod(1, 1, (n, p) => n / Fact(p), n => n, p => p + 1);

            //var res = THEmethod(-2, -1, (n, p) => -Pow(n, p), n => -n, p => p - 1, 1);

            var res = THEmethod(2, 0, (n, p) => Pow(n, p), n => n, p => p + 1);

            Console.WriteLine("{0:F" + digitsAfterDecimal + "}", res);
        }

        private static decimal THEmethod(
            decimal arg1,
            decimal arg2,
            Func<decimal, decimal, decimal> work, 
            Func<decimal, decimal> change1,
            Func<decimal, decimal> change2,
            decimal defaultStartValue = 0)
        {
            decimal result = defaultStartValue;
            decimal oldRes = 0;
            decimal diff = 0;

            do
            {
                oldRes = result;

                result += work(arg1, arg2);

                arg1 = change1(arg1);
                arg2 = change2(arg2);

                diff = Math.Abs(result - oldRes);
            } while (diff > 0.000000000000000000000000001m);

            return result;
        }

        private static decimal Pow(decimal num, decimal pow)
        {
            if (pow == 0) return 1m;
            if (pow == 1) return num;

            bool negative = pow < 0;

            if (negative) pow = -pow;
            decimal result = num;

            for (int i = 1; i < pow; i++)
            {
                result *= num;
            }

            if (negative) return 1 / result;
            else return result;
        }

        private static decimal Fact(decimal num)
        {
            decimal result = 1;

            for (decimal i = num; i >= 2; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}