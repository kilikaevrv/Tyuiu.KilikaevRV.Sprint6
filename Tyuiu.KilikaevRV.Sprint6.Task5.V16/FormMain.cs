using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KilikaevRV.Sprint6.Task5.V16.Lib;

namespace Tyuiu.KilikaevRV.Sprint6.Task5.V16
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private double[] loadedData;
        private string inputFilePath = @"C:\DataSprint6\InPutDataFileTask5V16.txt";
        private string outputFilePath = @"C:\DataSprint6\OutPutDataFileTask5V16.txt";

        public FormMain()
        {
            InitializeComponent();
            UpdateFileStatus();
        }

        private void UpdateFileStatus()
        {
            if (File.Exists(inputFilePath))
            {
                labelFileStatus_KRV.Text = $"✅ Файл найден: {Path.GetFileName(inputFilePath)}";
                labelFileStatus_KRV.ForeColor = Color.Green;
                buttonLoad_KRV.Enabled = true;
                buttonLoad_KRV.BackColor = Color.LimeGreen;

                // Показываем информацию о файле
                FileInfo fileInfo = new FileInfo(inputFilePath);
                textBoxInfo_KRV.Text = $"📄 Имя файла: {Path.GetFileName(inputFilePath)}\n" +
                                     $"📁 Полный путь: {inputFilePath}\n" +
                                     $"📊 Размер файла: {fileInfo.Length} байт\n" +
                                     $"📅 Дата создания: {fileInfo.CreationTime:dd.MM.yyyy HH:mm}\n" +
                                     $"⏰ Дата изменения: {fileInfo.LastWriteTime:dd.MM.yyyy HH:mm}";
            }
            else
            {
                labelFileStatus_KRV.Text = $"❌ Файл не найден: {Path.GetFileName(inputFilePath)}";
                labelFileStatus_KRV.ForeColor = Color.Red;
                buttonLoad_KRV.Enabled = false;
                buttonLoad_KRV.BackColor = Color.LightGray;
                textBoxInfo_KRV.Text = $"Файл '{Path.GetFileName(inputFilePath)}' не найден.\n" +
                                     $"Ожидаемый путь: {inputFilePath}\n\n" +
                                     $"Убедитесь, что:\n" +
                                     $"1. Файл существует по указанному пути\n" +
                                     $"2. Папка C:\\DataSprint6 существует\n" +
                                     $"3. Файл имеет правильное имя: InPutDataFileTask5V16.txt";
            }
        }

        private void buttonLoad_KRV_Click(object sender, EventArgs e)
        {
            try
            {
                // Загружаем данные
                loadedData = ds.LoadFromDataFile(inputFilePath);

                // Отображаем данные
                DisplayData();

                // Показываем статистику
                DisplayStatistics();

                MessageBox.Show($"✅ Данные успешно загружены!\n\n" +
                              $"📊 Загружено элементов: {loadedData.Length}\n" +
                              $"📁 Файл: {Path.GetFileName(inputFilePath)}\n" +
                              $"📍 Путь: {inputFilePath}",
                              "Успешная загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Ошибка загрузки данных:\n\n{ex.Message}",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayData()
        {
            textBoxData_KRV.Clear();

            if (loadedData == null || loadedData.Length == 0)
            {
                textBoxData_KRV.Text = "Нет данных для отображения";
                return;
            }

            textBoxData_KRV.Text = "📋 ЗАГРУЖЕННЫЕ ДАННЫЕ (округлены до 3 знаков):\n";
            textBoxData_KRV.AppendText(new string('═', 50) + "\n");
            textBoxData_KRV.AppendText("№     Значение     Статус\n");
            textBoxData_KRV.AppendText(new string('═', 50) + "\n");

            for (int i = 0; i < loadedData.Length; i++)
            {
                string status;
                if (loadedData[i] > 0)
                    status = "Положительное";
                else if (loadedData[i] < 0)
                    status = "Отрицательное";
                else
                    status = "Ноль";

                textBoxData_KRV.AppendText($"{i + 1,3}: {loadedData[i],10:F3}     {status}\n");

                // Разделитель каждые 10 строк
                if ((i + 1) % 10 == 0 && i < loadedData.Length - 1)
                {
                    textBoxData_KRV.AppendText(new string('─', 50) + "\n");
                }
            }

            textBoxData_KRV.AppendText(new string('═', 50) + "\n");
            textBoxData_KRV.AppendText($"📊 Всего элементов: {loadedData.Length}\n");
        }

        private void DisplayStatistics()
        {
            textBoxStats_KRV.Clear();

            if (loadedData == null || loadedData.Length == 0)
            {
                textBoxStats_KRV.Text = "Нет данных для статистики";
                return;
            }

            textBoxStats_KRV.Text = "📈 СТАТИСТИЧЕСКИЙ АНАЛИЗ ДАННЫХ:\n";
            textBoxStats_KRV.AppendText(new string('═', 50) + "\n");
            textBoxStats_KRV.AppendText($"🔢 Количество элементов: {loadedData.Length}\n");
            textBoxStats_KRV.AppendText($"💰 Сумма всех значений: {ds.GetSum(loadedData):F3}\n");
            textBoxStats_KRV.AppendText($"📊 Среднее арифметическое: {ds.GetAverage(loadedData):F3}\n");
            textBoxStats_KRV.AppendText($"⬆️ Максимальное значение: {ds.GetMax(loadedData):F3}\n");
            textBoxStats_KRV.AppendText($"⬇️ Минимальное значение: {ds.GetMin(loadedData):F3}\n");
            textBoxStats_KRV.AppendText($"➕ Положительных чисел: {ds.GetPositiveCount(loadedData)}\n");
            textBoxStats_KRV.AppendText($"➖ Отрицательных чисел: {ds.GetNegativeCount(loadedData)}\n");
            textBoxStats_KRV.AppendText($"⚪ Нулевых значений: {loadedData.Count(x => Math.Abs(x) < 0.0001)}\n");
            textBoxStats_KRV.AppendText(new string('═', 50) + "\n");

            // Дополнительные расчеты
            if (loadedData.Length > 1)
            {
                double range = ds.GetMax(loadedData) - ds.GetMin(loadedData);
                textBoxStats_KRV.AppendText($"📏 Диапазон значений: {range:F3}\n");

                double variance = loadedData.Select(x => Math.Pow(x - ds.GetAverage(loadedData), 2)).Sum() / (loadedData.Length - 1);
                double stdDev = Math.Sqrt(variance);
                textBoxStats_KRV.AppendText($"📐 Дисперсия: {Math.Round(variance, 3):F3}\n");
                textBoxStats_KRV.AppendText($"📏 Стандартное отклонение: {Math.Round(stdDev, 3):F3}\n");
            }
        }

        private void buttonSave_KRV_Click(object sender, EventArgs e)
        {
            if (loadedData == null || loadedData.Length == 0)
            {
                MessageBox.Show("⚠️ Сначала загрузите данные!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Сохраняем на диск C
                using (StreamWriter writer = new StreamWriter(outputFilePath, false))
                {
                    writer.WriteLine("╔══════════════════════════════════════════════════════╗");
                    writer.WriteLine("║      РЕЗУЛЬТАТЫ ОБРАБОТКИ ДАННЫХ ИЗ ФАЙЛА           ║");
                    writer.WriteLine("╚══════════════════════════════════════════════════════╝");
                    writer.WriteLine();
                    writer.WriteLine($"📄 Исходный файл: {Path.GetFileName(inputFilePath)}");
                    writer.WriteLine($"📍 Полный путь: {inputFilePath}");
                    writer.WriteLine($"📅 Дата обработки: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
                    writer.WriteLine(new string('═', 60));
                    writer.WriteLine();

                    writer.WriteLine("📊 ЗАГРУЖЕННЫЕ ДАННЫЕ:");
                    writer.WriteLine(new string('─', 60));
                    writer.WriteLine("№     Значение");
                    writer.WriteLine(new string('─', 60));

                    for (int i = 0; i < loadedData.Length; i++)
                    {
                        writer.WriteLine($"{i + 1,4}. {loadedData[i],10:F3}");
                    }

                    writer.WriteLine(new string('─', 60));
                    writer.WriteLine($"Всего элементов: {loadedData.Length}");
                    writer.WriteLine();

                    writer.WriteLine("📈 СТАТИСТИЧЕСКИЕ ДАННЫЕ:");
                    writer.WriteLine(new string('─', 60));
                    writer.WriteLine($"🔢 Количество элементов: {loadedData.Length}");
                    writer.WriteLine($"💰 Сумма всех значений: {ds.GetSum(loadedData):F3}");
                    writer.WriteLine($"📊 Среднее арифметическое: {ds.GetAverage(loadedData):F3}");
                    writer.WriteLine($"⬆️ Максимальное значение: {ds.GetMax(loadedData):F3}");
                    writer.WriteLine($"⬇️ Минимальное значение: {ds.GetMin(loadedData):F3}");
                    writer.WriteLine($"➕ Положительных чисел: {ds.GetPositiveCount(loadedData)}");
                    writer.WriteLine($"➖ Отрицательных чисел: {ds.GetNegativeCount(loadedData)}");
                    writer.WriteLine($"⚪ Нулевых значений: {loadedData.Count(x => Math.Abs(x) < 0.0001)}");
                    writer.WriteLine();

                    if (loadedData.Length > 1)
                    {
                        double range = ds.GetMax(loadedData) - ds.GetMin(loadedData);
                        writer.WriteLine($"📏 Диапазон значений: {range:F3}");

                        double variance = loadedData.Select(x => Math.Pow(x - ds.GetAverage(loadedData), 2)).Sum() / (loadedData.Length - 1);
                        double stdDev = Math.Sqrt(variance);
                        writer.WriteLine($"📐 Дисперсия: {Math.Round(variance, 3):F3}");
                        writer.WriteLine($"📏 Стандартное отклонение: {Math.Round(stdDev, 3):F3}");
                        writer.WriteLine();
                    }

                    writer.WriteLine(new string('═', 60));
                    writer.WriteLine();
                    writer.WriteLine($"👤 Выполнил: Килькаев Роман Владимирович");
                    writer.WriteLine($"🎓 Группа: АСОиУб-23-2");
                    writer.WriteLine($"📅 Дата выполнения: {DateTime.Now:dd.MM.yyyy}");
                }

                MessageBox.Show($"✅ Результаты успешно сохранены!\n\n" +
                              $"📄 Имя файла: {Path.GetFileName(outputFilePath)}\n" +
                              $"📍 Путь: {outputFilePath}\n\n" +
                              $"📊 Сохранено данных: {loadedData.Length} элементов\n" +
                              $"⏰ Время сохранения: {DateTime.Now:HH:mm:ss}",
                              "Сохранение завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Ошибка при сохранении результатов:\n\n{ex.Message}",
                              "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KRV_Click(object sender, EventArgs e)
        {
            string helpText = @"📋 ЗАДАНИЕ 5, ВАРИАНТ 16

⚙️ НАЗНАЧЕНИЕ ПРОГРАММЫ:
Чтение числовых данных из файла и их статистическая обработка.

📁 ФАЙЛЫ:
• Входной файл: C:\DataSprint6\InPutDataFileTask5V16.txt
• Выходной файл: C:\DataSprint6\OutPutDataFileTask5V16.txt

📝 ФОРМАТ ВХОДНОГО ФАЙЛА:
• Числа в одной строке
• Разделители: пробелы, запятые, точки с запятой
• Поддерживаются целые и дробные числа
• Пример содержимого: 1.5 2.3 -4.7 8.9 0 12.4

🔧 ФУНКЦИОНАЛ:
1. Проверка существования входного файла
2. Загрузка и парсинг данных
3. Округление значений до 3 знаков после запятой
4. Статистический анализ данных
5. Сохранение результатов в файл

🎯 ВЫПОЛНЯЕМЫЕ ОПЕРАЦИИ:
• Подсчет количества элементов
• Вычисление суммы и среднего значения
• Поиск максимального и минимального значений
• Подсчет положительных, отрицательных и нулевых значений
• Расчет дисперсии и стандартного отклонения

👤 ВЫПОЛНИЛ:
Килькаев Роман Владимирович
Группа: АСОиУб-23-2";

            MessageBox.Show(helpText, "📚 СПРАВКА",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFolder_KRV_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = @"C:\DataSprint6";

                if (Directory.Exists(folderPath))
                {
                    System.Diagnostics.Process.Start("explorer.exe", folderPath);
                }
                else
                {
                    MessageBox.Show("Папка C:\\DataSprint6 не существует.\n" +
                                  "Создайте папку и поместите в нее файл с данными.",
                                  "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии папки:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}