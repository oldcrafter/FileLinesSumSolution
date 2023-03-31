using FileLinesSum;

namespace TestProject;

public class Tests
{
    [Test]
    public void GetIndexOfLineWithMaxSum_Test()
    {
        var input = new Nullable<double>[] { 5.6, 5.3, 45.0, 58.0 };
        var result = CombinerHelper.GetIndexOfLineWithMaxSum(input);
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void GetIndexOfLineWithMaxSum_Test2()
    {

        var input = new Nullable<double>[] { 5.6, 5.3, 45.0, null, 58.0 };
        var result = CombinerHelper.GetIndexOfLineWithMaxSum(input);
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void GetIndexesOfBadLines_Test()
    {
        var input = new Nullable<double>[] { 5.6, 5.3, 45.0, null, 58.0, null, null };
        var result = CombinerHelper.GetIndexesOfBadLines(input);
        Assert.That(result, Is.EqualTo(new int[] { 3, 5, 6 }));
    }

    [Test]
    public void GetIndexesOfBadLines_Test2()
    {
        var input = new Nullable<double>[] { 5.6, 5.3, 45.0, 58.0 };
        var result = CombinerHelper.GetIndexesOfBadLines(input);
        Assert.That(result, Is.EqualTo(Array.Empty<int>()));
    }
}
