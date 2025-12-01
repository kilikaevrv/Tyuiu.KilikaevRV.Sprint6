namespace Tyuiu.KilikaevRV.Sprint6.Task0.V8
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
            this.textBoxResult_KRV = new System.Windows.Forms.TextBox();
            this.buttonResult_KRV = new System.Windows.Forms.Button();
            this.buttonHelp_KRV = new System.Windows.Forms.Button();
            this.labelExpression_KRV = new System.Windows.Forms.Label();
            this.labelResult_KRV = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // textBoxResult_KRV
            this.textBoxResult_KRV.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult_KRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxResult_KRV.Location = new System.Drawing.Point(12, 80);
            this.textBoxResult_KRV.Name = "textBoxResult_KRV";
            this.textBoxResult_KRV.ReadOnly = true;
            this.textBoxResult_KRV.Size = new System.Drawing.Size(260, 23);
            this.textBoxResult_KRV.TabIndex = 0;

            // buttonResult_KRV
            this.buttonResult_KRV.BackColor = System.Drawing.Color.Lime;
            this.buttonResult_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonResult_KRV.Location = new System.Drawing.Point(12, 120);
            this.buttonResult_KRV.Name = "buttonResult_KRV";
            this.buttonResult_KRV.Size = new System.Drawing.Size(120, 30);
            this.buttonResult_KRV.TabIndex = 1;
            this.buttonResult_KRV.Text = "Выполнить";
            this.buttonResult_KRV.UseVisualStyleBackColor = false;
            this.buttonResult_KRV.Click += new System.EventHandler(this.buttonResult_KRV_Click);

            // buttonHelp_KRV
            this.buttonHelp_KRV.BackColor = System.Drawing.Color.Blue;
            this.buttonHelp_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonHelp_KRV.ForeColor = System.Drawing.Color.White;
            this.buttonHelp_KRV.Location = new System.Drawing.Point(152, 120);
            this.buttonHelp_KRV.Name = "buttonHelp_KRV";
            this.buttonHelp_KRV.Size = new System.Drawing.Size(120, 30);
            this.buttonHelp_KRV.TabIndex = 2;
            this.buttonHelp_KRV.Text = "Справка";
            this.buttonHelp_KRV.UseVisualStyleBackColor = false;
            this.buttonHelp_KRV.Click += new System.EventHandler(this.buttonHelp_KRV_Click);

            // labelExpression_KRV
            this.labelExpression_KRV.AutoSize = true;
            this.labelExpression_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelExpression_KRV.Location = new System.Drawing.Point(12, 20);
            this.labelExpression_KRV.Name = "labelExpression_KRV";
            this.labelExpression_KRV.Size = new System.Drawing.Size(260, 17);
            this.labelExpression_KRV.TabIndex = 3;
            this.labelExpression_KRV.Text = "Выражение: y(x) = (2x² - 1) / √(x² - 2)";

            // labelResult_KRV
            this.labelResult_KRV.AutoSize = true;
            this.labelResult_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelResult_KRV.Location = new System.Drawing.Point(12, 60);
            this.labelResult_KRV.Name = "labelResult_KRV";
            this.labelResult_KRV.Size = new System.Drawing.Size(169, 17);
            this.labelResult_KRV.TabIndex = 4;
            this.labelResult_KRV.Text = "Результат при x = 3.000:";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.labelResult_KRV);
            this.Controls.Add(this.labelExpression_KRV);
            this.Controls.Add(this.buttonHelp_KRV);
            this.Controls.Add(this.buttonResult_KRV);
            this.Controls.Add(this.textBoxResult_KRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 8 | Килия Р.В.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult_KRV;
        private System.Windows.Forms.Button buttonResult_KRV;
        private System.Windows.Forms.Button buttonHelp_KRV;
        private System.Windows.Forms.Label labelExpression_KRV;
        private System.Windows.Forms.Label labelResult_KRV;
    }
}