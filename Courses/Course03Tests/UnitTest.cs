using NUnit.Framework;

namespace Course03Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(1, 2, 3)]
    [TestCase(1, 3, 2)]
    [TestCase(3, 1, 2)]
    [TestCase(2, 3, 1)]
    [TestCase(2, 1, 3)]
    [TestCase(3, 2, 1)]
    public void Test1(float a, float b, float c)
    {
        Assert.AreEqual(2, Course03.Course03.Find(a, b, c));
    }
}