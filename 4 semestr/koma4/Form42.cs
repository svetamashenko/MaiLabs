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
    public partial class Form42 : Form
    {
        Form1 parent;
        public Form42(Form1 form1)
        {
            parent = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matrix matrix = new Matrix(richTextBox1.Text);
            if (Matrix.Determinant(matrix) != 0){
                MatrixOfMatrix mom = new MatrixOfMatrix(matrix, true);
                richTextBox2.Text = mom.Reverse().ToMatrix().ToString();
                richTextBox2.Text = matrix.Reverse().ToString();
            }
            else
            {
                richTextBox2.Text = "Обратной матрицы не существует";
            }
            //готово
        }
    }
}
