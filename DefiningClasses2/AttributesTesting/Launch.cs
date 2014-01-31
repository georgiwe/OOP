using System;

public class Launch
{
    public static void Main()
    {
        string versionOfSampleClass = SampleClass.GetVersion();

        Console.WriteLine(versionOfSampleClass);
    }
}