using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint2.Task4.V15.Lib;

namespace Tyuiu.ButakovIK.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double z = ds.Calculate(10, 5);
            Assert.AreEqual(76825.813, z);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double z = ds.Calculate(10, 484);
            Assert.AreEqual(1.101, z);
        }
    }
}
