namespace FileLinesSum;

public static class LoaderHelper
{
    public static void ToConsole(LinesLoader loader)
    {
        Console.WriteLine("============= LOAD FROM FILE " + loader.FilePath + " =================");    
        for (var i = 0; i < loader.Lines.Length; i++)
        {
            Console.WriteLine("[index : {0}] {1}", i, loader.Lines[i]);
        }
    } 

    public static LinesLoader GetLinesLoader()
    {
        while (true)
        {
            Console.Write("input file path: ");
            var filePath = Console.ReadLine();

            try
            {
                if (string.IsNullOrEmpty(filePath))
                    throw new ArgumentNullException();

                var loader = new LinesLoader(filePath);

                FileIsEmptyExeption.ThrowIfFileIsEmpty(loader.Lines);

                return loader;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("bad file name. input file path again!");
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("filePath is null or empty. input file path again!");
            }
            catch (FileIsEmptyExeption)
            {
                Console.WriteLine("file is empty. input file path again!");
            }
        }
    }
}
