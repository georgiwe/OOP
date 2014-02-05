using System;
using System.Diagnostics;

public class Timer
{
    private int interval;
    private int executions;
    private EventHandler<TickEventArgs> tick;

    public Timer(int executions, int interval, params EventHandler<TickEventArgs>[] methods)
        : this(executions, interval)
    {
        this.Executions = executions;
        this.Interval = interval;

        foreach (var method in methods)
        {
            this.Tick += method;
        }
    }

    public Timer(int executions, int interval)
    {
        this.Executions = executions;
        this.Interval = interval;
    }

    public event EventHandler<TickEventArgs> Tick
    {
        add
        {
            Console.WriteLine("Subscribed \"{0}\" to the timer.", value.Method.Name);
            this.tick += value;
        }

        remove
        {
            Console.WriteLine("Unsubscribed \"{0}\" from the timer.", value.Method.Name);
            this.tick -= value;
        }
    }

    public int Executions
    {
        get
        {
            return this.executions;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException();
            }

            this.executions = value;
        }
    }

    public int Interval
    {
        get
        {
            return this.interval;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException();
            }

            this.interval = value;
        }
    }

    public void Start()
    {
        Stopwatch clock = new Stopwatch();
        int executions = 0;
        clock.Start();

        while (executions < this.executions)
        {
            if (clock.Elapsed.Seconds == this.interval)
            {
                this.OnTick(executions);
                executions++;
                clock.Restart();
            }
        }
    }

    protected void OnTick(int executions)
    {
        var e = new TickEventArgs(executions);
        this.tick(this, e);
    }
}