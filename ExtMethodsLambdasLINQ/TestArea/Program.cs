namespace MaxLenString
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class MaxLenString
    {
        private static string maxLengthStr;
        private static Random rnd;

        public static void Main()
        {
            rnd = new Random();

            List<string> strArr = new List<string>(10000000);

            for (int i = 0; i < strArr.Capacity; i++)
            {
                strArr.Add(new string('*', rnd.Next(1, 21)));
            }

            maxLengthStr = string.Empty;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            /*var strArrLen = strArr.Max(s => s.Length);

            //var resultMINE = from str in strArr
            //                 where CompareToMax(str)
            //                 select str;

            //var result = strArr.Where(s => CompareToMax(s)); */

            var resultHIS = from str in strArr
                            where str.Length == strArr.Max(sa => sa.Length)
                            //where str.Length == strArrLen
                            select str;

            /*var result = strArr.Where(s => s.Length == strArr.Max(x => x.Length)); // GetMax(strArr)

            //Console.WriteLine("My result: " + resultMINE.Last());*/
            Console.WriteLine("His result: " + resultHIS.First());

            Console.WriteLine("Time: " + sw.Elapsed);
        }

        private static int GetMax(IEnumerable<string> arr)
        {
            int result = 0;

            foreach (var item in arr)
            {
                if (item.Length > result)
                {
                    result = item.Length;
                }
            }

            return result;
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
