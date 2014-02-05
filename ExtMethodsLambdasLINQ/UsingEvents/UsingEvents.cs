using System;

public class UsingEvents
{
    private static Random rnd = new Random();

    public static void Main()
    {
        Timer timer = new Timer(4, 1, ChangeCC);

        timer.Tick += OnEachTick;

        timer.Start();

        Console.WriteLine();

        timer.Interval = 2;
        timer.Executions = 2;
        timer.Start();

        Console.ResetColor();

        timer.Tick -= OnEachTick;
    }

    private static void OnEachTick(object sender, TickEventArgs eventArgs)
    {
        Console.WriteLine("A tick occured at {0:HH:mm:ss}.", eventArgs.Time);
    }

    private static void ChangeCC(object sender, TickEventArgs eventArgs)
    {
        Console.ForegroundColor = GetRandomConsoleColor();
    }

    private static ConsoleColor GetRandomConsoleColor()
    {
        var consoleColors = Enum.GetValues(typeof(ConsoleColor));
        ConsoleColor rndCol = (ConsoleColor)consoleColors.GetValue(rnd.Next(consoleColors.Length));

        while (rndCol == ConsoleColor.DarkBlue ||
            rndCol == ConsoleColor.Black ||
            rndCol == ConsoleColor.Blue)
        {
            rndCol = (ConsoleColor)consoleColors.GetValue(rnd.Next(consoleColors.Length));
        }

        return rndCol;
    }
}