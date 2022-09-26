namespace lab1._5
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
            this.CoefsTextBox = new System.Windows.Forms.TextBox();
            this.CoefsLabel = new System.Windows.Forms.Label();
            this.QLabel = new System.Windows.Forms.Label();
            this.DoButton = new System.Windows.Forms.Button();
            this.EpsilonLabel = new System.Windows.Forms.Label();
            this.EpsilonTextBox = new System.Windows.Forms.TextBox();
            this.CheckLabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CoefsTextBox
            // 
            this.CoefsTextBox.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CoefsTextBox.Location = new System.Drawing.Point(31, 129);
            this.CoefsTextBox.Multiline = true;
            this.CoefsTextBox.Name = "CoefsTextBox";
            this.CoefsTextBox.Size = new System.Drawing.Size(166, 154);
            this.CoefsTextBox.TabIndex = 0;
            this.CoefsTextBox.Text = "5 -5 -6\r\n-1 -8 -5\r\n2 7 -3";
            // 
            // CoefsLabel
            // 
            this.CoefsLabel.AutoSize = true;
            this.CoefsLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CoefsLabel.Location = new System.Drawing.Point(27, 77);
            this.CoefsLabel.Name = "CoefsLabel";
            this.CoefsLabel.Size = new System.Drawing.Size(148, 21);
            this.CoefsLabel.TabIndex = 1;
            this.CoefsLabel.Text = "Входные данные:";
            // 
            // QLabel
            // 
            this.QLabel.AutoSize = true;
            this.QLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.QLabel.Location = new System.Drawing.Point(332, 77);
            this.QLabel.Name = "QLabel";
            this.QLabel.Size = new System.Drawing.Size(108, 42);
            this.QLabel.TabIndex = 2;
            this.QLabel.Text = "Матрица Q: \n\n";
            // 
            // DoButton
            // 
            this.DoButton.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.DoButton.Location = new System.Drawing.Point(336, 390);
            this.DoButton.Name = "DoButton";
            this.DoButton.Size = new System.Drawing.Size(122, 38);
            this.DoButton.TabIndex = 3;
            this.DoButton.Text = "Вычислить.";
            this.DoButton.UseVisualStyleBackColor = true;
            this.DoButton.Click += new System.EventHandler(this.DoButton_Click);
            // 
            // EpsilonLabel
            // 
            this.EpsilonLabel.AutoSize = true;
            this.EpsilonLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.EpsilonLabel.Location = new System.Drawing.Point(212, 77);
            this.EpsilonLabel.Name = "EpsilonLabel";
            this.EpsilonLabel.Size = new System.Drawing.Size(91, 21);
            this.EpsilonLabel.TabIndex = 6;
            this.EpsilonLabel.Text = "Точность:";
            // 
            // EpsilonTextBox
            // 
            this.EpsilonTextBox.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.EpsilonTextBox.Location = new System.Drawing.Point(216, 129);
            this.EpsilonTextBox.Name = "EpsilonTextBox";
            this.EpsilonTextBox.Size = new System.Drawing.Size(87, 29);
            this.EpsilonTextBox.TabIndex = 5;
            this.EpsilonTextBox.Text = "0,0001";
            // 
            // CheckLabel
            // 
            this.CheckLabel.AutoSize = true;
            this.CheckLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CheckLabel.Location = new System.Drawing.Point(418, 237);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(96, 63);
            this.CheckLabel.TabIndex = 7;
            this.CheckLabel.Text = "Проверка: \n\n\n";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.RLabel.Location = new System.Drawing.Point(505, 77);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(107, 42);
            this.RLabel.TabIndex = 8;
            this.RLabel.Text = "Матрица R: \n\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.EpsilonLabel);
            this.Controls.Add(this.EpsilonTextBox);
            this.Controls.Add(this.DoButton);
            this.Controls.Add(this.QLabel);
            this.Controls.Add(this.CoefsLabel);
            this.Controls.Add(this.CoefsTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CoefsTextBox;
        private System.Windows.Forms.Label CoefsLabel;
        private System.Windows.Forms.Label QLabel;
        private System.Windows.Forms.Button DoButton;
        private System.Windows.Forms.Label EpsilonLabel;
        private System.Windows.Forms.TextBox EpsilonTextBox;
        private System.Windows.Forms.Label CheckLabel;
        private System.Windows.Forms.Label RLabel;
    }
}

