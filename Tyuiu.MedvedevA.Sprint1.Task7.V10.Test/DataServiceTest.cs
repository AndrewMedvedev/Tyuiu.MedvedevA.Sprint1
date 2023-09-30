using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevA.Sprint1.Task7.V10.Lib;

namespace Tyuiu.MedvedevA.Sprint1.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double wait = 0.75;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
