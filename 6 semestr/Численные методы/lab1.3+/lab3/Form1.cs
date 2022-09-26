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
            comboBox1.SelectedIndex = 0;
        }

        private void DoButton_Click(object sender, EventArgs e)
        {
            SolvingLabel.Text = "Решение СЛАУ: \n\n\n";
            double epsilon = double.Parse(EpsilonTextBox.Text);
            string[] rows;
            rows = CoefsTextBox.Text.Split('\n').ToArray();
            int high = rows.Length;
            double[] columns = rows[0].Split(' ').Select(double.Parse).ToArray();
            int length = high;
            double[,] A = new double[high, high];
            for (int i = 0; i < high; i++)
                for (int j = 0; j < length; j++)
                    A[i, j] = 0;
            double[] Ans = new double[high];
            for (int i = 0; i < high; i++)
            {
                double[] coeftr = rows[i].Split(' ').Select(double.Parse).ToArray();
                Ans[i] = coeftr[coeftr.Length - 1];
                for (int j = 0; j < coeftr.Length - 1; j++)
                {
                    A[i, j] = coeftr[j];
                }
            }
            double[] x = new double[high];
            if (comboBox1.SelectedIndex == 0)
            {
                int k = 1;
                double[] newx = new double[high];
                double raznx = 0;
                double[] raznxi = new double[high];
                double sum = 0;
                for (int i = 0; i < high; i++)
                {
                    newx[i] = Ans[i] / A[i, i];
                    if (Math.Abs(newx[i] - x[i]) > raznx)
                        raznx = Math.Abs(newx[i] - x[i]);
                }
                int prov = 0;
                while (raznx > epsilon)
                {
                    for (int i = 0; i < high; i++)
                    {
                        x[i] = newx[i];
                        for (int a = 0; a < i; a++)
                            sum -= A[i, a] * x[a];
                        for (int a = i + 1; a < length; a++)
                            sum -= A[i, a] * x[a];
                        newx[i] = (sum + Ans[i]) / A[i, i];
                        raznxi[i] = Math.Abs(newx[i] - x[i]);
                        sum = 0;
                        prov++;
                    }
                    raznx = raznxi.Max();
                    k++;
                }
                for (int i = 0; i < high; i++)
                    SolvingLabel.Text += "x[" + (i + 1) + "] = " + Math.Round(newx[i], 2) + "\n";
                SolvingLabel.Text += "Ответ получен за " + k + " итераций." + "\n";
            }

            else
            {
                int k = 1;
                double[] newx = new double[high];
                double raznx = 0;
                double[] raznxi = new double[high];
                double sum = 0;
                for (int i = 0; i < high; i++)
                {
                    newx[i] = Ans[i] / A[i, i];
                    if (Math.Abs(newx[i] - x[i]) > raznx)
                        raznx = Math.Abs(newx[i] - x[i]);
                }
                int prov = 0;
                while (raznx > epsilon)
                {
                    for (int i = 0; i < high; i++)
                    {
                        x[i] = newx[i];
                        for (int a = 0; a < i; a++)
                            sum -= A[i, a] * newx[a];
                        for (int a = i + 1; a < length; a++)
                            sum -= A[i, a] * x[a];
                        newx[i] = (sum + Ans[i]) / A[i, i];
                        raznxi[i] = Math.Abs(newx[i] - x[i]);
                        sum = 0;
                        prov++;
                    }
                    raznx = raznxi.Max();
                    k++;
                }
                for (int i = 0; i < high; i++)
                    SolvingLabel.Text += "x[" + (i + 1) + "] = " + Math.Round(newx[i], 2) + "\n";
                SolvingLabel.Text += "Ответ получен за " + k + " итераций." + "\n";
            }
        }
    }
}
