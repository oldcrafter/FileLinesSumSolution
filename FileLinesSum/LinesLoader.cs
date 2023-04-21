using System.Text;

namespace FileLinesSum;

public class LinesLoader
{
    public string FilePath => _filePath;
    public List<Line> Lines => _lines;

    private readonly string _filePath;
    private List<Line> _lines = new();

    public LinesLoader(string filePath)
	{
        _filePath= filePath;
        LoadLinesFromFile(filePath);
    }

    private void LoadLinesFromFile(string filePath)
    {
        _lines = File.ReadAllLines(_filePath, Encoding.UTF8)
        .Select((value, index) => new Line(value, index))
        .ToList();
    }
}
