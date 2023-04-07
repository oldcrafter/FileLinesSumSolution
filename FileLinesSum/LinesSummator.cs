namespace FileLinesSum;

public class LinesSummator
{
	private double?[] _summs;
	
	public LinesSummator(double[][] parsedLines)
	{
		_summs = GetSumsOfLines(parsedLines);
	}

	public int GetIndexOfLineWithMaxSum()
	{
        var (value, index) = _summs.Select((n, i) => (n, i)).Max();
        return index;
    }

    public int[] GetIndexesOfBadLines()
    {
        return _summs.Select((v, i) => new { v , i })
		.Where(x => x.v is null)
		.Select(x => x.i).ToArray();
    }


    private double?[] GetSumsOfLines(double[][] values)
	{
		var summs = new double?[values.Length];

		for (var i = 0; i < summs.Length; i++)
			summs[i] = GetSumOfElements(values[i]);

		return summs;
	}

    private double? GetSumOfElements(double[] elements)
    {
        if (elements.Length == 0)
			return null;

		return elements.Sum();
    }
}
