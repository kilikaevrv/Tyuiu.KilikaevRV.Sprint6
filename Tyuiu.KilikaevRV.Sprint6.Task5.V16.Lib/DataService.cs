using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KilikaevRV.Sprint6.Task5.V16.Lib
{
    public class DataService : ISprint6Task5V16
    {
        public double[] LoadFromDataFile(string path)
        {
            try
            {
                // Путь к файлу на диске C с правильным именем
                string filePath = @"C:\DataSprint6\InPutDataFileTask5V16.txt";

                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"Файл не найден: {filePath}");
                }

                // Читаем весь файл
                string fileContent = File.ReadAllText(filePath).Trim();

                // Разделяем на числа (поддерживаем разные разделители)
                string[] numberStrings = fileContent.Split(
                    new[] { ' ', ',', ';', '\t', '\n', '\r' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (numberStrings.Length == 0)
                {
                    return new double[0];
                }

                // Конвертируем строки в числа
                double[] result = new double[numberStrings.Length];

                for (int i = 0; i < numberStrings.Length; i++)
                {
                    string numStr = numberStrings[i].Trim().Replace('.', ',');

                    if (double.TryParse(numStr, out double number))
                    {
                        result[i] = Math.Round(number, 3);
                    }
                    else
                    {
                        result[i] = 0;
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка чтения файла: {ex.Message}", ex);
            }
        }

        public double GetSum(double[] array)
        {
            if (array == null || array.Length == 0) return 0;
            return Math.Round(array.Sum(), 3);
        }

        public double GetAverage(double[] array)
        {
            if (array == null || array.Length == 0) return 0;
            return Math.Round(array.Average(), 3);
        }

        public double GetMax(double[] array)
        {
            if (array == null || array.Length == 0) return 0;
            return Math.Round(array.Max(), 3);
        }

        public double GetMin(double[] array)
        {
            if (array == null || array.Length == 0) return 0;
            return Math.Round(array.Min(), 3);
        }

        public int GetPositiveCount(double[] array)
        {
            if (array == null || array.Length == 0) return 0;
            return array.Count(x => x > 0);
        }

        public int GetNegativeCount(double[] array)
        {
            if (array == null || array.Length == 0) return 0;
            return array.Count(x => x < 0);
        }
    }
}