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
            this.Lab21RadioButton = new System.Windows.Forms.RadioButton();
            this.Lab22RadioButton = new System.Windows.Forms.RadioButton();
            this.DoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IterationSolvingLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EpsilonLabel = new System.Windows.Forms.Label();
            this.EpsilonTextBox = new System.Windows.Forms.TextBox();
            this.MenuButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lab21RadioButton
            // 
            this.Lab21RadioButton.AutoSize = true;
            this.Lab21RadioButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Lab21RadioButton.Location = new System.Drawing.Point(242, 130);
            this.Lab21RadioButton.Name = "Lab21RadioButton";
            this.Lab21RadioButton.Size = new System.Drawing.Size(285, 31);
            this.Lab21RadioButton.TabIndex = 0;
            this.Lab21RadioButton.TabStop = true;
            this.Lab21RadioButton.Text = "Лабораторная работа 2.1";
            this.Lab21RadioButton.UseVisualStyleBackColor = true;
            // 
            // Lab22RadioButton
            // 
            this.Lab22RadioButton.AutoSize = true;
            this.Lab22RadioButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Lab22RadioButton.Location = new System.Drawing.Point(242, 201);
            this.Lab22RadioButton.Name = "Lab22RadioButton";
            this.Lab22RadioButton.Size = new System.Drawing.Size(285, 31);
            this.Lab22RadioButton.TabIndex = 1;
            this.Lab22RadioButton.TabStop = true;
            this.Lab22RadioButton.Text = "Лабораторная работа 2.2";
            this.Lab22RadioButton.UseVisualStyleBackColor = true;
            // 
            // DoButton
            // 
            this.DoButton.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.DoButton.Location = new System.Drawing.Point(330, 400);
            this.DoButton.Name = "DoButton";
            this.DoButton.Size = new System.Drawing.Size(121, 38);
            this.DoButton.TabIndex = 2;
            this.DoButton.Text = "Выполнить";
            this.DoButton.UseVisualStyleBackColor = true;
            this.DoButton.Click += new System.EventHandler(this.DoButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lab21RadioButton);
            this.panel1.Controls.Add(this.Lab22RadioButton);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 391);
            this.panel1.TabIndex = 3;
            // 
            // IterationSolvingLabel
            // 
            this.IterationSolvingLabel.AutoSize = true;
            this.IterationSolvingLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.IterationSolvingLabel.Location = new System.Drawing.Point(264, 50);
            this.IterationSolvingLabel.Name = "IterationSolvingLabel";
            this.IterationSolvingLabel.Size = new System.Drawing.Size(237, 22);
            this.IterationSolvingLabel.TabIndex = 2;
            this.IterationSolvingLabel.Text = "Метод простых итераций: \n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EpsilonLabel);
            this.panel2.Controls.Add(this.EpsilonTextBox);
            this.panel2.Controls.Add(this.IterationSolvingLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 394);
            this.panel2.TabIndex = 4;
            // 
            // EpsilonLabel
            // 
            this.EpsilonLabel.AutoSize = true;
            this.EpsilonLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.EpsilonLabel.Location = new System.Drawing.Point(23, 50);
            this.EpsilonLabel.Name = "EpsilonLabel";
            this.EpsilonLabel.Size = new System.Drawing.Size(202, 22);
            this.EpsilonLabel.TabIndex = 1;
            this.EpsilonLabel.Text = "Точность вычислений:";
            // 
            // EpsilonTextBox
            // 
            this.EpsilonTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.EpsilonTextBox.Location = new System.Drawing.Point(63, 94);
            this.EpsilonTextBox.Name = "EpsilonTextBox";
            this.EpsilonTextBox.Size = new System.Drawing.Size(100, 30);
            this.EpsilonTextBox.TabIndex = 0;
            this.EpsilonTextBox.Text = "0,0001";
            // 
            // MenuButton
            // 
            this.MenuButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.MenuButton.Location = new System.Drawing.Point(662, 400);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.DoButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Lab21RadioButton;
        private System.Windows.Forms.RadioButton Lab22RadioButton;
        private System.Windows.Forms.Button DoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label EpsilonLabel;
        private System.Windows.Forms.TextBox EpsilonTextBox;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Label IterationSolvingLabel;
    }
}

