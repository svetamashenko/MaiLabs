using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
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
                InputCoefs1Task.Visible = true;
                CoefsLabel1Task.Visible = true;
                Task1Task.Visible = true;
                SolvingOut1Task.Visible = true;
                Perform1TaskButton.Visible = true;
            }
            if (radioButton2.Checked == true)
            {
                MainButton.Visible = false;
                MainTaskLabel.Visible = false;
                groupBox1.Visible = false;
                Perform2TaskButton.Visible = true;
                MenuButton.Visible = true;
                CoefsLabel2Task.Visible = true;
                ProblemOut2Task.Visible = true;
                SolvingOut2Task.Visible = true;
                Task2Task.Visible = true;
                InputCoefs2Task.Visible = true;
            }
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (Perform1TaskButton.Visible == true)
            {
                MainButton.Visible = true;
                MainTaskLabel.Visible = true;
                groupBox1.Visible = true;
                InputCoefs1Task.Visible = false;
                CoefsLabel1Task.Visible = false;
                Task1Task.Visible = false;
                SolvingOut1Task.Visible = false;
                Perform1TaskButton.Visible = false;
                MenuButton.Visible = false;
            }
            if (Perform2TaskButton.Visible == true)
            {
                MainButton.Visible = true;
                MainTaskLabel.Visible = true;
                groupBox1.Visible = true;
                Perform2TaskButton.Visible = false;
                MenuButton.Visible = false;
                CoefsLabel2Task.Visible = false;
                ProblemOut2Task.Visible = false;
                SolvingOut2Task.Visible = false;
                Task2Task.Visible = false;
                InputCoefs2Task.Visible = false;
            }
        }

        //
        //1 задание
        //
        private void Perform1TaskButton_Click(object sender, EventArgs e)
        {
            SqMatrix sqMatrix = new SqMatrix(InputCoefs1Task.Text);
            Polynom polynom = SqMatrix.CharacterPolynom(sqMatrix);
            SolvingOut1Task.Text = "P(a) = " +  polynom.deParcer();
        }

        //
        // 2 задание
        //
        private void Perform2TaskButton_Click(object sender, EventArgs e)
        {
            SqMatrix sqMatrix = new SqMatrix(InputCoefs2Task.Text);
            Polynom polynom = SqMatrix.CharacterPolynom(sqMatrix);

            //что-то не так с дихотомией и хордами

            List<double> l = polynom.findRoots();
            SolvingOut2Task.Text = "a = " + l.Max().ToString();
        }

        public static double[] Newton(double[,] f1, int h1, int l1, double[,] f2, int h2, int l2)
        {
            double[] answer = new double[2];
            double x_curr = f((proizvodx(f1, h1, l1)), l1, h1, 0, 0);
            double y_curr = f((proizvody(f2, h1, l1)), l1, h1, 0, 0);
            for (double a = x_curr; (f(f1, l1, h1, a, y_curr) > 0.1) && (f(f2, l1, h1, a, y_curr) > 0.1); a -= 0.1)
                for (double b = y_curr; (f(f1, l1, h1, a, b) > 0.1) && (f(f2, l1, h1, a, b) > 0.1); b -= 0.1)
                {
                }
            do
            {
                double fxpro = f((proizvodx(f1, h1, l1)), l1, h1, x_curr, y_curr);
                double fypro = f((proizvody(f1, h1, l1)), l1, h1, x_curr, y_curr);
                double gxpro = f((proizvodx(f2, h2, l2)), l2, h2, x_curr, y_curr);
                double gypro = f((proizvody(f2, h2, l2)), l2, h2, x_curr, y_curr);
                double j = fxpro * gypro - fypro * gxpro;
                x_curr = x_curr - (1 / j) * (f(f1, l1, h1, x_curr, y_curr) * gypro - fypro * f(f2, l2, h2, x_curr, y_curr));
                y_curr = y_curr - (1 / j) * (-f(f1, l1, h1, x_curr, y_curr) * gxpro + fxpro * f(f2, l2, h2, x_curr, y_curr));
            } while ((f(f1, l1, h1, x_curr, y_curr) >= 0.000000001) && (f(f2, l2, h2, x_curr, y_curr) >= 0.000000001));
            answer[0] = x_curr;
            answer[1] = y_curr;
            return answer;
        }
        public static double f(double[] x, double i)
        {
            double result;
            result = x[0] * i + x[1];
            for (int s = 2; s < x.Length; s++)
            {
                result = result * i + x[s];
            }
            return result;
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
        public static double[] proizvod(double[] x)
        {
            double[] coefNew = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                coefNew[i] = x[i] * (x.Length - 1 - i);
            }
            return coefNew;
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
        public static string ProbOut(double[] coef)
        {
            string Old = "";
            int j = 0;
            while (coef[j] == 0)
            {
                j++;
            }
            int good = 0;
            if (j == 0)
                good = 0;
            else good = j - 1;
            for (int i = j; i < coef.Length - good; i++)
            {
                string sign = "+";
                if (coef[i] < 0)
                {
                    sign = "-";
                    coef[i] = coef[i] * -1;
                }
                if ((i != j))
                {
                    if (i == coef.Length - 2)
                    {
                        if (coef[i] != 0)
                        {
                            if (coef[i] != 1)
                            {
                                Old += sign + coef[i].ToString() + "x";
                            }
                            else
                            {
                                Old += sign + "x";
                            }
                        }
                    }
                    else if (i == coef.Length - 1)
                    {
                        if (coef[i] != 0)
                        {
                            if (coef[i] != 1)
                            {
                                Old += sign + coef[i].ToString();
                            }
                            else
                            {
                                Old += sign + "1";
                            }
                        }
                    }
                    else
                    {
                        if (coef[i] != 0)
                        {
                            if (coef[i] != 1)
                            {
                                Old += sign + coef[i].ToString() + "x^" + (coef.Length - i - 1).ToString();
                            }
                            else
                            {
                                Old += sign + "x^" + (coef.Length - i - 1).ToString();
                            }
                        }
                    }
                }
                else
                {
                    if (coef[i] != 0)
                    {
                        string newsign;
                        if (coef[i] != 1)
                        {
                            if (sign == "+")
                                newsign = "";
                            else
                                newsign = "-";
                            Old += newsign + coef[i].ToString() + "x^" + (coef.Length - i - 1).ToString();
                        }
                        else
                        {
                            if (sign == "+")
                            {
                                Old += "x^" + (coef.Length - i - 1).ToString();
                            }
                            else
                            {
                                Old += "-x^" + (coef.Length - i - 1).ToString();
                            }
                        }
                    }

                }
                if (sign == "-")
                {
                    coef[i] = coef[i] * -1;
                }
            }
            return Old;
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
