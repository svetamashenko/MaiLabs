using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koma4
{
    public class Matrix
    {
        private int nRows;
        private int nCols;
        private double[,] matrix;

        //только для квадратных
        //а больше в лабе и не надо
        public Matrix(string str)
        {
            string[] strArr = str.Split('\n');
            double[][] preMatrix = new double[strArr.Length][];
            nRows = strArr.Length;
            for (int i = 0; i < nRows; i++)
            {
                preMatrix[i] = strArr[i].Split(' ').Select(double.Parse).ToArray();
            }
            nCols = preMatrix[0].Length;
            matrix = new double[nRows, nCols];
            for (int i = 0; i < nRows; i++)
                for (int j = 0; j < nCols; j++)
                    matrix[i, j] = preMatrix[i][j];

        }

        public Matrix(int nRows, int nCols)
        {
            this.nRows = nRows;
            this.nCols = nCols;
            this.matrix = new double[nRows, nCols];
            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nCols; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        public Matrix(double[,] matrix)
        {
            this.nRows = matrix.GetLength(0);
            this.nCols = matrix.GetLength(1);
            this.matrix = matrix;
        }

        public Matrix(Matrix m)
        {
            nRows = m.GetnRows;
            nCols = m.GetnCols;
            matrix = m.matrix;
        }

        public double this[int m, int n]
        {
            get
            {
                if (m < 0 || m > nRows)
                {
                    throw new Exception("m-th row is out of range!");
                }
                if (n < 0 || n > nCols)
                {
                    throw new Exception("n-th col is out of range!");
                }
                return matrix[m, n];
            }
            set { matrix[m, n] = value; }
        }

        public int GetnRows
        {
            get { return nRows; }
        }

        public int GetnCols
        {
            get { return nCols; }
        }

        public override string ToString()
        {
            string strMatrix = "";
            int i, j;
            for (i = 0; i < nRows - 1; i++)
            {
                for (j = 0; j < nCols - 1; j++)
                    strMatrix += Math.Round(matrix[i, j], 3).ToString() + " ";
                strMatrix += Math.Round(matrix[i, j], 3).ToString() + "\n";
            }
            for (j = 0; j < nCols - 1; j++)
                strMatrix += Math.Round(matrix[i, j], 3).ToString() + " ";
            strMatrix += Math.Round(matrix[i, j], 3).ToString();
            return strMatrix;
        }

        public override bool Equals(object obj)
        {
            return (obj is Matrix) && this.Equals((Matrix)obj);
        }

        public bool Equals(Matrix m)
        {
            if (!CompareDimension(this, m))
                return false;
            for (int i = 0; i < m.GetnRows; i++)
                for (int j = 0; j < m.GetnCols; j++)
                    if (this[i, j] != m[i, j])
                        return false;
            return true;
        }

        public override int GetHashCode()
        {
            return matrix.GetHashCode();
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (!Matrix.CompareDimension(m1, m2))
            {
                throw new Exception("The dimensions of two matrices must be the same!");
            }
            Matrix result = new Matrix(m1.GetnRows, m1.GetnCols);
            for (int i = 0; i < m1.GetnRows; i++)
            {
                for (int j = 0; j < m1.GetnCols; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix m)
        {
            for (int i = 0; i < m.GetnRows; i++)
            {
                for (int j = 0; j < m.GetnCols; j++)
                {
                    m[i, j] = -m[i, j];
                }
            }
            return m;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (!Matrix.CompareDimension(m1, m2))
            {
                throw new Exception("The dimensions of two matrices must be the same!");
            }
            Matrix result = new Matrix(m1.GetnRows, m1.GetnCols);
            for (int i = 0; i < m1.GetnRows; i++)
            {
                for (int j = 0; j < m1.GetnCols; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix m, double d)
        {
            Matrix result = new Matrix(m.GetnRows, m.GetnCols);
            for (int i = 0; i < m.GetnRows; i++)
            {
                for (int j = 0; j < m.GetnCols; j++)
                {
                    result[i, j] = m[i, j] * d;
                }
            }
            return result;
        }

        public static Matrix operator *(double d, Matrix m)
        {
            Matrix result = new Matrix(m.GetnRows, m.GetnCols);
            for (int i = 0; i < m.GetnRows; i++)
            {
                for (int j = 0; j < m.GetnCols; j++)
                {
                    result[i, j] = m[i, j] * d;
                }
            }
            return result;
        }

        public static Matrix operator /(Matrix m, double d)
        {
            Matrix result = new Matrix(m.GetnRows, m.GetnCols);
            for (int i = 0; i < m.GetnRows; i++)
            {
                for (int j = 0; j < m.GetnCols; j++)
                {
                    result[i, j] = m[i, j] / d;
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.GetnCols != m2.GetnRows)
            {
                throw new Exception("The numbers of columns of the" +
                 " first matrix must be equal to the number of " +
                 " rows of the second matrix!");
            }
            Matrix result = new Matrix(m1.GetnRows, m2.GetnCols);
            for (int i = 0; i < m1.GetnRows; i++)
            {
                for (int j = 0; j < m2.GetnCols; j++)
                {
                    for (int k = 0; k < m1.GetnCols; k++)
                    {
                        result[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }
            return result;
        }

        public bool IsSquared()
        {
            if (nRows == nCols)
                return true;
            else
                return false;
        }

        public static bool CompareDimension(Matrix m1, Matrix m2)
        {
            if (m1.GetnRows == m2.GetnRows && m1.GetnCols == m2.GetnCols)
                return true;
            else
                return false;
        }

        public static double Determinant(Matrix mat)
        {
            double result = 0.0;
            if (!mat.IsSquared())
            {
                throw new Exception("The matrix must be squared!");
            }
            if (mat.GetnRows == 1)
                result = mat[0, 0];
            else
            {
                for (int i = 0; i < mat.GetnRows; i++)
                {
                    result += Math.Pow(-1, i) * mat[0, i] * Determinant(Matrix.Minor(mat, 0, i));
                }
            }
            return result;
        }

        public static Matrix Minor(Matrix mat, int row, int col)
        {
            Matrix mm = new Matrix(mat.GetnRows - 1, mat.GetnCols - 1);
            int ii = 0, jj = 0;
            for (int i = 0; i < mat.GetnRows; i++)
            {
                if (i == row)
                    continue;
                jj = 0;
                for (int j = 0; j < mat.GetnCols; j++)
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

        public Matrix Transponed()
        {
            Matrix res = new Matrix(nCols, nRows);
            for (int i = 0; i < this.nRows; i++)
                for (int j = 0; j < this.nCols; j++)
                    res[j, i] = this[i, j];
            return res;
        }

        public Matrix Reverse()
        {
            Matrix algAdd = new Matrix(nRows, nCols);
            for (int i = 0; i < nRows; i++)
                for (int j = 0; j < nCols; j++)
                    algAdd[i, j] = Math.Pow(-1, i + j) * Determinant(Matrix.Minor(this, i, j));
            Matrix algAddTr = algAdd.Transponed();
            return (algAddTr / Determinant(this));
        }

        public Matrix ToTriangleForm()
        {
            Matrix res = new Matrix(this);
            double coef;
            Matrix[] strs = new Matrix[this.nRows];
            for(int i=0; i<this.nRows;i++)
                strs[i] = new Matrix(1, this.nCols);
            for (int i = 0; i < this.nRows; i++)
                for (int j = 0; j < this.nCols; j++)
                    strs[i][0, j] = this[i, j];
            for (int i = 0; i < Math.Min(this.nRows, this.nCols); i++)
            {
                for(int k = i + 1; k < this.nRows; k++)
                {
                    coef = strs[k][0, i] / strs[i][0, i];
                    if (coef == 0) continue;
                    strs[k] -= strs[i] * coef;
                }
            }
            for (int i = 0; i < this.nRows; i++)
                for (int j = 0; j < this.nCols; j++)
                    res[i, j] = strs[i][0, j];

            return res;
        }
        public double DiagonalMultiplication()
        {
            double res = 1;
            for (int i = 0; i < this.GetnCols; i++)
                res *= this[i, i];
            return res;
        }
    }
}
