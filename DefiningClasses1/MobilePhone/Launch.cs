using System;

class Launch
{
    static void Main()
    {
        // GSM
        string model = "iPhone";
        string manufacturer = "Apple Inc.";
        decimal price = 600; // USD
        string owner = "Mr. Anderson";

        // Batt
        float battHsIdle = 500f;
        float battHsTalk = 200f;

        // Display
        float dispSizeInches = 7.14f;
        string dispNumColours = "256M";

        Battery batt = new Battery(battHsIdle, battHsTalk, BatteryType.LiIon);
        Display display = new Display(dispSizeInches, dispNumColours);
        GSM gsm = new GSM(model, manufacturer, price, owner, batt, display);

        Console.WriteLine(GSM.IPhone4S);
        
        GSMtest.RunTest();

        Call call = new Call(DateTime.Now, "+359883444998", 71);

        Console.WriteLine(gsm);

        GSMCallHistoryTest.RunTest();
    }
}