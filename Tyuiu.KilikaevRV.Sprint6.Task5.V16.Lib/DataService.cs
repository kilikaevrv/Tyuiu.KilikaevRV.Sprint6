using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KilikaevRV.Sprint6.Task5.V16.Lib
{
    public class DataService : ISprint6Task5V16
    {
        public int len = 0;

        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                double[] numsArray = new double[100];
                int count = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    if (double.TryParse(line, out double num))
                    {
                        numsArray[count] = num;
                        count++;
                    }
                }

                double[] resultArray = new double[count];
                Array.Copy(numsArray, resultArray, count);
                len = count;

                return resultArray;
            }
        }

        // 1. Сумма элементов
        public double GetSum(double[] array)
        {
            if (array == null || array.Length == 0)
                return 0;

            return array.Sum();
        }

        // 2. Максимальный элемент
        public double GetMax(double[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Массив пуст");

            return array.Max();
        }

        // 3. Минимальный элемент
        public double GetMin(double[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Массив пуст");

            return array.Min();
        }

        // 4. Среднее значение
        public double GetAverage(double[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Массив пуст");

            return array.Average();
        }

        // 5. Количество положительных элементов (> 0)
        public int GetPositiveCount(double[] array)
        {
            if (array == null || array.Length == 0)
                return 0;

            return array.Count(num => num > 0);
        }

        // 6. Количество отрицательных элементов (< 0)
        public int GetNegativeCount(double[] array)
        {
            if (array == null || array.Length == 0)
                return 0;

            return array.Count(num => num < 0);
        }

        // 7. Количество нулей (если нужно)
        public int GetZeroCount(double[] array)
        {
            if (array == null || array.Length == 0)
                return 0;

            return array.Count(num => num == 0);
        }
    }
}