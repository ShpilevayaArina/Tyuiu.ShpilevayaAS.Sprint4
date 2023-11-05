using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint4.Task2.V26.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint4.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 5, 6, 8, 3, 4, 6, 8, 2, 4, 3, 6, 8, 4 };

            Assert.AreEqual(45, ds.Calculate(numsArray));
        }
    }
}
