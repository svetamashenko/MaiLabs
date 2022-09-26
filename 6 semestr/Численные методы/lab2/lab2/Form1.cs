using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
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
            if ((panel1.Visible == true) && (Lab21RadioButton.Checked == true))
            {
                panel1.Visible = false;
                panel2.Visible = true;
                MenuButton.Visible = true;
                Lab = 1;
                Lab21();
            }
            else if ((panel1.Visible == true) && (Lab22RadioButton.Checked == true))
            {
                panel1.Visible = false;
                panel2.Visible = true;
                MenuButton.Visible = true;
                Lab = 2;
                Lab22();
            }
            else if ((panel2.Visible == true) && (Lab == 1))
                Lab21();
            else if ((panel2.Visible == true) && (Lab == 2))
                Lab22();
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
        public void Lab21()
        {
            double eps = Convert.ToSingle(EpsilonTextBox.Text);

            IterationSolvingLabel.Text = "Метод простых итераций: \n";

            int k = 0;
            double x = 1;
            double xnew = 0;
            while (Math.Abs(xnew - x) >= eps)
            {
                x = xnew;
                xnew = x + f1(x);
                k++;
            }

            IterationSolvingLabel.Text += "x = " + Math.Round(x, 4) + "\n" + "f(x) = " + Math.Round(f1(x), 2) + "\n";
            IterationSolvingLabel.Text += "Решение найдено за " + k + " итераций.\n\n";


            IterationSolvingLabel.Text += "Метод Ньютона: \n";
            k = 0;
            x = 1;
            xnew = 0;
            while (Math.Abs(xnew - x) >= eps)
            {
                x = xnew;
                xnew = x - f1(x) / df1(x);
                k++;
            }
            IterationSolvingLabel.Text += "x = " + Math.Round(xnew, 4) + "\n" + "f(x) = " + Math.Round(f1(xnew), 2) + "\n";
            IterationSolvingLabel.Text += "Решение найдено за " + k + " итераций.\n\n";


        }

        public double f1(double x)
        {
            double func = Math.Pow((1 - Math.Pow(x, 2)), 0.5) - Math.Exp(x) + 0.1;
            return func;
        }

        public double df1(double x)
        {
            double func = -x / Math.Pow((1 - Math.Pow(x, 2)), 0.5) - Math.Exp(x);
            return func;
        }
        public double proizv_f1(double x)
        {
            double func = (x + Math.Pow((1 - Math.Pow(x, 2)), 0.5) * Math.Exp(x)) / Math.Pow((1 - Math.Pow(x, 2)), 0.5);
            return func;
        }
        public void Lab22()
        {
            double eps = Convert.ToSingle(EpsilonTextBox.Text);

            IterationSolvingLabel.Text = "Метод простых итераций: \n";

            int k = 0;
            double x1 = 7;
            double x2 = 3;
            double x1new = 4;
            double x2new = 0;
            while (Math.Max(Math.Abs(x1new - x1), Math.Abs(x2new - x2)) >= eps)
            {
                x1 = x1new;
                x2 = x2new;
                //IterationSolvingLabel.Text += "phix = " + Math.Abs(Math.Round(phixdy(x1, x2), 4)) + "; phiy = " + Math.Abs(Math.Round(phiydx(x1, x2), 4)) + "\n";
                x1new = phix(x1, x2);
                x2new = phiy(x1, x2);
                k++;
            }
            IterationSolvingLabel.Text += "x1 = " + Math.Round(x1new, 4) + "\nx2 = " + Math.Round(x2new, 4) + "\n";
            IterationSolvingLabel.Text += "f1(x) = " + Math.Round(g1(x1new, x2new), 2) + "\nf2(x) = " + Math.Round(g2(x1new, x2new), 2) + "\n";
            IterationSolvingLabel.Text += "Решение найдено за " + k + " итераций.\n\n";


            IterationSolvingLabel.Text += "Метод Ньютона: \n";

            k = 0;
            x1 = 7;
            x2 = 3;
            x1new = 4;
            x2new = 0;
            while (Math.Max(Math.Abs(x1new - x1), Math.Abs(x2new - x2)) >= eps)
            {
                x1 = x1new;
                x2 = x2new;
                x1new = x1 - A1(x1, x2) / J(x1, x2);
                x2new = x2 - A2(x1, x2) / J(x1, x2);
                k++;
            }
            IterationSolvingLabel.Text += "x1 = " + Math.Round(x1new, 4) + "\nx2 = " + Math.Round(x2new, 4) + "\n";
            IterationSolvingLabel.Text += "f1(x) = " + Math.Round(g1(x1new, x2new), 2) + "\nf2(x) = " + Math.Round(g2(x1new, x2new), 2) + "\n";
            IterationSolvingLabel.Text += "Решение найдено за " + k + " итераций.\n\n";
        }


        public double g1(double x, double y)
        {
            double func = (x * x + 16) * y - 64;
            return func;
        }
        public double g2(double x, double y)
        {
            double func = Math.Pow((x - 2), 2) + Math.Pow((y - 2), 2) - 16;
            return func;
        }

        public double phix(double x, double y)
        {
            double func = Math.Pow(16 - Math.Pow(y - 2, 2), 0.5) + 2;
            return func;
        }
        public double phiy(double x, double y)
        {
            double func = 64 / (x * x + 16);
            return func;
        }
        public double phixdy(double x, double y)
        {
            double func = (-y + 2) / Math.Pow(-y * y + 4 * y + 12, 0.5);
            return func;
        }
        public double phiydx(double x, double y)
        {
            double func = -128 * x / Math.Pow(x * x + 16, 2);
            return func;
        }


        public double g1dx(double x, double y)
        {
            double func = 2 * x * y;
            return func;
        }
        public double g1dy(double x, double y)
        {
            double func = x * x + 16;
            return func;
        }
        public double g2dx(double x, double y)
        {
            double func = 2 * x - 4;
            return func;
        }
        public double g2dy(double x, double y)
        {
            double func = 2 * y - 4;
            return func;
        }
        public double A1(double x, double y)
        {
            double A = g1(x, y) * g2dy(x, y) - g2(x, y) * g1dy(x, y);
            return A;
        }
        public double A2(double x, double y)
        {
            double A = g2(x, y) * g1dx(x, y) - g1(x, y) * g2dx(x, y);
            return A;
        }
        public double J(double x, double y)
        {
            double J = g1dx(x, y) * g2dy(x, y) - g2dx(x, y) * g1dy(x, y);
            return J;
        }
    }
}
