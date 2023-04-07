//using System;
//using System.IO;
//using System.Reflection.PortableExecutable;
//namespace FileLinesSum;

//public static class CombinerHelper
//{
//    private static readonly string NumberDelimiter = ",";
//    private static readonly string DecimalDelimiter = ".";

//    public static int GetIndexOfLineWithMaxSum(double?[] summs)
//    {
//        var (value, index) = summs.Select((n, i) => (n, i)).Max();
//        return index;
//    }

//    public static int[] GetIndexesOfBadLines(double?[] summs)
//    {
//        return summs.Select((v, i) => new { v, i })
//        .Where(x => x.v is null)
//        .Select(x => x.i).ToArray();
//    }

//    public static double?[] GetSumsFromAllLines(string[] allLinesFromFile)
//    {
//        var summsFromAllLines = new double?[allLinesFromFile.Length];

//        for (var i = 0; i < allLinesFromFile.Length; i++)
//        {
//            var line = allLinesFromFile[i];
//            var splitedLine = GetSplitedLine(line);
//            var numbersFromLine = GetNumbersFromLine(splitedLine);
//            var sumOfNumbersFromLine = GetSumOfNumbers(numbersFromLine);
//            summsFromAllLines[i] = sumOfNumbersFromLine;
//        }

//        return summsFromAllLines;
//    }

//    public static double? GetSumOfNumbers(double[] numbers)
//    {
//        if (numbers.Length == 0)
//            return null;

//        return numbers.Sum();
//    }

//    //public static string[] GetAllLinesFromFile(string filePath)
//    //{
//    //    List<string> lines = new List<string>();

//    //    try
//    //    {
//    //        using (StreamReader streamReader = new StreamReader(filePath))
//    //        {
//    //            while (streamReader.Peek() >= 0)
//    //            {
//    //                string? line = streamReader.ReadLine();
//    //                if (line is null)
//    //                    lines.Add(string.Empty);
//    //                else lines.Add(line);
//    //            }
//    //        }
//    //    }
//    //    catch 
//    //    {
//    //        throw;
//    //    }

//    //    if (lines.Count == 0)
//    //        throw new FileIsEpmtyExeption();

//    //    return lines.ToArray<string>();
//    //}

//    public static string[] GetSplitedLine(string line)
//    //{
//    //    if (line is null)
//    //       return Array.Empty<string>();
        
//    //    string[] splitedLine = line.Split(NumberDelimiter).Select(p => p.Trim().Replace(DecimalDelimiter, ",")).ToArray();
//    //    return splitedLine;
//    //}

//    public static double[] GetNumbersFromLine(string[] strings)
//    {
//        if (strings.Length == 0)
//            return Array.Empty<double>();

//        var numbers = new List<double>();

//        for (var i = 0; i < strings.Length; i++)
//        {
//            if (double.TryParse(strings[i], out var number))
//                numbers.Add(number);
//            else return Array.Empty<double>();
//        }

//        return numbers.ToArray();
//    }

//    public static void ToConsole(Combiner combiner)
//    {
//        Console.WriteLine("File :" + combiner.FilePath);
//        Console.WriteLine("======================================");
//        Console.WriteLine(String.Join("\n", combiner.AllLinesFromFile));
//        Console.WriteLine("======================================");
//        Console.WriteLine("INDEX OF MAX SUM OF LINES: " + combiner.IndexOfLineWithMaxSum);
//        Console.WriteLine("INDEXEX OF BAD LINES: " + String.Join (",", combiner.GetIndexesOfBadLines));
//    }
//}
