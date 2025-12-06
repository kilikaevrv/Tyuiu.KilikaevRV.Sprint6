using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KilikaevRV.Sprint6.Task4.V19.Lib;

namespace Tyuiu.KilikaevRV.Sprint6.Task4.V19
{
    public partial class FormMain : Form
    {
        // Объявляем PictureBox здесь, если не работает через дизайнер
        private PictureBox pictureBoxGraph_KRV;

        public FormMain()
        {
            InitializeComponent();
            InitializePictureBox(); // Инициализируем PictureBox
        }

        private void InitializePictureBox()
        {
            // Создаем PictureBox если его нет
            if (pictureBoxGraph_KRV == null)
            {
                pictureBoxGraph_KRV = new PictureBox();
                pictureBoxGraph_KRV.Name = "pictureBoxGraph_KRV";
                pictureBoxGraph_KRV.BackColor = Color.White;
                pictureBoxGraph_KRV.BorderStyle = BorderStyle.FixedSingle;
                pictureBoxGraph_KRV.Location = new Point(324, 12);
                pictureBoxGraph_KRV.Size = new Size(564, 537);

                // Добавляем на форму
                this.Controls.Add(pictureBoxGraph_KRV);
            }
        }

        private void buttonDone_KRV_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                int startValue = Convert.ToInt32(textBoxStart_KRV.Text);
                int stopValue = Convert.ToInt32(textBoxStop_KRV.Text);

                double[] valueArray = ds.GetMassFunction(startValue, stopValue);

                // Вывод в textBox
                textBoxResult_KRV.Text = "Результаты табулирования функции:\r\n";
                textBoxResult_KRV.AppendText("---------------------------------\r\n");
                textBoxResult_KRV.AppendText("|    X    |    F(x)    |\r\n");
                textBoxResult_KRV.AppendText("---------------------------------\r\n");

                for (int i = 0; i < valueArray.Length; i++)
                {
                    int x = startValue + i;
                    textBoxResult_KRV.AppendText($"|{x,5:d}     |  {valueArray[i],8:f2}    |\r\n");
                }

                textBoxResult_KRV.AppendText("---------------------------------\r\n");

                // Рисуем график
                DrawGraph_KRV(valueArray, startValue, stopValue);

                // Сохранение в файл
                SaveToFile(valueArray, startValue, stopValue);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода. Введите целые числа.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawGraph_KRV(double[] values, int startValue, int stopValue)
        {
            if (pictureBoxGraph_KRV == null || values == null || values.Length == 0) return;

            int width = pictureBoxGraph_KRV.Width;
            int height = pictureBoxGraph_KRV.Height;

            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Заливаем фон
                g.Clear(Color.White);

                if (values.Length > 1)
                {
                    // Находим min и max значения
                    double minY = values[0];
                    double maxY = values[0];
                    for (int i = 1; i < values.Length; i++)
                    {
                        if (values[i] < minY) minY = values[i];
                        if (values[i] > maxY) maxY = values[i];
                    }// Добавляем отступы
                    double range = maxY - minY;
                    if (range < 0.1) range = 10;
                    minY -= range * 0.1;
                    maxY += range * 0.1;

                    // Отступы от краев
                    int padding = 40;
                    int graphWidth = width - 2 * padding;
                    int graphHeight = height - 2 * padding;

                    // Рисуем оси
                    Pen axisPen = new Pen(Color.Black, 2);
                    g.DrawLine(axisPen, padding, height - padding, width - padding, height - padding); // X
                    g.DrawLine(axisPen, padding, padding, padding, height - padding); // Y

                    // Подписи осей
                    Font labelFont = new Font("Arial", 10);
                    g.DrawString("X", labelFont, Brushes.Black, width - padding + 5, height - padding - 10);
                    g.DrawString("F(x)", labelFont, Brushes.Black, padding - 30, padding - 20);

                    // Рисуем график
                    Pen graphPen = new Pen(Color.Blue, 3);

                    for (int i = 0; i < values.Length; i++)
                    {
                        float x = padding + i * graphWidth / (values.Length - 1);
                        float y = padding + graphHeight - (float)((values[i] - minY) * graphHeight / (maxY - minY));

                        // Рисуем точки
                        g.FillEllipse(Brushes.Red, x - 4, y - 4, 8, 8);

                        // Соединяем с предыдущей точкой
                        if (i > 0)
                        {
                            float prevX = padding + (i - 1) * graphWidth / (values.Length - 1);
                            float prevY = padding + graphHeight - (float)((values[i - 1] - minY) * graphHeight / (maxY - minY));
                            g.DrawLine(graphPen, prevX, prevY, x, y);
                        }
                    }

                    // Заголовок
                    Font titleFont = new Font("Arial", 12, FontStyle.Bold);
                    g.DrawString("График функции F(x)", titleFont, Brushes.Black, width / 2 - 80, 10);
                }
                else
                {
                    // Если всего одна точка
                    Font font = new Font("Arial", 12);
                    g.DrawString("Недостаточно данных для графика", font, Brushes.Red, 10, 10);
                }
            }

            pictureBoxGraph_KRV.Image = bmp;
        }

        private void SaveToFile(double[] values, int startValue, int stopValue)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask4V19.txt");

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine("Результаты табулирования функции F(x) = (5x + 2.5)/(sin(x) - 2) + 2");
                writer.WriteLine($"Диапазон: от {startValue} до {stopValue}");
                writer.WriteLine("---------------------------------");
                writer.WriteLine("|    X    |    F(x)    |");
                writer.WriteLine("---------------------------------");

                for (int i = 0; i < values.Length; i++)
                {
                    int x = startValue + i;
                    writer.WriteLine($"|{x,5:d}     |  {values[i],8:f2}    |");
                }

                writer.WriteLine("---------------------------------");
            }

            MessageBox.Show($"Результаты сохранены в файл:\n{path}", "Успешно",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelp_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулирование функции F(x) = (5x + 2.5)/(sin(x) - 2) + 2\n" +
                          "на диапазоне [-5; 5] с шагом 1.\n" +
                          "При делении на ноль возвращается 0.\n" +
                          "Результаты округляются до 2 знаков после запятой.\n\n" +
                          "Выполнил: Килькаев Р.В., группа АСОиУб-23-2",
                          "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}