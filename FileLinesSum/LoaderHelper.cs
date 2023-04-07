namespace FileLinesSum;

public static class LoaderHelper
{
    public static void ToConsole(LinesLoader loader)
    {
        Console.WriteLine("============= LOAD FROM FILE " + loader.FilePath + " =================");    
        for (var i = 0; i < loader.Lines.Length; i++)
        {
            Console.WriteLine("[index : " + i + "]" + loader.Lines[i]);
        }
    } 
}
