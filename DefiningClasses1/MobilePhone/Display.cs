using System;
using System.Text;
using System.Text.RegularExpressions;

public class Display
{
    private float? size;
    private string numOfColours;

    public Display()
    {
    }

    public Display(float? sizeInches, string numColours)
    {
        this.Size = sizeInches;
        this.NumberOfColours = numColours;
    }

    public float? Size 
    {
        get { return this.size; }

        private set
        {
            if (value < 1 || value > 9) throw new ArgumentException("Display size must be between 1 and 9 inches");

            this.size = value;
        }
    }

    public string NumberOfColours 
    { 
        get { return this.numOfColours; }

        private set
        {
            bool valid = Regex.IsMatch(value, @"^\d+[a-z]*", RegexOptions.IgnoreCase);

            if (valid) this.numOfColours = value;
            else throw new FormatException("Input should start with a digit.");
        }
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        var size = this.Size.ToString();
        var colours = this.NumberOfColours;

        if (this.size != null) result.AppendLine(String.Format("{0} {1} inches", "Display size:", size));
        if (this.NumberOfColours != null) result.AppendLine(String.Format("{0} {1}", "Display colours:", colours));

        return result.ToString();
    }
}