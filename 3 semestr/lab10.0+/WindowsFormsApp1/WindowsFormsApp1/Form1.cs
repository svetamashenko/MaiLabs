using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = button1.Location.X;
            int y = button1.Location.Y;
            Random n = new Random();
            int k = n.Next(4);
            switch (k)
            {

                case 1:
                    button1.Location = new Point(x + 10, y + 10);
                    break;
                case 2:
                    button1.Location = new Point(x - 10, y - 10);
                    break;
                case 3:
                    button1.Location = new Point(x + 10, y - 10);
                    break;
                case 4:
                    button1.Location = new Point(x - 10, y + 10);
                    break;
            }
            if (button1.Left < 0)
            { button1.Left = 0; }
            if ((button1.Left + button1.Width) > this.ClientSize.Width)
            { button1.Left = this.ClientSize.Width - button1.Width; }
            if (button1.Top < 0)
            { button1.Top = 0; }
            if ((button1.Top + button1.Height) > this.ClientSize.Height)
            {
                button1.Top = this.ClientSize.Height - button1.Height;
            }
        }

            private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = "Ввод пароля";
            textBox1.PasswordChar = '*';
            textBox1.TextAlign = HorizontalAlignment.Center; // пишем текст из середин
            label1.Text = textBox1.Text;
        } 
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
