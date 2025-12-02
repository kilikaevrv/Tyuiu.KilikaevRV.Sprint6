using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KilikaevRV.Sprint6.Task1.V26.Lib
{
    public class DataService : ISprint6Task1V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = Math.Abs(stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                // F(x) = (2cos(x)+2)/(2x-1) + cos(x) - 5x + 3
                double denominator = 2 * x - 1;

                if (Math.Abs(denominator) < 0.0001) // проверка на ноль
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double cosX = Math.Cos(x);
                    double numerator = 2 * cosX + 2;
                    double fraction = numerator / denominator;
                    double result = fraction + cosX - 5 * x + 3;

                    valueArray[count] = Math.Round(result, 2);
                }

                count++;
            }

            return valueArray;
        }
    }
}