using System;
using System.Windows.Forms;
using Tyuiu.KilikaevRV.Sprint6.Task1.V26.Lib;

namespace Tyuiu.KilikaevRV.Sprint6.Task1.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_KRV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);

            // Формируем результат
            textBoxResult_KRV.Text = "Табулирование функции:\r\n";
            textBoxResult_KRV.Text += "F(x) = (2cos(x)+2)/(2x-1) + cos(x) - 5x + 3\r\n";
            textBoxResult_KRV.Text += "на интервале [-5; 5] с шагом 1\r\n\r\n";
            textBoxResult_KRV.Text += "+----------+----------+\r\n";
            textBoxResult_KRV.Text += "|    x     |   f(x)   |\r\n";
            textBoxResult_KRV.Text += "+----------+----------+\r\n";

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                textBoxResult_KRV.Text += $"| {x,5}    | {valueArray[count],8:f2} |\r\n";
                count++;
            }

            textBoxResult_KRV.Text += "+----------+----------+\r\n";
        }

        private void buttonHelp_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание №1, вариант 26\n" +
                "Выполнил: Килия Р.В. АСОиУб-23-3\n\n" +
                "Написать программу, которая выводит таблицу значений функции:\n" +
                "F(x) = (2cos(x)+2)/(2x-1) + cos(x) - 5x + 3\n" +
                "на диапазоне [-5; 5] с шагом 1.\n" +
                "При делении на ноль вернуть значение 0.\n" +
                "Значения округлить до двух знаков после запятой.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}