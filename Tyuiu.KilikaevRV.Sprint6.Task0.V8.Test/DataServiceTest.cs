using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint6.Task0.V8.Lib;

namespace Tyuiu.KilikaevRV.Sprint6.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 3;
            double result = ds.Calculate(x);
            double wait = 6.425;

            Assert.AreEqual(wait, result);
        }
    }
}