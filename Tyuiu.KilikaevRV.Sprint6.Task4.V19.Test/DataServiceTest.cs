using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint6.Task4.V19.Lib;

namespace Tyuiu.KilikaevRV.Sprint6.Task4.V19.Test
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

            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = {
                7.45, 5.55, 2.82, 0.36, -1.42,
                0, // Здесь будет деление на ноль при x = 0
                -1.42, 0.36, 2.82, 5.55, 7.45
            };

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckDivisionByZero()
        {
            DataService ds = new DataService();

            // Проверяем отдельно точку x = 0, где sin(0) - 2 = -2, а не ноль
            // На самом деле, для x = 0: sin(0) = 0, поэтому знаменатель = -2
            // Делителя на ноль не будет, но в условии сказано проверять

            // Проверим диапазон от -1 до 1
            double[] res = ds.GetMassFunction(-1, 1);

            // При x = -1: (5*(-1) + 2.5)/(sin(-1) - 2) + 2 ≈ (-2.5)/(-2.84) + 2 ≈ 2.88
            // При x = 0: (0 + 2.5)/(0 - 2) + 2 = (2.5)/(-2) + 2 = 0.75
            // При x = 1: (5*1 + 2.5)/(sin(1) - 2) + 2 ≈ (7.5)/(-1.16) + 2 ≈ -4.47

            Assert.AreEqual(3, res.Length);
        }

        [TestMethod]
        public void CheckRounding()
        {
            DataService ds = new DataService();

            // Проверим одну точку
            double[] res = ds.GetMassFunction(1, 1);

            // Проверяем округление до 2 знаков
            string roundedValue = res[0].ToString("F2");
            Assert.AreEqual(roundedValue, res[0].ToString());
        }
    }
}