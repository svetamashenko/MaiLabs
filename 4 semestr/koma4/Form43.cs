using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koma4
{
    public partial class Form43 : Form
    {
        Form1 parent;
        public Form43(Form1 form1)
        {
            parent = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matrix matrix = new Matrix(richTextBox1.Text);
            richTextBox1.Text = matrix.ToTriangleForm().ToString();
            textBox1.Text = matrix.ToTriangleForm().DiagonalMultiplication().ToString();
        }
    }
}
