using FileLinesSum;
//using System.Diagnostics;


var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
var path = Path.GetDirectoryName(location);
var testFilesFolder = @"\TestFiles\";
var goodFile = "testfile.txt";
var filePath = path + testFilesFolder + goodFile;
Console.WriteLine(filePath);

try
{
    var linesLoader = new LinesLoader(filePath);
    LoaderHelper.ToConsole(linesLoader);
    var linesParser = new LinesParser(linesLoader.Lines);
    var linesSummator = new LinesSummator(linesParser.ParsedLines);
    SummatorHelper.ToConsole(linesSummator);

}
catch (FileIsEpmtyExeption)
{
    Console.WriteLine("FILE IS EMPTY!");
}
catch (System.IO.FileNotFoundException)
{
    Console.WriteLine("FILE NOT FOUND!");
}

