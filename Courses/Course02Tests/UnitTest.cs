using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Course02Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    public static IEnumerable<TestCaseData> AllTestCase
    {
        get
        {
            yield return new TestCaseData("今天外出，去游泳", new DateTime(2022, 4, 23), 30, true);
            yield return new TestCaseData("今天外出，去游泳", new DateTime(2022, 4, 23), 30, false);
            yield return new TestCaseData("今天外出，去爬山", new DateTime(2022, 4, 23), 29, true);
            yield return new TestCaseData("今天外出，去爬山", new DateTime(2022, 4, 23), 29, false);
            yield return new TestCaseData("今天工作，去客戶單位談業務", new DateTime(2022, 4, 22), 30, true);
            yield return new TestCaseData("今天工作，去客戶單位談業務", new DateTime(2022, 4, 22), 29, true);
            yield return new TestCaseData("今天工作，在公司上網查資料", new DateTime(2022, 4, 22), 30, false);
            yield return new TestCaseData("今天工作，在公司上網查資料", new DateTime(2022, 4, 22), 29, false);
        }
    }

    [Test]
    [TestCaseSource(nameof(AllTestCase))]
    public void Test1(string expected, DateTime today, int temp, bool isGoodWeather)
    {
        Assert.AreEqual(expected, Course02.Course02.HowAbout(today, temp, isGoodWeather));
    }
}