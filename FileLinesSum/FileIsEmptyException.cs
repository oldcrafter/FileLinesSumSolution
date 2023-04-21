using System.Text;

namespace FileLinesSum;

public class FileIsEmptyException : Exception
{
    public FileIsEmptyException(string message) : base(message)
    { 
    }

    public static void ThrowIfFileIsEmpty(string filePath)
    {
        if (File.ReadAllLines(filePath, Encoding.UTF8).Count() <= 0)
            throw new FileIsEmptyException("File is empty");
    }
}
