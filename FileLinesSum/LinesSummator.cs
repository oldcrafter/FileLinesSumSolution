namespace FileLinesSum;

public class LinesSummator
{
	private readonly List<Line> _lines;

    public LinesSummator(List<Line> lines)
	{
		_lines = lines; 
	}

    public int GetIndexOfLineWithMaxSum()
	{
        return _lines.MaxBy(l => l.GetSum()).Index;
    }

    public int[] GetIndexesOfBadLines()
    {
        return _lines.Where(l => l.GetSum() is double.NaN).Select(l => l.Index).ToArray();
    }
}
