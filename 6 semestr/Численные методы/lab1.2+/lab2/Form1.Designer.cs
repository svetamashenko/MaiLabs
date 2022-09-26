namespace lab2
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
            this.CheckLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CoefsTextBox
            // 
            this.CoefsTextBox.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CoefsTextBox.Location = new System.Drawing.Point(112, 123);
            this.CoefsTextBox.Multiline = true;
            this.CoefsTextBox.Name = "CoefsTextBox";
            this.CoefsTextBox.Size = new System.Drawing.Size(166, 154);
            this.CoefsTextBox.TabIndex = 0;
            this.CoefsTextBox.Text = "13 -5 -66\r\n-4 9 -5 -47\r\n-1 -12 -6 -43\r\n6 20 -5 -74\r\n4 5 14";
            // 
            // CoefsLabel
            // 
            this.CoefsLabel.AutoSize = true;
            this.CoefsLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CoefsLabel.Location = new System.Drawing.Point(108, 71);
            this.CoefsLabel.Name = "CoefsLabel";
            this.CoefsLabel.Size = new System.Drawing.Size(148, 21);
            this.CoefsLabel.TabIndex = 1;
            this.CoefsLabel.Text = "Входные данные:";
            // 
            // SolvingLabel
            // 
            this.SolvingLabel.AutoSize = true;
            this.SolvingLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SolvingLabel.Location = new System.Drawing.Point(357, 71);
            this.SolvingLabel.Name = "SolvingLabel";
            this.SolvingLabel.Size = new System.Drawing.Size(142, 21);
            this.SolvingLabel.TabIndex = 2;
            this.SolvingLabel.Text = "Решение СЛАУ: \n";
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
            // CheckLabel
            // 
            this.CheckLabel.AutoSize = true;
            this.CheckLabel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CheckLabel.Location = new System.Drawing.Point(547, 71);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(170, 21);
            this.CheckLabel.TabIndex = 4;
            this.CheckLabel.Text = "Проверка решения: \n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckLabel);
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
        private System.Windows.Forms.Label CheckLabel;
    }
}

