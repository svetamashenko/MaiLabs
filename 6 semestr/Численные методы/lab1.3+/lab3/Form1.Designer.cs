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
            this.CoefsTextBox = new System.Windows.Forms.TextBox();
            this.CoefsLabel = new System.Windows.Forms.Label();
            this.SolvingLabel = new System.Windows.Forms.Label();
            this.DoButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.EpsilonLabel = new System.Windows.Forms.Label();
            this.EpsilonTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CoefsTextBox
            // 
            this.CoefsTextBox.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CoefsTextBox.Location = new System.Drawing.Point(52, 178);
            this.CoefsTextBox.Multiline = true;
            this.CoefsTextBox.Name = "CoefsTextBox";
            this.CoefsTextBox.Size = new System.Drawing.Size(166, 154);
            this.CoefsTextBox.TabIndex = 0;
            this.CoefsTextBox.Text = "-23 -7 5 2 -26\r\n-7 -21 4 9 -55\r\n9 5 -31 -8 -58\r\n0 1 -2 10 -24";
            // 
            // CoefsLabel
            // 
            this.CoefsLabel.AutoSize = true;
            this.CoefsLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CoefsLabel.Location = new System.Drawing.Point(48, 126);
            this.CoefsLabel.Name = "CoefsLabel";
            this.CoefsLabel.Size = new System.Drawing.Size(148, 21);
            this.CoefsLabel.TabIndex = 1;
            this.CoefsLabel.Text = "Входные данные:";
            // 
            // SolvingLabel
            // 
            this.SolvingLabel.AutoSize = true;
            this.SolvingLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SolvingLabel.Location = new System.Drawing.Point(480, 126);
            this.SolvingLabel.Name = "SolvingLabel";
            this.SolvingLabel.Size = new System.Drawing.Size(142, 21);
            this.SolvingLabel.TabIndex = 2;
            this.SolvingLabel.Text = "Решение СЛАУ: \n\n\n";
            // 
            // DoButton
            // 
            this.DoButton.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.DoButton.Location = new System.Drawing.Point(336, 355);
            this.DoButton.Name = "DoButton";
            this.DoButton.Size = new System.Drawing.Size(122, 38);
            this.DoButton.TabIndex = 3;
            this.DoButton.Text = "Решить.";
            this.DoButton.UseVisualStyleBackColor = true;
            this.DoButton.Click += new System.EventHandler(this.DoButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Метод простых итераций",
            "Метод Зейделя"});
            this.comboBox1.Location = new System.Drawing.Point(266, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // EpsilonLabel
            // 
            this.EpsilonLabel.AutoSize = true;
            this.EpsilonLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.EpsilonLabel.Location = new System.Drawing.Point(262, 126);
            this.EpsilonLabel.Name = "EpsilonLabel";
            this.EpsilonLabel.Size = new System.Drawing.Size(91, 21);
            this.EpsilonLabel.TabIndex = 6;
            this.EpsilonLabel.Text = "Точность:";
            // 
            // EpsilonTextBox
            // 
            this.EpsilonTextBox.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.EpsilonTextBox.Location = new System.Drawing.Point(266, 178);
            this.EpsilonTextBox.Name = "EpsilonTextBox";
            this.EpsilonTextBox.Size = new System.Drawing.Size(87, 29);
            this.EpsilonTextBox.TabIndex = 5;
            this.EpsilonTextBox.Text = "0,0001";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EpsilonLabel);
            this.Controls.Add(this.EpsilonTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DoButton);
            this.Controls.Add(this.SolvingLabel);
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
        private System.Windows.Forms.Label SolvingLabel;
        private System.Windows.Forms.Button DoButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label EpsilonLabel;
        private System.Windows.Forms.TextBox EpsilonTextBox;
    }
}

