using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KilkulovaRV.Sprint6.Task5.V16.Lib
{
    public class DataService : ISprint6Task5V16
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                double[] numsArray = new double[100]; // Временный массив
                int count = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    // Преобразуем строку в число
                    if (double.TryParse(line, out double num))
                    {
                        numsArray[count] = num;
                        count++;
                    }
                }

                // Создаём массив нужного размера
                double[] resultArray = new double[count];
                Array.Copy(numsArray, resultArray, count);
                len = count;

                return resultArray;
            }
        }
    }
}