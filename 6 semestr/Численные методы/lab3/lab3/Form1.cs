using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Lab = 0;

        private void DoButton_Click(object sender, EventArgs e)
        {
            if ((panel1.Visible == true) && (Lab31RadioButton.Checked == true))
            {
                chart1.Visible = true;
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                comboBox1.Visible = true;
                panel1.Visible = false;
                panel2.Visible = true;
                MenuButton.Visible = true;
                Lab = 1;
                this.comboBox1.SelectedItem = "a) Лагранж";
                Lab31();
            }
            else if ((panel1.Visible == true) && (Lab32RadioButton.Checked == true))
            {
                chart1.Visible = true;
                comboBox1.Visible = false;
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                panel1.Visible = false;
                panel2.Visible = true;
                MenuButton.Visible = true;
                Lab = 2;
                Lab32();
            }
            else if ((panel1.Visible == true) && (Lab33RadioButton.Checked == true))
            {
                chart1.Visible = true;
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                comboBox1.Visible = false;
                panel1.Visible = false;
                panel2.Visible = true;
                MenuButton.Visible = true;
                Lab = 3;
                Lab33();
            }
            else if ((panel1.Visible == true) && (Lab34RadioButton.Checked == true))
            {
                chart1.Visible = false;
                comboBox1.Visible = false;
                panel1.Visible = false;
                panel2.Visible = true;
                MenuButton.Visible = true;
                Lab = 4;
                Lab34();
            }
            else if ((panel1.Visible == true) && (Lab35RadioButton.Checked == true))
            {
                chart1.Visible = false;
                comboBox1.Visible = false;
                panel1.Visible = false;
                panel2.Visible = true;
                MenuButton.Visible = true;
                Lab = 5;
                Lab35();
            }
            else if ((panel2.Visible == true) && (Lab == 1))
                Lab31();
            else if ((panel2.Visible == true) && (Lab == 2))
                Lab32();
            else if ((panel2.Visible == true) && (Lab == 3))
                Lab33();
            else if ((panel2.Visible == true) && (Lab == 4))
                Lab34();
            else if ((panel2.Visible == true) && (Lab == 5))
                Lab35();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                MenuButton.Visible = false;
            }
        }

        public void Lab31()
        {
            chart1.Series[0].Name = "f";
            chart1.Series[1].Name = "F1";
            chart1.Series[2].Name = "";
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            SolvingLabel.Text = "";
            double[] ax = new double[4] { 0, Math.PI / 8, 2 * Math.PI / 8, 3 * Math.PI / 8 };
            double[] bx = new double[4] { 0, Math.PI / 8, Math.PI / 3, 3 * Math.PI / 8 };
            double X = 3 * Math.PI / 16;
            double[] ay = new double[4];
            double[] by = new double[4];
            for (int i = 0; i < ax.Length; i++)
            {
                ay[i] = Math.Tan(ax[i]);
                by[i] = Math.Tan(bx[i]);
                double aPnLagr = Lagrange(ax[i], ax, ay);
                double bPnLagr = Lagrange(bx[i], bx, by);
                double aPnNewt = Newton(ax[i], ax, ay);
                double bPnNewt = Newton(bx[i], bx, by);
                if (comboBox1.SelectedItem.ToString() == "a) Лагранж")
                {
                    chart1.Series[0].Points.AddXY(ax[i], ay[i]);
                    chart1.Series[1].Points.AddXY(ax[i], aPnLagr);
                }
                else if (comboBox1.SelectedItem.ToString() == "a) Ньютон")
                {
                    chart1.Series[0].Points.AddXY(ax[i], ay[i]);
                    chart1.Series[1].Points.AddXY(ax[i], aPnNewt);
                }
                else if (comboBox1.SelectedItem.ToString() == "б) Лагранж")
                {
                    chart1.Series[0].Points.AddXY(bx[i], by[i]);
                    chart1.Series[1].Points.AddXY(bx[i], bPnLagr);
                }
                else
                {
                    chart1.Series[0].Points.AddXY(bx[i], by[i]);
                    chart1.Series[1].Points.AddXY(bx[i], bPnNewt);
                }
            }
            if (comboBox1.SelectedItem.ToString() == "a) Лагранж")
                SolvingLabel.Text += "Метод Лагранжа:\na) Погрешность: " + Math.Abs(Math.Round(Math.Tan(X) - Lagrange(X, ax, ay), 8)) + "\n";
            else if (comboBox1.SelectedItem.ToString() == "a) Ньютон")
                SolvingLabel.Text += "Метод Ньютона:\na) Погрешность: " + Math.Abs(Math.Round(Math.Tan(X) - Newton(X, ax, ay), 8)) + "\n";
            else if (comboBox1.SelectedItem.ToString() == "б) Лагранж")
                SolvingLabel.Text += "Метод Лагранжа:\nб) Погрешность: " + Math.Abs(Math.Round(Math.Tan(X) - Lagrange(X, bx, by), 8)) + "\n";
            else
                SolvingLabel.Text += "Метод Ньютона:\nб) Погрешность: " + Math.Abs(Math.Round(Math.Tan(X) - Newton(X, bx, by), 8)) + "\n";
        }
        public double Lagrange(double X, double[] x, double[] y)
        {
            double Pn = 0;
            for (int i = 0; i < y.Length; i++)
            {
                double Qni = 1;
                for (int j = 0; j < x.Length; j++)
                    if (j != i)
                        Qni *= (X - x[j]) / (x[i] - x[j]);
                Pn += y[i] * Qni;
            }
            return Pn;

        }
        public double Newton(double X, double[] x, double[] y)
        {
            double Pn = y[0] + (X - x[0]) * f(x[0], x[1]) + (X - x[0]) * (X - x[1]) * f(x[0], x[1], x[2]) + (X - x[0]) * (X - x[1]) * (X - x[2]) * f(x[0], x[1], x[2], x[3]);
            return Pn;
        }
        public double f(double x1, double x2)
        {
            return (Math.Tan(x1) - Math.Tan(x2)) / (x1 - x2);
        }
        public double f(double x1, double x2, double x3)
        {
            return (f(x1, x2) - f(x2, x3)) / (x1 - x3);
        }
        public double f(double x1, double x2, double x3, double x4)
        {
            return (f(x1, x2, x3) - f(x2, x3, x4)) / (x1 - x4);
        }
        public void Lab32()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[0].Name = "f";
            chart1.Series[1].Name = "F1";
            chart1.Series[2].Name = "";
            SolvingLabel.Text = "";
            double[] x = new double[] { 0, 0.9, 1.8, 2.7, 3.6 };
            double[] y = new double[] { 0, 0.36892, 0.85408, 1.7856, 6.3138 };
            double X = 1.5;
            double h = x[1] - x[0];
            double[,] C = new double[,] { { 4 * h, h, 0 },
                { h, 4 * h, h },
                { 0, h, 4 * h } };
            double[] coefs = new double[] {3*((y[2] - y[1])/h - (y[1]-y[0])/h),
                3*((y[3]-y[2])/h - (y[2] - y[1])/h ),
                3*((y[4] - y[3])/h - (y[3]-y[2])/h)};
            double[] cvspomog = Trexdiag(C, coefs);
            double[] c = new double[] { 0, cvspomog[0], cvspomog[1], cvspomog[2] };
            double[] a = new double[4] { y[0], y[1], y[2], y[3] };
            double[] b = new double[4];
            double[] d = new double[4];
            for (int i = 0; i < 3; i++)
            {
                b[i] = (y[i + 1] - y[i]) / h - (h / 3) * (c[i + 1] + 2 * c[i]);
                d[i] = (c[i + 1] - c[i]) / (3 * h);
            }
            b[3] = (y[4] - y[3]) / h - (2 / 3) * h * c[3];
            d[3] = -c[3] / (3 * h);
            SolvingLabel.Text += "f(" + X + ") = " + Math.Round(f(X, h, x, a, b, c, d), 4) + "\n";
            for (int i = 0; i < x.Length; i++)
                chart1.Series[0].Points.AddXY(x[i], y[i]);
            for (double i = 0; i < x[x.Length - 1]; i += 0.9)
            {
                double xvspom = i;
                chart1.Series[1].Points.AddXY(xvspom, f(xvspom, h, x, a, b, c, d));
            }
        chart1.Series[1].Points.AddXY(x[x.Length - 1], y[y.Length - 1]);
        }

    public double[] Trexdiag(double[,] A, double[] Ans)
        {
            double[] v = new double[3];
            double[] u = new double[3];
            v[0] = A[0, 1] / -A[0, 0];
            u[0] = -Ans[0] / -A[0, 0];
            v[1] = A[1, 2] / (-A[1, 1] - A[1, 0] * v[0]);
            u[1] = (A[1, 0] * u[0] - Ans[1]) / (-A[1, 1] - A[1, 0] * v[0]);
            v[2] = 0;
            u[2] = (A[2, 1] * u[1] - Ans[2]) / (-A[2, 2] - A[2, 1] * v[1]);
            double[] x = new double[3];
            x[2] = u[2];
            x[1] = v[1] * x[2] + u[1];
            x[0] = v[0] * x[1] + u[0];
            return x;
        }
        public double f(double X, double h, double[] x, double[] a, double[] b, double[] c, double[] d)
        {
            int interv = 1;
            while (X > x[0] + h * interv)
                interv++;
            if (interv > 4)
                interv = 4;
            return a[interv - 1] + b[interv - 1] * (X - x[interv - 1]) + c[interv - 1] * Math.Pow(X - x[interv - 1], 2) + d[interv - 1] * Math.Pow(X - x[interv - 1], 3);
        }
        public void Lab33()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[0].Name = "f";
            chart1.Series[1].Name = "F1";
            chart1.Series[2].Name = "F2";
            SolvingLabel.Text = "";
            double[] x = new double[] { -0.9, 0, 0.9, 1.8, 2.7, 3.6 };
            double[] y = new double[] { -0.36892, 0, 0.36892, 0.85408, 1.7856, 6.3138 }; 
            double sumx = 0;
            for (int i = 0; i < x.Length; i++)
                sumx += x[i];
            double sumy = 0;
            for (int i = 0; i < x.Length; i++)
                sumy += y[i];
            double sumx2 = 0;
            for (int i = 0; i < x.Length; i++)
                sumx2 += Math.Pow(x[i], 2);
            double sumx3 = 0;
            for (int i = 0; i < x.Length; i++)
                sumx3 += Math.Pow(x[i], 3);
            double sumx4 = 0;
            for (int i = 0; i < x.Length; i++)
                sumx4 += Math.Pow(x[i], 4);
            double sumxy = 0;
            for (int i = 0; i < x.Length; i++)
                sumxy += x[i] * y[i];
            double sumx2y = 0;
            for (int i = 0; i < x.Length; i++)
                sumx2y += Math.Pow(x[i], 2) * y[i];
            double[,] A1 = new double[,] { { x.Length, sumx },
                {sumx,  sumx2} };
            double[] b1 = new double[] { sumy, sumxy };
            double[] F1 = SolveSystem(A1, b1, 2, 2);
            SolvingLabel.Text += "F1 = " + Math.Round(F1[0], 4) + "+" + Math.Round(F1[1], 4) + "*x\n";
            double[,] A2 = new double[,] { { x.Length, sumx, sumx2 },
                {sumx,  sumx2, sumx3},
            {sumx2, sumx3, sumx4}};
            double[] b2 = new double[] { sumy, sumxy, sumx2y };
            double[] F2 = SolveSystem(A2, b2, 3, 3);
            SolvingLabel.Text += "F2 = " + Math.Round(F2[0], 4) + "+" + Math.Round(F2[1], 4) + "*x+" + Math.Round(F2[2], 4) + "*x^2\n";
            for (int i = 0; i < x.Length; i++)
                chart1.Series[0].Points.AddXY(x[i], y[i]);
            for (double i = x[0]; i <= x[x.Length - 1]; i += 0.9)
            {
                chart1.Series[1].Points.AddXY(i, func(i, F1));
                chart1.Series[2].Points.AddXY(i, func(i, F2));
            }
            double Pogr1 = 0;
            double Pogr2 = 0;
            for (int i = 0; i < x.Length; i++)
            {
                Pogr1 += Math.Pow(func(x[i], F1) - y[i], 2);
                Pogr2 += Math.Pow(func(x[i], F2) - y[i], 2);
            }
            SolvingLabel.Text += "Ф1 = " + Math.Round(Pogr1, 4) + "\n" + "Ф2 = " + Math.Round(Pogr2, 4) + "\n";
        }
        public double[] SolveSystem(double[,] A, double[] Ans, int length, int high)
        {
            double[,] L = new double[length, high];
            double[,] U = new double[length, high];
            for (int a = 0; a < high; a++)
                for (int b = 0; b < length - 1; b++)
                {
                    if (a == b)
                        L[a, b] = 1;
                    else
                        L[a, b] = 0;
                    U[a, b] = 0;
                }
            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    double sum1 = 0;
                    double sum2 = 0;
                    for (int k = 0; k < j; k++)
                    {
                        sum1 += L[k, i] * U[j, k];
                    }
                    for (int k = 0; k < i; k++)
                    {
                        sum2 += L[k, i] * U[j, k];
                    }
                    if (i <= j)
                        U[j, i] = (A[j, i] - sum1);
                    else
                        L[j, i] = (A[j, i] - sum2) / U[j, j];
                }
            }
            double[] y = new double[high];
            double[] x = new double[high];
            y[0] = Ans[0] / L[0, 0];
            double help = 0;
            for (int i = 1; i < high; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    help += y[j] * L[j, i];
                }
                y[i] = (Ans[i] - help);
                help = 0;
            }
            x[high - 1] = y[high - 1] / U[high - 1, high - 1];
            help = 0;
            for (int i = high - 2; i > -1; i--)
            {
                for (int j = high - 1; j > i; j--)
                {
                    help += x[j] * U[j, i];
                }
                x[i] = (y[i] - help) / U[i, i];
                help = 0;
            }
            return x;
        }
        public double func(double x, double[] coefs)
        {
            double Res = 0;
            for (int i =  0; i < coefs.Length ; i++)
                Res += coefs[i] * Math.Pow(x, i);
            return Res;
        }
        public void Lab34()
        {
            SolvingLabel.Text = "";
            double[] x = new double[] { 1, 1.5, 2, 2.5, 3 };
            double[] y = new double[] { 0, 0.40547, 0.69315, 0.91629, 1.0986 };
            double X = 2;
            SolvingLabel.Text += "f'(2) = " + proiz1(X, x, y) + "\n";
            SolvingLabel.Text += "f''(2) = " + proiz2(x, y) + "\n";

        }
        public double proiz1(double X, double[] x, double[] y)
        {
            return (y[2] - y[1]) / (x[2] - x[1]) + ((y[3] - y[2]) / (x[3] - x[2]) - (y[2] - y[1]) / (x[2] - x[1])) / (x[3] - x[1]) * (2 * X - x[1] - x[2]);
        }
        public double proiz2(double[] x, double[] y)
        {
            return 2 * ((y[3] - y[2]) / (x[3] - x[2]) - (y[2] - y[1]) / (x[2] - x[1])) / (x[3] - x[1]);
        }
        public void Lab35()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[0].Name = "f";
            chart1.Series[1].Name = "F1";
            chart1.Series[2].Name = "F2";
            SolvingLabel.Text = "";
            double X0 = -1.0;
            double Xk = 1.0;
            double h1 = 0.5;
            double h2 = 0.25;
            double Treug05 = FTreugolnik(X0, Xk, h1);
            double Treug025 = FTreugolnik(X0, Xk, h2);
            double Trapets05 = FTrapetsia(X0, Xk, h1);
            double Trapets025 = FTrapetsia(X0, Xk, h2);
            double Simpson05 = FSimpson(X0, Xk, h1);
            double Simpson025 = FSimpson(X0, Xk, h2);
            double Real = Integral(Xk) - Integral(X0);
            SolvingLabel.Text += "Метод прямоугольников, шаг h1: I = " + Math.Round(Treug05, 5) + "\n";
            SolvingLabel.Text += "Метод прямоугольников, шаг h2: I = " + Math.Round(Treug025, 5) + "\n\n";
            SolvingLabel.Text += "Метод трапеции, шаг h1: I = " + Math.Round(Trapets05, 5) + "\n";
            SolvingLabel.Text += "Метод трапеции, шаг h2: I = " + Math.Round(Trapets025, 5) + "\n\n";
            SolvingLabel.Text += "Метод Симпсона, шаг h1: I = " + Math.Round(Simpson05, 5) + "\n";
            SolvingLabel.Text += "Метод Симпсона, шаг h2: I = " + Math.Round(Simpson025, 5) + "\n\n";
            SolvingLabel.Text += "Точное значение: I = " + Math.Round(Real, 5) + "\n\nУточнение интегралов:\n\n";
            SolvingLabel.Text += "Уточнение метода прямоугольников: I = " + Math.Round(RungeRomberg(Treug05, Treug025), 5) + "\n";
            SolvingLabel.Text += "Погрешность: I = " + Math.Round(Pogreshnost(RungeRomberg(Treug05, Treug025), Real), 5) + "\n\n";
            SolvingLabel.Text += "Уточнение метода трапеции: I = " + Math.Round(RungeRomberg(Trapets05, Trapets025), 5) + "\n";
            SolvingLabel.Text += "Погрешность: I = " + Math.Round(Pogreshnost(RungeRomberg(Trapets05, Trapets025), Real), 5) + "\n\n";
            SolvingLabel.Text += "Уточнение метода Симпсона: I = " + Math.Round(RungeRomberg(Simpson05, Simpson025), 5) + "\n";
            SolvingLabel.Text += "Погрешность: I = " + Math.Round(Pogreshnost(RungeRomberg(Simpson05, Simpson025), Real), 5) + "\n\n";
        }
        public double y(double x)
        {
            return x / (Math.Pow(3 * x + 4, 3));
            //return x / (Math.Pow(3 * x + 4, 2));
        }
        public double Integral(double x)
        {
            double Ans = -1.0 / (27.0 * x + 36.0) + (2.0 / (9.0 * Math.Pow(3.0 * x + 4.0, 2)));
            //double Ans = ((1.0 / 9) * Math.Log(Math.Abs(3.0 * x + 4), Math.Exp(1)) + (4.0 / (27.0 * x + 36.0))) * 0.001 / 0.001;
            return Ans;
        }
        public double FTreugolnik(double X0, double Xk, double h)
        {
            double Integr = 0;
            for (double x = X0; x < Xk; x += h)
                Integr += y((2 * x + h) / 2);
            return h * Integr;
        }
        public double FTrapetsia(double X0, double Xk, double h)
        {
            double Integr = 0;
            for (double x = X0; x <= Xk; x += h)
                if ((x == X0) || (x == Xk - h))
                    Integr += y(x) / 2;
                else
                    Integr += y(x);
            return h * Integr;
        }
        public double FSimpson(double X0, double Xk, double h)
        {
            double Integr = 0;
            for (double x = X0; x <= Xk; x += h)
                if ((x == X0) || (x == Xk))
                    Integr += y(x);
                else if (((x - X0) / h) % 2 == 1)
                    Integr += 4*y(x);
                else
                    Integr += 2*y(x);
            return h / 3 * Integr;
        }
        public double RungeRomberg(double F05, double F025)
        {
            return F025 + (F025 - F05) /(Math.Pow(2, 2) - 1);
        }
        public double Pogreshnost(double F1, double F2)
        {
            return Math.Abs(F1-F2);
        }
    }
}
