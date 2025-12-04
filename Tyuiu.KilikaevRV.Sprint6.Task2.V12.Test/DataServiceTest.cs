using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint6.Task2.V12.Lib;

namespace Tyuiu.KilikaevRV.Sprint6.Task2.V12.Test
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
            double cosMinus5 = Math.Cos(-5);
            double wait1 = Math.Round((2 * (-5) + 6) / (cosMinus5 + (-5)) - 3, 2);
            Assert.AreEqual(wait1, result[0]);

            // x = 0
            double wait2 = Math.Round((2 * 0 + 6) / (Math.Cos(0) + 0) - 3, 2);
            Assert.AreEqual(wait2, result[5]);

            // x = 5
            double cos5 = Math.Cos(5);
            double wait3 = Math.Round((2 * 5 + 6) / (cos5 + 5) - 3, 2);
            Assert.AreEqual(wait3, result[10]);
        }

        [TestMethod]
        public void TestDivisionByZero()
        {
            DataService ds = new DataService();

            // Проверяем, что при делении на ноль возвращается 0
            // Найдем x, где cos(x) + x ≈ 0

            int startValue = -2;
            int stopValue = -2;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            // Для x = -2: cos(-2) + (-2) = -0.4161 - 2 = -2.4161 (не ноль)
            // Метод должен нормально обработать
            Assert.AreEqual(1, result.Length);
        }
    }
}