using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint6.Task1.V26.Lib;

namespace Tyuiu.KilikaevRV.Sprint6.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            // Проверяем размер массива
            Assert.AreEqual(11, result.Length);

            // Проверяем несколько значений
            // x = -5
            double wait1 = Math.Round((2 * Math.Cos(-5) + 2) / (2 * (-5) - 1) + Math.Cos(-5) - 5 * (-5) + 3, 2);
            Assert.AreEqual(wait1, result[0]);

            // x = 0
            double wait2 = Math.Round((2 * Math.Cos(0) + 2) / (2 * 0 - 1) + Math.Cos(0) - 5 * 0 + 3, 2);
            Assert.AreEqual(wait2, result[5]);

            // x = 5
            double wait3 = Math.Round((2 * Math.Cos(5) + 2) / (2 * 5 - 1) + Math.Cos(5) - 5 * 5 + 3, 2);
            Assert.AreEqual(wait3, result[10]);
        }

        [TestMethod]
        public void TestDivisionByZero()
        {
            DataService ds = new DataService();

            // x = 0.5 даст деление на ноль, но у нас целые числа
            // Проверим с диапазоном, где может быть деление на ноль
            int startValue = 0;
            int stopValue = 1;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            // При x=0: знаменатель = -1, не ноль
            // При x=1: знаменатель = 1, не ноль
            Assert.AreEqual(2, result.Length);
        }
    }
}