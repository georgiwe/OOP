namespace MaxLenString
{
    using System;
    using System.Linq;

    public class MaxLenString
    {
        private static string maxLengthStr;

        public static void Main()
        {
            var strArr = new[] { "999999999", "22", "1", "55555", "666666", };

            maxLengthStr = string.Empty;

            var result = from str in strArr
                         where CompareToMax(str)
                         select str;

            Console.WriteLine(result.Last());
        }

        private static bool CompareToMax(string str)
        {
            if (str.Length > maxLengthStr.Length)
            {
                maxLengthStr = str;
                return true;
            }

            return false;
        }
    }
}