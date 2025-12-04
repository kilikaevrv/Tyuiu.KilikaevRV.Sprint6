using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint6.Task3.V20.Lib;

namespace Tyuiu.KilikaevRV.Sprint6.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                {-14, 17, -19, 3, 2},
                {-4, -14, -19, -9, -1},
                {1, 0, 13, 14, 8},
                {13, 7, 8, -3, -15},
                {2, -20, 12, -14, 4}
            };

            int[,] result = ds.Calculate(matrix);

            // Проверяем размеры
            Assert.AreEqual(5, result.GetLength(0));
            Assert.AreEqual(5, result.GetLength(1));

            // Проверяем, что пятая строка изменена правильно
            // Исходная пятая строка: [2, -20, 12, -14, 4]
            // Четные: 2, -20, 12, -14, 4 → все должны стать 0

            Assert.AreEqual(0, result[4, 0]);  // было 2
            Assert.AreEqual(0, result[4, 1]);  // было -20
            Assert.AreEqual(0, result[4, 2]);  // было 12
            Assert.AreEqual(0, result[4, 3]);  // было -14
            Assert.AreEqual(0, result[4, 4]);  // было 4

            // Проверяем, что остальные строки не изменились
            Assert.AreEqual(-14, result[0, 0]);
            Assert.AreEqual(17, result[0, 1]);
            Assert.AreEqual(-19, result[0, 2]);
            Assert.AreEqual(3, result[0, 3]);
            Assert.AreEqual(2, result[0, 4]);

            Assert.AreEqual(1, result[2, 0]);
            Assert.AreEqual(0, result[2, 1]);
            Assert.AreEqual(13, result[2, 2]);
            Assert.AreEqual(14, result[2, 3]);
            Assert.AreEqual(8, result[2, 4]);
        }
    }
}