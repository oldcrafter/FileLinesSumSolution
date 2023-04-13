namespace FileLinesSum;

public class Line
{
    private const string Separator = ",";
    private readonly string _line;

    public Line(string line)
    {
        _line = line;    
    }

    public Token[] Split()
    {
        return _line.Split(Separator)
            .Select(s => new Token(s.Trim()))
            .ToArray();
    }
}
