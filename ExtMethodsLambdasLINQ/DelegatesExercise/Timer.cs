using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

public delegate void Deleg();

public class Timer
{
    private int interval;
    private int numOfExecutions;
    private Stopwatch clock;
    private Deleg methods;

    public Timer(int interval, int numOfExec, params Deleg[] methods)
    {
        this.Interval = interval;
        this.clock = new Stopwatch();
        this.numOfExecutions = numOfExec;

        for (int i = 0; i < methods.Length; i++)
        {
            this.methods += methods[i];
        }
    }

    public Delegate[] Methods
    {
        get
        {
            var newArr = new Delegate[this.methods.GetInvocationList().Length];
            Array.Copy(this.methods.GetInvocationList(), newArr, this.methods.GetInvocationList().Length);

            return newArr;
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

    public int Executions
    {
        get
        {
            return this.numOfExecutions;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException();
            }

            this.numOfExecutions = value;
        }
    }

    public void AddMethod(Deleg method)
    {
        this.methods += method;
    }

    public void RemoveMethod(Deleg method)
    {
        this.methods -= method;
    }

    public void Execute()
    {
        this.Start();
        int executed = 0;

        while (executed < this.numOfExecutions)
        {
            if (this.Elapsed() == this.Interval)
            {
                this.methods.Invoke();
                this.clock.Restart();
                executed++;
            }
        }

        this.clock.Reset();
    }

    private void Start()
    {
        this.clock.Start();
    }

    private int Elapsed()
    {
        return this.clock.Elapsed.Seconds;
    }

    private void Stop()
    {
        this.clock.Stop();
    }
}