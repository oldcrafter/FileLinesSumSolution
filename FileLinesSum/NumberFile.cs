using System.Text;

namespace FileLinesSum;

public class NumberFile
{
    private readonly List<Line> _lines;

    public NumberFile (List<Line> lines)
    {
        _lines = lines;
    }

    public static NumberFile LoadFromFile(string filePath)
    {
        var lines = LoadLinesFromFile(filePath);
        return new NumberFile(lines);
    }

    private static List<Line> LoadLinesFromFile(string filePath)
    {
        return File.ReadAllLines(filePath, Encoding.UTF8)
            .Select((value, index) => new Line(value, index))
            .ToList();
    }

    public int GetIndexOfLineWithMaxSum()
    {
        const int wrongIndex = -1;
        
        return _lines.MaxBy(l => l.GetSum())?.Index ?? wrongIndex;
    }

    public int[] GetIndexesOfBadLines()
    {
        return _lines.Where(l => l.GetSum() is double.NaN)
            .Select(l => l.Index)
            .ToArray();
    }
}
