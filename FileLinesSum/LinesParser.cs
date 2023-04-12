namespace FileLinesSum;

internal class LinesParser
{
    public double[][] ParsedLines => _parsedLines;

	private readonly double[][] _parsedLines;

	public LinesParser(string[] lines)
	{
        _parsedLines = new double[lines.Length][];
		ParseAllLines(lines);
    }

    private void ParseAllLines(string[] lines)
    {
        for(var i = 0; i < lines.Length; i++)
            _parsedLines[i] = ParseLine(lines[i]);
    }

    private double[] ParseLine(string line)
    {
        var splitedLine = SplitLIne(line);
        var numbersFromLine = new List<double>();

        for (var i = 0; i < splitedLine.Length; i++)
            if (double.TryParse(splitedLine[i], out var number))
                numbersFromLine.Add(number);
            else return Array.Empty<double>();

        return numbersFromLine.ToArray();
    }

    private string[] SplitLIne(string line)
    {
        return new LineSpliter(line).SplitedLine;
    }
}
