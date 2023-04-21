namespace FileLinesSum;

public class Line : IComparable<Line>
{
    public int Index => _index;
    public string Value => _value;
    
    private const string Separator = ",";
    private readonly string _value;
    private readonly int _index;

    public Line(string lineValue, int lineIndex)
    {
        _value = lineValue;    
        _index = lineIndex;
    }

    private Token[] SplitLine()
    {
        return _value.Split(Separator)
            .Select(s => new Token(s.Trim()))
            .ToArray();
    }

    public double GetSum()
    {
        var tokens = SplitLine();

        if (tokens.All(t => t.IsNumber()))
            return tokens.Select(t => t.ToNumber()).Sum();

        return double.NaN;
    }

    public int CompareTo(Line? other)
    {
        if (other is null)
            return 1;
        
        return _index.CompareTo(other.Index);
    }

    public override string ToString()
    {
        return String.Concat("Lineindex : ", _index, " Value : ", _value);
    }
}
