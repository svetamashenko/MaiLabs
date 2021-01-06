using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labka3
{
    public partial class Form1 : Form
    {
        bool First = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (First)
            {
                Singleton.Source.Value = (int)numericUpDown2.Value;
                First = false;
                button1.Text = "Вывести значение";
            }
            MessageBox.Show("Хешкод = " + Singleton.Source.GetHashCode() + '\n' + "Значение поля Singleton = " + Singleton.Source.Value, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
