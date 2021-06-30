using System;

public class Matrix
{

    //квадратная матрица
    public class SqMatrix
    {
        private int size;
        private double[,] matrix;

        public SqMatrix(string str)
        {
            string[] strArr = str.Split('\n');
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
            int sz = matrix.size;
            PolyMatrix pm = new PolyMatrix(sz);
            for (int i = 0; i < sz; i++)
                for (int j = 0; j < sz; j++)
                {
                    if (i == j)
                        pm[i, j] = new Polynom(new double[] { -1, matrix[i, j] });
                    else
                        pm[i, j] = Polynom.UnarPolynom(matrix[i, j]);
                }
            return PolyMatrix.Determinant(pm);
        }

    }
}
