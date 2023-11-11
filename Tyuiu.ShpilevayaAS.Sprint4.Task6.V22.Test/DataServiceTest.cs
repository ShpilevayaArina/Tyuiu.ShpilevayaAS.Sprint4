using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint4.Task6.V22.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint4.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var weather = new string[] { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };
            string[] res = ds.Calculate(weather);
            string[] wait = { "Снег", "Град", "Туча" };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
