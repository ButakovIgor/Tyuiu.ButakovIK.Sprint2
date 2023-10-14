using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint2.Task3.V10.Lib;

namespace Tyuiu.ButakovIK.Sprint2.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double y = ds.Calculate(2);
            Assert.AreEqual(-70.25, y);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double y = ds.Calculate(0);
            Assert.AreEqual(-1, y);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double y = ds.Calculate(-2);
            Assert.AreEqual(0.036, y);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double y = ds.Calculate(-15);
            Assert.AreEqual(-164.933, y);
        }
    }
}
