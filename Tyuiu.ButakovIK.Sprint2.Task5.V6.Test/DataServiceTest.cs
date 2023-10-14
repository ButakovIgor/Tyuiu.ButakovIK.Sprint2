using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint2.Task5.V6.Lib;

namespace Tyuiu.ButakovIK.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindCard()
        {
            DataService ds = new DataService();
            Assert.AreEqual("туз бубен", ds.FindCardNameAndValue(3, 14));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(-1, 5);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(5, 15);
            });
        }
    }
}
