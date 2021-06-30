using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MainButton.Visible = false;
                MainTaskLabel.Visible = false;
                groupBox1.Visible = false;
                MenuButton.Visible = true;
                Matrix11Task.Visible = true;
                Matrix21Task.Visible = true;
                MatrixLabel1Task.Visible = true;
                Task1Task.Visible = true;
                SolvingOut1Task.Visible = true;
                ProblemOut1Task.Visible = true;
                Perform1TaskButton.Visible = true;
            }
            if (radioButton2.Checked == true)
            {
                MainButton.Visible = false;
                MainTaskLabel.Visible = false;
                groupBox1.Visible = false;
                Perform2TaskButton.Visible = true;
                MenuButton.Visible = true;
                MatrixLabel2Task.Visible = true;
                ProblemOut2Task.Visible = true;
                NumberLabel2Task.Visible = true;
                SolvingOut2Task.Visible = true;
                Task2Task.Visible = true;
                InputCoefs2Task.Visible = true;
            }
            if (radioButton3.Checked == true)
            {
                MainButton.Visible = false;
                MainTaskLabel.Visible = false;
                groupBox1.Visible = false;
                Perform3TaskButton.Visible = true;
                MenuButton.Visible = true;
                Task3Task.Visible = true;
                CoefsLabel3Task.Visible = true;
                InputCoefs3Task.Visible = true;
                ProblemOut3Task.Visible = true;
                SolvingOut3Task.Visible = true;
            }
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (Perform1TaskButton.Visible == true)
            {
                MainButton.Visible = true;
                MainTaskLabel.Visible = true;
                groupBox1.Visible = true;
                Matrix11Task.Visible = false;
                Matrix21Task.Visible = false;
                MatrixLabel1Task.Visible = false;
                Task1Task.Visible = false;
                SolvingOut2Task.Visible = false;
                ProblemOut1Task.Visible = false;
                Perform1TaskButton.Visible = false;
                MenuButton.Visible = false;
                Out1Task.Visible = false;
            }
            if (Perform2TaskButton.Visible == true)
            {
                MainButton.Visible = true;
                MainTaskLabel.Visible = true;
                groupBox1.Visible = true;
                Perform2TaskButton.Visible = false;
                MatrixLabel2Task.Visible = false;
                MenuButton.Visible = false;
                ProblemOut2Task.Visible = false;
                NumberLabel2Task.Visible = false;
                SolvingOut2Task.Visible = false;
                Task2Task.Visible = false;
                InputCoefs2Task.Visible = false;
                Out2Task.Visible = false;
            }
            if (Perform3TaskButton.Visible == true)
            {
                MainButton.Visible = true;
                MainTaskLabel.Visible = true;
                groupBox1.Visible = true;
                Perform3TaskButton.Visible = false;
                MenuButton.Visible = false;
                Task3Task.Visible = false;
                CoefsLabel3Task.Visible = false;
                InputCoefs3Task.Visible = false;
                ProblemOut3Task.Visible = false;
                SolvingOut3Task.Visible = false;
                Out3Task.Visible = false;
            }
        }

        //
        //1 задание
        //
        private void Perform1TaskButton_Click(object sender, EventArgs e)
        {
            Matrix m1 = new Matrix(Matrix11Task.Text);
            Matrix m2 = new Matrix(Matrix21Task.Text);

            MatrixOfMatrix mLeft = new MatrixOfMatrix(m1, false);
            MatrixOfMatrix mRight = new MatrixOfMatrix(m2, true);
            SolvingOut1Task.Text = "";
            Out1Task.Text = (mLeft * mRight).ToMatrix().ToString();
            Out1Task.Visible = true;
        }

        //
        // 2 задание
        //
        private void Perform2TaskButton_Click(object sender, EventArgs e)
        {
            Matrix matrix = new Matrix(InputCoefs2Task.Text);
            if (Matrix.Determinant(matrix) != 0)
            {
                MatrixOfMatrix mom = new MatrixOfMatrix(matrix, true);
                Out2Task.Text = mom.Reverse().ToMatrix().ToString();
                Out2Task.Text = matrix.Reverse().ToString();
                Out2Task.Visible = true;
                SolvingOut2Task.Text = "Обратная\nматрица:";
            }
            else
            {
                Out2Task.Visible = false;
                SolvingOut2Task.Text = "Обратной матрицы не существует.";
            }
        }

        //
        // 3 задание
        //
        private void Perform3TaskButton_Click(object sender, EventArgs e)
        {
            Matrix matrix = new Matrix(InputCoefs3Task.Text);
            ProblemOut3Task.Text = "Преобразованная\nматрица: ";
            Out3Task.Text = matrix.ToTriangleForm().ToString();
            Out3Task.Visible = true;
            SolvingOut3Task.Text = "Определитель: " + matrix.ToTriangleForm().DiagonalMultiplication().ToString();
        }

        public static double f(double[,] coef, int lenght, int high, double x, double y)
        {
            double result = 0;
            for (int h = 0; h < high; h++)
            {
                double resultx = coef[0, h] * x + coef[1, h];
                for (int l = 2; l < lenght; l++)
                {
                    resultx = resultx * x + coef[l, h];
                }
                if (h == 0)
                    result += resultx * y;
                else if (h == high - 1)
                    result += resultx;
                else
                    result = (result + resultx) * y;
            }
            return result;
        }
        public static double[,] proizvodx(double[,] coef, int high, int lenght)
        {
            double[,] answer = new double[lenght + 1, high];
            for (int h = 0; h < high; h++)
                for (int l = lenght - 1; l >= 0; l--)
                {
                    answer[lenght - l, h] = coef[lenght - l - 1, h] * l;
                }
            return answer;
        }
        public static double[,] proizvody(double[,] coef, int high, int lenght)
        {
            double[,] answer = new double[lenght, high + 1];
            for (int l = 0; l < lenght; l++)
                for (int h = high - 1; h >= 0; h--)
                {
                    answer[l, high - h] = coef[l, high - h - 1] * h;
                }
            return answer;
        }
        public static string Prob2Out(double[,] coef, int high, int lenght)
        {
            string Old = "";
            for (int h = high - 1; h >= 0; h--)
                for (int l = lenght - 1; l >= 0; l--)
                {
                    string sign = "+";
                    if (coef[lenght - l - 1, high - h - 1] < 0)
                    {
                        sign = "-";
                        coef[lenght - l - 1, high - h - 1] = coef[lenght - l - 1, high - h - 1] * -1;
                    }
                    if (coef[lenght - l - 1, high - h - 1] == 0)
                    {
                    }
                    else if (((l == lenght - 1) && (h == high - 1) && (sign == "+")) || ((Old == "") && (sign == "+")))
                    {
                        if (coef[lenght - l - 1, high - h - 1] == 1)
                        {
                            if ((l == 1) && (h != 1) && (h != 0))
                                Old += "xy^" + h;
                            else if ((h == 1) && (l != 1) && (l != 0))
                                Old += "x^" + l + "y";
                            else if ((l == 0) && (h != 1) && (h != 0))
                                Old += "y^" + h;
                            else if ((h == 0) && (l != 1) && (l != 0))
                                Old += "x^" + l;
                            else if ((h == 1) && (l == 1))
                                Old += "xy";
                            else if ((h == 1) && (l == 0))
                                Old += "y";
                            else if ((h == 0) && (l == 1))
                                Old += "x";
                            else if ((h == 0) && (l == 0))
                                Old += "1";
                            else Old += "x^" + l + "y^" + h;
                        }
                        else
                        {
                            if ((l == 1) && (h != 1) && (h != 0))
                                Old += coef[lenght - l - 1, high - h - 1] + "xy^" + h;
                            else if ((h == 1) && (l != 1) && (l != 0))
                                Old += coef[lenght - l - 1, high - h - 1] + "x^" + l + "y";
                            else if ((l == 0) && (h != 1) && (h != 0))
                                Old += coef[lenght - l - 1, high - h - 1] + "y^" + h;
                            else if ((h == 0) && (l != 1) && (l != 0))
                                Old += coef[lenght - l - 1, high - h - 1] + "x^" + l;
                            else if ((h == 1) && (l == 1))
                                Old += coef[lenght - l - 1, high - h - 1] + "xy";
                            else if ((h == 1) && (l == 0))
                                Old += coef[lenght - l - 1, high - h - 1] + "y";
                            else if ((h == 0) && (l == 1))
                                Old += coef[lenght - l - 1, high - h - 1] + "x";
                            else if ((h == 0) && (l == 0))
                                Old += coef[lenght - l - 1, high - h - 1];
                            else Old += coef[lenght - l - 1, high - h - 1] + "x^" + l + "y^" + h;
                        }
                    }
                    else if (coef[lenght - l - 1, high - h - 1] == 1)
                    {
                        if ((l == 1) && (h != 1) && (h != 0))
                            Old += sign + "xy^" + h;
                        else if ((h == 1) && (l != 1) && (l != 0))
                            Old += sign + "x^" + l + "y";
                        else if ((l == 0) && (h != 1) && (h != 0))
                            Old += sign + "y^" + h;
                        else if ((h == 0) && (l != 1) && (l != 0))
                            Old += sign + "x^" + l;
                        else if ((h == 1) && (l == 1))
                            Old += sign + "xy";
                        else if ((h == 1) && (l == 0))
                            Old += sign + "y";
                        else if ((h == 0) && (l == 1))
                            Old += sign + "x";
                        else if ((h == 0) && (l == 0))
                            Old += sign + "1";
                        else Old += sign + "x^" + l + "y^" + h;
                    }
                    else
                    {
                        if ((l == 1) && (h != 1) && (h != 0))
                            Old += sign + coef[lenght - l - 1, high - h - 1] + "xy^" + h;
                        else if ((h == 1) && (l != 1) && (l != 0))
                            Old += sign + coef[lenght - l - 1, high - h - 1] + "x^" + l + "y";
                        else if ((l == 0) && (h != 1) && (h != 0))
                            Old += sign + coef[lenght - l - 1, high - h - 1] + "y^" + h;
                        else if ((h == 0) && (l != 1) && (l != 0))
                            Old += sign + coef[lenght - l - 1, high - h - 1] + "x^" + l;
                        else if ((h == 1) && (l == 1))
                            Old += sign + coef[lenght - l - 1, high - h - 1] + "xy";
                        else if ((h == 1) && (l == 0))
                            Old += sign + coef[lenght - l - 1, high - h - 1] + "y";
                        else if ((h == 0) && (l == 1))
                            Old += sign + coef[lenght - l - 1, high - h - 1] + "x";
                        else if ((h == 0) && (l == 0))
                            Old += sign + coef[lenght - l - 1, high - h - 1];
                        else Old += sign + coef[lenght - l - 1, high - h - 1] + "x^" + l + "y^" + h;
                    }
                    if (sign == "-")
                    {
                        coef[lenght - l - 1, high - h - 1] = coef[lenght - l - 1, high - h - 1] * -1;
                    }
                }
            return Old;
        }
    }
}
