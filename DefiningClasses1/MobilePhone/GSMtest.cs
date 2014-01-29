using System;

class GSMtest
{
    private static GSM[] testers;

    public static void RunTest()
    {
        testers = new GSM[]
        {
             new GSM("K500i", "SonyEricsson", 100m, "Pawn shop", new Battery(), new Display()),
             new GSM("WTF11", "NOKIA", 0m, "Lost", new Battery(), new Display()),
             new GSM("FOO", "BAR", 1000000m, "London museum of Contemporary Art", new Battery(), new Display())
        };

        for (int i = 0; i < testers.Length; i++)
            Console.WriteLine(testers[i]);
    }
}