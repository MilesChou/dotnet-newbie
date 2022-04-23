using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Course02Tests;

public class Tests
{
    private static readonly DateTime Holiday = new DateTime(2022, 4, 23);
    private static readonly DateTime WorkingDay = new DateTime(2022, 4, 22);
    private const bool Sunny = true;
    private const bool Raining = false;
    private const int HotTemperature = 30;
    private const int ColdTemperature = 29;


    [SetUp]
    public void Setup()
    {
    }


    [Test]
    public void 當假日且溫度大於30_要外出去游泳()
    {
        // 不管天氣好不好，反正就是要去游泳
        Assert.AreEqual("今天外出，去游泳", Course02.Course02.HowAbout(Holiday, HotTemperature, Sunny));
        Assert.AreEqual("今天外出，去游泳", Course02.Course02.HowAbout(Holiday, HotTemperature, Raining));
    }

    [Test]
    public void 當假日且溫度小於29_要外出去爬山()
    {
        // 不管天氣好不好，反正就是要去爬山
        Assert.AreEqual("今天外出，去爬山", Course02.Course02.HowAbout(Holiday, ColdTemperature, Sunny));
        Assert.AreEqual("今天外出，去爬山", Course02.Course02.HowAbout(Holiday, ColdTemperature, Raining));
    }

    [Test]
    public void 當假日且天氣好_要工作去客戶單位談業務()
    {
        // 不管天氣熱不熱，反正就是要去客戶單位談業務
        Assert.AreEqual("今天工作，去客戶單位談業務", Course02.Course02.HowAbout(WorkingDay, ColdTemperature, Sunny));
        Assert.AreEqual("今天工作，去客戶單位談業務", Course02.Course02.HowAbout(WorkingDay, HotTemperature, Sunny));
    }

    [Test]
    public void 當假日且天氣爛_要工作在公司上網查資料()
    {
        // 不管天氣熱不熱，反正就是要在公司上網查資料
        Assert.AreEqual("今天工作，在公司上網查資料", Course02.Course02.HowAbout(WorkingDay, ColdTemperature, Raining));
        Assert.AreEqual("今天工作，在公司上網查資料", Course02.Course02.HowAbout(WorkingDay, HotTemperature, Raining));
    }
}