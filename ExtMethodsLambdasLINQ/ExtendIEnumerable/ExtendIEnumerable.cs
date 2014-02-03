using System;
using System.Collections.Generic;

public class ExtendStringbuilder
{
    public static void Main()
    {
        var list = new List<int>(new int[] { 4, 1, 3, 0 });
        var arr = new int[] { 4, 1, 3, 0 };
        var listStr = new List<string>() { "wewe", "Weqew" };

        Console.WriteLine(list.Sum());
        Console.WriteLine(list.Average());
        Console.WriteLine(list.Min());
        Console.WriteLine(list.Max());
    }
}