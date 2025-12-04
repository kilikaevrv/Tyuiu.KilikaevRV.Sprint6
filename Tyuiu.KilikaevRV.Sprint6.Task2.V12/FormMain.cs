using System;
using System.Windows.Forms;
using Tyuiu.KilikaevRV.Sprint6.Task2.V12.Lib;

namespace Tyuiu.KilikaevRV.Sprint6.Task2.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_KRV_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                int startValue = -5;
                int stopValue = 5;

                double[] valueArray = ds.GetMassFunction(startValue, stopValue);

                // Очищаем DataGridView
                dataGridViewResult_KRV.Rows.Clear();

                // Заполняем DataGridView
                int count = 0;
                for (int x = startValue; x <= stopValue; x++)
                {
                    dataGridViewResult_KRV.Rows.Add(x.ToString(), valueArray[count].ToString("F2"));
                    count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание №2, вариант 12\n" +
                "Выполнил: Килия Р.В. АСОиУб-23-3\n\n" +
                "Написать программу, которая выводит таблицу значений функции:\n" +
                "F(x) = (2x+6)/(cos(x)+x) - 3\n" +
                "на диапазоне [-5; 5] с шагом 1.\n" +
                "При делении на ноль вернуть значение 0.\n" +
                "Значения округлить до двух знаков после запятой.\n" +
                "Результат вывести в DataGridView.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}