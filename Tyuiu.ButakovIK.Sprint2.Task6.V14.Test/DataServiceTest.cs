using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint2.Task6.V14.Lib;

namespace Tyuiu.ButakovIK.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindDayOfTheWeekName()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Воскресенье", ds.FindDayName(2, 6));
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1, 366);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1, 8);
            });
        }
    }
}
