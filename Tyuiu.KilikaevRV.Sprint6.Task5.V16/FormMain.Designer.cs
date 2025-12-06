namespace Tyuiu.KilikaevRV.Sprint6.Task5.V16
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonLoad_KRV;
        private System.Windows.Forms.Button buttonHelp_KRV;
        private System.Windows.Forms.Button buttonSave_KRV;
        private System.Windows.Forms.Button buttonOpenFolder_KRV;
        private System.Windows.Forms.TextBox textBoxData_KRV;
        private System.Windows.Forms.TextBox textBoxStats_KRV;
        private System.Windows.Forms.TextBox textBoxInfo_KRV;
        private System.Windows.Forms.Label labelFileStatus_KRV;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelStats;

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
            this.buttonLoad_KRV = new System.Windows.Forms.Button();
            this.buttonHelp_KRV = new System.Windows.Forms.Button();
            this.buttonSave_KRV = new System.Windows.Forms.Button();
            this.buttonOpenFolder_KRV = new System.Windows.Forms.Button();
            this.textBoxData_KRV = new System.Windows.Forms.TextBox();
            this.textBoxStats_KRV = new System.Windows.Forms.TextBox();
            this.textBoxInfo_KRV = new System.Windows.Forms.TextBox();
            this.labelFileStatus_KRV = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelStats = new System.Windows.Forms.Label();

            // buttonLoad_KRV
            this.buttonLoad_KRV.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonLoad_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonLoad_KRV.ForeColor = System.Drawing.Color.White;
            this.buttonLoad_KRV.Location = new System.Drawing.Point(12, 12);
            this.buttonLoad_KRV.Name = "buttonLoad_KRV";
            this.buttonLoad_KRV.Size = new System.Drawing.Size(120, 40);
            this.buttonLoad_KRV.TabIndex = 0;
            this.buttonLoad_KRV.Text = "📂 Загрузить";
            this.buttonLoad_KRV.UseVisualStyleBackColor = false;
            this.buttonLoad_KRV.Click += new System.EventHandler(this.buttonLoad_KRV_Click);

            // buttonHelp_KRV
            this.buttonHelp_KRV.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonHelp_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonHelp_KRV.Location = new System.Drawing.Point(138, 12);
            this.buttonHelp_KRV.Name = "buttonHelp_KRV";
            this.buttonHelp_KRV.Size = new System.Drawing.Size(120, 40);
            this.buttonHelp_KRV.TabIndex = 1;
            this.buttonHelp_KRV.Text = "❓ Справка";
            this.buttonHelp_KRV.UseVisualStyleBackColor = false;
            this.buttonHelp_KRV.Click += new System.EventHandler(this.buttonHelp_KRV_Click);

            // buttonSave_KRV
            this.buttonSave_KRV.BackColor = System.Drawing.Color.Gold;
            this.buttonSave_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonSave_KRV.Location = new System.Drawing.Point(264, 12);
            this.buttonSave_KRV.Name = "buttonSave_KRV";
            this.buttonSave_KRV.Size = new System.Drawing.Size(120, 40);
            this.buttonSave_KRV.TabIndex = 2;
            this.buttonSave_KRV.Text = "💾 Сохранить";
            this.buttonSave_KRV.UseVisualStyleBackColor = false;
            this.buttonSave_KRV.Click += new System.EventHandler(this.buttonSave_KRV_Click);

            // buttonOpenFolder_KRV
            this.buttonOpenFolder_KRV.BackColor = System.Drawing.Color.Orange; this.buttonOpenFolder_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonOpenFolder_KRV.Location = new System.Drawing.Point(390, 12);
            this.buttonOpenFolder_KRV.Name = "buttonOpenFolder_KRV";
            this.buttonOpenFolder_KRV.Size = new System.Drawing.Size(120, 40);
            this.buttonOpenFolder_KRV.TabIndex = 3;
            this.buttonOpenFolder_KRV.Text = "📁 Папка";
            this.buttonOpenFolder_KRV.UseVisualStyleBackColor = false;
            this.buttonOpenFolder_KRV.Click += new System.EventHandler(this.buttonOpenFolder_KRV_Click);

            // labelFileStatus_KRV
            this.labelFileStatus_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelFileStatus_KRV.Location = new System.Drawing.Point(12, 65);
            this.labelFileStatus_KRV.Name = "labelFileStatus_KRV";
            this.labelFileStatus_KRV.Size = new System.Drawing.Size(498, 20);
            this.labelFileStatus_KRV.TabIndex = 4;
            this.labelFileStatus_KRV.Text = "Проверка файла...";

            // textBoxInfo_KRV
            this.textBoxInfo_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxInfo_KRV.Location = new System.Drawing.Point(12, 90);
            this.textBoxInfo_KRV.Multiline = true;
            this.textBoxInfo_KRV.Name = "textBoxInfo_KRV";
            this.textBoxInfo_KRV.ReadOnly = true;
            this.textBoxInfo_KRV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo_KRV.Size = new System.Drawing.Size(498, 80);
            this.textBoxInfo_KRV.TabIndex = 5;

            // labelData
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelData.Location = new System.Drawing.Point(12, 180);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(81, 17);
            this.labelData.TabIndex = 6;
            this.labelData.Text = "📋 Данные";

            // textBoxData_KRV
            this.textBoxData_KRV.Font = new System.Drawing.Font("Courier New", 9F);
            this.textBoxData_KRV.Location = new System.Drawing.Point(12, 200);
            this.textBoxData_KRV.Multiline = true;
            this.textBoxData_KRV.Name = "textBoxData_KRV";
            this.textBoxData_KRV.ReadOnly = true;
            this.textBoxData_KRV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData_KRV.Size = new System.Drawing.Size(240, 349);
            this.textBoxData_KRV.TabIndex = 7;

            // labelStats
            this.labelStats.AutoSize = true;
            this.labelStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelStats.Location = new System.Drawing.Point(258, 180);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(99, 17);
            this.labelStats.TabIndex = 8;
            this.labelStats.Text = "📊 Статистика";

            // textBoxStats_KRV
            this.textBoxStats_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxStats_KRV.Location = new System.Drawing.Point(258, 200);
            this.textBoxStats_KRV.Multiline = true;
            this.textBoxStats_KRV.Name = "textBoxStats_KRV";
            this.textBoxStats_KRV.ReadOnly = true;
            this.textBoxStats_KRV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStats_KRV.Size = new System.Drawing.Size(252, 349);
            this.textBoxStats_KRV.TabIndex = 9;

            // FormMain
            this.ClientSize = new System.Drawing.Size(524, 561);
            this.Controls.Add(this.textBoxStats_KRV);
            this.Controls.Add(this.labelStats);
            this.Controls.Add(this.textBoxData_KRV);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textBoxInfo_KRV);
            this.Controls.Add(this.labelFileStatus_KRV);
            this.Controls.Add(this.buttonOpenFolder_KRV);
            this.Controls.Add(this.buttonSave_KRV);
            this.Controls.Add(this.buttonHelp_KRV);
            this.Controls.Add(this.buttonLoad_KRV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 16 | Килькаев Р.В.";
        }
    }
}