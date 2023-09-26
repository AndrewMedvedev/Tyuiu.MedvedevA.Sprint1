using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevA.Sprint1.Task5.V2.Lib;
namespace Tyuiu.MedvedevA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 15;
            DataService ds = new DataService();
            double res = ds.FahrenheitToСelsius(x);

            int result = Convert.ToInt32(res);

            int wait = -9;
            Assert.AreEqual(wait, result);
        }
    }
}
