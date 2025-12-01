using System;
using System.Windows.Forms;
using Tyuiu.KilikaevRV.Sprint6.Task0.V8.Lib;

namespace Tyuiu.KilikaevRV.Sprint6.Task0.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_KRV_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int x = 3;
                double result = ds.Calculate(x);
                textBoxResult_KRV.Text = result.ToString("F3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание №0, вариант 8\n" +
                "Выполнил: Килия Р.В. АСОиУб-23-3\n" +
                "Дано выражение:\n" +
                "y(x) = (2x? - 1) / ?(x? - 2)\n" +
                "Вычислить при x = 3, округлить до 3 знаков после запятой.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}