using FileLinesSum;

var loader = LoaderHelper.GetLinesLoader();
LoaderHelper.ToConsole(loader);

var summator = new LinesSummator(loader.Lines);
SummatorHelper.ToConsole(summator);


