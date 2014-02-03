using System;

public class DelegatesExercise
{
    public static void Main()
    {
        Timer timer = new Timer(1, 3, Test);

        timer.Execute();

        Console.WriteLine();

        timer.AddMethod(Test2);

        timer.Interval = 2;
        timer.Executions = 2;
        timer.Execute();

        Console.WriteLine();

        timer.RemoveMethod(Test);
        timer.Executions = 3;
        timer.Execute();

        timer.RemoveMethod(Test);
    }

    public static void Test()
    {
        Console.WriteLine("Success!");
    }

    public static void Test2()
    {
        Console.WriteLine("More success!");
    }
}