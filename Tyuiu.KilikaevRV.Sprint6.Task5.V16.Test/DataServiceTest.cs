using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint6.Task5.V16.Lib;
using System.IO;

namespace Tyuiu.KilikaevRV.Sprint6.Task8.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\Temp\TestData.txt";

            // Создаем тестовый файл
            File.WriteAllText(path, "10.5\n20.3\n30.7\n");

            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(10.5, result[0]);
            Assert.AreEqual(20.3, result[1]);
            Assert.AreEqual(30.7, result[2]);

            // Удаляем тестовый файл
            File.Delete(path);
        }

        [TestMethod]
        public void CheckRounding()
        {
            DataService ds = new DataService();

            string path = @"C:\Temp\TestData2.txt";
            File.WriteAllText(path, "1.23456\n2.34567\n3.45678\n");

            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(1.235, result[0]); // Округление до 3 знаков
            Assert.AreEqual(2.346, result[1]);
            Assert.AreEqual(3.457, result[2]);

            File.Delete(path);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void FileNotFoundTest()
        {
            DataService ds = new DataService();
            ds.LoadFromDataFile(@"C:\NonExistentFile.txt");
        }

        [TestMethod]
        public void EmptyFileTest()
        {
            DataService ds = new DataService();

            string path = @"C:\Temp\EmptyFile.txt";
            File.WriteAllText(path, "");

            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(0, result.Length);

            File.Delete(path);
        }

        [TestMethod]
        public void StatisticsTest()
        {
            DataService ds = new DataService();

            double[] testData = { 1.5, -2.5, 3.5, -4.5, 0 };

            Assert.AreEqual(-1.5, ds.GetSum(testData));
            Assert.AreEqual(-0.3, ds.GetAverage(testData));
            Assert.AreEqual(3.5, ds.GetMax(testData));
            Assert.AreEqual(-4.5, ds.GetMin(testData));
            Assert.AreEqual(2, ds.GetPositiveCount(testData));
            Assert.AreEqual(2, ds.GetNegativeCount(testData));
        }
    }
}