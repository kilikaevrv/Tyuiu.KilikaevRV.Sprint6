namespace Tyuiu.KilikaevRV.Sprint6.Task1.V26
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

        private void InitializeComponent()
        {
            this.textBoxResult_KRV = new System.Windows.Forms.TextBox();
            this.buttonDone_KRV = new System.Windows.Forms.Button();
            this.buttonHelp_KRV = new System.Windows.Forms.Button();
            this.labelTitle_KRV = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // textBoxResult_KRV
            this.textBoxResult_KRV.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult_KRV.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_KRV.Location = new System.Drawing.Point(12, 50);
            this.textBoxResult_KRV.Multiline = true;
            this.textBoxResult_KRV.Name = "textBoxResult_KRV";
            this.textBoxResult_KRV.ReadOnly = true;
            this.textBoxResult_KRV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KRV.Size = new System.Drawing.Size(300, 300);
            this.textBoxResult_KRV.TabIndex = 0;

            // buttonDone_KRV
            this.buttonDone_KRV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDone_KRV.Location = new System.Drawing.Point(12, 360);
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
            this.buttonHelp_KRV.Location = new System.Drawing.Point(172, 360);
            this.buttonHelp_KRV.Name = "buttonHelp_KRV";
            this.buttonHelp_KRV.Size = new System.Drawing.Size(140, 30);
            this.buttonHelp_KRV.TabIndex = 2;
            this.buttonHelp_KRV.Text = "Справка";
            this.buttonHelp_KRV.UseVisualStyleBackColor = false;
            this.buttonHelp_KRV.Click += new System.EventHandler(this.buttonHelp_KRV_Click);

            // labelTitle_KRV
            this.labelTitle_KRV.AutoSize = true;
            this.labelTitle_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelTitle_KRV.Location = new System.Drawing.Point(12, 20);
            this.labelTitle_KRV.Name = "labelTitle_KRV";
            this.labelTitle_KRV.Size = new System.Drawing.Size(310, 17);
            this.labelTitle_KRV.TabIndex = 3;
            this.labelTitle_KRV.Text = "Табулирование функции (вариант 26)";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 400);
            this.Controls.Add(this.labelTitle_KRV);
            this.Controls.Add(this.buttonHelp_KRV);
            this.Controls.Add(this.buttonDone_KRV);
            this.Controls.Add(this.textBoxResult_KRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Задание 1 | Килия Р.В.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxResult_KRV;
        private System.Windows.Forms.Button buttonDone_KRV;
        private System.Windows.Forms.Button buttonHelp_KRV;
        private System.Windows.Forms.Label labelTitle_KRV;
    }
}