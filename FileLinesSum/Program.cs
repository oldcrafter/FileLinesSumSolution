using FileLinesSum;

var loader = LoaderHelper.GetLinesLoader();
LoaderHelper.ToConsole(loader);
var lines = loader.Lines.Select(s => new Line(s)).ToArray();
var summator = new LinesSummator(lines);
SummatorHelper.ToConsole(summator);


