namespace lab6
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
            this.InputCoefs2Task = new System.Windows.Forms.TextBox();
            this.CoefsLabel2Task = new System.Windows.Forms.Label();
            this.Task2Task = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MainTaskLabel = new System.Windows.Forms.Label();
            this.MainButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.CoefsLabel1Task = new System.Windows.Forms.Label();
            this.InputCoefs1Task = new System.Windows.Forms.TextBox();
            this.Task1Task = new System.Windows.Forms.Label();
            this.Perform2TaskButton = new System.Windows.Forms.Button();
            this.Perform1TaskButton = new System.Windows.Forms.Button();
            this.SolvingOut2Task = new System.Windows.Forms.Label();
            this.ProblemOut2Task = new System.Windows.Forms.Label();
            this.SolvingOut1Task = new System.Windows.Forms.Label();
            this.Step = new System.Windows.Forms.TextBox();
            this.Interval = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputCoefs2Task
            // 
            this.InputCoefs2Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.InputCoefs2Task.Location = new System.Drawing.Point(97, 162);
            this.InputCoefs2Task.Name = "InputCoefs2Task";
            this.InputCoefs2Task.Size = new System.Drawing.Size(139, 29);
            this.InputCoefs2Task.TabIndex = 0;
            this.InputCoefs2Task.Visible = false;
            // 
            // CoefsLabel2Task
            // 
            this.CoefsLabel2Task.AutoSize = true;
            this.CoefsLabel2Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CoefsLabel2Task.Location = new System.Drawing.Point(185, 105);
            this.CoefsLabel2Task.Name = "CoefsLabel2Task";
            this.CoefsLabel2Task.Size = new System.Drawing.Size(151, 21);
            this.CoefsLabel2Task.TabIndex = 3;
            this.CoefsLabel2Task.Text = "Введите матрицу:";
            this.CoefsLabel2Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CoefsLabel2Task.Visible = false;
            // 
            // Task2Task
            // 
            this.Task2Task.AutoSize = true;
            this.Task2Task.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Task2Task.Location = new System.Drawing.Point(17, 50);
            this.Task2Task.Name = "Task2Task";
            this.Task2Task.Size = new System.Drawing.Size(584, 27);
            this.Task2Task.TabIndex = 8;
            this.Task2Task.Text = "2. Найти максимальное собственное значение матрицы.";
            this.Task2Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Task2Task.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(53, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(102, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Задание 1.";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(53, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 21);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Задание 2.";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(174, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 110);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // MainTaskLabel
            // 
            this.MainTaskLabel.AutoSize = true;
            this.MainTaskLabel.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.MainTaskLabel.Location = new System.Drawing.Point(113, 44);
            this.MainTaskLabel.Name = "MainTaskLabel";
            this.MainTaskLabel.Size = new System.Drawing.Size(326, 33);
            this.MainTaskLabel.TabIndex = 12;
            this.MainTaskLabel.Text = "Лабораторная работа №6.";
            this.MainTaskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainButton
            // 
            this.MainButton.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.MainButton.Location = new System.Drawing.Point(174, 398);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(204, 42);
            this.MainButton.TabIndex = 13;
            this.MainButton.Text = "Выполнить.";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.MenuButton.Location = new System.Drawing.Point(22, 359);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(104, 31);
            this.MenuButton.TabIndex = 14;
            this.MenuButton.Text = "К меню.";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Visible = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // CoefsLabel1Task
            // 
            this.CoefsLabel1Task.AutoSize = true;
            this.CoefsLabel1Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CoefsLabel1Task.Location = new System.Drawing.Point(68, 105);
            this.CoefsLabel1Task.Name = "CoefsLabel1Task";
            this.CoefsLabel1Task.Size = new System.Drawing.Size(290, 21);
            this.CoefsLabel1Task.TabIndex = 15;
            this.CoefsLabel1Task.Text = "Введите функцию, интервал и шаг:";
            this.CoefsLabel1Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CoefsLabel1Task.Visible = false;
            // 
            // InputCoefs1Task
            // 
            this.InputCoefs1Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.InputCoefs1Task.Location = new System.Drawing.Point(97, 162);
            this.InputCoefs1Task.Name = "InputCoefs1Task";
            this.InputCoefs1Task.Size = new System.Drawing.Size(139, 29);
            this.InputCoefs1Task.TabIndex = 17;
            this.InputCoefs1Task.Visible = false;
            // 
            // Task1Task
            // 
            this.Task1Task.AutoSize = true;
            this.Task1Task.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Task1Task.Location = new System.Drawing.Point(20, 50);
            this.Task1Task.Name = "Task1Task";
            this.Task1Task.Size = new System.Drawing.Size(419, 27);
            this.Task1Task.TabIndex = 19;
            this.Task1Task.Text = "1. Найти характеристический полином.";
            this.Task1Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Task1Task.Visible = false;
            // 
            // Perform2TaskButton
            // 
            this.Perform2TaskButton.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Perform2TaskButton.Location = new System.Drawing.Point(174, 226);
            this.Perform2TaskButton.Name = "Perform2TaskButton";
            this.Perform2TaskButton.Size = new System.Drawing.Size(204, 42);
            this.Perform2TaskButton.TabIndex = 22;
            this.Perform2TaskButton.Text = "Найти.";
            this.Perform2TaskButton.UseVisualStyleBackColor = true;
            this.Perform2TaskButton.Visible = false;
            this.Perform2TaskButton.Click += new System.EventHandler(this.Perform2TaskButton_Click);
            // 
            // Perform1TaskButton
            // 
            this.Perform1TaskButton.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Perform1TaskButton.Location = new System.Drawing.Point(174, 226);
            this.Perform1TaskButton.Name = "Perform1TaskButton";
            this.Perform1TaskButton.Size = new System.Drawing.Size(204, 42);
            this.Perform1TaskButton.TabIndex = 23;
            this.Perform1TaskButton.Text = "Найти.";
            this.Perform1TaskButton.UseVisualStyleBackColor = true;
            this.Perform1TaskButton.Visible = false;
            this.Perform1TaskButton.Click += new System.EventHandler(this.Perform1TaskButton_Click);
            // 
            // SolvingOut2Task
            // 
            this.SolvingOut2Task.AutoSize = true;
            this.SolvingOut2Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SolvingOut2Task.Location = new System.Drawing.Point(300, 320);
            this.SolvingOut2Task.Name = "SolvingOut2Task";
            this.SolvingOut2Task.Size = new System.Drawing.Size(15, 21);
            this.SolvingOut2Task.TabIndex = 30;
            this.SolvingOut2Task.Text = " ";
            this.SolvingOut2Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SolvingOut2Task.Visible = false;
            // 
            // ProblemOut2Task
            // 
            this.ProblemOut2Task.AutoSize = true;
            this.ProblemOut2Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.ProblemOut2Task.Location = new System.Drawing.Point(300, 285);
            this.ProblemOut2Task.Name = "ProblemOut2Task";
            this.ProblemOut2Task.Size = new System.Drawing.Size(15, 21);
            this.ProblemOut2Task.TabIndex = 31;
            this.ProblemOut2Task.Text = " ";
            this.ProblemOut2Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProblemOut2Task.Visible = false;
            // 
            // SolvingOut1Task
            // 
            this.SolvingOut1Task.AutoSize = true;
            this.SolvingOut1Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SolvingOut1Task.Location = new System.Drawing.Point(300, 320);
            this.SolvingOut1Task.Name = "SolvingOut1Task";
            this.SolvingOut1Task.Size = new System.Drawing.Size(15, 21);
            this.SolvingOut1Task.TabIndex = 32;
            this.SolvingOut1Task.Text = " ";
            this.SolvingOut1Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SolvingOut1Task.Visible = false;
            // 
            // Step
            // 
            this.Step.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Step.Location = new System.Drawing.Point(360, 162);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(90, 29);
            this.Step.TabIndex = 33;
            this.Step.Visible = false;
            // 
            // Interval
            // 
            this.Interval.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Interval.Location = new System.Drawing.Point(253, 162);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(90, 29);
            this.Interval.TabIndex = 34;
            this.Interval.Visible = false;
            // 
            // chart1
            // 
            chart1.Visible = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(614, 41);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.SteelBlue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Coral;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(803, 485);
            this.chart1.TabIndex = 35;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 550);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Interval);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.SolvingOut1Task);
            this.Controls.Add(this.ProblemOut2Task);
            this.Controls.Add(this.SolvingOut2Task);
            this.Controls.Add(this.Perform1TaskButton);
            this.Controls.Add(this.Perform2TaskButton);
            this.Controls.Add(this.Task1Task);
            this.Controls.Add(this.InputCoefs1Task);
            this.Controls.Add(this.CoefsLabel1Task);
            this.Controls.Add(this.Task2Task);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.MainTaskLabel);
            this.Controls.Add(this.CoefsLabel2Task);
            this.Controls.Add(this.InputCoefs2Task);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputCoefs2Task;
        private System.Windows.Forms.Label CoefsLabel2Task;
        private System.Windows.Forms.Label Task2Task;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MainTaskLabel;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Label CoefsLabel1Task;
        private System.Windows.Forms.TextBox InputCoefs1Task;
        private System.Windows.Forms.Label Task1Task;
        private System.Windows.Forms.Button Perform2TaskButton;
        private System.Windows.Forms.Button Perform1TaskButton;
        private System.Windows.Forms.Label SolvingOut2Task;
        private System.Windows.Forms.Label ProblemOut2Task;
        private System.Windows.Forms.Label SolvingOut1Task;
        private System.Windows.Forms.TextBox Step;
        private System.Windows.Forms.TextBox Interval;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

