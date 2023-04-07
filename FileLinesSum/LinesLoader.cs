namespace FileLinesSum;

public class LinesLoader
{
    public string[] Lines => _lines;
    public string FilePath => _filePath;
    
    private string[] _lines;
    private string _filePath;
	
    public LinesLoader(string filePath)
	{
        _filePath= filePath;
        _lines = GetLinesFromFile(_filePath);
	}

    public string[] GetLinesFromFile(string filePath)
    {
        var lines = new List<string>();

        using (var streamReader = new StreamReader(filePath))
        {
            while (streamReader.Peek() >= 0)
            {
                string? line = streamReader.ReadLine();
                if (line is null)
                    lines.Add(string.Empty);
                else lines.Add(line);
            }
        }

        if (lines.Count == 0)
            throw new FileIsEpmtyExeption();

        return lines.ToArray();
    }
}
