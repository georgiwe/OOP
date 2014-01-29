using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class GSM
{
    private static GSM iPhone4s = new GSM("iPhone", "Apple Inc.", 600m, "William Gates",
                                          new Battery(500, 200, BatteryType.LiIon),
                                          new Display(7.1f, "65 Gigamillion"));
    private string model;
    private string manufacturer;
    private decimal? price;
    private string owner;

    private Battery battery;
    private Display display;

    private List<Call> callsMade;

    public GSM(string model, string manufacturer)
        : this(model, manufacturer, null, null, null, null)
    {
    }

    public GSM(string model, string manufacturer, decimal? price)
        : this(model, manufacturer, price, null, null, null)
    {
    }

    public GSM(string model, string manufacturer, decimal? price, string owner)
        : this(model, manufacturer, price, owner, null, null)
    {
    }

    public GSM(string model, string manufacturer, decimal? price, string owner, Battery batt)
        : this(model, manufacturer, price, owner, batt, null)
    {
    }

    public GSM(string model, string manufacturer,
        decimal? price, string owner, Battery batt, Display display)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.Owner = owner;

        this.battery = batt;
        this.display = display;

        this.callsMade = new List<Call>();
    }

    public void MakeCall(string number, int duration)
    {
        if (string.IsNullOrEmpty(number) ||
            string.IsNullOrWhiteSpace(number) ||
            number.Length < 6)
            throw new ArgumentException("Invalid phone number");

        bool invalid = Regex.IsMatch(number, @"[^\d\+]", RegexOptions.IgnoreCase);

        if (number[0] != '+' || invalid) throw new ArgumentException(
            "The number should be in the fromat +XXXXXXXXX, where X represents a digit.");

        if (duration < 0) throw new ArgumentException("Call duration cannot be negative");

        this.callsMade.Add(new Call(DateTime.Now, number, duration));
    }

    public List<Call> CallsList
    {
        // Returns a new List, to protect the actual callsMade list,
        // since a List is a referrence type and it can be changed by referrence.
        get { return new List<Call>(this.callsMade); }
    }

    public int CallCount
    {
        get { return this.callsMade.Count; }
    }
    
    public void DeleteCalls(string number)
    {
        for (int i = 0; i < this.callsMade.Count; i++)
        {
            if (this.callsMade[i].DialedNumber == number) this.callsMade.RemoveAt(i);
        }
    }

    public void DeleteCalls(int index)
    {
        if (index < 0 || index >= this.callsMade.Count)
        {
            throw new IndexOutOfRangeException("Invalid call index.");
        }

        this.callsMade.RemoveAt(index);
    }

    public void ClearCallLog()
    {
        this.callsMade.Clear();
    }

    public decimal CalculateTotalCost(decimal pricePerCall)
    {
        decimal totalCost = 0;

        for (int i = 0; i < this.callsMade.Count; i++)
            totalCost += pricePerCall * ((decimal)this.callsMade[i].Duration / 60);

        return totalCost;
    }

    public void DisplayCallInfo()
    {
        if (this.callsMade.Count == 0)
        {
            Console.WriteLine("There are no calls in the call log.");
            return;
        }

        for (int i = 0; i < this.callsMade.Count; i++)
            Console.WriteLine(this.callsMade[i]);
    }

    public static GSM IPhone4S
    {
        get { return iPhone4s; }
    }

    public string Model
    {
        get { return this.model; }

        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Please enter a valid model");
            }

            this.model = value;
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }

        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Please enter a valid manufacturer");
            }

            this.manufacturer = value;
        }
    }

    public decimal? Price
    {
        get { return this.price; }

        private set
        {
            if (value < 0) throw new ArgumentException("The price cannot be negative");

            this.price = value;
        }
    }

    public string Owner
    {
        get { return this.owner; }

        private set
        {
            if (value != null && (value == "" || Regex.IsMatch(value, @"^ +$")))
            {
                throw new ArgumentException("Please enter a valid identification");
            }

            this.owner = value;
        }
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        var model = this.Model;
        var manufact = this.Manufacturer;
        var owner = this.Owner;

        result.AppendLine(string.Format("{0} {1}", "Phone model:", model));
        result.AppendLine(string.Format("{0} {1}", "Phone manufacturer:", manufact));

        if (this.owner != null) result.AppendLine(string.Format("{0} {1}", "Phone owner:", owner)).AppendLine();
        if (this.battery != null) result.Append(this.battery.ToString()).AppendLine();
        if (this.display != null) result.Append(this.display.ToString()).AppendLine();
        
        return result.ToString();
    }
}