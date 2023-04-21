namespace FileLinesSum;

public static class SummatorHelper
{
    public static void ToConsole(LinesSummator summator)
    {

        Console.WriteLine("===================  SUMMATOR  ===================");
        Console.WriteLine("INDEX OF MAX SUM OF LINES: " + summator.GetIndexOfLineWithMaxSum());
        Console.WriteLine("INDEXEX OF BAD LINES: " + String.Join(",", summator.GetIndexesOfBadLines()));
    }
}
