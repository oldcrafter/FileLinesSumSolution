using FileLinesSum;

var filePath = @"D:\Projects\FileLinesSumSolution\testfile.txt";

try
{
    var combiner = new Combiner(filePath);
    CombinerHelper.ToConsole(combiner);
}
catch (LineIsNullExeption)
{
    Console.WriteLine("FILE IS EMPTY!");
}
catch (FileNotFoundException)
{
    Console.WriteLine("FILE NOT FOUND!");
}

