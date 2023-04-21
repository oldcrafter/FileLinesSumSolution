namespace FileLinesSum;

public static class LoaderHelper
{
    public static void ToConsole(LinesLoader loader)
    {
        Console.WriteLine("============= LOAD FROM FILE " + loader.FilePath + " =================");

        loader.Lines.Sort();
        loader.Lines.ForEach(line => Console.WriteLine(line));
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

                FileIsEmptyException.ThrowIfFileIsEmpty(filePath);

                var loader = new LinesLoader(filePath);

                return loader;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("bad file name. input file path again!");
            }
            catch (FileIsEmptyException)
            {
                Console.WriteLine("file is empty. input file path again!");
            }
        }
    }
}
