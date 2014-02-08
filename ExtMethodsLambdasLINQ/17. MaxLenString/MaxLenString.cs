namespace MaxLenString
{
    using System;
    using System.Linq;

    public class MaxLenString
    {
        private static string maxLengthStr;

        public static void Main()
        {
            var strArr = new[] { "999999999", "666666", "55555", "22", "1" };

            maxLengthStr = strArr[0];

            var result = from str in strArr
                         where CompareToMax(str)
                         select str;

            Console.WriteLine(result.First());
        }

        private static bool CompareToMax(string str)
        {
            if (str.Length >= maxLengthStr.Length)
            {
                maxLengthStr = str;
                return true;
            }

            return false;
        }
    }
}
