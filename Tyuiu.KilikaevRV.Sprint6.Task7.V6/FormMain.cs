using System;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KilikaevRV.Sprint6.Task7.V6.Lib;

namespace Tyuiu.KilikaevRV.Sprint6.Task7.V6
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private int[,] inputMatrix;
        private int[,] outputMatrix;
        private string inputFilePath = "";

        public FormMain()
        {
            InitializeComponent();
        }

        // Загрузка файла
        private void buttonLoad_KV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Выберите файл с матрицей",
                InitialDirectory = Directory.GetCurrentDirectory()
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFilePath = openFileDialog.FileName;
                labelFile_KV.Text = "Файл: " + Path.GetFileName(inputFilePath);

                try
                {
                    // Читаем и отображаем исходную матрицу
                    inputMatrix = ReadMatrixFromFile(inputFilePath);
                    DisplayMatrixInGrid(dataGridViewIn_KV, inputMatrix);

                    // Обрабатываем и отображаем результат
                    outputMatrix = ds.GetMatrix(inputFilePath);
                    DisplayMatrixInGrid(dataGridViewOut_KV, outputMatrix);

                    buttonSave_KV.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла:\n{ex.Message}",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Сохранение результата
        private void buttonSave_KV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Сохранить результат",
                FileName = "OutPutFileTask7V6.csv",
                DefaultExt = "csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ds.SaveMatrixToFile(outputMatrix, saveFileDialog.FileName);
                    MessageBox.Show($"Файл успешно сохранен:\n{saveFileDialog.FileName}",
                                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла:\n{ex.Message}",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Справка
        private void buttonHelp_KV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ИИПБ-23-2\nКирикулова Р.В.\n\n" +
                           "Изменяет в 7-й строке числа не равные 6 на 0.",
                           "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Вспомогательные методы
        private int[,] ReadMatrixFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            return matrix;
        }

        private void DisplayMatrixInGrid(DataGridView dgv, int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            dgv.RowCount = rows;
            dgv.ColumnCount = cols;

            // Настройка размеров колонок
            for (int j = 0; j < cols; j++)
            {
                dgv.Columns[j].Width = 50;
                dgv.Columns[j].HeaderText = j.ToString();
            }

            // Заполнение данными
            for (int i = 0; i < rows; i++)
            {
                dgv.Rows[i].HeaderCell.Value = i.ToString();
                for (int j = 0; j < cols; j++)
                {
                    dgv[j, i].Value = matrix[i, j];
                }
            }
        }
    }
}