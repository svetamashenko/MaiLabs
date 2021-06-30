namespace lab4
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
            this.InputCoefs2Task = new System.Windows.Forms.TextBox();
            this.NumberLabel2Task = new System.Windows.Forms.Label();
            this.Task2Task = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.MainTaskLabel = new System.Windows.Forms.Label();
            this.MainButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.MatrixLabel1Task = new System.Windows.Forms.Label();
            this.Matrix11Task = new System.Windows.Forms.TextBox();
            this.Task1Task = new System.Windows.Forms.Label();
            this.Perform2TaskButton = new System.Windows.Forms.Button();
            this.Perform1TaskButton = new System.Windows.Forms.Button();
            this.Task3Task = new System.Windows.Forms.Label();
            this.CoefsLabel3Task = new System.Windows.Forms.Label();
            this.InputCoefs3Task = new System.Windows.Forms.TextBox();
            this.ProblemOut1Task = new System.Windows.Forms.Label();
            this.ProblemOut3Task = new System.Windows.Forms.Label();
            this.SolvingOut3Task = new System.Windows.Forms.Label();
            this.SolvingOut2Task = new System.Windows.Forms.Label();
            this.ProblemOut2Task = new System.Windows.Forms.Label();
            this.SolvingOut1Task = new System.Windows.Forms.Label();
            this.Perform3TaskButton = new System.Windows.Forms.Button();
            this.Matrix21Task = new System.Windows.Forms.TextBox();
            this.MatrixLabel2Task = new System.Windows.Forms.Label();
            this.Out3Task = new System.Windows.Forms.RichTextBox();
            this.Out2Task = new System.Windows.Forms.RichTextBox();
            this.Out1Task = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputCoefs2Task
            // 
            this.InputCoefs2Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.InputCoefs2Task.Location = new System.Drawing.Point(214, 162);
            this.InputCoefs2Task.Name = "InputCoefs2Task";
            this.InputCoefs2Task.Size = new System.Drawing.Size(139, 29);
            this.InputCoefs2Task.TabIndex = 0;
            this.InputCoefs2Task.Visible = false;
            // 
            // NumberLabel2Task
            // 
            this.NumberLabel2Task.Location = new System.Drawing.Point(0, 0);
            this.NumberLabel2Task.Name = "NumberLabel2Task";
            this.NumberLabel2Task.Size = new System.Drawing.Size(100, 23);
            this.NumberLabel2Task.TabIndex = 33;
            // 
            // Task2Task
            // 
            this.Task2Task.AutoSize = true;
            this.Task2Task.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Task2Task.Location = new System.Drawing.Point(153, 50);
            this.Task2Task.Name = "Task2Task";
            this.Task2Task.Size = new System.Drawing.Size(300, 27);
            this.Task2Task.TabIndex = 8;
            this.Task2Task.Text = "2. Найти обратную матрицу.";
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
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(291, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 200);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(53, 117);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(102, 21);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Задание 3.";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // MainTaskLabel
            // 
            this.MainTaskLabel.AutoSize = true;
            this.MainTaskLabel.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.MainTaskLabel.Location = new System.Drawing.Point(234, 44);
            this.MainTaskLabel.Name = "MainTaskLabel";
            this.MainTaskLabel.Size = new System.Drawing.Size(326, 33);
            this.MainTaskLabel.TabIndex = 12;
            this.MainTaskLabel.Text = "Лабораторная работа №4.";
            this.MainTaskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainButton
            // 
            this.MainButton.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.MainButton.Location = new System.Drawing.Point(291, 398);
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
            // MatrixLabel1Task
            // 
            this.MatrixLabel1Task.AutoSize = true;
            this.MatrixLabel1Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.MatrixLabel1Task.Location = new System.Drawing.Point(185, 105);
            this.MatrixLabel1Task.Name = "MatrixLabel1Task";
            this.MatrixLabel1Task.Size = new System.Drawing.Size(155, 21);
            this.MatrixLabel1Task.TabIndex = 15;
            this.MatrixLabel1Task.Text = "Введите матрицы:";
            this.MatrixLabel1Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MatrixLabel1Task.Visible = false;
            // 
            // Matrix11Task
            // 
            this.Matrix11Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Matrix11Task.Location = new System.Drawing.Point(214, 162);
            this.Matrix11Task.Name = "Matrix11Task";
            this.Matrix11Task.Size = new System.Drawing.Size(139, 29);
            this.Matrix11Task.TabIndex = 17;
            this.Matrix11Task.Visible = false;
            // 
            // Task1Task
            // 
            this.Task1Task.AutoSize = true;
            this.Task1Task.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Task1Task.Location = new System.Drawing.Point(153, 50);
            this.Task1Task.Name = "Task1Task";
            this.Task1Task.Size = new System.Drawing.Size(365, 27);
            this.Task1Task.TabIndex = 19;
            this.Task1Task.Text = "1. Умножение квадратных матриц.";
            this.Task1Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Task1Task.Visible = false;
            // 
            // Perform2TaskButton
            // 
            this.Perform2TaskButton.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Perform2TaskButton.Location = new System.Drawing.Point(291, 226);
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
            this.Perform1TaskButton.Location = new System.Drawing.Point(291, 226);
            this.Perform1TaskButton.Name = "Perform1TaskButton";
            this.Perform1TaskButton.Size = new System.Drawing.Size(204, 42);
            this.Perform1TaskButton.TabIndex = 23;
            this.Perform1TaskButton.Text = "Умножить.";
            this.Perform1TaskButton.UseVisualStyleBackColor = true;
            this.Perform1TaskButton.Visible = false;
            this.Perform1TaskButton.Click += new System.EventHandler(this.Perform1TaskButton_Click);
            // 
            // Task3Task
            // 
            this.Task3Task.AutoSize = true;
            this.Task3Task.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Task3Task.Location = new System.Drawing.Point(153, 50);
            this.Task3Task.Name = "Task3Task";
            this.Task3Task.Size = new System.Drawing.Size(347, 27);
            this.Task3Task.TabIndex = 24;
            this.Task3Task.Text = "3. Найти определитель матрицы.";
            this.Task3Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Task3Task.Visible = false;
            // 
            // CoefsLabel3Task
            // 
            this.CoefsLabel3Task.AutoSize = true;
            this.CoefsLabel3Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CoefsLabel3Task.Location = new System.Drawing.Point(185, 105);
            this.CoefsLabel3Task.Name = "CoefsLabel3Task";
            this.CoefsLabel3Task.Size = new System.Drawing.Size(151, 21);
            this.CoefsLabel3Task.TabIndex = 25;
            this.CoefsLabel3Task.Text = "Введите матрицу:";
            this.CoefsLabel3Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CoefsLabel3Task.Visible = false;
            // 
            // InputCoefs3Task
            // 
            this.InputCoefs3Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.InputCoefs3Task.Location = new System.Drawing.Point(214, 162);
            this.InputCoefs3Task.Name = "InputCoefs3Task";
            this.InputCoefs3Task.Size = new System.Drawing.Size(139, 29);
            this.InputCoefs3Task.TabIndex = 27;
            this.InputCoefs3Task.Visible = false;
            // 
            // ProblemOut1Task
            // 
            this.ProblemOut1Task.AutoSize = true;
            this.ProblemOut1Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.ProblemOut1Task.Location = new System.Drawing.Point(300, 285);
            this.ProblemOut1Task.Name = "ProblemOut1Task";
            this.ProblemOut1Task.Size = new System.Drawing.Size(30, 30);
            this.ProblemOut1Task.TabIndex = 21;
            this.ProblemOut1Task.Text = " ";
            this.ProblemOut1Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProblemOut1Task.Visible = false;
            // 
            // ProblemOut3Task
            // 
            this.ProblemOut3Task.AutoSize = true;
            this.ProblemOut3Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.ProblemOut3Task.Location = new System.Drawing.Point(300, 285);
            this.ProblemOut3Task.Name = "ProblemOut3Task";
            this.ProblemOut3Task.Size = new System.Drawing.Size(15, 21);
            this.ProblemOut3Task.TabIndex = 28;
            this.ProblemOut3Task.Text = " ";
            this.ProblemOut3Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProblemOut3Task.Visible = false;
            // 
            // SolvingOut3Task
            // 
            this.SolvingOut3Task.AutoSize = true;
            this.SolvingOut3Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SolvingOut3Task.Location = new System.Drawing.Point(300, 375);
            this.SolvingOut3Task.Name = "SolvingOut3Task";
            this.SolvingOut3Task.Size = new System.Drawing.Size(15, 21);
            this.SolvingOut3Task.TabIndex = 29;
            this.SolvingOut3Task.Text = " ";
            this.SolvingOut3Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SolvingOut3Task.Visible = false;
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
            // Perform3TaskButton
            // 
            this.Perform3TaskButton.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Perform3TaskButton.Location = new System.Drawing.Point(291, 226);
            this.Perform3TaskButton.Name = "Perform3TaskButton";
            this.Perform3TaskButton.Size = new System.Drawing.Size(204, 42);
            this.Perform3TaskButton.TabIndex = 22;
            this.Perform3TaskButton.Text = "Найти.";
            this.Perform3TaskButton.UseVisualStyleBackColor = true;
            this.Perform3TaskButton.Visible = false;
            this.Perform3TaskButton.Click += new System.EventHandler(this.Perform3TaskButton_Click);
            // 
            // Matrix21Task
            // 
            this.Matrix21Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Matrix21Task.Location = new System.Drawing.Point(450, 162);
            this.Matrix21Task.Name = "Matrix21Task";
            this.Matrix21Task.Size = new System.Drawing.Size(139, 29);
            this.Matrix21Task.TabIndex = 34;
            this.Matrix21Task.Visible = false;
            // 
            // MatrixLabel2Task
            // 
            this.MatrixLabel2Task.AutoSize = true;
            this.MatrixLabel2Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.MatrixLabel2Task.Location = new System.Drawing.Point(185, 105);
            this.MatrixLabel2Task.Name = "MatrixLabel2Task";
            this.MatrixLabel2Task.Size = new System.Drawing.Size(151, 21);
            this.MatrixLabel2Task.TabIndex = 35;
            this.MatrixLabel2Task.Text = "Введите матрицу:";
            this.MatrixLabel2Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MatrixLabel2Task.Visible = false;
            // 
            // Out3Task
            // 
            this.Out3Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Out3Task.Location = new System.Drawing.Point(465, 285);
            this.Out3Task.Name = "Out3Task";
            this.Out3Task.Size = new System.Drawing.Size(110, 110);
            this.Out3Task.TabIndex = 36;
            this.Out3Task.Text = "";
            this.Out3Task.Visible = false;
            // 
            // richTextBox1
            // 
            this.Out2Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Out2Task.Location = new System.Drawing.Point(465, 285);
            this.Out2Task.Name = "richTextBox1";
            this.Out2Task.Size = new System.Drawing.Size(110, 110);
            this.Out2Task.TabIndex = 37;
            this.Out2Task.Text = "";
            this.Out2Task.Visible = false;
            // 
            // richTextBox2
            // 
            this.Out1Task.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Out1Task.Location = new System.Drawing.Point(465, 285);
            this.Out1Task.Name = "richTextBox2";
            this.Out1Task.Size = new System.Drawing.Size(110, 110);
            this.Out1Task.TabIndex = 38;
            this.Out1Task.Text = "";
            this.Out1Task.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.Out1Task);
            this.Controls.Add(this.Out2Task);
            this.Controls.Add(this.Out3Task);
            this.Controls.Add(this.MatrixLabel2Task);
            this.Controls.Add(this.Matrix21Task);
            this.Controls.Add(this.Perform3TaskButton);
            this.Controls.Add(this.SolvingOut1Task);
            this.Controls.Add(this.ProblemOut2Task);
            this.Controls.Add(this.SolvingOut2Task);
            this.Controls.Add(this.SolvingOut3Task);
            this.Controls.Add(this.ProblemOut3Task);
            this.Controls.Add(this.InputCoefs3Task);
            this.Controls.Add(this.CoefsLabel3Task);
            this.Controls.Add(this.Task3Task);
            this.Controls.Add(this.Perform1TaskButton);
            this.Controls.Add(this.Perform2TaskButton);
            this.Controls.Add(this.ProblemOut1Task);
            this.Controls.Add(this.Task1Task);
            this.Controls.Add(this.Matrix11Task);
            this.Controls.Add(this.MatrixLabel1Task);
            this.Controls.Add(this.Task2Task);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.MainTaskLabel);
            this.Controls.Add(this.NumberLabel2Task);
            this.Controls.Add(this.InputCoefs2Task);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputCoefs2Task;
        private System.Windows.Forms.Label NumberLabel2Task;
        private System.Windows.Forms.Label Task2Task;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MainTaskLabel;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Label MatrixLabel1Task;
        private System.Windows.Forms.TextBox Matrix11Task;
        private System.Windows.Forms.Label Task1Task;
        private System.Windows.Forms.Button Perform2TaskButton;
        private System.Windows.Forms.Button Perform1TaskButton;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label Task3Task;
        private System.Windows.Forms.Label CoefsLabel3Task;
        private System.Windows.Forms.TextBox InputCoefs3Task;
        private System.Windows.Forms.Label ProblemOut1Task;
        private System.Windows.Forms.Label ProblemOut3Task;
        private System.Windows.Forms.Label SolvingOut3Task;
        private System.Windows.Forms.Label SolvingOut2Task;
        private System.Windows.Forms.Label ProblemOut2Task;
        private System.Windows.Forms.Label SolvingOut1Task;
        private System.Windows.Forms.Button Perform3TaskButton;
        private System.Windows.Forms.TextBox Matrix21Task;
        private System.Windows.Forms.Label MatrixLabel2Task;
        private System.Windows.Forms.RichTextBox Out3Task;
        private System.Windows.Forms.RichTextBox Out2Task;
        private System.Windows.Forms.RichTextBox Out1Task;
    }
}

