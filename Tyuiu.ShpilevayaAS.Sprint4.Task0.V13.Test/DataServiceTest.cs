using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint4.Task0.V13.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint4.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int summ = 26;

            Assert.AreEqual(summ, ds.GetSumEvenArrEl(array));
        }
    }
}
