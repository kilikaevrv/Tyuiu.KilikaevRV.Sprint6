using System;
using System.Windows.Forms;
using Tyuiu.KilikaevRV.Sprint6.Task3.V20.Lib;

namespace Tyuiu.KilikaevRV.Sprint6.Task3.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Исходная матрица
            int[,] matrix = {
                {-14, 17, -19, 3, 2},
                {-4, -14, -19, -9, -1},
                {1, 0, 13, 14, 8},
                {13, 7, 8, -3, -15},
                {2, -20, 12, -14, 4}
            };

            // Заполняем DataGridView исходной матрицей
            FillDataGridView(dataGridViewMatrix_KRV, matrix, "Исходная матрица");
        }

        private void buttonDone_KRV_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                // Исходная матрица
                int[,] matrix = {
                    {-14, 17, -19, 3, 2},
                    {-4, -14, -19, -9, -1},
                    {1, 0, 13, 14, 8},
                    {13, 7, 8, -3, -15},
                    {2, -20, 12, -14, 4}
                };

                // Выполняем преобразование
                int[,] resultMatrix = ds.Calculate(matrix);

                // Заполняем DataGridView результатом
                FillDataGridView(dataGridViewResult_KRV, resultMatrix, "Результат");

                // Подсвечиваем измененную строку
                HighlightFifthRow(dataGridViewResult_KRV);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание №3, вариант 20\n" +
                "Выполнил: Килия Р.В. АСОиУб-23-3\n\n" +
                "Дан массив 5 на 5 элементов.\n" +
                "Заменить четные значения в пятой строке на 0.\n\n" +
                "Исходная матрица:\n" +
                "-14  17 -19   3   2\n" +
                " -4 -14 -19  -9  -1\n" +
                "  1   0  13  14   8\n" +
                " 13   7   8  -3 -15\n" +
                "  2 -20  12 -14   4\n\n" +
                "Результат вывести в DataGridView.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Метод для заполнения DataGridView
        private void FillDataGridView(DataGridView dgv, int[,] matrix, string title)
        {
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = true;
            dgv.ColumnCount = matrix.GetLength(1);

            // Настраиваем заголовки колонок
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                dgv.Columns[j].HeaderText = $"Столбец {j + 1}";
                dgv.Columns[j].Width = 50;
                dgv.Columns[j].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Очищаем строки
            dgv.Rows.Clear();

            // Заполняем данными
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                dgv.Rows.Add();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dgv.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        // Метод для подсветки пятой строки
        private void HighlightFifthRow(DataGridView dgv)
        {
            // Подсвечиваем пятую строку (индекс 4)
            int rowIndex = 4;

            for (int j = 0; j < dgv.ColumnCount; j++)
            {
                dgv.Rows[rowIndex].Cells[j].Style.BackColor = System.Drawing.Color.LightYellow;
                dgv.Rows[rowIndex].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            }
        }
    }
}