using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint6.Task6.V23.Lib;
using System.IO;

namespace Tyuiu.KilikaevRV.Sprint6.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();

            // Создаём временный файл для теста
            string testFile = "test.txt";
            File.WriteAllText(testFile, "This is test string\nAnother sample text\nNo match here");

            string result = ds.CollectTextFromFile(testFile);

            // Ожидаемый результат: слова с буквой s
            string expected = "This is test string sample";

            Assert.AreEqual(expected, result);

            // Удаляем временный файл
            File.Delete(testFile);
        }

        [TestMethod]
        public void FileNotFoundTest()
        {
            DataService ds = new DataService();
            string result = ds.CollectTextFromFile("nonexistent.txt");
            Assert.AreEqual("Файл не найден", result);
        }
    }
}