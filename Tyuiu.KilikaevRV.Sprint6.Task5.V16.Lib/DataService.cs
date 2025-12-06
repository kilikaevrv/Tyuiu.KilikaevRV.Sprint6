using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KilikaevRV.Sprint6.Task4.V19.Lib;
public class DataService : ISprint6Task5V16
{
    public double[] LoadFromDataFile(string path)
    {
        try
        {
            // 1. Используем переданный путь, а не жёсткий C:\...
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            // 2. Читаем весь файл
            string fileContent = File.ReadAllText(path).Trim();

            // 3. Разделяем на числа (поддерживаем разные разделители)
            string[] numberStrings = fileContent.Split(
                new[] { ' ', ',', ';', '\t', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries
            );

            // 4. Преобразуем строки в числа
            double[] numbers = new double[numberStrings.Length];
            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (double.TryParse(numberStrings[i], out double num))
                {
                    numbers[i] = num;
                }
                else
                {
                    throw new FormatException($"Не удалось преобразовать '{numberStrings[i]}' в число в строке {i + 1}");
                }
            }

            return numbers;
        }
        catch (FileNotFoundException ex)
        {
            // Пробрасываем с понятным сообщением
            throw new FileNotFoundException($"Ошибка чтения файла: {ex.Message}", ex);
        }
        catch (FormatException ex)
        {
            throw new FormatException($"Ошибка формата данных в файле: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new Exception($"Непредвиденная ошибка при чтении файла: {ex.Message}", ex);
        }
    }
}