using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KilikaevRV.Sprint6.Task6.V23.Lib
{
    public class DataService : ISprint6Task6V23
    {
        public string CollectTextFromFile(string path)
        {
            try
            {
                if (!File.Exists(path))
                    return "Файл не найден";

                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    string[] words = line.Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '\n', '\r' },
                                                StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        // Ищем 's' или 'S' в слове
                        if (word.IndexOf('s') >= 0 || word.IndexOf('S') >= 0)
                        {
                            // Возвращаем ПЕРВОЕ найденное слово в оригинальном регистре
                            return word;
                        }
                    }
                }

                // Если слово с 's' не найдено
                return "";
            }
            catch (Exception ex)
            {
                return $"Ошибка: {ex.Message}";
            }
        }
    }
}