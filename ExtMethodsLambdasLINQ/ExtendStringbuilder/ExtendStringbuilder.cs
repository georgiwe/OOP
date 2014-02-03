using System;
using System.Text;

public class ExtendStringbuilder
{
    public static void Main()
    {
        var test = new StringBuilder("I am a string");

        test = test.Substring(5, 50);

        Console.WriteLine(test);
    }
}