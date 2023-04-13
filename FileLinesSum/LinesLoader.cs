using System.Text;

namespace FileLinesSum;

public class LinesLoader
{
    public string FilePath { get; }
    public string[] Lines => File.ReadAllLines(FilePath, Encoding.UTF8);

    public LinesLoader(string filePath)
	{
        FilePath = filePath;
  	}
}
