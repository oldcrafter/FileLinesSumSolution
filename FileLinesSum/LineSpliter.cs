namespace FileLinesSum;

public class LineSpliter
{
    public string[] SplitedLine => _splitedLine;

    private readonly string NumberDelimiter = ",";
    private readonly string DecimalDelimiter = ".";
    private string[] _splitedLine;

    public LineSpliter(string line)
    {
        _splitedLine = line.Split(NumberDelimiter)
            .Select(p => p.Trim().Replace(DecimalDelimiter, ","))
            .ToArray();
    }
    
}
