namespace Tyuiu.KilikaevRV.Sprint6.Task6.V23
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private Button buttonOpenFile_KV;
        private Button buttonDone_KV;
        private Button buttonHelp_KV;
        private TextBox textBoxInput_KV;
        private TextBox textBoxOutput_KV;
        private Label labelTask_KV;
        private Label labelInput_KV;
        private Label labelOutput_KV;

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
            this.buttonOpenFile_KV = new System.Windows.Forms.Button();
            this.buttonDone_KV = new System.Windows.Forms.Button();
            this.buttonHelp_KV = new System.Windows.Forms.Button();
            this.textBoxInput_KV = new System.Windows.Forms.TextBox();
            this.textBoxOutput_KV = new System.Windows.Forms.TextBox();
            this.labelTask_KV = new System.Windows.Forms.Label();
            this.labelInput_KV = new System.Windows.Forms.Label();
            this.labelOutput_KV = new System.Windows.Forms.Label();

            // FormMain
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Text = "Спринт 6 | Таск 6 | Вариант 23 | Кирикулова Р.В.";
            this.StartPosition = FormStartPosition.CenterScreen;

            // labelTask_KV
            this.labelTask_KV.AutoSize = true;
            this.labelTask_KV.Location = new System.Drawing.Point(20, 20);
            this.labelTask_KV.Size = new System.Drawing.Size(400, 40);
            this.labelTask_KV.Text = "Дан файл InPutFileTask6V23.txt. Вывести слова, содержащие букву 's'.";

            // buttonOpenFile_KV
            this.buttonOpenFile_KV.Location = new System.Drawing.Point(20, 70);
            this.buttonOpenFile_KV.Size = new System.Drawing.Size(150, 30);
            this.buttonOpenFile_KV.Text = "Открыть файл";
            this.buttonOpenFile_KV.Click += new EventHandler(buttonOpenFile_KV_Click);

            // buttonDone_KV
            this.buttonDone_KV.Location = new System.Drawing.Point(180, 70);
            this.buttonDone_KV.Size = new System.Drawing.Size(150, 30);
            this.buttonDone_KV.Text = "Выполнить";
            this.buttonDone_KV.Enabled = false;
            this.buttonDone_KV.Click += new EventHandler(buttonDone_KV_Click);

            // buttonHelp_KV
            this.buttonHelp_KV.Location = new System.Drawing.Point(340, 70);
            this.buttonHelp_KV.Size = new System.Drawing.Size(150, 30);
            this.buttonHelp_KV.Text = "Справка";
            this.buttonHelp_KV.Click += new EventHandler(buttonHelp_KV_Click);

            // labelInput_KV
            this.labelInput_KV.AutoSize = true;
            this.labelInput_KV.Location = new System.Drawing.Point(20, 120);
            this.labelInput_KV.Text = "Ввод:";

            // textBoxInput_KV
            this.textBoxInput_KV.Location = new System.Drawing.Point(20, 140);
            this.textBoxInput_KV.Multiline = true;
            this.textBoxInput_KV.Size = new System.Drawing.Size(560, 100);
            this.textBoxInput_KV.ScrollBars = ScrollBars.Vertical;

            // labelOutput_KV
            this.labelOutput_KV.AutoSize = true;
            this.labelOutput_KV.Location = new System.Drawing.Point(20, 250);
            this.labelOutput_KV.Text = "Результат:";

            // textBoxOutput_KV
            this.textBoxOutput_KV.Location = new System.Drawing.Point(20, 270);
            this.textBoxOutput_KV.Multiline = true;
            this.textBoxOutput_KV.Size = new System.Drawing.Size(560, 100);
            this.textBoxOutput_KV.ScrollBars = ScrollBars.Vertical;
            this.textBoxOutput_KV.ReadOnly = true;

            // Добавление контролов на форму
            this.Controls.Add(this.labelTask_KV);
            this.Controls.Add(this.buttonOpenFile_KV);
            this.Controls.Add(this.buttonDone_KV);
            this.Controls.Add(this.buttonHelp_KV);
            this.Controls.Add(this.labelInput_KV);
            this.Controls.Add(this.textBoxInput_KV);
            this.Controls.Add(this.labelOutput_KV);
            this.Controls.Add(this.textBoxOutput_KV);
        }
    }
}