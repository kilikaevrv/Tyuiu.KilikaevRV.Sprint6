namespace Tyuiu.KilikaevRV.Sprint6.Task7.V6
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private Button buttonLoad_KV;
        private Button buttonSave_KV;
        private Button buttonHelp_KV;
        private Label labelTask_KV;
        private Label labelFile_KV;
        private DataGridView dataGridViewIn_KV;
        private DataGridView dataGridViewOut_KV;
        private Label labelInput_KV;
        private Label labelOutput_KV;
        private SplitContainer splitContainer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonLoad_KV = new System.Windows.Forms.Button();
            this.buttonSave_KV = new System.Windows.Forms.Button();
            this.buttonHelp_KV = new System.Windows.Forms.Button();
            this.labelTask_KV = new System.Windows.Forms.Label();
            this.labelFile_KV = new System.Windows.Forms.Label();
            this.dataGridViewIn_KV = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_KV = new System.Windows.Forms.DataGridView();
            this.labelInput_KV = new System.Windows.Forms.Label();
            this.labelOutput_KV = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();

            // Настройка DataGridView
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_KV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_KV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();

            // ==================== КНОПКИ ====================

            // buttonLoad_KV
            this.buttonLoad_KV.Location = new System.Drawing.Point(20, 100);
            this.buttonLoad_KV.Name = "buttonLoad_KV";
            this.buttonLoad_KV.Size = new System.Drawing.Size(150, 40);
            this.buttonLoad_KV.Text = "Загрузить файл";
            this.buttonLoad_KV.UseVisualStyleBackColor = true;
            this.buttonLoad_KV.Click += new System.EventHandler(this.buttonLoad_KV_Click);
            this.buttonLoad_KV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            // buttonSave_KV
            this.buttonSave_KV.Location = new System.Drawing.Point(180, 100);
            this.buttonSave_KV.Name = "buttonSave_KV";
            this.buttonSave_KV.Size = new System.Drawing.Size(150, 40);
            this.buttonSave_KV.Text = "Сохранить результат";
            this.buttonSave_KV.UseVisualStyleBackColor = true;
            this.buttonSave_KV.Click += new System.EventHandler(this.buttonSave_KV_Click);
            this.buttonSave_KV.Enabled = false;
            this.buttonSave_KV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            // buttonHelp_KV
            this.buttonHelp_KV.Location = new System.Drawing.Point(340, 100);
            this.buttonHelp_KV.Name = "buttonHelp_KV";
            this.buttonHelp_KV.Size = new System.Drawing.Size(150, 40);
            this.buttonHelp_KV.Text = "Справка";
            this.buttonHelp_KV.UseVisualStyleBackColor = true;
            this.buttonHelp_KV.Click += new System.EventHandler(this.buttonHelp_KV_Click);
            this.buttonHelp_KV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));// ==================== ЛАБЕЛЫ ====================

            // labelTask_KV
            this.labelTask_KV.AutoSize = true;
            this.labelTask_KV.Location = new System.Drawing.Point(20, 20);
            this.labelTask_KV.Name = "labelTask_KV";
            this.labelTask_KV.Size = new System.Drawing.Size(600, 40);
            this.labelTask_KV.Text = "Загрузить CSV файл с матрицей. Изменить в 7-й строке числа не равные 6 на 0. Сохранить результат в файл.";
            this.labelTask_KV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            // labelFile_KV
            this.labelFile_KV.AutoSize = true;
            this.labelFile_KV.Location = new System.Drawing.Point(20, 70);
            this.labelFile_KV.Name = "labelFile_KV";
            this.labelFile_KV.Size = new System.Drawing.Size(400, 20);
            this.labelFile_KV.Text = "Файл не выбран";
            this.labelFile_KV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            // ==================== SPLIT CONTAINER ====================

            // splitContainer1
            this.splitContainer1.Location = new System.Drawing.Point(20, 170);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(750, 400);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.SplitterWidth = 10;

            // Панель 1 - Входная матрица
            this.labelInput_KV = new System.Windows.Forms.Label();
            this.labelInput_KV.AutoSize = true;
            this.labelInput_KV.Location = new System.Drawing.Point(10, 10);
            this.labelInput_KV.Name = "labelInput_KV";
            this.labelInput_KV.Size = new System.Drawing.Size(100, 20);
            this.labelInput_KV.Text = "Входная матрица:";
            this.labelInput_KV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            this.dataGridViewIn_KV.Location = new System.Drawing.Point(10, 35);
            this.dataGridViewIn_KV.Name = "dataGridViewIn_KV";
            this.dataGridViewIn_KV.Size = new System.Drawing.Size(360, 340);
            this.dataGridViewIn_KV.AllowUserToAddRows = false;
            this.dataGridViewIn_KV.AllowUserToDeleteRows = false;
            this.dataGridViewIn_KV.ReadOnly = true;
            this.dataGridViewIn_KV.RowHeadersVisible = true;
            this.dataGridViewIn_KV.ColumnHeadersVisible = true;
            this.dataGridViewIn_KV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIn_KV.BackgroundColor = System.Drawing.Color.White;

            this.splitContainer1.Panel1.Controls.Add(this.labelInput_KV);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewIn_KV);

            // Панель 2 - Выходная матрица
            this.labelOutput_KV = new System.Windows.Forms.Label();
            this.labelOutput_KV.AutoSize = true;
            this.labelOutput_KV.Location = new System.Drawing.Point(10, 10);
            this.labelOutput_KV.Name = "labelOutput_KV";
            this.labelOutput_KV.Size = new System.Drawing.Size(150, 20);
            this.labelOutput_KV.Text = "Результат (7-я строка изменена):";
            this.labelOutput_KV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            this.dataGridViewOut_KV.Location = new System.Drawing.Point(10, 35);
            this.dataGridViewOut_KV.Name = "dataGridViewOut_KV";
            this.dataGridViewOut_KV.Size = new System.Drawing.Size(360, 340);
            this.dataGridViewOut_KV.AllowUserToAddRows = false;
            this.dataGridViewOut_KV.AllowUserToDeleteRows = false;
            this.dataGridViewOut_KV.ReadOnly = true;
            this.dataGridViewOut_KV.RowHeadersVisible = true;
            this.dataGridViewOut_KV.ColumnHeadersVisible = true;
            this.dataGridViewOut_KV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOut_KV.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;

            this.splitContainer1.Panel2.Controls.Add(this.labelOutput_KV);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewOut_KV);

            // ==================== ФОРМА ====================

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonHelp_KV);
            this.Controls.Add(this.buttonSave_KV);
            this.Controls.Add(this.buttonLoad_KV);
            this.Controls.Add(this.labelFile_KV);
            this.Controls.Add(this.labelTask_KV);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 6 | Кирикулова Р.В.";
            this.Load += new System.EventHandler(this.FormMain_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_KV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_KV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Инициализация при загрузке формы
        }
    }
}