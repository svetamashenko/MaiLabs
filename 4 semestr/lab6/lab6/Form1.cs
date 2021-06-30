using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab6
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
                //ProblemOut1Task.Visible = true;
                Perform1TaskButton.Visible = true;
                Interval.Visible = true;
                Step.Visible = true;
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
                InputCoefs2Task.Visible = true;
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
                InputCoefs1Task.Visible = false;
                Task1Task.Visible = false;
                SolvingOut1Task.Visible = false;
                //ProblemOut1Task.Visible = false;
                Perform1TaskButton.Visible = false;
                MenuButton.Visible = false;
                //Out1Task.Visible = false;
                Interval.Visible = false;
                Step.Visible = false;
            }
            if (Perform2TaskButton.Visible == true)
            {
                MainButton.Visible = true;
                MainTaskLabel.Visible = true;
                groupBox1.Visible = true;
                Perform2TaskButton.Visible = false;
                InputCoefs2Task.Visible = false;
                MenuButton.Visible = false;
                ProblemOut2Task.Visible = false;
                CoefsLabel2Task.Visible = false;
                SolvingOut2Task.Visible = false;
                Task2Task.Visible = false;
                InputCoefs2Task.Visible = false;
                //Out2Task.Visible = false;
            }
        }

        //
        //1 задание
        //
        private void Perform1TaskButton_Click(object sender, EventArgs e)
        {
            double[] coef = InputCoefs1Task.Text.Split(' ').Select(double.Parse).ToArray(), gran = Interval.Text.Split(' ').Select(double.Parse).ToArray();
            double step = Convert.ToDouble(Step.Text);

            double[] ans = new double[coef.Length - 1];
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            double x = gran[0], y, y1;
            //double[] coef1 = interpol(coef, gran, step); интерполяция

            double[] coef1 = new double[coef.Length];
            List<double[]> deltay = new List<double[]>();
            deltay.Add(coef);
            double[] delta = proizvod(coef);
            for (int i = 1; i < coef.Length; i++)
            {
                deltay.Add(delta);
                delta = proizvod(delta);
            }
            int v = 0;
            string Out = "";
            foreach (double[] j in deltay)
                v++;
            double num = 0;
            int k = 0;
            foreach (double[] j in deltay)
            {
                num = j[0] / (Factorial(k) * Math.Pow(step, k));
                double[] mnoj1 = new double[2];
                mnoj1[0] = 1;
                mnoj1[1] = 0;
                for (int p = 0; p < umnoj(mnoj1,k).Length; p++)
                {
                    coef1[coef1.Length - umnoj(mnoj1, k).Length - 1 + p] += umnoj(mnoj1, k)[p] * num;
                    Out += "[" + umnoj(mnoj1, k)[p] + ", " + mnoj1[0] + ", " + mnoj1[1]+ ", " + k + "]";
                }
                Out += "\n";
               k++;
            }

            for (int i = 0; i < coef.Length; i++)
            {
                y = coef[i];
                y1 = coef1[i];
                SolvingOut1Task.Text += coef1[i] + " ";
                chart1.Series[0].Points.AddXY(x, y);
                chart1.Series[1].Points.AddXY(x, y1);
                x += step;
            }
            SolvingOut1Task.Text = Out;
            chart1.Visible = true;
        }

        //
        // 2 задание
        //
        private void Perform2TaskButton_Click(object sender, EventArgs e)
        {

        }
        public static double[] umnoj(double[] coef, int k)
        {
            if (k == 0)
            {
                double[] ans0 = new double[1];
                ans0[0] = 0;
                return ans0;
            }
            if (k == 1)
            {
                double[] ans1 = new double[1];
                ans1[0] = 1;
                return ans1;
            }
            double[] ansm = new double[coef.Length + k -1];
            int o = 0;
            while (o < k - 2)
            {
                double[] ans = new double[coef.Length + 1];
                double[] mnoj = new double[2];
                mnoj[0] = 1;
                mnoj[1] = o;
                for (int i = 0; i < ans.Length; i++)
                    for (int j = 0; j < mnoj.Length; j++)
                    {
                        if (i + j < ansm.Length)
                            ansm[i + j + o] += ans[i] * mnoj[j];
                    }
                o--;
            }
            return ansm;
        }
        public static int Factorial(int numb)
        {
            int res = 1;
            for (int i = numb; i > 1; i--)
                res *= i;
            return res;
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