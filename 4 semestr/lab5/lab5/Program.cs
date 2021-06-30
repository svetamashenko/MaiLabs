using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Polynom
    {
        private const double _EPS = 0.0001;
        private double[] arrCoef = null;  //массив коэффициентов
        public int rank;   //максимальная степень
        public Polynom(int a)
        {
            rank = a;
            arrCoef = new double[a + 1];
            for (int i = 0; i <= a; i++)
            {
                arrCoef[i] = 0;
            }
        }
        public Polynom(double[] _arr)
        {
            int zeros = 0;

            for (int i = 0; i < _arr.Length; i++)        //определяем кол-во нулей в начале
            {
                if (_arr[i] != 0)
                    break;

                zeros++;
            }
            arrCoef = new double[_arr.Length - zeros];
            for (int i = 0; i < arrCoef.Length; i++)         //копируем нужную часть
            {
                arrCoef[i] = _arr[i + zeros];
            }
            rank = arrCoef.Length - 1;
        }
        public Polynom(List<double> _arr)
        {
            int zeros = 0;

            for (int i = 0; i < _arr.Count; i++)        //определяем кол-во нулей в начале
            {
                if (_arr[i] != 0)
                    break;

                zeros++;
            }
            arrCoef = new double[_arr.Count - zeros];
            for (int i = 0; i < arrCoef.Length; i++)         //копируем нужную часть
            {
                arrCoef[i] = _arr[i + zeros];
            }
            rank = arrCoef.Length - 1;
        }
        public static Polynom operator *(Polynom A, Polynom B)
        {
            Polynom C = new Polynom(A.rank + B.rank);
            for (int i = 0; i < C.rank; i++)
                C[i] = 0;
            for (int i = 0; i <= A.rank; i++)
            {
                for (int k = 0; k <= B.rank; k++)
                {
                    C[i + k] += A[i] * B[k];
                }
            }
            return C;
        }
        public static Polynom operator *(Polynom A, double c)
        {
            Polynom B = new Polynom(A.rank);
            for (int i = 0; i <= A.rank; i++)
                B[i] = A[i] * c;
            return B;
        }
        public static Polynom operator *(double c, Polynom A)
        {
            Polynom B = new Polynom(A.rank);
            for (int i = 0; i <= A.rank; i++)
                B[i] = A[i] * c;
            return B;
        }
        public static Polynom operator +(Polynom A, Polynom B)
        {
            int max = Math.Max(A.rank, B.rank) + 1;
            int min = Math.Min(A.rank, B.rank) + 1;
            Polynom poly = new Polynom(max - 1);
            if (A.rank == max - 1)
            {
                for (int i = 0; i < max; i++)
                    poly[max - 1 - i] = A[max - 1 - i];
                for (int i = 0; i < min; i++)
                    poly[max - 1 - i] += B[min - 1 - i];
            }
            else
            {
                for (int i = 0; i < max; i++)
                    poly[max - 1 - i] = B[max - 1 - i];
                for (int i = 0; i < min; i++)
                    poly[max - 1 - i] += A[min - 1 - i];
            }


            return poly;
        }
        public static Polynom operator -(Polynom A, Polynom B)
        {
            return A + (-B);
        }
        public static Polynom operator -(Polynom A)
        {
            Polynom poly = new Polynom(A.rank);
            for (int i = 0; i <= A.rank; i++)
            {
                poly[i] = -A[i];
            }
            return poly;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object a)
        {
            if (a is Polynom)
            {
                for (int i = 0; i < ((Polynom)a).rank; i++)
                {
                    if (((Polynom)a)[i] != ((Polynom)a)[i]) return false;
                }
                return true;
            }
            else return false;
        }
        public static bool operator ==(Polynom A, Polynom B)
        {
            for (int i = 0; i < A.rank; i++)
            {
                if (A[i] != A[i]) return false;
            }
            return true;
        }
        public static bool operator !=(Polynom A, Polynom B)
        {
            return !(A == B);
        }

        public double this[int a]
        {
            get { return arrCoef[a]; }
            set { arrCoef[a] = value; }
        }
        public static double[] proizvod(double[] x)
        {
            double[] coefNew = new double[x.Length - 1];
            for (int i = 0; i < x.Length - 1; i++)
            {
                coefNew[i] = x[i] * (x.Length - 1 - i);
            }
            return coefNew;
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
            if ((coef2.Length == 0) || (coef2.Length == 1))
                return nol;
            if (coef2[0] == 1)
            {
                double[] ans = new double[coef1.Length];
                ans[0] = coef1[0];
                for (int i = 1; i < coef1.Length; i++)
                    ans[i] = coef1[i];
                double[] help = new double[coef2.Length];
                for (int i = 0; i < (delim.Length - delit.Length + 2); i++)
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
                    for (int j = 1; j < coef2.Length; j++)
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

        public int RootNum()
        {
            double[] coef = new double[arrCoef.Length];
            for (int i = 0; i < coef.Length; i++)
                coef[i] = arrCoef[i];
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
                fmax[k] = f_x(i, max);
                fnul[k] = f_x(i, nul);
                fmin[k] = f_x(i, min);
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
            return minus - plus;
        }

        public List<double> findRoots()
        {
            List<double> roots = new List<double>();
            double[] coefs = this.GetCoef();
            int n = this.RootNum();
            while (n > 0)
            {
                double[] gr = grani(coefs);
                double a = ChordMethod(coefs, gr[0], gr[1]);
                roots.Add(Math.Round(a, 2));
                coefs = Gorner(coefs, roots[roots.Count - 1]);
                n--;
            }
            return roots;
        }

        //public static double startDihotomia(double[] coef, double min, double max)
        //{
        //    double f2 = f_x(coef, max);
        //    f2 = (Math.Abs(f2 - Math.Round(f2)) < _EPS) ? Math.Round(f2) : f2;
        //    if (f2 == 0)
        //    {
        //        return Math.Round(max);
        //    }
        //    double nmin = min - 1;
        //    double f1 = f_x(coef, nmin);
        //    while (f1* f2 >= 0)
        //    {
        //        if (f1 == 0)
        //        {
        //            return nmin;
        //        }
        //        if (Math.Abs(Math.Round(f1) - f1) < _EPS && Math.Round(f1) == 0) 
        //        {
        //            return Math.Round(nmin);
        //        }
        //        nmin += 10*_EPS;
        //        f1 = f_x(coef, nmin);
        //    }

        //    return dih(coef, nmin, max);
        //}

        //private static double dih(double[] coef, double min, double max)
        //{
        //    double mid = (min + max) * 0.5;
        //    if (max - min < _EPS || f_x(coef, mid) == 0)
        //        return mid;

        //    if (f_x(coef, min) * f_x(coef, mid) < 0)
        //        return dih(coef, min, mid);
        //    return dih(coef, mid, max);
        //}

        public double[] GetCoef()
        {
            return arrCoef;
        }

        //public static List<double> AllRoots(double[] arr, double min, double max)
        //{
        //    double sup = max;
        //    double inf = sup - 0.5;
        //    List<double> roots = new List<double>();
        //    while (sup >= min)
        //    {
        //        if (f_x(arr, inf) * f_x(arr, sup) <= 0)
        //        {
        //            roots.Add(Math.Round(ChordMethod(arr, inf, sup), 2));
        //        }

        //        sup = inf - 0.5;
        //        inf = sup - 0.5;
        //    }
        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = arr[i] * (-1);
        //    }



        //    return roots;
        //}

        public static double ChordMethod(double[] f, double a, double b)
        {
            double x = b;
            double xprev = a;
            while (Math.Abs(x - xprev) > _EPS)
            {
                xprev = x;
                x = a - f_x(f, a) * (b - a) / (f_x(f, b) - f_x(f, a));
                if (f_x(f, a) * f_x(f, x) < 0)
                {
                    b = x;
                    continue;
                }
                a = x;
            }
            return x;
        }

        private static double f_x(double[] coef, double x)
        {
            double f = 0;
            for (int i = 0; i < coef.Length; i++)
            {
                f += coef[i] * Math.Pow(x, coef.Length - 1 - i);
            }
            return f;
        }

        public static double[] grani(double[] _arr)
        {
            _arr = delStartZero(_arr);      //удаляем нули в начале

            if (_arr[0] < 0)
            {
                for (int i = 0; i < _arr.Length; i++)
                    _arr[i] *= -1;
            }

            int len = _arr.Length;

            int max = 1;
            while (!isPositive(Gorner(_arr, max)))
                max++;

            int min = 1;
            while (!isPositive(Gorner(negativeXPoly(_arr), min)))
                min++;
            min *= -1;

            double[] arr = { min, max };
            return arr;
        }

        private static bool isPositive(double[] _arr)
        {
            bool pos = true;
            foreach (double a in _arr)
            {
                if (a < 0) pos = false;
            }
            return pos;
        }

        public static double[] Gorner(double[] _arr, double x)
        {
            double[] arr = new double[_arr.Length - 1];

            arr[0] = _arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] * x + _arr[i];
            }

            return arr;
        }

        private static double[] delStartZero(double[] _arr)
        {
            int zeros = 0;

            for (int i = 0; i < _arr.Length; i++)        //определяем кол-во нулей в начале
            {
                if (_arr[i] != 0)
                    break;

                zeros++;
            }

            double[] arr = new double[_arr.Length - zeros];
            for (int i = 0; i < arr.Length; i++)         //копируем нужную часть
            {
                arr[i] = _arr[i + zeros];
            }

            return arr;
        }

        //возвращает массив коэффициентов, каждый второй коэф со старшего умножается на -1
        //для нахождения нижней границы
        private static double[] negativeXPoly(double[] _arr)
        {
            double[] arr = new double[_arr.Length];

            for (int i = 0; i < _arr.Length; i++)
            {
                arr[i] = _arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    arr[i] *= -1;
                }
            }
            return arr;
        }

        public static string PrintCoefs(double[] coefs)
        {
            string str = "";
            foreach (var a in coefs)
                str += a.ToString() + " ";
            return str;
        }

        public string deParcer()
        {
            int lenth = arrCoef.Length;
            string res = "";
            for (int i = 0; i < lenth; i++)
            {
                if (arrCoef[i] == 0)
                    continue;

                if (i != 0 && arrCoef[i] > 0)
                    res += "+";
                if (arrCoef[i] < 0)
                    res += "-";


                switch (lenth - i)
                {
                    //Для 0-вой степени
                    case 1:
                        res += Math.Abs(arrCoef[i]);
                        break;


                    //Для 1-вой степени
                    case 2:
                        res += Math.Abs(arrCoef[i]) + "*x";
                        break;

                    //Для остальных степеней
                    default:
                        if (Math.Abs(arrCoef[i]) != 1)
                        {
                            res += Math.Abs(arrCoef[i]) + "*";
                        }
                        res += "x^" + (lenth - i - 1);
                        break;
                }
            }
            return res;
        }

        public static Polynom UnarPolynom(double a)
        {
            Polynom p = new Polynom(new double[] { a });
            //p.arrCoef[0] = a;
            return p;
        }
    }
    class PolyMatrix
    {
        private int size;
        private Polynom[,] matrix;

        public PolyMatrix(int size)
        {
            this.size = size;
            this.matrix = new Polynom[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = new Polynom(new double[] { 0 });
                }
            }
        }

        public PolyMatrix(PolyMatrix m)
        {
            size = m.Getsize;
            matrix = m.matrix;
        }

        public Polynom this[int m, int n]
        {
            get
            {
                if (m < 0 || m > size)
                {
                    throw new Exception("m-th row is out of range!");
                }
                if (n < 0 || n > size)
                {
                    throw new Exception("n-th col is out of range!");
                }
                return matrix[m, n];
            }
            set { matrix[m, n] = value; }
        }

        public int Getsize
        {
            get { return size; }
        }

        public override string ToString()
        {
            string strPolyMatrix = "";
            int i, j;
            for (i = 0; i < size - 1; i++)
            {
                for (j = 0; j < size - 1; j++)
                    strPolyMatrix += matrix[i, j].deParcer() + "\t";
                strPolyMatrix += matrix[i, j].deParcer() + "\n";
            }
            for (j = 0; j < size - 1; j++)
                strPolyMatrix += matrix[i, j].deParcer() + "\t";
            strPolyMatrix += matrix[i, j].deParcer();
            return strPolyMatrix;
        }

        public override bool Equals(object obj)
        {
            return (obj is PolyMatrix) && this.Equals((PolyMatrix)obj);
        }

        public bool Equals(PolyMatrix m)
        {
            if (!CompareDimension(this, m))
                return false;
            for (int i = 0; i < m.Getsize; i++)
                for (int j = 0; j < m.Getsize; j++)
                    if (this[i, j] != m[i, j])
                        return false;
            return true;
        }

        public override int GetHashCode()
        {
            return matrix.GetHashCode();
        }

        public static PolyMatrix operator +(PolyMatrix m1, PolyMatrix m2)
        {
            if (!PolyMatrix.CompareDimension(m1, m2))
            {
                throw new Exception("The dimensions of two matrices must be the same!");
            }
            PolyMatrix result = new PolyMatrix(m1.Getsize);
            for (int i = 0; i < m1.Getsize; i++)
            {
                for (int j = 0; j < m1.Getsize; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return result;
        }

        public static PolyMatrix operator -(PolyMatrix m)
        {
            for (int i = 0; i < m.Getsize; i++)
            {
                for (int j = 0; j < m.Getsize; j++)
                {
                    m[i, j] = -m[i, j];
                }
            }
            return m;
        }

        public static PolyMatrix operator -(PolyMatrix m1, PolyMatrix m2)
        {
            if (!PolyMatrix.CompareDimension(m1, m2))
            {
                throw new Exception("The dimensions of two matrices must be the same!");
            }
            PolyMatrix result = new PolyMatrix(m1.Getsize);
            for (int i = 0; i < m1.Getsize; i++)
            {
                for (int j = 0; j < m1.Getsize; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return result;
        }

        public static PolyMatrix operator *(PolyMatrix m, double d)
        {
            PolyMatrix result = new PolyMatrix(m.Getsize);
            for (int i = 0; i < m.Getsize; i++)
            {
                for (int j = 0; j < m.Getsize; j++)
                {
                    result[i, j] = m[i, j] * d;
                }
            }
            return result;
        }

        public static PolyMatrix operator *(double d, PolyMatrix m)
        {
            PolyMatrix result = new PolyMatrix(m.Getsize);
            for (int i = 0; i < m.Getsize; i++)
            {
                for (int j = 0; j < m.Getsize; j++)
                {
                    result[i, j] = m[i, j] * d;
                }
            }
            return result;
        }

        public static PolyMatrix operator /(PolyMatrix m, double d)
        {
            PolyMatrix result = new PolyMatrix(m.Getsize);
            for (int i = 0; i < m.Getsize; i++)
            {
                for (int j = 0; j < m.Getsize; j++)
                {
                    result[i, j] = m[i, j] * (1 / d);
                }
            }
            return result;
        }

        public static PolyMatrix operator *(PolyMatrix m1, PolyMatrix m2)
        {
            if (m1.Getsize != m2.Getsize)
            {
                throw new Exception("The numbers of columns of the" +
                 " first matrix must be equal to the number of " +
                 " rows of the second matrix!");
            }
            Polynom tmp;
            PolyMatrix result = new PolyMatrix(m2.Getsize);
            for (int i = 0; i < m1.Getsize; i++)
            {
                for (int j = 0; j < m2.Getsize; j++)
                {
                    tmp = result[i, j];
                    for (int k = 0; k < result.Getsize; k++)
                    {
                        tmp += m1[i, k] * m2[k, j];
                    }
                    result[i, j] = tmp;
                }
            }
            return result;
        }

        public static bool CompareDimension(PolyMatrix m1, PolyMatrix m2)
        {
            if (m1.Getsize == m2.Getsize)
                return true;
            else
                return false;
        }

        public static Polynom Determinant(PolyMatrix mat)
        {
            Polynom result = Polynom.UnarPolynom(0);
            if (mat.Getsize == 1)
                result = mat[0, 0];
            else
            {
                for (int i = 0; i < mat.Getsize; i++)
                {
                    result += Math.Pow(-1, i) * mat[0, i] * Determinant(PolyMatrix.Minor(mat, 0, i));
                }
            }
            return result;
        }

        public static PolyMatrix Minor(PolyMatrix mat, int row, int col)
        {
            PolyMatrix mm = new PolyMatrix(mat.Getsize - 1);
            int ii = 0, jj;
            for (int i = 0; i < mat.Getsize; i++)
            {
                if (i == row)
                    continue;
                jj = 0;
                for (int j = 0; j < mat.Getsize; j++)
                {
                    if (j == col)
                        continue;
                    mm[ii, jj] = mat[i, j];
                    jj++;
                }
                ii++;
            }
            return mm;
        }

    }
    public class SqMatrix
    {
        private int size;
        private double[,] matrix;

        public SqMatrix(string str)
        {
            string[] strArr = str.Split(';');
            double[][] preSqMatrix = new double[strArr.Length][];
            size = strArr.Length;
            for (int i = 0; i < size; i++)
            {
                preSqMatrix[i] = strArr[i].Split(' ').Select(double.Parse).ToArray();
            }
            size = preSqMatrix[0].Length;
            matrix = new double[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = preSqMatrix[i][j];

        }

        public SqMatrix(int size)
        {
            this.size = size;
            this.matrix = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = 0.0;
                }
            }
        }

        public SqMatrix(double[,] matrix)
        {
            this.size = matrix.GetLength(0);
            this.size = matrix.GetLength(1);
            this.matrix = matrix;
        }

        public SqMatrix(SqMatrix m)
        {
            size = m.Getsize;
            matrix = m.matrix;
        }

        public double this[int m, int n]
        {
            get
            {
                if (m < 0 || m > size)
                {
                    throw new Exception("m-th row is out of range!");
                }
                if (n < 0 || n > size)
                {
                    throw new Exception("n-th col is out of range!");
                }
                return matrix[m, n];
            }
            set { matrix[m, n] = value; }
        }

        public int Getsize
        {
            get { return size; }
        }

        public override string ToString()
        {
            string strSqMatrix = "";
            int i, j;
            for (i = 0; i < size - 1; i++)
            {
                for (j = 0; j < size - 1; j++)
                    strSqMatrix += matrix[i, j].ToString() + " ";
                strSqMatrix += matrix[i, j].ToString() + "\n";
            }
            for (j = 0; j < size - 1; j++)
                strSqMatrix += matrix[i, j].ToString() + " ";
            strSqMatrix += matrix[i, j].ToString();
            return strSqMatrix;
        }

        public override bool Equals(object obj)
        {
            return (obj is SqMatrix) && this.Equals((SqMatrix)obj);
        }

        public bool Equals(SqMatrix m)
        {
            if (!CompareDimension(this, m))
                return false;
            for (int i = 0; i < m.Getsize; i++)
                for (int j = 0; j < m.Getsize; j++)
                    if (this[i, j] != m[i, j])
                        return false;
            return true;
        }

        public override int GetHashCode()
        {
            return matrix.GetHashCode();
        }

        public static SqMatrix operator +(SqMatrix m1, SqMatrix m2)
        {
            if (!SqMatrix.CompareDimension(m1, m2))
            {
                throw new Exception("The dimensions of two matrices must be the same!");
            }
            SqMatrix result = new SqMatrix(m1.Getsize);
            for (int i = 0; i < m1.Getsize; i++)
            {
                for (int j = 0; j < m1.Getsize; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return result;
        }

        public static SqMatrix operator -(SqMatrix m)
        {
            for (int i = 0; i < m.Getsize; i++)
            {
                for (int j = 0; j < m.Getsize; j++)
                {
                    m[i, j] = -m[i, j];
                }
            }
            return m;
        }

        public static SqMatrix operator -(SqMatrix m1, SqMatrix m2)
        {
            if (!SqMatrix.CompareDimension(m1, m2))
            {
                throw new Exception("The dimensions of two matrices must be the same!");
            }
            SqMatrix result = new SqMatrix(m1.Getsize);
            for (int i = 0; i < m1.Getsize; i++)
            {
                for (int j = 0; j < m1.Getsize; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return result;
        }

        public static SqMatrix operator *(SqMatrix m, double d)
        {
            SqMatrix result = new SqMatrix(m.Getsize);
            for (int i = 0; i < m.Getsize; i++)
            {
                for (int j = 0; j < m.Getsize; j++)
                {
                    result[i, j] = m[i, j] * d;
                }
            }
            return result;
        }

        public static SqMatrix operator *(double d, SqMatrix m)
        {
            SqMatrix result = new SqMatrix(m.Getsize);
            for (int i = 0; i < m.Getsize; i++)
            {
                for (int j = 0; j < m.Getsize; j++)
                {
                    result[i, j] = m[i, j] * d;
                }
            }
            return result;
        }

        public static SqMatrix operator /(SqMatrix m, double d)
        {
            SqMatrix result = new SqMatrix(m.Getsize);
            for (int i = 0; i < m.Getsize; i++)
            {
                for (int j = 0; j < m.Getsize; j++)
                {
                    result[i, j] = m[i, j] / d;
                }
            }
            return result;
        }

        public static SqMatrix operator *(SqMatrix m1, SqMatrix m2)
        {
            if (m1.Getsize != m2.Getsize)
            {
                throw new Exception("The numbers of columns of the" +
                 " first matrix must be equal to the number of " +
                 " rows of the second matrix!");
            }
            double tmp;
            SqMatrix result = new SqMatrix(m2.Getsize);
            for (int i = 0; i < m1.Getsize; i++)
            {
                for (int j = 0; j < m2.Getsize; j++)
                {
                    tmp = result[i, j];
                    for (int k = 0; k < result.Getsize; k++)
                    {
                        tmp += m1[i, k] * m2[k, j];
                    }
                    result[i, j] = tmp;
                }
            }
            return result;
        }

        public static bool CompareDimension(SqMatrix m1, SqMatrix m2)
        {
            if (m1.Getsize == m2.Getsize)
                return true;
            else
                return false;
        }

        public static double Determinant(SqMatrix mat)
        {
            double result = 0.0;
            if (mat.Getsize == 1)
                result = mat[0, 0];
            else
            {
                for (int i = 0; i < mat.Getsize; i++)
                {
                    result += Math.Pow(-1, i) * mat[0, i] * Determinant(SqMatrix.Minor(mat, 0, i));
                }
            }
            return result;
        }

        public static SqMatrix Minor(SqMatrix mat, int row, int col)
        {
            SqMatrix mm = new SqMatrix(mat.Getsize - 1);
            int ii = 0, jj = 0;
            for (int i = 0; i < mat.Getsize; i++)
            {
                if (i == row)
                    continue;
                jj = 0;
                for (int j = 0; j < mat.Getsize; j++)
                {
                    if (j == col)
                        continue;
                    mm[ii, jj] = mat[i, j];
                    jj++;
                }
                ii++;
            }
            return mm;
        }

        public static Polynom CharacterPolynom(SqMatrix matrix)
        {
            //int sz = matrix.size;
            //PolyMatrix pm = new PolyMatrix(sz);
            //for (int i = 0; i < sz; i++)
            //    for (int j = 0; j < sz; j++) {
            //        if (i == j)
            //            pm[i, j] = new Polynom(new double[] { -1, matrix[i, j] });
            //        else
            //            pm[i, j] = Polynom.UnarPolynom(matrix[i, j]);
            //    }
            //return PolyMatrix.Determinant(pm);

            List<double> S = new List<double>();

            for (int i = 0; i < matrix.size; i++)
                S.Add(matrix.Pow(i + 1).Track);

            List<double> p = new List<double>();

            p.Add(-S[0]);

            for (int k = 1; k < matrix.size; k++)
            {
                double tempSum = S[k];
                for (int i = 0; i < k; i++)
                    tempSum += p[i] * S[k - 1 - i];
                tempSum = -tempSum / (1 + k);
                p.Add(tempSum);
            }

            p.Reverse();
            p.Add(1);
            p.Reverse();

            return new Polynom(p);

        }
        public SqMatrix Pow(int a)
        {
            SqMatrix res = new SqMatrix(this.matrix);
            for (int i = 0; i < a - 1; i++)
                res *= this;
            return res;
        }
        public double Track
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < size; i++)
                    sum += matrix[i, i];
                return sum;
            }
        }

    }
}
