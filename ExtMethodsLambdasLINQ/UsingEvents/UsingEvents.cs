using System;

class UsingEvents
{
    static void Main()
    {
        Timer timer = new Timer(1, 2, Mthod);
        timer.Subscribe(Method2);

        timer.RaiseEvent();

        timer.Unsubscribe(Method2);

        timer.RaiseEvent();
    }

    private static void Mthod()
    {
        Console.WriteLine("Success!");
    }

    private static void Method2()
    {
        Console.WriteLine("Whaaat?!");
    }
}