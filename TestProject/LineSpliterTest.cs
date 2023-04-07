namespace TestProject;

internal class LineSpliterTest
{
    [TestCase("5.6, 5.3, 45, 58, 101", new string[] { "5,6", "5,3", "45", "58", "101" })]
    public void LineSpliterTest1(string input, string[] expected)
    {
        var result = new LineSpliter(input).SplitedLine;
        Console.WriteLine(result);
        Assert.That(result, Is.EqualTo(expected));
    }
}
