using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KilikaevRV.Sprint6.Task7.V6.Lib
{
    public class DataService : ISprint6Task7V6
    {
        public int[,] GetMatrix(string path)
        {
            try
            {
                // 1. Читаем все строки файла
                string[] lines = File.ReadAllLines(path);

                // 2. Определяем размеры матрицы
                int rows = lines.Length;
                int cols = lines[0].Split(';').Length;

                int[,] matrix = new int[rows, cols];

                // 3. Заполняем матрицу
                for (int i = 0; i < rows; i++)
                {
                    string[] values = lines[i].Split(';');
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = int.Parse(values[j]);
                    }
                }

                // 4. Изменяем 7-ю строку (индекс 6)
                int rowToChange = 6;

                if (rowToChange < rows)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[rowToChange, j] != 6)
                        {
                            matrix[rowToChange, j] = 0;
                        }
                    }
                }

                return matrix;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при обработке файла: {ex.Message}");
            }
        }

        // Метод для сохранения матрицы в CSV файл
        public void SaveMatrixToFile(int[,] matrix, string path)
        {
            try
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        sb.Append(matrix[i, j]);
                        if (j < cols - 1)
                            sb.Append(';');
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(path, sb.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при сохранении файла: {ex.Message}");
            }
        }
    }
}