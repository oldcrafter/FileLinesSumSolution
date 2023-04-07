namespace TestProject;

internal class LinesLoaderTest
{
    [Test]
    public void FileNotFoundEx_Test()
    {
        var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
        var path = Path.GetDirectoryName(location);
        var testFilesFolder = @"\TestFiles\";
        var emptyFile = "nofile.txt";
        var filePath = path + testFilesFolder + emptyFile;
        var ex = Assert.Throws<System.IO.FileNotFoundException>(() => { new LinesLoader(filePath); });
    }

    [Test]
    public void FileIsEmptyEx_Test()
    {
        var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
        var path = Path.GetDirectoryName(location);
        var testFilesFolder = @"\TestFiles\";
        var emptyFile = "emptyfile.txt";
        var filePath = path + testFilesFolder + emptyFile;
        var ex = Assert.Throws<FileIsEpmtyExeption>(() => { new LinesLoader(filePath); });
    }
}
