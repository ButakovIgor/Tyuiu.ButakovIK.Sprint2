using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint2.Task1.V20.Lib;

namespace Tyuiu.ButakovIK.Sprint2.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(242, 155, 456, 17);
            bool[] wait = new bool[6] { false, false, false, true, true, true };
        }
    }
}
