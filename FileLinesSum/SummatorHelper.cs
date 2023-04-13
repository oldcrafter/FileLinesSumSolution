namespace FileLinesSum;

public static class SummatorHelper
{
    public static void ToConsole(LinesSummator summator)
    {

        Console.WriteLine("===================  SUMMATOR  ===================");
        for (var i = 0; i < summator.Summs.Length; i++)
            Console.WriteLine("[index : {0}] {1}", i, summator.Summs[i]);
        Console.WriteLine("INDEX OF MAX SUM OF LINES: " + summator.GetIndexOfLineWithMaxSum());
        Console.WriteLine("INDEXEX OF BAD LINES: " + String.Join(",", summator.GetIndexesOfBadLines()));
    }
}
