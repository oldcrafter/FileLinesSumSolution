namespace FileLinesSum;

public class Combiner
{
    public readonly string FilePath;
    public readonly string[] AllLinesFromFile;
    public readonly double?[] SumsFromAllLines;
    public int IndexOfLineWithMaxSum { get { return CombinerHelper.GetIndexOfLineWithMaxSum(SumsFromAllLines); } }
    public int[] GetIndexesOfBadLines { get { return CombinerHelper.GetIndexesOfBadLines(SumsFromAllLines); } }

    public Combiner(string filePath)
    {
        try
        {
            FilePath = filePath;
            AllLinesFromFile = CombinerHelper.GetAllLinesFromFile(FilePath);
            SumsFromAllLines = CombinerHelper.GetSumsFromAllLines(AllLinesFromFile);
        }
        catch
        {
            throw;
        }
    }
}

