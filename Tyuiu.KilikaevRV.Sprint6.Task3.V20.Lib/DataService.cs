using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KilikaevRV.Sprint6.Task3.V20.Lib
{
    public class DataService : ISprint6Task3V20
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Создаем копию матрицы, чтобы не изменять оригинал
            int[,] resultMatrix = (int[,])matrix.Clone();

            // Индекс пятой строки (нумерация с 0, поэтому 4)
            int fifthRowIndex = 4;

            // Проходим по всем элементам пятой строки
            for (int j = 0; j < columns; j++)
            {
                // Проверяем, четное ли значение
                if (resultMatrix[fifthRowIndex, j] % 2 == 0)
                {
                    // Заменяем четное значение на 0
                    resultMatrix[fifthRowIndex, j] = 0;
                }
            }

            return resultMatrix;
        }
    }
}