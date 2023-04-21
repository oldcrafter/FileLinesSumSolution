namespace FileLinesSum;

public class LinesSummator
{
	public double?[] Summs => _summs;
	private readonly double?[] _summs;

    public LinesSummator(List<Line> lines)
	{
		_summs = new double?[lines.Count]; 
		GetSummsFromLines(lines);
	}

	private void GetSummsFromLines(List<Line> lines)
	{
		foreach(var line in lines)
			_summs[line.Index] = line.GetSum();
	} 

    public int GetIndexOfLineWithMaxSum()
	{
        var (value, index) = _summs.Select((n, i) => (n, i)).Max();
        return index;
    }

    public int[] GetIndexesOfBadLines()
    {
        return _summs.Select((value, index) => new { value , index })
		.Where(x => x.value is null)
		.Select(x => x.index)
		.ToArray();
    }
}
