namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Lab31RadioButton = new System.Windows.Forms.RadioButton();
            this.Lab32RadioButton = new System.Windows.Forms.RadioButton();
            this.DoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lab35RadioButton = new System.Windows.Forms.RadioButton();
            this.Lab33RadioButton = new System.Windows.Forms.RadioButton();
            this.Lab34RadioButton = new System.Windows.Forms.RadioButton();
            this.SolvingLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MenuButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lab31RadioButton
            // 
            this.Lab31RadioButton.AutoSize = true;
            this.Lab31RadioButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Lab31RadioButton.Location = new System.Drawing.Point(258, 29);
            this.Lab31RadioButton.Name = "Lab31RadioButton";
            this.Lab31RadioButton.Size = new System.Drawing.Size(285, 31);
            this.Lab31RadioButton.TabIndex = 0;
            this.Lab31RadioButton.TabStop = true;
            this.Lab31RadioButton.Text = "Лабораторная работа 3.1";
            this.Lab31RadioButton.UseVisualStyleBackColor = true;
            // 
            // Lab32RadioButton
            // 
            this.Lab32RadioButton.AutoSize = true;
            this.Lab32RadioButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Lab32RadioButton.Location = new System.Drawing.Point(258, 104);
            this.Lab32RadioButton.Name = "Lab32RadioButton";
            this.Lab32RadioButton.Size = new System.Drawing.Size(285, 31);
            this.Lab32RadioButton.TabIndex = 1;
            this.Lab32RadioButton.TabStop = true;
            this.Lab32RadioButton.Text = "Лабораторная работа 3.2";
            this.Lab32RadioButton.UseVisualStyleBackColor = true;
            // 
            // DoButton
            // 
            this.DoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoButton.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.DoButton.Location = new System.Drawing.Point(513, 572);
            this.DoButton.Name = "DoButton";
            this.DoButton.Size = new System.Drawing.Size(121, 38);
            this.DoButton.TabIndex = 2;
            this.DoButton.Text = "Выполнить";
            this.DoButton.UseVisualStyleBackColor = true;
            this.DoButton.Click += new System.EventHandler(this.DoButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lab35RadioButton);
            this.panel1.Controls.Add(this.Lab33RadioButton);
            this.panel1.Controls.Add(this.Lab34RadioButton);
            this.panel1.Controls.Add(this.Lab31RadioButton);
            this.panel1.Controls.Add(this.Lab32RadioButton);
            this.panel1.Location = new System.Drawing.Point(183, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 391);
            this.panel1.TabIndex = 3;
            // 
            // Lab35RadioButton
            // 
            this.Lab35RadioButton.AutoSize = true;
            this.Lab35RadioButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Lab35RadioButton.Location = new System.Drawing.Point(258, 329);
            this.Lab35RadioButton.Name = "Lab35RadioButton";
            this.Lab35RadioButton.Size = new System.Drawing.Size(285, 31);
            this.Lab35RadioButton.TabIndex = 4;
            this.Lab35RadioButton.TabStop = true;
            this.Lab35RadioButton.Text = "Лабораторная работа 3.5";
            this.Lab35RadioButton.UseVisualStyleBackColor = true;
            // 
            // Lab33RadioButton
            // 
            this.Lab33RadioButton.AutoSize = true;
            this.Lab33RadioButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Lab33RadioButton.Location = new System.Drawing.Point(258, 179);
            this.Lab33RadioButton.Name = "Lab33RadioButton";
            this.Lab33RadioButton.Size = new System.Drawing.Size(285, 31);
            this.Lab33RadioButton.TabIndex = 2;
            this.Lab33RadioButton.TabStop = true;
            this.Lab33RadioButton.Text = "Лабораторная работа 3.3";
            this.Lab33RadioButton.UseVisualStyleBackColor = true;
            // 
            // Lab34RadioButton
            // 
            this.Lab34RadioButton.AutoSize = true;
            this.Lab34RadioButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Lab34RadioButton.Location = new System.Drawing.Point(258, 254);
            this.Lab34RadioButton.Name = "Lab34RadioButton";
            this.Lab34RadioButton.Size = new System.Drawing.Size(285, 31);
            this.Lab34RadioButton.TabIndex = 3;
            this.Lab34RadioButton.TabStop = true;
            this.Lab34RadioButton.Text = "Лабораторная работа 3.4";
            this.Lab34RadioButton.UseVisualStyleBackColor = true;
            // 
            // SolvingLabel
            // 
            this.SolvingLabel.AutoSize = true;
            this.SolvingLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SolvingLabel.Location = new System.Drawing.Point(14, 36);
            this.SolvingLabel.Name = "SolvingLabel";
            this.SolvingLabel.Size = new System.Drawing.Size(237, 22);
            this.SolvingLabel.TabIndex = 2;
            this.SolvingLabel.Text = "Метод простых итераций: \n";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.SolvingLabel);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 566);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "a) Лагранж",
            "a) Ньютон",
            "б) Лагранж",
            "б) Ньютон"});
            this.comboBox1.Location = new System.Drawing.Point(59, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 30);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Visible = false;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(372, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(810, 563);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // MenuButton
            // 
            this.MenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.MenuButton.Location = new System.Drawing.Point(845, 572);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(126, 38);
            this.MenuButton.TabIndex = 2;
            this.MenuButton.Text = "В меню.";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Visible = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 720);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.DoButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Lab31RadioButton;
        private System.Windows.Forms.RadioButton Lab32RadioButton;
        private System.Windows.Forms.Button DoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.RadioButton Lab35RadioButton;
        private System.Windows.Forms.RadioButton Lab33RadioButton;
        private System.Windows.Forms.RadioButton Lab34RadioButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label SolvingLabel;
    }
}

