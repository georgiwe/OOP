using System;
using System.Collections.Generic;

public class GSMCallHistoryTest
{
    public static void RunTest()
    {
        GSM gsm = new GSM("iPhone", "Apple Inc.", 500m, "Kotooshu", new Battery(), new Display());

        gsm.MakeCall("+359883444998", 54);
        gsm.MakeCall("+359888360067", 41);
        gsm.MakeCall("+359000000000", 143);
        gsm.MakeCall("+174374737", 8);

        gsm.DisplayCallInfo();

        Console.WriteLine("{0} {1}","Total Cost:", gsm.CalculateTotalCost(0.37m).ToString("C"));

        int longestCallIndex = GetLongestCallIndex(gsm);

        gsm.DeleteCalls(longestCallIndex);

        Console.WriteLine("{0} {1}", "Total Cost:", gsm.CalculateTotalCost(0.37m).ToString("C"));

        gsm.ClearCallLog();
        gsm.DisplayCallInfo();
    }

    public static int GetLongestCallIndex(GSM gsm)
    {
        int maxDur = 0;
        int maxDurInd = 0;
        var calls = gsm.CallsList;

        for (int i = 0; i < calls.Count; i++)
        {
            if (calls[i].Duration > maxDur)
            {
                maxDur = calls[i].Duration;
                maxDurInd = i;
            }
        }

        return maxDurInd;
    }
}