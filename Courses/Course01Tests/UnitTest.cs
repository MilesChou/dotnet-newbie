using Courses01;
using NUnit.Framework;

namespace Courses01Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase("分數錯誤，請重新輸入", 101)]
    [TestCase("分數錯誤，請重新輸入", -1)]
    [TestCase("考試優秀", 100)]
    [TestCase("考試優秀", 90)]
    [TestCase("考試良好", 89)]
    [TestCase("考試良好", 80)]
    [TestCase("考試及格", 79)]
    [TestCase("考試及格", 60)]
    [TestCase("下次繼續努力", 59)]
    [TestCase("下次繼續努力", 0)]
    public void TestCourse1(string excepted, int score)
    {
        Assert.AreEqual(excepted, Course01.Grade(score));
    }
}