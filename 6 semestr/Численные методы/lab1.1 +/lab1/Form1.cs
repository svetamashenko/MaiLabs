using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DoButton_Click(object sender, EventArgs e)
        {
            int[] start = new int[2];
            start[0] = 1;
            start[1] = 1;
            string[] rows;
            rows = CoefsTextBox.Text.Split('\n').ToArray();
            int high = rows.Length;
            double[] columns = rows[0].Split(' ').Select(double.Parse).ToArray();
            int length = columns.Length;
            double[,] A = new double[length, high];
            double[] Ans = new double[high];
            for (int a = 0; a < high; a++)
            {
                double[] coeftr = rows[a].Split(' ').Select(double.Parse).ToArray();
                Ans[a] = coeftr[length - 1];
                for (int b = 0; b < length - 1; b++)
                    A[b, a] = coeftr[b];
            }
            double[,] L = new double[length, high];
            double[,] U = new double[length, high];
            double[,] B = new double[length, high];
            double[,] I = new double[length - 1, high];
            for (int a = 0; a < high; a++)
                for (int b = 0; b < length - 1; b++)
                {
                    if (a == b)
                        L[a, b] = 1;
                    else
                        L[a, b] = 0;
                    U[a, b] = 0;
                }
            for (int a = 0; a < high; a++)
                for (int b = 0; b < length - 1; b++)
                {
                    if (a == b)
                        I[a, b] = 1;
                    else
                        I[a, b] = 0;
                }
            if (textBox1.Text != "1 1")
            {
                start = textBox1.Text.Split(' ').Select(int.Parse).ToArray();
                for (int a = 0; a < high; a++)
                    for (int b = 0; b < length - 1; b++)
                        B[a, b] = A[a, b];
                A = permutation(A, start, high, length);
            }




            // LU разложение
            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < length - 1; j++)
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



            label1.Text = "L - матрица:\n";
            label2.Text = "U - матрица:\n";
            label4.Text = "Определитель матрицы:\n";
            label5.Text = "Решение СЛАУ:\n";
            label6.Text = "L x U:\n";
            label7.Text = "Обратная матрица:\n";
            label8.Text = "A x A^(-1):\n";
            // Вывод матриц L и U
            for (int j = 0; j < high; j++)
            {
                for (int i = 0; i < length - 1; i++)
                {
                    label1.Text += Math.Round(L[i, j], 2) + " ";
                    label2.Text += Math.Round(U[i, j], 2) + " ";
                }
                label1.Text += '\n';
                label2.Text += '\n';
            }


            // Определитель матрицы
            double detA = 1;
            for (int i = 0; i < high; i++)
                detA *= U[i, i];
            if ((start[0] + start[1]) % 2 == 1)
                detA *= -1;
            label4.Text += "det(A) = " + detA;


            // Решение СЛАУ
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
            for (int i = 0; i < high; i++)
            {
                label5.Text += "x" + (i + 1) + " = " + Math.Round(x[i], 2) + '\n';
            }

            double[,] prov = peremnoj(U, L, high, length);
            for (int j = 0; j < high; j++)
            {
                for (int i = 0; i < length - 1; i++)
                {
                    label6.Text += Math.Round(prov[i, j], 2) + " ";
                }
                label6.Text += '\n';
            }


            // Обратная матрица к L
            double[,] Y = new double[high, length - 1];
            double[,] X = new double[high, length - 1];
            for (int a = 0; a < high; a++)
                for (int b = 0; b < length - 1; b++)
                {
                    if (a == b)
                    {
                        X[a, b] = 1 / U[a, b];
                        Y[a, b] = 1;
                    }
                    else
                    {
                        X[a, b] = 0;
                        Y[a, b] = 0;
                    }
                }
            for (int i = 0; i < high; i++)
            {
                for (int j = i; j < high; j++)
                {
                    for (int z = 0; z < high; z++)
                    {
                        help += Y[i, z] * L[z, j];
                    }
                    if (i != j)
                        Y[i, j] = - help;
                    help = 0;
                }
            }


            // Обратная матрица к U
            for (int j = high - 1; j >= high - 1; j--)
                for (int i = high - 1; i >= 0; i--)
                {
                    for (int z = high - 1; z >= 0; z--)
                        help += U[j, z] * X[i, z];
                    if (i != j)
                        X[i, j] = (-help) / U[i, i];
                    help = 0;
                }
            for (int j = high - 2; j >= 0; j--)
                for (int i = high - 2; i >= 0; i--)
                {
                    for (int z = high - 1; z >= 0; z--)
                        help += U[z, i] * X[z, j];
                    if (i != j)
                        X[i, j] = (-help) / U[i, i];
                    help = 0;
                }

            double[,] Ytransp = new double[length - 1, high];
            for (int a = 0; a < high; a++)
                for (int b = 0; b < length - 1; b++)
                    Ytransp[a, b] = Y[b, a];
            double[,] obrAtransp = new double[length - 1, high];
            double[,] obrA = peremnoj(X, Ytransp, high, length);
            for (int a = 0; a < high; a++)
                for (int b = 0; b < length - 1; b++)
                    obrAtransp[a, b] = obrA[b, a];
            double[,] res = peremnoj(A, obrAtransp, high, length);
            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < high; j++)
                {
                    label7.Text += Math.Round(obrA[i, j], 2) + " ";
                    label8.Text += Math.Round(res[i, j]) + " ";
                }
                label7.Text += "\n";
                label8.Text += "\n";
            }
        }
        public double[,] permutation(double[,] matrix, int[] numbers, int high, int lenght)
        {
            numbers[0] -= 1;
            numbers[1] -= 1;
            double[,] newmatrix = new double[high, high];
            double[,] helpmatrix = new double[high, high];
            int c = 1;
            for (int i = 0; i < high; i++)
                if (i == numbers[0])
                    for (int a = 0; a < high; a++)
                        helpmatrix[a, 0] = matrix[a, i];
                else
                {
                    for (int a = 0; a < high; a++)
                        helpmatrix[a, c] = matrix[a, i];
                    c++;
                }
            c = 1;
            for (int i = 0; i < high; i++)
                if (i == numbers[1])
                    for (int a = 0; a < lenght - 1; a++)
                        newmatrix[0, a] = helpmatrix[i, a];
                else
                {
                    for (int a = 0; a < lenght - 1; a++)
                        newmatrix[c, a] = helpmatrix[i, a];
                    c++;
                }

            return newmatrix;
        }

        public double[,] backpermutation(double[,] matrix, int[] numbers, int high, int lenght)
        {
            double[,] helpmatrix = new double[lenght, high];
            double[,] newmatrix = new double[lenght, high];
            int c = 0;
            int d = numbers[0];
            // столбцы
            if (numbers[0] == 0)
                helpmatrix = matrix;
            else for (int j = 0; j < lenght - 1; j++)
                {
                    if (j == 0)
                        for (int a = 0; a < high; a++)
                        {
                            helpmatrix[a, numbers[0]] = matrix[a, 0];
                            helpmatrix[a, j] = matrix[a, j + 1];
                        }
                    else if (j < numbers[0])
                        for (int a = 0; a < lenght - 1; a++)
                            helpmatrix[a, j] = matrix[a, j + 1];
                    else if (j == numbers[0]) ;
                    else
                        for (int a = 0; a < high; a++)
                            helpmatrix[a, j] = matrix[a, j];
                }
            if (numbers[1] == 0)
                newmatrix = helpmatrix;
            else for (int i = 0; i < lenght - 1; i++)
                {
                    if (i == 0)
                        for (int a = 0; a < high; a++)
                        {
                            newmatrix[numbers[1], a] = helpmatrix[0, a];
                            newmatrix[i, a] = helpmatrix[i + 1, a];
                        }
                    else if (i < numbers[1])
                        for (int a = 0; a < high; a++)
                            newmatrix[i, a] = helpmatrix[i + 1, a];
                    else if (i == numbers[1]) ;
                    else
                        for (int a = 0; a < high; a++)
                            newmatrix[i, a] = helpmatrix[i, a];
                }
            return newmatrix;
        }

        public double[,] peremnoj(double[,] first, double[,] second, int high, int lenght)
        {
            double[,] result = new double[high, lenght];
            double sum = 0;
            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < lenght - 1; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < high; k++)
                    {
                        result[i, j] += first[i, k] * second[k, j];
                    }
                }
            }
            return result;
        }
    }
}