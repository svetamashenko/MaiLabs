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
                NumberLabel4Task.Visible = true;
                InputNumber4Task.Visible = true;
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
            if (radioButton6.Checked == true)
            {
                MainButton.Visible = false;
                MainTaskLabel.Visible = false;
                groupBox1.Visible = false;
                Perform6TaskButton.Visible = true;
                MenuButton.Visible = true;
                Task6Task.Visible = true;
                CoefsLabel6Task.Visible = true;
                InputCoefs6Task.Visible = true;
                ProblemOut6Task.Visible = true;
                SolvingOut6Task.Visible = true;
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
                NumberLabel4Task.Visible = false;
                InputNumber4Task.Visible = false;
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
            if (Perform6TaskButton.Visible == true)
            {
                MainButton.Visible = true;
                MainTaskLabel.Visible = true;
                groupBox1.Visible = true;
                Perform6TaskButton.Visible = false;
                MenuButton.Visible = false;
                Task6Task.Visible = false;
                CoefsLabel6Task.Visible = false;
                InputCoefs6Task.Visible = false;
                ProblemOut6Task.Visible = false;
                SolvingOut6Task.Visible = false;
            }
        }

        //
        //1 задание
        //
        private void Perform1TaskButton_Click(object sender, EventArgs e)
        {
            double[] coefin;
            coefin = InputCoefs1Task.Text.Split(' ').Select(Double.Parse).ToArray();
            string Old = "f(x) = " + ProbOut(coefin);
            ProblemOut1Task.Text = Old;
            double[] coef = new double[coefin.Length];
            int count = 0;
            for (int i = 0; i < coef.Length; i++)
            {
                if (coefin[i] == 0)
                {
                    count++;
                }
                else
                    coef[i - count] = coefin[i];
            }
            double max1 = 0;
            for (int i = 0; i < coef.Length - count; i++)
            {
                if (coef[i] < 0)
                {
                    coef[i] = coef[i] * (-1);
                }
            }
            for (int i = 0; i < coef.Length - count; i++)
            {
                if (coef[i] > max1)
                    max1 = coef[i];
            }
            double max2 = 0;
            for (int i = 0; i < coef.Length - count - 1; i++)
            {
                if (coef[i] > max2)
                    max2 = coef[i];
            }
            double ans1 = (max1 / coef[0]) + 1;
            double ans2 = (1 / (1 + (max2 / coef[coef.Length - count - 1])));
            string Out2 = "Нижняя граница: " + Math.Round(ans2, 5) + "\nВерхняя граница: " + Math.Round(ans1, 5);
            SolvingOut1Task.Text = Out2;
        }

        //
        // 2 задание
        //
        private void Perform2TaskButton_Click(object sender, EventArgs e)
        {
            double[] coefin;
            coefin = InputCoefs2Task.Text.Split(' ').Select(Double.Parse).ToArray();
            string Old = "f(x) = " + ProbOut(coefin);
            ProblemOut2Task.Text = Old;
            double[] coef = new double[coefin.Length];
            int k = 0;
            double znak = coefin[0];
            for (int i = coefin.Length - 1; i > 0; i--)
            {
                if (coefin[i] * znak < 0)
                    k = i;
            }
            int count = 0;
            for (int i = 0; i < coef.Length; i++)
            {
                if (coefin[i] == 0)
                {
                    count++;
                }
                else
                    coef[i - count] = coefin[i];
            }
            if (coef[0] < 0)
                for (int i = 0; i < coef.Length - count; i++)
                {
                    coef[i] = coef[i] * -1;
                }
            double min = 0;
            for (int i = 1; i < coef.Length - count; i++)
            {
                if (coef[i] < min)
                    min = coef[i];
            }
            Old += " " + k + " " + -min + coef[0] + "*";
            ProblemOut2Task.Text = Old;
            double answ = 1 + (Math.Pow((-min / coef[0]), (1.0 / k)));
            SolvingOut2Task.Text = "Верхняя граница положительных\nдействительных корней: " + Math.Round(answ, 4);
        }

        //
        // 3 задание
        //
        private void Perform3TaskButton_Click(object sender, EventArgs e)
        {
            double[] coef;
            coef = InputCoefs3Task.Text.Split(' ').Select(double.Parse).ToArray();
            string Old = "f(x) = " + ProbOut(coef);
            ProblemOut3Task.Text = Old;
            if (coef[0] < 0)
                for (int i = 0; i < coef.Length; i++)
                {
                    coef[i] = coef[i] * -1;
                }
            int high = -1;
            for (int m = 100; m>0; m--)
            {
                int proof = 0;
                double[] p1 = proizvod(coef);
                double c = f(proizvod(coef), m);
                if (c < 0)
                    proof--;
                for (int i = 1; i < coef.Length; i++)
                {
                    p1 = proizvod(p1);
                    c = f(p1, m);
                    if (proof < 0)
                        proof--;
                }
                if (proof == 0)
                    high = m;
            }
            SolvingOut3Task.Text = "Верхняя граница положительных\nдействительных корней: " + high;
        }

        //
        // 4 задание
        //
        private void Perform4TaskButton_Click(object sender, EventArgs e)
        {
            double[] coef1 = InputCoefs4Task.Text.Split(' ').Select(double.Parse).ToArray();
            double[] coef2 = InputNumber4Task.Text.Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < coef2.Length; i++)
            {
                coef2[i] = coef2[i] * -1;
            }
            ProblemOut4Task.Text = "f(x)=" + ProbOut(coef1) + "\n" + "g(x)=" + ProbOut(coef2);
            double[] ans = new double[coef1.Length];
            ans[0] = coef1[0];
            for (int i = 1; i < coef1.Length; i++)
                ans[i] = coef1[i];
            double[] help = new double[coef2.Length];
            for (int i = 0; i < coef1.Length - coef2.Length + 1; i++)
            {
                for (int j = 0; j < coef2.Length; j++)
                    help[j] = coef2[j] * ans[i];
                for (int j = 1; j < coef2.Length; j++)
                {
                    ans[j + i] += help[j];
                }
            }
            double[] ans2 = new double[coef2.Length - 1];
            double[] ans1 = new double[ans.Length - ans2.Length];
            for (int i = 0; i < ans1.Length; i++)
                ans1[i] = ans[i];
            for (int i = 0; i < ans2.Length; i++)
                ans2[i] = ans[ans1.Length + i];
            string Prob = "Частное: " + ProbOut(ans1) + "\nОстаток: " + ProbOut(ans2);
            SolvingOut4Task.Text = Prob;
        }

        //
        // 5 задание
        //
        private void Perform5TaskButton_Click(object sender, EventArgs e)
        {

            double[] coef = InputCoefs5Task.Text.Split(' ').Select(double.Parse).ToArray();
            ProblemOut5Task.Text = "f(x)=" + ProbOut(coef);
            double[] proiz = proizvod(coef);
            List<double[]> Shturm = new List<double[]>();
            Shturm.Add(coef);
            Shturm.Add(proiz);
            string find = "";
            string pr = "";
            int n = 2;
            int proof = 0;
            for (int i = 0; i < ost(coef, proiz).Length; i++)
                if (ost(coef, proiz)[i] != 0)
                    proof++;
            for (int i = 0; i < ost(coef, proiz).Length; i++)
                find += " " + ost(coef, proiz)[i];
            double[] ost1 = new double[ost(coef, proiz).Length];
            for (int i = 0; i < ost(coef, proiz).Length; i++)
            {
                ost1[i] = -ost(coef, proiz)[i];
            }
            if (proof == 0)
            {
                pr = "end";
                proof = 0;
            }
            else if (proof == 1)
            {
                Shturm.Add(ost1);
                pr = "end";
                n++;
                proof = 0;
            }
            else
            {
                Shturm.Add(ost1);
                n++;
                proof = 0;
            }
            while (pr != "end")
                for (int j = 2; j < 20; j++)
                {
                    for (int i = 0; i < Shturm[n-1].Length; i++)
                    {
                        int g = 0;
                        if (Shturm[n-1][i] != 0)
                            g++;
                        else if ((g == 0) && (Shturm[n-1][i] == 0))
                            proof++;
                    }
                    double[] delit = new double[Shturm[n-1].Length - proof];
                    if (delit.Length == 0)
                        pr = "end";
                    for (int i = 0; i < delit.Length; i++)
                        delit[i] = Shturm[n - 1][proof+i];
                    double[] delim = Shturm[n - 2];
                    double[] osta = new double[ost(delim, delit).Length];
                    for (int i = 0; i < ost(delim, delit).Length; i++)
                    {
                        osta[i] = -ost(delim, delit)[i];
                    }
                    if (osta.Length == 0)
                    {
                        pr = "end";
                        proof = 0;
                    }
                    else if (osta.Length == 1)
                    {
                        Shturm.Add(osta);
                        pr = "end";
                        n++;
                        proof = 0;
                    }
                    else
                    {
                        Shturm.Add(osta);
                        n++;
                        proof = 0;
                    }
                }
            double[] func = new double[coef.Length];
            double max = 300000;
            double min = -300000;
            int nul = 0;
            double[] fmax = new double[n];
            double[] fnul = new double[n];
            double[] fmin = new double[n];
            int k = 0;
            foreach (double[] i in Shturm)
            {
                fmax[k] = f(i, max);
                fnul[k] = f(i, nul);
                fmin[k] = f(i, min);
                k++;
            }
            int plus = 0;
            int minus = 0;
            int nol = 0;
            for (int i = 1; i < fmax.Length; i++)
            {
                if (fmax[i] * fmax[i - 1] < 0)
                    plus++;
                if (fnul[i] * fnul[i - 1] < 0)
                    nol++;
                if (fmin[i] * fmin[i - 1] < 0)
                    minus++;
            }
            find += "\n";
            foreach (double[] i in Shturm)
            {
                for (int j = 0; j < i.Length; j++)
                    find += i[j] + " ";
                find += "\n";
            }
            for (int j = 0; j < proizvod(coef).Length; j++)
                find += proizvod(coef)[j] + " ";
            find += "\n";
            SolvingOut5Task.Text = "Число корней: " + (minus - plus);
        }
        private void Perform6TaskButton_Click(object sender, EventArgs e)
        {
            double[] coef = InputCoefs6Task.Text.Split(' ').Select(double.Parse).ToArray();
            ProblemOut6Task.Text = "f(x)=" + ProbOut(coef); 
            double[] newCoef = new double[coef.Length];
            for (int y = 0; y < coef.Length; y++)
            {
                newCoef[y] = coef[y];
            }
            double[] counter = new double[coef.Length];
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
            for (int y = 1; y < coef.Length; y = y + 2)
            {
                minCoef[y] = minCoef[y] * (-1);
            }
            for (double i = 20; i > 0; i--)
            {
                for (int y = 0; y < coef.Length; y++)
                {
                    minCoef[y] = coef[y];
                }
                for (int y = 1; y < coef.Length; y = y + 2)
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
            string inter = "[";
            string corn = "[";
            List<double[]> sht = ShturmSyst(coef);
            List<double[]> intervals = Interv(sht, min, max, 1);
            int count = 0;
            foreach (double[] i in intervals)
                count++;
            for (int i = count; i > 0; i--)
            {
                double[] b = intervals[i-1];
                inter += b[0] + "," + b[1] + ";";
                corn += Newton(coef, b) + ";";
            }
            inter = inter.Remove(inter.Length - 1);
            corn = corn.Remove(corn.Length - 1);
            SolvingOut6Task.Text = "Корни: " + corn + "]" + "\nИнтервалы: " + inter + "]";
        }
        public static double Newton(double[] coef, double[] interv)
        {
            double x_curr = interv[1] - 0.5;
            do
            {
                x_curr = x_curr - (f(coef, x_curr) / f(proizvod(coef), x_curr));
            } while (f(coef, x_curr) > 0.0000001);
            return Math.Round(x_curr, 3);
        }
        public static List<double[]> Interv(List<double[]> sht, double min, double max, double step)
        {
            List<double[]> answ = new List<double[]>();
            int n = 0;
            for (double i = -min; i < max - 1; i+=1/step)
            {
                double j = i + 1 / step;
                if ((fSht(sht, i) - fSht(sht, j) == 0))
                {
                }
                else if (fSht(sht, i) - fSht(sht, j) == 1)
                {
                    double[] interv = new double[2];
                    interv[0] = i;
                    interv[1] = j;
                    answ.Add(interv);
                    n++;
                }
                else
                {
                    Interv(sht, min,min+i/(step*2), step * 2);
                    Interv(sht, max - i / (step * 2), max, step * 2);
                }
            }
            return answ;
        }
        //1 -2,18 -20,156 88,1304 -121,0277 49,4916 7,8382

        public static double[] fSht(List<double[]> Sht, double i1, double i2)
        {
            double[] ans = new double[2];
            int change1 = 0;
            int change2 = 0;
            double[] mas1 = new double[Sht.Count];
            double[] mas2 = new double[Sht.Count];
            int k = 0;
            foreach (double[] i in Sht)
            {
                mas1[k] = f(i, i1);
                mas1[k] = f(i, i2);
                k++;
            }
            for (int i = 1; i < mas1.Length; i++)
            {
                if (mas1[i] * mas1[i - 1] < 0)
                    change1++;
                if (mas2[i] * mas2[i - 1] < 0)
                    change2++;
            }
            if (change1 - change2 == 1)
            {
                ans[0] = i1;
                ans[1] = i2;
            }
            else
            {
                for (int c = 2; change1 - change2 == 1; c = c * 2)
                {
                    fSht(Sht, i1, i2 - 1 / c);
                    fSht(Sht, i1, i2 + 1 / c);
                }
            }
            return ans;
        }
        public static int fSht(List<double[]> Sht, double num)
        {
            int change = 0;
            double[] mas = new double[Sht.Count];
            int k = 0;
            foreach (double[] i in Sht)
            {
                mas[k] = f(i, num);
                k++;
            }
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] * mas[i - 1] < 0)
                    change++;
            }
            return change;
        }
        public static List<double[]> ShturmSyst(double[] coef)
        {
            double[] proiz = proizvod(coef);
            List<double[]> Shturm = new List<double[]>();
            Shturm.Add(coef);
            Shturm.Add(proiz);
            string find = "";
            string pr = "";
            int n = 2;
            int proof = 0;
            for (int i = 0; i < ost(coef, proiz).Length; i++)
                if (ost(coef, proiz)[i] != 0)
                    proof++;
            double[] ost1 = new double[ost(coef, proiz).Length];
            for (int i = 0; i < ost(coef, proiz).Length; i++)
            {
                ost1[i] = -ost(coef, proiz)[i];
            }
            if (proof == 0)
            {
                pr = "end";
                proof = 0;
            }
            else if (proof == 1)
            {
                Shturm.Add(ost1);
                pr = "end";
                n++;
                proof = 0;
            }
            else
            {
                Shturm.Add(ost1);
                n++;
                proof = 0;
            }
            while (pr != "end")
                for (int j = 2; j < 20; j++)
                {
                    for (int i = 0; i < Shturm[n - 1].Length; i++)
                    {
                        int g = 0;
                        if (Shturm[n - 1][i] != 0)
                            g++;
                        else if ((g == 0) && (Shturm[n - 1][i] == 0))
                            proof++;
                    }
                    double[] delit = new double[Shturm[n - 1].Length - proof];
                    if (delit.Length == 0)
                        pr = "end";
                    for (int i = 0; i < delit.Length; i++)
                        delit[i] = Shturm[n - 1][proof + i];
                    double[] delim = Shturm[n - 2];
                    double[] osta = new double[ost(delim, delit).Length];
                    for (int i = 0; i < ost(delim, delit).Length; i++)
                    {
                        osta[i] = -ost(delim, delit)[i];
                    }
                    if (osta.Length == 0)
                    {
                        pr = "end";
                        proof = 0;
                    }
                    else if (osta.Length == 1)
                    {
                        Shturm.Add(osta);
                        pr = "end";
                        n++;
                        proof = 0;
                    }
                    else
                    {
                        Shturm.Add(osta);
                        n++;
                        proof = 0;
                    }
                }
            return Shturm;
        }
        public static double[] ost(double[] delim, double[] delit)
        {
            double[] coef1 = new double[delim.Length];
            for (int i = 0; i < delim.Length; i++)
                coef1[i] = delim[i];
            double[] coef2 = new double[delit.Length];
            for (int i = 0; i < delit.Length; i++)
                coef2[i] = delit[i];
            double[] nol = new double[0];
            if ((coef2.Length == 0)||(coef2.Length == 1))
                return nol;
            if (coef2[0] == 1)
            {
                double[] ans = new double[coef1.Length];
                ans[0] = coef1[0];
                for (int i = 1; i < coef1.Length; i++)
                    ans[i] = coef1[i];
                double[] help = new double[coef2.Length];
                for (int i = 0; i <( delim.Length - delit.Length + 2); i++)
                {
                    for (int j = 0; j < coef2.Length; j++)
                        help[j] = coef2[j] * ans[i];
                    for (int j = 1; j < coef2.Length; j++)
                    {
                        ans[j + i] += help[j];
                    }
                }
                double[] ans2 = new double[coef2.Length - 1];
                double[] ans1 = new double[ans.Length - ans2.Length];
                for (int i = 0; i < ans1.Length; i++)
                    ans1[i] = ans[i];
                for (int i = 0; i < ans2.Length; i++)
                    ans2[i] = ans[ans1.Length + i];
                return ans2;
            }
            else
            {
                for (int i = 1; i < coef2.Length; i++)
                {
                    coef2[i] = coef2[i] * -1;
                }
                double mnoj = 0;
                int h = 0;
                while (coef2[h] == 0)
                    h++;
                mnoj = coef1[0] / coef2[h];
                double[] ans = new double[coef1.Length];
                ans[0] = mnoj;
                for (int i = 1; i < coef1.Length; i++)
                    ans[i] = coef1[i];
                for (int i = 1; i < (coef1.Length - coef2.Length + 2); i++)
                {
                    for (int j =1;j< coef2.Length; j++)
                    {
                        ans[i + j - 1] = ans[i + j - 1] + coef2[j] * mnoj;
                    }
                    mnoj = ans[i] / coef2[h];
                }
                double[] ans2 = new double[coef2.Length - 1];
                double[] ans1 = new double[ans.Length - ans2.Length];
                for (int i = 0; i < ans1.Length; i++)
                    ans1[i] = ans[i];
                for (int i = 0; i < ans2.Length; i++)
                    ans2[i] = ans[ans1.Length + i];
                return ans2;
            }
        }
        public static double[] Newton(double[,] f1, int h1, int l1, double[,] f2, int h2, int l2)
        {
            double[] answer = new double[2];
            double x_curr = f((proizvodx(f1, h1, l1)), l1, h1, 0, 0);
            double y_curr = f((proizvody(f2, h1, l1)), l1, h1, 0, 0);
            for (double a = x_curr; (f(f1, l1, h1, a, y_curr) > 0.1) && (f(f2, l1, h1, a, y_curr) > 0.1); a -= 0.1)
                for (double b = y_curr; (f(f1, l1, h1, a, b) > 0.1) && (f(f2, l1, h1, a, b) > 0.1); b -= 0.1)
                {
                }
            do
            {
                double fxpro = f((proizvodx(f1, h1, l1)), l1, h1, x_curr, y_curr);
                double fypro = f((proizvody(f1, h1, l1)), l1, h1, x_curr, y_curr);
                double gxpro = f((proizvodx(f2, h2, l2)), l2, h2, x_curr, y_curr);
                double gypro = f((proizvody(f2, h2, l2)), l2, h2, x_curr, y_curr);
                double j = fxpro * gypro - fypro * gxpro;
                x_curr = x_curr - (1 / j) * (f(f1, l1, h1, x_curr, y_curr) * gypro - fypro * f(f2, l2, h2, x_curr, y_curr));
                y_curr = y_curr - (1 / j) * (-f(f1, l1, h1, x_curr, y_curr) * gxpro + fxpro * f(f2, l2, h2, x_curr, y_curr));
            } while ((f(f1, l1, h1, x_curr, y_curr) >= 0.000000001) && (f(f2, l2, h2, x_curr, y_curr) >= 0.000000001));
            answer[0] = x_curr;
            answer[1] = y_curr;
            return answer;
        }
        public static double f(double[] x, double i)
        {
            double result;
            if (x.Length == 0)
                return 0;
            else if (x.Length == 1)
                return x[0];
            else
            {
                result = x[0] * i + x[1];
                for (int s = 2; s < x.Length; s++)
                {
                    result = result * i + x[s];
                }
                return result;
            }
        }

        public static double f(double[,] coef, int lenght, int high, double x, double y)
        {
            double result = 0;
            for (int h = 0; h < high; h++)
            {
                double resultx = coef[0, h] * x + coef[1, h];
                for (int l = 2; l < lenght; l++)
                {
                    resultx = resultx * x + coef[l, h];
                }
                if (h == 0)
                    result += resultx * y;
                else if (h == high - 1)
                    result += resultx;
                else
                    result = (result + resultx) * y;
            }
            return result;
        }
        public static double[] proizvod(double[] x)
        {
            double[] coefNew = new double[x.Length - 1];
            for (int i = 0; i < x.Length-1;i++)
            {
                coefNew[i] = x[i] * (x.Length - 1 - i);
            }
            return coefNew;
        }
        public static double[,] proizvodx(double[,] coef, int high, int lenght)
        {
            double[,] answer = new double[lenght + 1, high];
            for (int h = 0; h < high; h++)
                for (int l = lenght - 1; l >= 0; l--)
                {
                    answer[lenght - l, h] = coef[lenght - l - 1, h] * l;
                }
            return answer;
        }
        public static double[,] proizvody(double[,] coef, int high, int lenght)
        {
            double[,] answer = new double[lenght, high + 1];
            for (int l = 0; l < lenght; l++)
                for (int h = high - 1; h >= 0; h--)
                {
                    answer[l, high - h] = coef[l, high - h - 1] * h;
                }
            return answer;
        }
        public static string ProbOut(double[] coef)
        {
            string Old = "";
            int j = 0;
            int prof = 0;
            for (int i = 0; i < coef.Length; i++)
            {
                if ((coef[i] == 0) && (prof == 0))
                {
                    j++;
                }
                else
                    prof++;
            }
            if (j == coef.Length)
                return "0";
            else if (j == coef.Length - 1)
                {
                    Old += coef[j];
                    return Old;
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
                            if (j == coef.Length - 2)
                            {
                                if (coef[j] == 1)
                                {
                                    if (sign == "+")
                                        Old += "x";
                                    else
                                        Old += sign +"x";
                                }
                                else if (sign == "+")
                                    Old += coef[i] + "x";
                                else
                                    Old += sign + coef[i] + "x";
                            }
                            else if (sign == "+")
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
            return Old;
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
