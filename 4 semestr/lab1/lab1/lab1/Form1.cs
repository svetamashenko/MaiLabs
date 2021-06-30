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

        private void MainButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MainButton.Visible = false;
                MainTaskLabel.Visible = false;
                groupBox1.Visible = false;
                MenuButton.Visible = true;
                InputCoefs1Task.Visible = true;
                InputNumber1Task.Visible = true;
                CoefsLabel1Task.Visible = true;
                NumberLabelTask1.Visible = true;
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

        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (Perform1TaskButton.Visible == true)
            {
                MainButton.Visible = true;
                MainTaskLabel.Visible = true;
                groupBox1.Visible = true;
                InputCoefs1Task.Visible = false;
                InputNumber1Task.Visible = false;
                CoefsLabel1Task.Visible = false;
                NumberLabelTask1.Visible = false;
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
        }

        //
        //1 задание
        //
        private void Perform1TaskButton_Click(object sender, EventArgs e)
        {
            double[] coef;
            coef = InputCoefs1Task.Text.Split(' ').Select(Double.Parse).ToArray();
            string Old = "f(x) = ";
            int j = 0;
            while (coef[j] == 0)
            {
                j++;
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
                if ((i != j)/* && (coef.Length - j <= 2)*/)
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
                            if (sign == "+")
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
            ProblemOut1Task.Text = Old;
            double x = Convert.ToDouble(InputNumber1Task.Text);
            double Res = 0;
            double newcoef = coef[0] * x + coef[1];
            for (int i = 2; i < coef.Length; i++)
            {
                newcoef = newcoef * x + coef[i];
            }
            Res = newcoef;
            string Val = Res.ToString();
            string Out = "f(" + x + ") = " + Val;
            SolvingOut1Task.Text = Out;
        }

        //
        // 2 задание
        //
        private void Perform2TaskButton_Click(object sender, EventArgs e)
        {
            double[] coef;
            coef = InputCoefs2Task.Text.Split(' ').Select(double.Parse).ToArray();
            string Old = "f(x) = ";
            int j = 0;
            while (coef[j] == 0)
            {
                j++;
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
                            if (sign == "+")
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
            if (Old[0] == '+')
            {
                Old.Substring(1);
            }
            ProblemOut2Task.Text = Old;
            double a;
            a = Convert.ToDouble(InputNumber2Task.Text);
            double[] newCoef = new double[coef.Length - 1];
            newCoef[0] = coef[0];
            for (int i = 1; i < newCoef.Length; i++)
            {
                newCoef[i] = newCoef[i - 1] * a + coef[i];
            }
            double free = newCoef[newCoef.Length - 1] * a + coef[newCoef.Length];
            string Prob = "";
            if (a < 0)
            {
                Prob += "f(x/(x + " + -a + ")) = ";
            }
            else
            {
                Prob += "f(x/(x - " + a + ")) = ";
            }
            for (int i = 0; i < newCoef.Length; i++)
            {
                string sign = "+";
                if (newCoef[i] < 0)
                {
                    sign = "-";
                    newCoef[i] = newCoef[i] * -1;
                }
                if (i != 0)
                {
                    if (i == newCoef.Length - 2)
                    {
                        if (newCoef[i] != 0)
                        {
                            if (newCoef[i] != 1)
                            {
                                Prob += sign + newCoef[i].ToString() + "x";
                            }
                            else
                            {
                                Prob += sign + "x";
                            }
                        }
                    }
                    else if (i == newCoef.Length - 1)
                    {
                        if (newCoef[i] != 0)
                        {
                            if (newCoef[i] != 1)
                            {
                                Prob += sign + newCoef[i].ToString();
                            }
                            else
                            {
                                Prob += sign + "1";
                            }
                        }
                    }
                    else if (newCoef[i] != 0)
                    {
                        if (newCoef[i] != 1)
                        {
                            Prob += sign + newCoef[i].ToString() + "x^" + (newCoef.Length - i - 1).ToString();
                        }
                        else
                        {
                            Prob += sign + "x^" + (newCoef.Length - i - 1).ToString();
                        }
                    }
                }
                else
                {
                    if (newCoef[i] != 0)
                    {
                        if (newCoef[i] != 1)
                        {
                            Prob += newCoef[i].ToString() + "x^" + (newCoef.Length - i - 1).ToString();
                        }
                        else
                        {
                            if (sign == "+")
                            {
                                Prob += "x^" + (newCoef.Length - i - 1).ToString();
                            }
                            else
                            {
                                Prob += "-x^" + (newCoef.Length - i - 1).ToString();
                            }
                        }
                    }
                }
            }
            SolvingOut2Task.Text = Prob;
        }

        //
        // 3 задание
        //
        private void Perform3TaskButton_Click(object sender, EventArgs e)
        {
            double[] coef;
            coef = InputCoefs3Task.Text.Split(' ').Select(double.Parse).ToArray();
            string Old = "f(x) = ";
            int j = 0;
            while (coef[j] == 0)
            {
                j++;
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
                            if (sign == "+")
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
            if (Old[0] == '+')
            {
                Old.Substring(1);
            }
            ProblemOut3Task.Text = Old;
            double a;
            a = Convert.ToDouble(InputNumber3Task.Text);
            double[] newCoef = new double[coef.Length];
            newCoef = coef;
            double[] counter = new double[coef.Length];
            double[] between = new double[counter.Length];
            string Prob = "";
            if (a > 0)
                Prob = "f(y + " + a + ") = ";
            else if (a < 0)
                Prob = "f(y - " + (-a) + ") = ";
            else
                Prob = "f(y) = ";
            for (int l = 0; l < coef.Length; l++) 
            {
                counter[0] = 0;
                counter[1] = newCoef[0] * a;
                for (int k = 2; k < coef.Length - l; k++)
                {
                    counter[k] = a * counter[k - 1] + newCoef[k -1] * a;
                }
                for (int k = coef.Length - 1 -l; k > 0; k--)
                {
                    newCoef[k] = newCoef[k] + counter[k];
                }
            }
            for (int i = 0; i < newCoef.Length; i++)
            {
                string sign = "+";
                if (newCoef[i] < 0)
                {
                    sign = "-";
                    newCoef[i] = newCoef[i] * -1;
                }
                if ((i != j))
                {
                    if (i == newCoef.Length - 2)
                    {
                        if (newCoef[i] != 0)
                        {
                            if (newCoef[i] != 1)
                            {
                                Prob += sign + newCoef[i].ToString() + "y";
                            }
                            else
                            {
                                Prob += sign + "y";
                            }
                        }
                    }
                    else if (i == newCoef.Length - 1)
                    {
                        if (newCoef[i] != 0)
                        {
                            if (newCoef[i] != 1)
                            {
                                Prob += sign + newCoef[i].ToString();
                            }
                            else
                            {
                                Prob += sign + "1";
                            }
                        }
                    }
                    else
                    {
                        if (newCoef[i] != 0)
                        {
                            if (newCoef[i] != 1)
                            {
                                Prob += sign + newCoef[i].ToString() + "y^" + (newCoef.Length - i - 1).ToString();
                            }
                            else
                            {
                                Prob += sign + "y^" + (newCoef.Length - i - 1).ToString();
                            }
                        }
                    }
                }
                else
                {
                    if (newCoef[i] != 0)
                    {
                        string newsign;
                        if (newCoef[i] != 1)
                        {
                            if (sign == "+")
                                newsign = "";
                            else
                                newsign = "-";
                            Prob += newsign + newCoef[i].ToString() + "y^" + (newCoef.Length - i - 1).ToString();
                        }
                        else
                        {
                            if (sign == "+")
                            {
                                Prob += "y^" + (newCoef.Length - i - 1).ToString();
                            }
                            else
                            {
                                Prob += "-y^" + (newCoef.Length - i - 1).ToString();
                            }
                        }
                    }

                }
                if (sign == "-")
                {
                    newCoef[i] = newCoef[i] * -1;
                }
            }
            SolvingOut3Task.Text = Prob;
        }

        //
        // 4 задание
        //
        private void Perform4TaskButton_Click(object sender, EventArgs e)
        {
            double[] coef;
            coef = InputCoefs4Task.Text.Split(' ').Select(double.Parse).ToArray();
            string Old = "f(x) = ";
            int j = 0;
            while (coef[j] == 0)
            {
                j++;
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
                            if (sign == "+")
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
            ProblemOut4Task.Text = Old;
            double[] newCoef = new double[coef.Length];
            for (int y = 0; y < coef.Length; y++)
            {
                newCoef[y] = coef[y];
            }
            double[] counter = new double[coef.Length];
            string Prob = "";
            double max = 0;
            //верхняя граница
            int proof = 1;
            for (double i = 20; i > 0; i--)
            {
                for (int y = 0; y < coef.Length; y++)
                {
                    newCoef[y] = coef[y];
                }
                for (int k = 0; k < counter.Length; k++)
                    counter[k] = 0;
                if (newCoef[0] < 0)
                    for (int y = 0; y < coef.Length; y++)
                    {
                        newCoef[y] = -newCoef[y];
                    }
                counter[0] = 0;
                counter[1] = newCoef[0] * i;
                for (int k = 2; k < coef.Length; k++)
                {
                    counter[k] = i * counter[k - 1] + newCoef[k - 1] * i;
                }
                for (int k = coef.Length - 1; k > 0; k--)
                {
                    newCoef[k] = newCoef[k] + counter[k];
                    if (newCoef[k] < 0)
                        proof = 0;
                }
                if (proof == 1)
                    max = i;
            }
            //нижняя граница
            double min = 0;
            proof = 1;
            double[] minCoef = new double[coef.Length];
            for(int y = 1; y < coef.Length; y = y + 2)
            {
                minCoef[y] = minCoef[y] * (-1);
            }
            for (double i = 20; i > 0; i--)
            {
                for (int y = 0; y < coef.Length; y++)
                {
                    minCoef[y] = coef[y];
                }
                for (int y = 1; y < coef.Length; y = y+2)
                {
                    minCoef[y] = minCoef[y] * (-1);
                }
                for (int k = 0; k < counter.Length; k++)
                    counter[k] = 0;
                if (minCoef[0] < 0)
                    for (int y = 0; y < coef.Length; y++)
                    {
                        minCoef[y] = -minCoef[y];
                    }
                counter[1] = minCoef[0] * i;
                for (int k = 2; k < coef.Length; k++)
                {
                    counter[k] = i * counter[k - 1] + minCoef[k - 1] * i;
                }
                for (int k = coef.Length - 1; k > 0; k--)
                {
                    minCoef[k] = minCoef[k] + counter[k];
                    if (minCoef[k] < 0)
                        proof = 0;
                }
                if (proof == 1)
                    min = i;
            }
            Prob += "Нижняя граница полинома: " + (-min) + "\nВерхняя граница полинома: " + max;
            SolvingOut4Task.Text = Prob;
        }

        //
        // 5 задание
        //
        static double counter(double[] prob,double x)
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
            double[] coef;
            coef = InputCoefs5Task.Text.Split(' ').Select(double.Parse).ToArray();
            string Old = "f(x) = ";
            int j = 0;
            while (coef[j] == 0)
            {
                j++;
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
                            if (sign == "+")
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
            ProblemOut5Task.Text = Old;
            string Prob = "";
            double a = -10;
            double b = 20;
            const double eps = 0.001;
            double answer = 0;
            while((b - a) > eps)
            {
                if (counter(coef, b) * counter(coef, answer) < 0)
                    a = answer;
                else if (counter(coef, a) * counter(coef, answer) < 0)
                    b = answer;
                else if (Math.Abs(a) > Math.Abs(b))
                    a = answer;
                else
                    b = answer;
                answer = (a + b) / 2;
            }
            double ready = Math.Round(answer, 3);
            Prob += "f("+ ready+")=0";
            SolvingOut5Task.Text = Prob;
        }
    }
}
