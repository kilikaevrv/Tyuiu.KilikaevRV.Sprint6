using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint6.Task7.V6.Lib;
using System.IO;

namespace Tyuiu.KilikaevRV.Sprint6.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            // Создаём тестовый CSV файл
            string testFile = "test.csv";
            File.WriteAllText(testFile,
                "1;2;3;4;5\n" +
                "6;7;8;9;10\n" +
                "11;12;13;14;15\n" +
                "16;17;18;19;20\n" +
                "21;22;23;24;25\n" +
                "26;27;28;29;30\n" +  // 6-я строка (индекс 5)
                "1;6;3;6;5\n" +       // 7-я строка (индекс 6) - здесь 6 остаётся, остальное 0
                "31;32;33;34;35");

            int[,] result = ds.GetMatrix(testFile);

            // Проверяем изменения в 7-й строке (индекс 6)
            Assert.AreEqual(0, result[6, 0]); // 1 → 0
            Assert.AreEqual(6, result[6, 1]); // 6 → 6 (остаётся)
            Assert.AreEqual(0, result[6, 2]); // 3 → 0
            Assert.AreEqual(6, result[6, 3]); // 6 → 6 (остаётся)
            Assert.AreEqual(0, result[6, 4]); // 5 → 0

            // Проверяем, что другие строки не изменились
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(10, result[1, 4]);
            Assert.AreEqual(35, result[7, 4]);

            File.Delete(testFile);
        }

        [TestMethod]
        public void ValidSaveMatrixToFile()
        {
            DataService ds = new DataService();

            // Создаём тестовую матрицу
            int[,] matrix = new int[3, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            string savePath = "saved_test.csv";

            // Сохраняем
            ds.SaveMatrixToFile(matrix, savePath);

            // Проверяем, что файл создан
            Assert.IsTrue(File.Exists(savePath));

            // Читаем и проверяем содержимое
            string content = File.ReadAllText(savePath);
            string expected = "1;2;3\r\n4;5;6\r\n7;8;9\r\n";

            // Сравниваем без учёта различий в переносах строк
            string normalizedContent = content.Replace("\r\n", "\n").Replace("\r", "\n");
            string normalizedExpected = expected.Replace("\r\n", "\n").Replace("\r", "\n");

            Assert.AreEqual(normalizedExpected, normalizedContent);

            File.Delete(savePath);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FileNotFoundTest()
        {
            DataService ds = new DataService();
            int[,] result = ds.GetMatrix("nonexistent.csv");
        }

        [TestMethod]
        public void MatrixSmallerThan7Rows()
        {
            DataService ds = new DataService();

            string testFile = "small.csv";
            File.WriteAllText(testFile,
                "1;2;3\n" +
                "4;5;6"); // Только 2 строки

            int[,] result = ds.GetMatrix(testFile);

            // Должна вернуться матрица без изменений
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(6, result[1, 2]);

            File.Delete(testFile);
        }
    }
}