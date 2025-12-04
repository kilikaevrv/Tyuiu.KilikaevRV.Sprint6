namespace Tyuiu.KilikaevRV.Sprint6.Task2.V12
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewResult_KRV = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDone_KRV = new System.Windows.Forms.Button();
            this.buttonHelp_KRV = new System.Windows.Forms.Button();
            this.labelFunction_KRV = new System.Windows.Forms.Label();
            this.labelTitle_KRV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KRV)).BeginInit();
            this.SuspendLayout();

            // dataGridViewResult_KRV
            this.dataGridViewResult_KRV.AllowUserToAddRows = false;
            this.dataGridViewResult_KRV.AllowUserToDeleteRows = false;
            this.dataGridViewResult_KRV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewResult_KRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult_KRV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResult_KRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KRV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnFx});
            this.dataGridViewResult_KRV.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewResult_KRV.Name = "dataGridViewResult_KRV";
            this.dataGridViewResult_KRV.ReadOnly = true;
            this.dataGridViewResult_KRV.RowHeadersVisible = false;
            this.dataGridViewResult_KRV.Size = new System.Drawing.Size(300, 250);
            this.dataGridViewResult_KRV.TabIndex = 0;

            // ColumnX
            this.ColumnX.HeaderText = "x";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Width = 120;

            // ColumnFx
            this.ColumnFx.HeaderText = "F(x)";
            this.ColumnFx.Name = "ColumnFx";
            this.ColumnFx.ReadOnly = true;
            this.ColumnFx.Width = 120;

            // buttonDone_KRV
            this.buttonDone_KRV.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDone_KRV.Location = new System.Drawing.Point(12, 340);
            this.buttonDone_KRV.Name = "buttonDone_KRV";
            this.buttonDone_KRV.Size = new System.Drawing.Size(140, 30);
            this.buttonDone_KRV.TabIndex = 1;
            this.buttonDone_KRV.Text = "Выполнить";
            this.buttonDone_KRV.UseVisualStyleBackColor = false;
            this.buttonDone_KRV.Click += new System.EventHandler(this.buttonDone_KRV_Click);

            // buttonHelp_KRV
            this.buttonHelp_KRV.BackColor = System.Drawing.Color.Blue;
            this.buttonHelp_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonHelp_KRV.ForeColor = System.Drawing.Color.White;
            this.buttonHelp_KRV.Location = new System.Drawing.Point(172, 340);
            this.buttonHelp_KRV.Name = "buttonHelp_KRV";
            this.buttonHelp_KRV.Size = new System.Drawing.Size(140, 30);
            this.buttonHelp_KRV.TabIndex = 2;
            this.buttonHelp_KRV.Text = "Справка";
            this.buttonHelp_KRV.UseVisualStyleBackColor = false;
            this.buttonHelp_KRV.Click += new System.EventHandler(this.buttonHelp_KRV_Click);

            // labelFunction_KRV
            this.labelFunction_KRV.AutoSize = true;
            this.labelFunction_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFunction_KRV.Location = new System.Drawing.Point(12, 50);
            this.labelFunction_KRV.Name = "labelFunction_KRV";
            this.labelFunction_KRV.Size = new System.Drawing.Size(250, 17);
            this.labelFunction_KRV.TabIndex = 3;
            this.labelFunction_KRV.Text = "F(x) = (2x + 6) / (cos(x) + x) - 3";

            // labelTitle_KRV
            this.labelTitle_KRV.AutoSize = true;
            this.labelTitle_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle_KRV.Location = new System.Drawing.Point(12, 20);
            this.labelTitle_KRV.Name = "labelTitle_KRV";
            this.labelTitle_KRV.Size = new System.Drawing.Size(310, 20);
            this.labelTitle_KRV.TabIndex = 4;
            this.labelTitle_KRV.Text = "Табулирование функции (вариант 12)";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 381);
            this.Controls.Add(this.labelTitle_KRV);
            this.Controls.Add(this.labelFunction_KRV);
            this.Controls.Add(this.buttonHelp_KRV);
            this.Controls.Add(this.buttonDone_KRV);
            this.Controls.Add(this.dataGridViewResult_KRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 12 | Килия Р.В.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KRV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResult_KRV;
        private System.Windows.Forms.Button buttonDone_KRV;
        private System.Windows.Forms.Button buttonHelp_KRV;
        private System.Windows.Forms.Label labelFunction_KRV;
        private System.Windows.Forms.Label labelTitle_KRV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFx;
    }
}