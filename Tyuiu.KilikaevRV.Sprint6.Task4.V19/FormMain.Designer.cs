namespace Tyuiu.KilikaevRV.Sprint6.Task4.V19
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonDone_KRV;
        private System.Windows.Forms.Button buttonHelp_KRV;
        private System.Windows.Forms.TextBox textBoxStart_KRV;
        private System.Windows.Forms.TextBox textBoxStop_KRV;
        private System.Windows.Forms.TextBox textBoxResult_KRV;
        private System.Windows.Forms.Label labelStart_KRV;
        private System.Windows.Forms.Label labelStop_KRV;
        private System.Windows.Forms.Label labelResult_KRV;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KRV;

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
            this.buttonDone_KRV = new System.Windows.Forms.Button();
            this.buttonHelp_KRV = new System.Windows.Forms.Button();
            this.textBoxStart_KRV = new System.Windows.Forms.TextBox();
            this.textBoxStop_KRV = new System.Windows.Forms.TextBox();
            this.textBoxResult_KRV = new System.Windows.Forms.TextBox();
            this.labelStart_KRV = new System.Windows.Forms.Label();
            this.labelStop_KRV = new System.Windows.Forms.Label();
            this.labelResult_KRV = new System.Windows.Forms.Label();
            this.panelGraph = new System.Windows.Forms.Panel();

            // Простой способ без Chart если возникают проблемы
            // this.chartFunction_KRV = new System.Windows.Forms.DataVisualization.Charting.Chart();

            this.SuspendLayout();

            // buttonDone_KRV
            this.buttonDone_KRV.Location = new System.Drawing.Point(12, 12);
            this.buttonDone_KRV.Name = "buttonDone_KRV";
            this.buttonDone_KRV.Size = new System.Drawing.Size(120, 35);
            this.buttonDone_KRV.TabIndex = 0;
            this.buttonDone_KRV.Text = "Выполнить";
            this.buttonDone_KRV.UseVisualStyleBackColor = true;
            this.buttonDone_KRV.Click += new System.EventHandler(this.buttonDone_KRV_Click);

            // buttonHelp_KRV
            this.buttonHelp_KRV.Location = new System.Drawing.Point(138, 12);
            this.buttonHelp_KRV.Name = "buttonHelp_KRV";
            this.buttonHelp_KRV.Size = new System.Drawing.Size(120, 35);
            this.buttonHelp_KRV.TabIndex = 1;
            this.buttonHelp_KRV.Text = "Справка";
            this.buttonHelp_KRV.UseVisualStyleBackColor = true;
            this.buttonHelp_KRV.Click += new System.EventHandler(this.buttonHelp_KRV_Click);

            // textBoxStart_KRV
            this.textBoxStart_KRV.Location = new System.Drawing.Point(12, 70);
            this.textBoxStart_KRV.Name = "textBoxStart_KRV";
            this.textBoxStart_KRV.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_KRV.Text = "-5";

            // textBoxStop_KRV
            this.textBoxStop_KRV.Location = new System.Drawing.Point(12, 110);
            this.textBoxStop_KRV.Name = "textBoxStop_KRV";
            this.textBoxStop_KRV.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_KRV.Text = "5";

            // textBoxResult_KRV
            this.textBoxResult_KRV.Location = new System.Drawing.Point(12, 150);
            this.textBoxResult_KRV.Multiline = true;
            this.textBoxResult_KRV.Name = "textBoxResult_KRV";
            this.textBoxResult_KRV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KRV.Size = new System.Drawing.Size(350, 350);

            // labelStart_KRV
            this.labelStart_KRV.AutoSize = true;
            this.labelStart_KRV.Location = new System.Drawing.Point(118, 73);
            this.labelStart_KRV.Name = "labelStart_KRV";
            this.labelStart_KRV.Size = new System.Drawing.Size(110, 16);
            this.labelStart_KRV.Text = "Начало (startX):";

            // labelStop_KRV
            this.labelStop_KRV.AutoSize = true;
            this.labelStop_KRV.Location = new System.Drawing.Point(118, 113);
            this.labelStop_KRV.Name = "labelStop_KRV";
            this.labelStop_KRV.Size = new System.Drawing.Size(103, 16);
            this.labelStop_KRV.Text = "Конец (stopX):";

            // labelResult_KRV
            this.labelResult_KRV.AutoSize = true;
            this.labelResult_KRV.Location = new System.Drawing.Point(12, 131);
            this.labelResult_KRV.Name = "labelResult_KRV";
            this.labelResult_KRV.Size = new System.Drawing.Size(82, 16);
            this.labelResult_KRV.Text = "Результат:";

            // panelGraph
            this.panelGraph.Location = new System.Drawing.Point(380, 12);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(500, 488);
            this.panelGraph.BackColor = System.Drawing.Color.White;
            this.panelGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.labelResult_KRV);
            this.Controls.Add(this.labelStop_KRV);
            this.Controls.Add(this.labelStart_KRV);
            this.Controls.Add(this.textBoxResult_KRV);
            this.Controls.Add(this.textBoxStop_KRV);
            this.Controls.Add(this.textBoxStart_KRV);
            this.Controls.Add(this.buttonHelp_KRV);
            this.Controls.Add(this.buttonDone_KRV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 19 | Килькаев Р.В.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}