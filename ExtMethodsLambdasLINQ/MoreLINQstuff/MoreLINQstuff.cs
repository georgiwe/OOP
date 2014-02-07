using System;
using System.Linq;

public class MoreLINQstuff
{
    public static void Main()
    {
        var nums = new[] { 4, 2, 21, 13, 9, 42, 0, 12 };

        var div7n3 = nums
            .Where(x => x % 21 == 0)
            .Select(x => x);

        var div3n7 = from num in nums
                     where num % 21 == 0
                     select num;
    }
}