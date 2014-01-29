using System;
using System.Text;

public enum BatteryType
{
    LiIon,
    NiMH,
    NiCd,
    LiPo
}

public class Battery
{
    private BatteryType battType;
    private float? hoursIdle;
    private float? hoursTalk;

    public Battery()
    {
    }

    public Battery(float? hoursIdle, float? hoursTalk, BatteryType battType)
    {
        this.Type = battType;
        this.HsIdle = hoursIdle;
        this.HsTalk = hoursTalk;
    }

    public BatteryType Type 
    {
        get { return this.battType; }

        // Enumeration, so no need to do checks
        private set { this.battType = value; }
    }

    public float? HsIdle 
    {
        get { return this.hoursIdle; }

        private set
        {
            if (value < 0) throw new ArgumentException("Standby time cannot be a negative number");

            this.hoursIdle = value;
        }
    }

    public float? HsTalk 
    {
        get { return this.hoursTalk; }

        private set
        {
            if (value < 0) throw new ArgumentException("Usage time cannot be a negative number");

            this.hoursTalk = value;
        }
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        var type = this.battType.ToString();
        var idle = this.HsIdle.ToString();
        var talk = this.HsTalk.ToString();

        result.AppendLine(String.Format("{0} {1}", "Battery type:", type));
        result.AppendLine(String.Format("{0} {1}", "Standby (hours):", idle));
        result.AppendLine(String.Format("{0} {1}", "Usage (hours):", talk));

        return result.ToString();
    }
}