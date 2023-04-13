namespace FileLinesSum;

public class LinesSummator
{
	public double?[] Summs => GetSummsFromLines();
	private readonly Line[] _lines;

	public LinesSummator(Line[] lines)
	{
		_lines = lines;
	}

	private double?[] GetSummsFromLines()
	{
        var summs = new double?[_lines.Length];

        for (var i = 0; i < _lines.Length; i++)
		{

			var splitedLines = _lines[i].Split();

			if (splitedLines.All(t => t.isNumber()))
				summs[i] = splitedLines.Select(t => t.ToNumber()).Sum();
		}

		return summs;
	}

    public int GetIndexOfLineWithMaxSum()
	{
        var (value, index) = Summs.Select((n, i) => (n, i)).Max();
        return index;
    }

    public int[] GetIndexesOfBadLines()
    {
        return Summs.Select((value, index) => new { value , index })
		.Where(x => x.value is null)
		.Select(x => x.index)
		.ToArray();
    }
}
