using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1._5
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DoButton_Click(object sender, EventArgs e)
        {
            QLabel.Text = "Матрица Q: \n\n";
            RLabel.Text = "Матрица R: \n\n";
            CheckLabel.Text = "Проверка (Q*R): \n";
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
            for (int i = 0; i < high; i++)
            {
                double[] coeftr = rows[i].Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < coeftr.Length; j++)
                {
                    A[i, j] = coeftr[j];
                }
            }
            double[] v = new double[high];
            double[,] H = new double[high, high];
            double[,] Q = new double[high, high];
            for (int i = 0; i < high; i++)
                for (int j = 0; j < high; j++)
                    if (i == j)
                        Q[i, j] = 1;
                    else
                        Q[i, j] = 0;

            int n = 0;
            int sign = 0;
            double sum = 0;
            double[,] Vspomog = new double[high, high];
            double delitel = 0;
            while (n < 2)
            {
                for (int i = 0; i < high; i++)
                    for (int j = 0; j < high; j++)
                        if (i == j)
                            H[i, j] = 1;
                        else
                            H[i, j] = 0;
                delitel = 0;
                sum = 0;
                if (A[n, n] < 0)
                    sign = -1;
                else
                    sign = 1;
                for (int j = n; j < high; j++)
                {
                    sum += Math.Pow(A[j, n], 2);
                }
                for (int i = 0; i < high; i++)
                {
                    if (i < n)
                        v[i] = 0;
                    else if (i == n)
                        v[i] = A[i, i] + sign * Math.Pow(sum, 0.5);
                    else
                        v[i] = A[i, n];
                }

                Vspomog = UmnojMatrix(v, v);

                for (int i = 0; i < high; i++)
                    delitel += Math.Pow(v[i], 2);
                for (int i = 0; i < high; i++)
                    for (int j = 0; j < high; j++)
                        H[i, j] -= 2 * Vspomog[i, j] / delitel;

                Q = UmnojMatrix(Q, H);
                A = UmnojMatrix(H, A);
                n++;
            }

            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < high; j++)
                    QLabel.Text += Math.Round(Q[i, j], 2) + " ";
                QLabel.Text += "\n";
            }

            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < high; j++)
                    RLabel.Text += Math.Round(A[i, j], 2) + " ";
                RLabel.Text += "\n";
            }

            QLabel.Text += "\n";

            QLabel.Text += "Ответ получен за " + n + " итераций." + "\n";

            // Проверка

            double[,] Check = UmnojMatrix(Q, A);
            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < high; j++)
                    CheckLabel.Text += Math.Round(Check[i, j]) + " ";
                CheckLabel.Text += "\n";
            }
        }
        public double[,] UmnojMatrix(double[,] Matr1, double[,] Matr2)
        {
            int high = Matr1.GetLength(0);
            double[,] newMatr = new double[high, high];
            for (int i = 0; i < high; i++)
                for (int j = 0; j < high; j++)
                {
                    for (int k = 0; k < high; k++)
                        newMatr[i, j] += Matr1[i, k] * Matr2[k, j];
                }
            return newMatr;
        }

        public double[,] UmnojMatrix(double[] Matr1, double[] Matr2)
        {
            int high = Matr1.GetLength(0);
            double[,] newMatr = new double[high, high];
            for (int i = 0; i < high; i++)
                for (int j = 0; j < high; j++)
                {
                        newMatr[i, j] += Matr1[i] * Matr2[j];
                }
            return newMatr;
        }

        public double[,] TranspMatrix(double[,] Matrix, int high)
        {
            double[,] Res = new double[high, high];
            for (int i = 0; i < high; i++)
                for (int j = 0; j < high; j++)
                    Res[i, j] = Matrix[j, i];
            return Res;
        }

        public double[,] NormMatrix(double[,] Matrix)
        {
            int high = Matrix.GetLength(0);
            double mnoj;
            double[,] newMatr = new double[high, high];
            for (int i = 0; i < high; i++)
            {
                mnoj = 1 / Matrix[i, i];
                if (Matrix[i, i] != 0)
                    for (int j = 0; j < high; j++)
                        newMatr[j, i] = mnoj * Matrix[j, i];
            }
            return newMatr;
        }

        public double[,] ObrMatrix(double[,] Matrix, int high)
        {
            double[,] Res = new double[high, high];
            for (int i = 0; i < high; i++)
                for (int j = 0; j < high; j++)
                    if (i == j)
                        Res[i, j] = 1;
                    else
                        Res[i, j] = 0;
            double mnoj = 1;
            for (int i = 0; i < high; i++)
            {
                mnoj = 1 / Matrix[i, i];
                for (int j = 0; j < high; j++)
                {
                    Matrix[i, j] = Matrix[i, j] * mnoj;
                    Res[i, j] = Res[i, j] * mnoj;
                }
                for (int k = 0; k < i; k++)
                {
                    mnoj = Matrix[k, i] / Matrix[i, i];
                    for (int j = 0; j < high; j++)
                    {
                        Matrix[k, j] -= Matrix[i, j] * mnoj;
                        Res[k, j] -= Res[i, j] * mnoj;
                    }
                }
                for (int k = i + 1; k < high; k++)
                {
                    mnoj = Matrix[k, i] / Matrix[i, i];
                    for (int j = 0; j < high; j++)
                    {
                        Matrix[k, j] -= Matrix[i, j] * mnoj;
                        Res[k, j] -= Res[i, j] * mnoj;
                    }
                }
            }
            return Res;
        }
    }
}
