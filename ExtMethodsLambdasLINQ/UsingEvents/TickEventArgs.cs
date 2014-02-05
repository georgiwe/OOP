using System;

public class TickEventArgs : EventArgs
{
    private readonly int executionsLeft;
    private readonly DateTime time;

    public TickEventArgs(int executionsLeft)
    {
        this.executionsLeft = executionsLeft;
        this.time = DateTime.Now;
    }

    public DateTime Time
    {
        get { return this.time; }
    }
}