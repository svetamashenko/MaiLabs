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

        private void DoButton_Click(object sender, EventArgs e)
        {
            SolvingLabel.Text = "Решение СЛАУ: \n";
            CheckLabel.Text = "Проверка решения: \n";
            string[] rows;
            rows = CoefsTextBox.Text.Split('\n').ToArray();
            int high = rows.Length;
            double[] columns = rows[0].Split(' ').Select(double.Parse).ToArray();
            int length = high + 1;
            double[,] A = new double[high, length];
            for (int i = 0; i < high; i++)
                for (int j = 0; j < length; j++)
                    A[i, j] = 0;
            double[] Ans = new double[high];
            int c = -1;
            for (int i = 0; i < high; i++)
            {
                double[] coeftr = rows[i].Split(' ').Select(double.Parse).ToArray();
                Ans[i] = coeftr[coeftr.Length - 1];
                for (int j = 0; j < coeftr.Length - 1; j++)
                {
                    if (c == -1)
                        A[i, j] = coeftr[j];
                    else
                        A[i, j + c] = coeftr[j];

                }
                c++;
            }
            double[] v = new double[high];
            double[] u = new double[high];
            v[0] = A[0, 1] / -A[0, 0];
            u[0] = -Ans[0] / -A[0, 0];
            for (int i = 1; i < high - 1; i++)
            {
                v[i] = A[i, i + 1] / (-A[i, i] - A[i, i - 1] * v[i - 1]);
                u[i] = (A[i, i - 1] * u[i - 1] - Ans[i]) / (-A[i, i] - A[i, i - 1] * v[i - 1]);
            }
            v[high - 1] = 0;
            u[high - 1] = (A[high - 1, high - 2] * u[high - 2] - Ans[high - 1]) / (-A[high - 1, high - 1] - A[high - 1, high - 2] * v[high - 2]);
            double[] x = new double[high];
            x[high - 1] = u[high - 1];
            for (int i = high - 2; i >= 0; i--)
                x[i] = v[i] * x[i + 1] + u[i];

            for (int i = 0; i < high; i++)
                SolvingLabel.Text += "x[" + (i+1) + "] = " + Math.Round(x[i], 2) + "\n";
            double Check = 0;
            for (int i = 0; i < high; i++)
            {
                Check = 0;
                for (int j = 0; j < high; j++)
                {
                    Check += A[i, j] * x[j];
                    if (A[i, j] != 0)
                    {
                        if (A[i, j + 1] < 0)
                            CheckLabel.Text += A[i, j] + "*" + x[j];
                        else
                            CheckLabel.Text += A[i, j] + "*" + x[j] + "+";
                    }
                }
                CheckLabel.Text = CheckLabel.Text.Remove(CheckLabel.Text.Length - 1);
                CheckLabel.Text += " = " + Check + "\n";
            }
        }
    }
}
