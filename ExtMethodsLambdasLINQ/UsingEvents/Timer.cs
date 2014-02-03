using System;
using System.Diagnostics;

public class Timer
{
    public event Action Event;
    private int interval;
    private int executions;

    public Timer(int interval, int executions, Action method) 
        : this(interval, executions)
    {
        this.Event += method;
    }

    public Timer(int interval, int executions)
    {
        this.Executions = executions;
        this.Interval = interval;
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

    public void Subscribe(Action method)
    {
        this.Event += method;
    }

    public void Unsubscribe(Action method)
    {
        this.Event -= method;
    }

    public void RaiseEvent()
    {
        int executed = 0;
        Stopwatch clock = new Stopwatch();
        clock.Start();

        while (executed < this.Executions)
        {
            if (clock.Elapsed.Seconds == this.Interval)
            {
                if (this.Event == null)
                {
                    break;
                }

                this.Event.Invoke();

                clock.Restart();
                executed++;
            }
        }
    }
}