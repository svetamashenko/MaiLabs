using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
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
                Test1.Visible = true;
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
                Test1.Visible = true;
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
                Test1.Visible = true;
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
                Test1.Visible = false;
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
                Test1.Visible = false;
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
                Test1.Visible = false;
            }
        }

        //
        //1 задание
        //
        private void Perform1TaskButton_Click(object sender, EventArgs e)
        {
            string[] coefs;
            coefs = InputCoefs1Task.Text.Split(';').ToArray();
            int j = coefs.Length;
            double[] coeflencount = coefs[0].Split(' ').Select(double.Parse).ToArray();
            int i = coeflencount.Length;
            double[,] coef = new double[i, j];
            string Out2 = "";
            for (int o = 0; o < j; o++)
            {
                double[] coeftr = coefs[o].Split(' ').Select(double.Parse).ToArray();
                for (int n = 0; n < i; n++)
                    coef[n, o] = coeftr[n];
            }
            string Old = ProbOut(coef, i, j);
            ProblemOut1Task.Text = Old;

            double[,] newcoef = new double[i, j];

            for (int h = 0; h < j; h++)
                for (int l = 0; l < i; l++)
                    newcoef[l, h] = coef[l, h];
            int f = 0;
            for (int c = 0; c < i - 1; c++)
            {
                for (int h = f + 1; h < j; h++)
                {
                    if (newcoef[c, f] != 0)
                    {
                        double mnoj = newcoef[c, h] / newcoef[c, f];
                        for (int l = 0; l < i; l++)
                        {
                            newcoef[l, h] = newcoef[l, h] - newcoef[l, f] * mnoj;
                        }
                    }
                }
                f++;
            }
            double[] answer = new double[j];
            double[] numbers = new double[j];
            int z = 0;
            double sum = 0;
            for (int h = j - 1; h >= 0; h--)
            {
                if (h == j - 1)
                {
                    answer[j - 1] = newcoef[i - 1, j - 1] / newcoef[i - 2, j - 1];
                    z++;
                }
                else
                {
                    int c = 2;
                    for (int l = i - 2; l >= i - 1 - z; l--)
                    {
                        sum -= newcoef[l, h] * answer[j - c + 1];
                        c++;
                    }
                    sum += newcoef[i - 1, h];
                    answer[h] = sum / newcoef[i - 2 - z, h];
                    sum = 0;
                    z++;
                }
            }
            string Out = "";
            for (int h = 0; h < j; h++)
                if (h == 0)
                    Out += "[" + Math.Round(answer[h], 2) + ";";
                else if (h == j - 1)
                    Out += Math.Round(answer[h], 2) + "]";
                else
                    Out += Math.Round(answer[h], 2) + ";";
            SolvingOut1Task.Text = Out;
        }

        //
        // 2 задание
        //
        private void Perform2TaskButton_Click(object sender, EventArgs e)
        {
            string[] coefs;
            coefs = InputCoefs2Task.Text.Split(';').ToArray();
            int j = coefs.Length;
            double[] coeflencount = coefs[0].Split(' ').Select(double.Parse).ToArray();
            int i = coeflencount.Length;
            double[,] coef = new double[i, j];
            for (int o = 0; o < j; o++)
            {
                double[] coeftr = coefs[o].Split(' ').Select(double.Parse).ToArray();
                for (int c = 0; c < i; c++)
                    coef[c, o] = coeftr[c];
            }
            string Old = ProbOut(coef, i, j);
            ProblemOut2Task.Text = Old;
            double[,] abcd = new double[4, j];
            for (int y = 0; y < j; y++)
            {
                int nol = 0;
                int pr = 0;
                for (int x = 0; x < i; x++)
                {
                    if ((coef[x, y] == 0) && (pr == 0))
                        nol++;
                    else pr = 1;
                }
                if (y == 0)
                {
                    abcd[0, y] = 0;
                    abcd[1, y] = coef[0, y];
                    abcd[2, y] = coef[1, y];
                    abcd[3, y] = coef[i - 1, y];
                }
                else if (y == j - 1)
                {
                    abcd[0, y] = coef[i - 3, y];
                    abcd[1, y] = coef[i - 2, y];
                    abcd[2, y] = 0;
                    abcd[3, y] = coef[i - 1, y];
                }
                else
                {
                    for (int h = nol; h < nol + 3; h++)
                        abcd[h - nol, y] = coef[h, y];
                    abcd[3, y] = coef[i - 1, y];
                }
                pr = 0; nol = 0;
            }
            double[] P = new double[j];
            double[] Q = new double[j];
            double[] ans = new double[j];
            for (int x = 0; x < j; x++)
            {
                if (x == 0)
                    P[x] = -abcd[2, x] / abcd[1, x];
                else
                    P[x] = -abcd[2, x] / (abcd[1, x] + abcd[0, x] * P[x - 1]);
            }
            for (int x = 0; x < j; x++)
            {
                if (x == 0)
                    Q[x] = abcd[3, x] / abcd[1, x];
                else
                    Q[x] = (abcd[3, x] - abcd[0, x] * Q[x - 1]) / (abcd[1, x] + abcd[0, x] * P[x - 1]);
            }
            for (int x = j - 1; x >= 0; x--)
            {
                if (x == j - 1)
                    ans[x] = Q[x];
                else
                    ans[x] = P[x] * ans[x + 1] + Q[x];
            }
            string Out = "";
            for (int h = 0; h < j; h++)
                if (h == 0)
                    Out += "[" + Math.Round(ans[h], 2) + ";";
                else if (h == j - 1)
                    Out += Math.Round(ans[h], 2) + "]";
                else
                    Out += Math.Round(ans[h], 2) + ";";
            SolvingOut2Task.Text = Out;
        }



        //
        // 3 задание
        //
        private void Perform3TaskButton_Click(object sender, EventArgs e)
        {
            string[] coefs;
            coefs = InputCoefs3Task.Text.Split(';').ToArray();
            int j = coefs.Length;
            double[] coeflencount = coefs[0].Split(' ').Select(double.Parse).ToArray();
            int i = coeflencount.Length;
            double[,] coef = new double[i, j];
            for (int o = 0; o < j; o++)
            {
                double[] coeftr = coefs[o].Split(' ').Select(double.Parse).ToArray();
                for (int c = 0; c < i; c++)
                    coef[c, o] = coeftr[c];
            }
            string Old = ProbOut(coef, i, j);
            ProblemOut3Task.Text = Old;
            double[,] newcoef = new double[i, j];
            double[,] alpha = new double[i - 1, j];
            double[] beta = new double[j];
            string Out = "";
            for (int h = 0; h < j; h++)
                for (int l = 0; l < i - 1; l++)
                    alpha[l, h] = 0;
            double mnoj = 0;
            for (int h = 0; h < j; h++)
            {
                mnoj = coef[h, h];
                for (int l = 0; l < i; l++)
                {
                    newcoef[l, h] = -coef[l, h] / mnoj;
                }
            }
            for (int h = 0; h < j; h++)
            {
                for (int l = 0; l < i - 1; l++)
                    if (l == h)
                        alpha[l, h] = 0;
                    else
                        alpha[l, h] = newcoef[l, h];
            }
            for (int h = 0; h < j; h++)
                beta[h] = newcoef[i - 1, h];
            double[] x = new double[j];
            for (int h = 0; h < j; h++)
            {
                x[h] = -beta[h];
            }
            double[] x1 = new double[j];
            double ps = 0;
            double psi = 1;

            //Метод простых итераций:
            while (psi >= 0.01)
            {
                for (int h = 0; h < j; h++)
                {
                    for (int l = 0; l < j; l++)
                    {
                        x1[h] += alpha[l, h] * x[l];
                    }
                    x1[h] += -beta[h];
                }
                for (int l = 0; l < j; l++)
                {
                    ps += x1[l] - x[l];
                }
                if (ps < 0)
                    ps = -ps;
                psi = ps;
                ps = 0;
                if (psi > 0.01)
                {
                    for (int h = 0; h < j; h++)
                    {
                        x[h] = x1[h];
                        x1[h] = 0;
                    }
                }
            }
            Out += "Метод простых итераций:\n";
            for (int h = 0; h < j; h++)
                if (h == 0)
                    Out += "[" + Math.Round(x1[h], 2) + ";";
                else if (h == j - 1)
                    Out += Math.Round(x1[h], 2) + "]";
                else
                    Out += Math.Round(x1[h], 2) + ";";
            Out += "\n";

            //Метод Зейделя:
            double[] xvsp = new double[j];
            for (int h = 0; h < j; h++)
            {
                x[h] = -beta[h];
                xvsp[h] = x[h];
                x1[h] = 0;
            }
            psi = 1;
            int d = 0;
            while (psi >= 0.01)
            {
                for (int h = 0; h < j; h++)
                {
                    for (int l = 0; l < j; l++)
                    {
                        x1[h] += alpha[l, h] * x[l];
                    }
                    x1[h] += -beta[h];
                    x[h] = x1[h];
                }
                d = 0;
                for (int l = 0; l < j; l++)
                {
                    ps += x1[l] - xvsp[l];
                }
                if (ps < 0)
                    ps = -ps;
                psi = ps;
                ps = 0;
                if (psi > 0.01)
                {
                    for (int h = 0; h < j; h++)
                    {
                        x[h] = x1[h];
                        xvsp[h] = x1[h];
                        x1[h] = 0;
                    }
                }
            }
            Out += "Метод Зейделя:\n";
            for (int h = 0; h < j; h++)
                if (h == 0)
                    Out += "[" + Math.Round(x1[h], 2) + ";";
                else if (h == j - 1)
                    Out += Math.Round(x1[h], 2) + "]";
                else
                    Out += Math.Round(x1[h], 2) + ";";
            SolvingOut3Task.Text = Out;
        }

        public static string ProbOut(double[,] coef, int i, int j)
        {
            string Old = "";
            int[] g = new int[j];
            int[] proof = new int[j];
            for (int h = 0; h < j; h++)
            {
                proof[h] = 0;
                g[h] = 0;
            }
            for (int h = 0; h < j; h++)
            {
                for (int l = 0; l < i; l++)
                {
                    if ((coef[l, h] == 0) && (proof[h] == 0))
                        g[h]++;
                    else
                        proof[h]++;
                }
            }
            for (int h = 0; h < j; h++)
            {
                for (int l = g[h]; l < i; l++)
                {
                    string sign = "+";
                    if (coef[l, h] < 0)
                    {
                        sign = "-";
                        coef[l, h] = coef[l, h] * -1;
                    }
                    if ((l == i-1))
                    {
                        {
                            string newsign;
                            if (coef[l, h] != 1)
                            {
                                if (sign == "+")
                                    newsign = "";
                                else
                                    newsign = "-";
                                Old += "= " + newsign + coef[l, h].ToString();
                            }
                            else
                            {
                                if (sign == "+")
                                {
                                    Old += "= 1";
                                }
                                else
                                {
                                    Old += " = -1";
                                }
                            }
                        }
                    }
                    else if ((l != 0) && (l!=g[h]))
                    {
                        {
                            if (coef[l, h] != 0)
                            {
                                if (coef[l, h] != 1)
                                {
                                    Old += sign + coef[l, h].ToString() + "x" + (l + 1).ToString();
                                }
                                else
                                {
                                    Old += sign + "x" + (l + 1).ToString();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (l == g[h])
                        {
                            string newsign;
                            if (coef[l, h] != 1)
                            {
                                if (sign == "+")
                                    newsign = "";
                                else
                                    newsign = "-";
                                Old += newsign + coef[l, h].ToString() + "x" + (l + 1).ToString();
                            }
                            else
                            {
                                if (sign == "+")
                                {
                                    Old += "x" + (l + 1).ToString();
                                }
                                else
                                {
                                    Old += "-x" + (l + 1).ToString();
                                }
                            }
                        }

                    }
                    if (sign == "-")
                    {
                        coef[l, h] = coef[l, h] * -1;
                    }
                }
                Old += "\n";
            }
            return Old;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Perform1TaskButton.Visible == true)
                InputCoefs1Task.Text = "-1 -7 -3 -2 -12;-8 1 -9 0 -60;8 2 -5 -3 -91;-5 3 5 -9 -43";
            if (Perform2TaskButton.Visible == true)
                InputCoefs2Task.Text = "8 -2 0 0 6;-1 6 -2 0 3;0 2 10 -4 8;0 0 -1 6 5";
            //   InputCoefs2Task.Text = "-14 -6 0 0 0 -78;-9 15 -1 0 0 -73;0 1 -11 1 0 -38;0 0 -7 12 3 77;0 0 0 6 -7 91";
            if (Perform3TaskButton.Visible == true)
                InputCoefs3Task.Text = "10 1 1 12;2 10 1 13;2 2 10 14";
            //   InputCoefs3Task.Text = "26 -9 -8 8 20;9 -21 -2 8 -164;-3 2 -18 8 140;1 -6 -1 11 -81";
        }
    }
}