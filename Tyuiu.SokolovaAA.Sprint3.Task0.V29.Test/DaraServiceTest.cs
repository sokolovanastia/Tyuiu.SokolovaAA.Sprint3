﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint3.Task0.V29.Lib;
    
namespace Tyuiu.SokolovaAA.Sprint3.Task0.V29.Test
{
    [TestClass]
    public class DaraServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.293;
            Assert.AreEqual(wait, res);
        }
    }
}
