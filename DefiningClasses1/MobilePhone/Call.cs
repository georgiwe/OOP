using System;
using System.Text;
using System.Text.RegularExpressions;

public class Call
{
    private DateTime date;
    private string dialedNumber;
    private int duration;

    public Call(DateTime dateTime, string number, int duration)
    {
        this.TimeDate = dateTime;
        this.DialedNumber = number;
        this.Duration = duration;
    }

    public DateTime TimeDate
    {
        get { return this.date; }
        
        private set 
        {
            if (value > DateTime.Now) throw new ArgumentException("Call time cannot be in the future");
            
            this.date = value;
        }
    }

    public string DialedNumber
    {
        get { return this.dialedNumber; }
        
        private set 
        {
            this.dialedNumber = value;
        }
    }

    public int Duration
    {
        get { return this.duration; }
        private set { this.duration = value; }
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        var date = this.TimeDate.Date.ToShortDateString();
        var time = this.TimeDate.ToString("HH:mm:ss");
        var number = this.DialedNumber;
        var duration = String.Format("{0} min, {1} sec", this.Duration / 60, this.Duration % 60);

        result.AppendLine(String.Format("{0} {1}", "Call date:", date));
        result.AppendLine(String.Format("{0} {1}", "Call time:", time));
        result.AppendLine(String.Format("{0} {1}", "Number:", number));
        result.AppendLine(String.Format("{0} {1}", "Call duration:", duration));

        return result.ToString();
    }
}