using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint4.Task3.V18.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint4.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 2, 4, 2, 7, 7 },
                                          { 4, 7, 9, 9, 7 },
                                          { 8, 5, 5, 6, 5 },
                                          { 7, 7, 5, 2, 9 },
                                          { 9, 3, 7, 9, 8 } };
            int res = ds.Calculate(mas2);
            int wait = 8;

            Assert.AreEqual(wait, res);
        }
    }
}
