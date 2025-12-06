using System;
using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.KilikaevRV.Sprint6.Task4.V19.Lib;

namespace Tyuiu.KilikaevRV.Sprint6.Task4.V19.Lib
{
    public class DataService : ISprint6Task4V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int cnt = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверка деления на ноль: sin(x) - 2 = 0
                double denominator = Math.Sin(x) - 2;

                if (Math.Abs(denominator) < 0.00001) // Проверка близко к нулю
                {
                    y = 0;
                }
                else
                {
                    y = (5 * x + 2.5) / denominator + 2;
                }

                valueArray[cnt] = Math.Round(y, 2);
                cnt++;
            }

            return valueArray;
        }
    }
}