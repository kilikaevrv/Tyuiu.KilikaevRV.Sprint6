using System;
using System.Windows.Forms;
using Tyuiu.KilikaevRV.Sprint6.Task6.V23.Lib;

namespace Tyuiu.KilikaevRV.Sprint6.Task6.V23
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private string filePath = "";

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_KV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Выберите файл"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                textBoxInput_KV.Text = File.ReadAllText(filePath);
                buttonDone_KV.Enabled = true;
                buttonOpenFile_KV.Text = "Файл выбран";
            }
        }

        private void buttonDone_KV_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                string result = ds.CollectTextFromFile(filePath);
                textBoxOutput_KV.Text = result;
            }
            else
            {
                MessageBox.Show("Сначала выберите файл!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonHelp_KV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ИИПБ-23-2\nКирикулова Р.В.",
                           "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}