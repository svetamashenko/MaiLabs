using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1._4
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DoButton_Click(object sender, EventArgs e)
        {
            SolvingLabel.Text = "Собственные значения: \n\n";
            СheckLabel.Text = "Проверка: \n\n";
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
            int k = 0;
            double[,] H = new double[high, high];
            double[,] HT = new double[high, high];
            double[,] SobstvVect = new double[high, high];
            for (int i = 0; i < high; i++)
                for (int j = 0; j < high; j++)
                    if (i == j)
                        SobstvVect[i, j] = 1;
                    else
                        SobstvVect[i, j] = 0;
            double phi = 0;
            double max_element = epsilon;
            int imax = 0, jmax = 0;
            while (max_element >= epsilon)
            {
                max_element = -100;

                for (int i = 0; i < high; i++)
                    for (int j = 0; j < high; j++)
                        if (i == j)
                            H[i, j] = 1;
                        else
                            H[i, j] = 0;

                for (int i = 0; i < high; i++)
                    for (int j = 1 + i; j < high; j++)
                        if (A[i, j] > max_element)
                        {
                            max_element = A[i, j];
                            imax = i;
                            jmax = j;
                        }

                phi = 0.5 * Math.Atan(2 * A[imax, jmax] / (A[imax, imax] - A[jmax, jmax]));
                H[imax, imax] = Math.Cos(phi);
                H[jmax, jmax] = Math.Cos(phi);
                H[imax, jmax] = -Math.Sin(phi);
                H[jmax, imax] = Math.Sin(phi);
                for (int i = 0; i < high; i++)
                {
                    for (int j = 0; j < high; j++)
                    {
                        HT[j, i] = H[i, j];
                    }
                }
                A = UmnojMatrix(HT, (UmnojMatrix(A, H)));
                SobstvVect = UmnojMatrix(HT, SobstvVect);
                k++;
            }

            SobstvVect = NormMatrix(SobstvVect);

            for (int i = 0; i < high; i++)
                SolvingLabel.Text += "x[" + (i + 1) + "] = " + Math.Round(A[i, i], 2) + "\n";

            SolvingLabel.Text += "\n";

            double[,] SobstvVect1 = new double[high, high];
            for (int i = 0; i < high; i++)
                for (int j = 0; j < high; j++)
                    SobstvVect1[i, j] = SobstvVect[j, i];

            for (int i = 0; i < high; i++)
            {
                SolvingLabel.Text += "v[" + (i + 1) + "] = ";
                for (int j = 0; j < high; j++)
                    SolvingLabel.Text += Math.Round(SobstvVect1[i, j], 2) + " ";
                SolvingLabel.Text += "\n";
            }

            SolvingLabel.Text += "\n";

            SolvingLabel.Text += "Ответ получен за " + k + " итераций." + "\n";

            // Проверка
            double[,] D = new double[high, high];
            for (int i = 0; i < high; i++)
                for (int j = 0; j < high; j++)
                {
                    if (i == j)
                        D[i, j] = A[i, i];
                    else
                        D[i, j] = 0;
                }
            double[,] Check = UmnojMatrix(UmnojMatrix(SobstvVect1, D), ObrMatrix(SobstvVect1, high));
            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < high; j++)
                    СheckLabel.Text += Math.Round(Check[i, j]) + " ";
                СheckLabel.Text += "\n";
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
