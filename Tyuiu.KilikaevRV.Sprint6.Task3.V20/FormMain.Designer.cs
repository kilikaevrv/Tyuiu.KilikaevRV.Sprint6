namespace Tyuiu.KilikaevRV.Sprint6.Task3.V20
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridViewMatrix_KRV = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult_KRV = new System.Windows.Forms.DataGridView();
            this.buttonDone_KRV = new System.Windows.Forms.Button();
            this.buttonHelp_KRV = new System.Windows.Forms.Button();
            this.labelOriginal_KRV = new System.Windows.Forms.Label();
            this.labelResult_KRV = new System.Windows.Forms.Label();
            this.labelTitle_KRV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KRV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KRV)).BeginInit();
            this.SuspendLayout();

            // dataGridViewMatrix_KRV
            this.dataGridViewMatrix_KRV.AllowUserToAddRows = false;
            this.dataGridViewMatrix_KRV.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix_KRV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMatrix_KRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_KRV.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewMatrix_KRV.Name = "dataGridViewMatrix_KRV";
            this.dataGridViewMatrix_KRV.ReadOnly = true;
            this.dataGridViewMatrix_KRV.Size = new System.Drawing.Size(280, 150);
            this.dataGridViewMatrix_KRV.TabIndex = 0;

            // dataGridViewResult_KRV
            this.dataGridViewResult_KRV.AllowUserToAddRows = false;
            this.dataGridViewResult_KRV.AllowUserToDeleteRows = false;
            this.dataGridViewResult_KRV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewResult_KRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KRV.Location = new System.Drawing.Point(12, 280);
            this.dataGridViewResult_KRV.Name = "dataGridViewResult_KRV";
            this.dataGridViewResult_KRV.ReadOnly = true;
            this.dataGridViewResult_KRV.Size = new System.Drawing.Size(280, 150);
            this.dataGridViewResult_KRV.TabIndex = 1;

            // buttonDone_KRV
            this.buttonDone_KRV.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDone_KRV.Location = new System.Drawing.Point(12, 440);
            this.buttonDone_KRV.Name = "buttonDone_KRV";
            this.buttonDone_KRV.Size = new System.Drawing.Size(140, 30);
            this.buttonDone_KRV.TabIndex = 2;
            this.buttonDone_KRV.Text = "Выполнить";
            this.buttonDone_KRV.UseVisualStyleBackColor = false;
            this.buttonDone_KRV.Click += new System.EventHandler(this.buttonDone_KRV_Click);

            // buttonHelp_KRV
            this.buttonHelp_KRV.BackColor = System.Drawing.Color.Blue;
            this.buttonHelp_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonHelp_KRV.ForeColor = System.Drawing.Color.White;
            this.buttonHelp_KRV.Location = new System.Drawing.Point(162, 440);
            this.buttonHelp_KRV.Name = "buttonHelp_KRV";
            this.buttonHelp_KRV.Size = new System.Drawing.Size(130, 30);
            this.buttonHelp_KRV.TabIndex = 3;
            this.buttonHelp_KRV.Text = "Справка";
            this.buttonHelp_KRV.UseVisualStyleBackColor = false;
            this.buttonHelp_KRV.Click += new System.EventHandler(this.buttonHelp_KRV_Click);

            // labelOriginal_KRV
            this.labelOriginal_KRV.AutoSize = true;
            this.labelOriginal_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOriginal_KRV.Location = new System.Drawing.Point(12, 60);
            this.labelOriginal_KRV.Name = "labelOriginal_KRV";
            this.labelOriginal_KRV.Size = new System.Drawing.Size(125, 17);
            this.labelOriginal_KRV.TabIndex = 4;
            this.labelOriginal_KRV.Text = "Исходная матрица";

            // labelResult_KRV
            this.labelResult_KRV.AutoSize = true;
            this.labelResult_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelResult_KRV.Location = new System.Drawing.Point(12, 260);
            this.labelResult_KRV.Name = "labelResult_KRV";
            this.labelResult_KRV.Size = new System.Drawing.Size(167, 17);
            this.labelResult_KRV.TabIndex = 5;
            this.labelResult_KRV.Text = "Матрица после замены";

            // labelTitle_KRV
            this.labelTitle_KRV.AutoSize = true;
            this.labelTitle_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle_KRV.Location = new System.Drawing.Point(12, 20);
            this.labelTitle_KRV.Name = "labelTitle_KRV";
            this.labelTitle_KRV.Size = new System.Drawing.Size(300, 20);
            this.labelTitle_KRV.TabIndex = 6;
            this.labelTitle_KRV.Text = "Замена четных в пятой строке на 0";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 481);
            this.Controls.Add(this.labelTitle_KRV);
            this.Controls.Add(this.labelResult_KRV);
            this.Controls.Add(this.labelOriginal_KRV);
            this.Controls.Add(this.buttonHelp_KRV);
            this.Controls.Add(this.buttonDone_KRV);
            this.Controls.Add(this.dataGridViewResult_KRV);
            this.Controls.Add(this.dataGridViewMatrix_KRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 20 | Килия Р.В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KRV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KRV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatrix_KRV;
        private System.Windows.Forms.DataGridView dataGridViewResult_KRV;
        private System.Windows.Forms.Button buttonDone_KRV;
        private System.Windows.Forms.Button buttonHelp_KRV;
        private System.Windows.Forms.Label labelOriginal_KRV;
        private System.Windows.Forms.Label labelResult_KRV;
        private System.Windows.Forms.Label labelTitle_KRV;
    }
}