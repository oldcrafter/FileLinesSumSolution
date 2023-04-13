namespace FileLinesSum;

public class FileIsEmptyExeption : Exception
{
    public FileIsEmptyExeption(string message) : base(message)
    { 
    }

    public static void ThrowIfFileIsEmpty(IEnumerable<string> lines)
    {
        if (lines.Any() is false)
            throw new FileIsEmptyExeption("File is empty");
    }
}
