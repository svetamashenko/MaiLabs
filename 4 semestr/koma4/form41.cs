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
    public partial class form41 : Form
    {
        private Form1 f1;
        public form41(Form1 form1)
        {
            f1 = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matrix m1 = new Matrix(richTextBox1.Text);
            Matrix m2 = new Matrix(richTextBox2.Text);

            MatrixOfMatrix mLeft = new MatrixOfMatrix(m1, false);
            MatrixOfMatrix mRight = new MatrixOfMatrix(m2, true);
            richTextBox3.Text = (mLeft * mRight).ToMatrix().ToString();

            //готово
        }
    }
}
