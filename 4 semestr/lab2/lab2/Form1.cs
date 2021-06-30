using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace lab2
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
                CoefsLabel2Task.Visible = true;
                ProblemOut2Task.Visible = true;
                NumberLabel2Task.Visible = true;
                SolvingOut2Task.Visible = true;
                Task2Task.Visible = true;
                InputCoefs2Task.Visible = true;
                InputNumber2Task.Visible = true;
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
                NumberLabel3Task.Visible = true;
                InputCoefs3Task.Visible = true;
                InputNumber3Task.Visible = true;
                ProblemOut3Task.Visible = true;
                SolvingOut3Task.Visible = true;
            }
            if (radioButton4.Checked == true)
            {
                MainButton.Visible = false;
                MainTaskLabel.Visible = false;
                groupBox1.Visible = false;
                Perform4TaskButton.Visible = true;
                MenuButton.Visible = true;
                Task4Task.Visible = true;
                CoefsLabel4Task.Visible = true;
                InputCoefs4Task.Visible = true;
                ProblemOut4Task.Visible = true;
                SolvingOut4Task.Visible = true;
                NumberLabel4Task.Visible = true;
                InputNumber4Task.Visible = true;
            }
            if (radioButton5.Checked == true)
            {
                MainButton.Visible = false;
                MainTaskLabel.Visible = false;
                groupBox1.Visible = false;
                Perform5TaskButton.Visible = true;
                MenuButton.Visible = true;
                Task5Task.Visible = true;
                CoefsLabel5Task.Visible = true;
                InputCoefs5Task.Visible = true;
                ProblemOut5Task.Visible = true;
                SolvingOut5Task.Visible = true;
            }
            if (radioButton6.Checked == true)
            {
                MainButton.Visible = false;
                MainTaskLabel.Visible = false;
                groupBox1.Visible = false;
                Perform6TaskButton.Visible = true;
                MenuButton.Visible = true;
                Task6Task.Visible = true;
                CoefsLabel6Task.Visible = true;
                Real.Visible = true;
                Complex.Visible = true;
                ProblemOut6Task.Visible = true;
                SolvingOut6Task.Visible = true;
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
                ProblemOut1Task.Visible = false;
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
                NumberLabel2Task.Visible = false;
                SolvingOut2Task.Visible = false;
                Task2Task.Visible = false;
                InputCoefs2Task.Visible = false;
                InputNumber2Task.Visible = false;
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
                NumberLabel3Task.Visible = false;
                InputCoefs3Task.Visible = false;
                InputNumber3Task.Visible = false;
                ProblemOut3Task.Visible = false;
                SolvingOut3Task.Visible = false;
            }
            if (Perform4TaskButton.Visible == true)
            {
                MainButton.Visible = true;
                MainTaskLabel.Visible = true;
                groupBox1.Visible = true;
                Perform4TaskButton.Visible = false;
                MenuButton.Visible = false;
                Task4Task.Visible = false;
                CoefsLabel4Task.Visible = false;
                InputCoefs4Task.Visible = false;
                ProblemOut4Task.Visible = false;
                SolvingOut4Task.Visible = false;
                NumberLabel4Task.Visible = false;
                InputNumber4Task.Visible = false;
            }
            if (Perform5TaskButton.Visible == true)
            {
                MainButton.Visible = true;
                MainTaskLabel.Visible = true;
                groupBox1.Visible = true;
                Perform5TaskButton.Visible = false;
                MenuButton.Visible = false;
                Task5Task.Visible = false;
                CoefsLabel5Task.Visible = false;
                InputCoefs5Task.Visible = false;
                ProblemOut5Task.Visible = false;
                SolvingOut5Task.Visible = false;
            }
            if (Perform6TaskButton.Visible == true)
            {
                MainButton.Visible = true;
                MainTaskLabel.Visible = true;
                groupBox1.Visible = true;
                Perform6TaskButton.Visible = false;
                MenuButton.Visible = false;
                Task6Task.Visible = false;
                CoefsLabel6Task.Visible = false;
                Real.Visible = false;
                Complex.Visible = false;
                ProblemOut6Task.Visible = false;
                SolvingOut6Task.Visible = false;
            }
        }

        //
        //1 задание
        //
        private void Perform1TaskButton_Click(object sender, EventArgs e)
        {
            double[] coef;
            coef = InputCoefs1Task.Text.Split(' ').Select(Double.Parse).ToArray();
            string Old = "f(x) = " + ProbOut(coef);
            ProblemOut1Task.Text = Old;
            double[] coefNew = proizvod(coef);
            string Out2 = "f'(x) = " + ProbOut(coefNew);
            SolvingOut1Task.Text = Out2;
        }

        //
        // 2 задание
        //
        private void Perform2TaskButton_Click(object sender, EventArgs e)
        {
            double[] coef;
            coef = InputCoefs2Task.Text.Split(' ').Select(double.Parse).ToArray();
            string Old = "f(x) = " + ProbOut(coef);
            ProblemOut2Task.Text = Old;
            double x_curr;
            x_curr = Convert.ToDouble(InputNumber2Task.Text) + 0.005;
            double Res1 = 0;
            string Prob = "";
            double fcoef = coef[0] * (x_curr + 0.5) + coef[1];
            for (int i = 2; i < coef.Length; i++)
            {
                fcoef = fcoef * (x_curr + 0.5) + coef[i];
            }
            Res1 = fcoef;
            double x_prev = 0;
            double scoef = 0;
            double proizvod1 = f(proizvod(coef), x_curr);
            for (double i = x_curr; i > -100000; i -= 0.005)
            {
                scoef = f(coef, i);
                x_curr = x_prev;
                x_prev = i;
                double proizvod2 = f(proizvod(coef), i);
                if ((scoef * fcoef < 0) || (proizvod1 * proizvod2 < 0))
                    break;
            }
            double x_next = 0;
            double tmp;
            do
            {
                tmp = x_next;
                x_next = x_curr - f(coef, x_curr) * (x_prev - x_curr) / (f(coef, x_prev) - f(coef, x_curr));
                x_prev = x_curr;
                x_curr = tmp;
            } while (Math.Abs(x_next - x_curr) > 0.001);
            Prob += Math.Round(x_next, 0);
            SolvingOut2Task.Text = Prob;
        }

        //
        // 3 задание
        //
        private void Perform3TaskButton_Click(object sender, EventArgs e)
        {
            double[] coef;
            coef = InputCoefs3Task.Text.Split(' ').Select(double.Parse).ToArray();
            string Old = "f(x) = " + ProbOut(coef);
            ProblemOut3Task.Text = Old;
            double x_curr;
            x_curr = Convert.ToDouble(InputNumber3Task.Text) + 0.005;
            string Prob = "";
            do
            {
                x_curr = x_curr - (f(coef, x_curr) / f(proizvod(coef), x_curr));
            } while (f(coef, x_curr) > 0.001);
            Prob += Math.Round(x_curr, 0);
            SolvingOut3Task.Text = Prob;
        }

        //
        // 4 задание
        //
        private void Perform4TaskButton_Click(object sender, EventArgs e)
        {
            string[] coefstr;
            coefstr = InputCoefs4Task.Text.Split(';').ToArray();
            double[] coeflencount = coefstr[0].Split(' ').Select(double.Parse).ToArray();
            int l = coeflencount.Length;
            int h = coefstr.Length;
            double[,] coef = new double[l, h];
            for (int i = 0; i < h; i++)
            {
                double[] coeftr = coefstr[i].Split(' ').Select(double.Parse).ToArray();
                for (int c = 0; c < l; c++)
                    coef[c, i] = coeftr[c];
            }
            string Old = "f(x, y)=" + Prob2Out(coef, h, l);
            ProblemOut4Task.Text = Old;
            double[] perem = new double[2];
            perem = InputNumber4Task.Text.Split(' ').Select(double.Parse).ToArray();
            double x = perem[0];
            double y = perem[1];
            string Prob = "f(" + x + ',' + y + ")=" + f(coef, l, h, x, y);
            SolvingOut4Task.Text = Prob;
        }

        //
        // 5 задание
        //
        static double counter(double[] prob, double x)
        {
            double result = prob[0] * x + prob[1];
            for (int i = 2; i < prob.Length; i++)
            {
                result = result * x + prob[i];
            }
            return result;
        }
        private void Perform5TaskButton_Click(object sender, EventArgs e)
        {
            string[] coefstr;
            coefstr = InputCoefs5Task.Text.Split(';').ToArray();
            double[] coeflencount = coefstr[0].Split(' ').Select(double.Parse).ToArray();
            int l = coeflencount.Length;
            int h = coefstr.Length;
            double[,] coef = new double[l, h];
            for (int i = 0; i < h; i++)
            {
                double[] coeftr = coefstr[i].Split(' ').Select(double.Parse).ToArray();
                for (int c = 0; c < l; c++)
                    coef[c, i] = coeftr[c];
            }
            string Old = "f(x, y)=" + Prob2Out(coef, h, l);
            ProblemOut5Task.Text = Old;
            string Prob = "f'(x)=" + Prob2Out(proizvodx(coef, h, l), h, l) + "\nf'(y)=" + Prob2Out(proizvody(coef, h, l), h, l);
            SolvingOut5Task.Text = Prob;
        }
        private void Perform6TaskButton_Click(object sender, EventArgs e)
        {
            string[] coefstr;
            coefstr = Real.Text.Split(';').ToArray();
            double[] coeflencount = coefstr[0].Split(' ').Select(double.Parse).ToArray();
            int l = coeflencount.Length;
            int h = coefstr.Length;
            double[,] coefreal = new double[l, h];
            for (int i = 0; i < h; i++)
            {
                double[] coeftr = coefstr[i].Split(' ').Select(double.Parse).ToArray();
                for (int c = 0; c < l; c++)
                    coefreal[c, i] = coeftr[c];
            }
            string[] coefstr2;
            coefstr2 = Complex.Text.Split(';').ToArray();
            double[] coeflencount2 = coefstr2[0].Split(' ').Select(double.Parse).ToArray();
            int l2 = coeflencount2.Length;
            int h2 = coefstr2.Length;
            double[,] coefcomplex = new double[l2, h2];
            for (int i = 0; i < h2; i++)
            {
                double[] coeftr2 = coefstr2[i].Split(' ').Select(double.Parse).ToArray();
                for (int c = 0; c < l2; c++)
                    coefcomplex[c, i] = coeftr2[c];
            }
            double[] Newt = /*Newton(coefreal, h, l, coefcomplex, h2, l2,*/ Newton(coefreal, h, l, coefcomplex, h2, l2)/*)*/;
            string Old = "f(x, y)=" + Prob2Out(coefreal, h, l);
            ProblemOut6Task.Text = Old;
            string Prob = "Корень: [" + Math.Round(Newt[0],2)+";" + Math.Round(Newt[1],4)+"]";
            SolvingOut6Task.Text = Prob;
        }

        public static double[] Newton(double[,] f1, int h1, int l1, double[,] f2, int h2, int l2)
        {
            double[] answer = new double[2];
            double x_curr = 2;// f((proizvodx(f1, h1, l1)), l1, h1, 0, 0);
            double y_curr = 2;// f((proizvody(f2, h1, l1)), l1, h1, 0, 0);
            for (double a = x_curr; a < -3; a -= 0.01)
                for (double b = y_curr; b > 3; b += 0.01)
                {
                    if ((Math.Pow(f(f1, l1, h1, a, b),2) < (Math.Pow(f(f1, l1, h1, x_curr, y_curr),2))) && (f(f1, l1, h1, a, b) < 1) && (f(f1, l1, h1, a, b) > 1))
                    {
                        x_curr = a;
                        y_curr = b;
                    }
                }
            x_curr = 1.2;
            y_curr = 1.7;
            do
            {
                double fxpro = f((proizvodx(f1, h1, l1)), l1, h1, x_curr, y_curr);
                double fypro = f((proizvody(f1, h1, l1)), l1, h1, x_curr, y_curr);
                double gxpro = f((proizvodx(f2, h2, l2)), l2, h2, x_curr, y_curr);
                double gypro = f((proizvody(f2, h2, l2)), l2, h2, x_curr, y_curr);
                double j = fxpro * gypro - fypro * gxpro;
                x_curr = x_curr - (1 / j) * (f(f1, l1, h1, x_curr, y_curr) * gypro - fypro * f(f2, l2, h2, x_curr, y_curr));
                y_curr = y_curr - (1 / j) * (-f(f1, l1, h1, x_curr, y_curr) * gxpro + fxpro * f(f2, l2, h2, x_curr, y_curr));
            } while ((f(f1, l1, h1, x_curr, y_curr)>= 0.0000000000001) && (f(f2, l2, h2, x_curr, y_curr)>= 0.0000000000001));
            answer[0] = x_curr;
            answer[1] = y_curr;
            return answer;
        }
       /* public static double[] Newton(double[,] f1, int h1, int l1, double[,] f2, int h2, int l2, double[] perem)
        {

        }*/
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
            double[] coefNew = new double[x.Length - 1];
            for (int i = 0; i < x.Length - 1; i++)
            {
                coefNew[i] = x[i] * (coefNew.Length - i);
            }
            return coefNew;
        }
        public static double[,] proizvodx(double[,] coef, int high, int lenght)
        {
            double[,] answer = new double[lenght+1, high];
            for (int h = 0; h < high; h++)
                for (int l = lenght - 1; l >=0; l--)
                { 
                    answer[lenght-l, h] = coef[lenght - l-1, h] * l;
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
            int prof = 0;
            for (int i = 0; i < coef.Length; i++)
            {
                if ((coef[i] == 0) && (prof == 0))
                {
                    j++;
                }
                else
                    prof++;
            }
            if (j == coef.Length)
                return "0";
            else if (j == coef.Length - 1)
            {
                string sign1 = "";
                if (coef[j] < 0)
                {
                    sign1 = "-";
                    coef[j] = coef[j] * -1;
                }
                Old +=sign1+ coef[j];
                if(sign1=="-")
                coef[j] = coef[j] * -1;
                return Old;
            }
            else if (j == coef.Length - 2)
            {
                if (coef[1+j] != 0)
                {
                    string sign1 = "";
                    string sign2 = "+";
                    if (coef[j] < 0)
                    {
                        sign1 = "-";
                        coef[j] = coef[j] * -1;
                    }
                    if (coef[1] < 0)
                    {
                        sign2 = "-";
                        coef[1 + j] = coef[1 + j] * -1;
                    }

                    Old += sign1 + coef[0 + j] + "x" + sign2 + coef[1 + j];
                    if (sign1 == "-")
                        coef[0 + j] = coef[0 + j] * -1;
                    if (sign2 == "-")
                        coef[1 + j] = coef[1 + j] * -1;
                    return Old;
                }
                else
                {
                    string sign1 = "";
                    if (coef[j] < 0)
                    {
                        sign1 = "-";
                        coef[j] = coef[j] * -1;
                    }
                    Old += sign1 + coef[0 + j] + "x";
                    if (sign1 == "-")
                        coef[0 + j] = coef[0 + j] * -1;
                    return Old;
                }
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
                            if (j == coef.Length - 2)
                            {
                                if (coef[j] == 1)
                                {
                                    if (sign == "+")
                                        Old += "x";
                                    else
                                        Old += sign + "x";
                                }
                                else if (sign == "+")
                                    Old += coef[i] + "x";
                                else
                                    Old += sign + coef[i] + "x";
                            }
                            else if (sign == "+")
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
                    if (coef[lenght - l-1, high - h-1] < 0)
                    {
                        sign = "-";
                        coef[lenght - l-1, high - h-1] = coef[lenght-l-1, high-h-1] * -1;
                    }
                    if (coef[lenght - l - 1, high - h - 1] == 0)
                    {
                    }
                    else if (((l == lenght - 1) && (h == high - 1) && (sign == "+")) || ((Old == "") && (sign == "+")))
                    {
                        if (coef[lenght - l-1, high - h-1] == 1)
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
                                Old += coef[lenght - l-1, high - h-1] + "xy^" + h;
                            else if ((h == 1) && (l != 1) && (l != 0))
                                Old += coef[lenght - l-1, high - h-1] + "x^" + l + "y";
                            else if ((l == 0) && (h != 1) && (h != 0))
                                Old += coef[lenght - l-1, high - h-1] + "y^" + h;
                            else if ((h == 0) && (l != 1) && (l != 0))
                                Old += coef[lenght - l-1, high - h-1] + "x^" + l;
                            else if ((h == 1) && (l == 1))
                                Old += coef[lenght - l-1, high - h-1] + "xy";
                            else if ((h == 1) && (l == 0))
                                Old += coef[lenght - l-1, high - h-1] + "y";
                            else if ((h == 0) && (l == 1))
                                Old += coef[lenght - l-1, high - h-1] + "x";
                            else if ((h == 0) && (l == 0))
                                Old += coef[lenght - l-1, high - h-1];
                            else Old += coef[lenght - l-1, high - h-1] + "x^" + l + "y^" + h;
                        }
                    }
                    else if (coef[lenght - l-1, high - h-1] == 1)
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
                        coef[lenght - l -1, high - h - 1] = coef[lenght - l - 1, high - h - 1] * -1;
                    }
                }
            return Old;
        }
    }
}
