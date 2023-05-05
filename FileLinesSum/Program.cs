using FileLinesSum;

var filePath = @"D:\Projects\FileLinesSumSolution\TestFiles\testfile.txt";
var numberFromFile = NumberFile.LoadFromFile(filePath);
var indexOfLineWithMaxSum = numberFromFile.GetIndexOfLineWithMaxSum();
var indexesOfBadLines = numberFromFile.GetIndexesOfBadLines();


Console.WriteLine("indexOfLineWithMaxSum = " + indexOfLineWithMaxSum);
Console.WriteLine(indexesOfBadLines.Aggregate("indexesOfBadLines:", (first, next) => $"{first} {next}"));



