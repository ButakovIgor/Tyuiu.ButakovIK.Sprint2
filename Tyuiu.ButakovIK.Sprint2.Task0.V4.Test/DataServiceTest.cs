using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint2.Task0.V4.Lib;

namespace Tyuiu.ButakovIK.Sprint2.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(333, 324);
            bool[] wait = new bool[6] { false, true, false, true, false, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
