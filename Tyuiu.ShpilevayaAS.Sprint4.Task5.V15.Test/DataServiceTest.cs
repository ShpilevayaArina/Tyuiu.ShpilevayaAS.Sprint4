using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint4.Task5.V15.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint4.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 4, 0, 1, -5, -5 }, 
                                          { -6, 2, -6, 3, -6 }, 
                                          { 4, -6, 2, 1, -5 }, 
                                          { 1, -6, 4, -3, -6 }, 
                                          { 1, -6, 2, 2, -5 } }; 
            int res = ds.Calculate(mas2);
            int wait = 27;

            Assert.AreEqual(wait, res);
        }
    }
}
