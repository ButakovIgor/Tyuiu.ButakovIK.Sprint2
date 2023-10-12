using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint2.Task2.V22.Lib;

namespace Tyuiu.ButakovIK.Sprint2.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(5, 5);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
