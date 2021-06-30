using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koma4
{
    public class MatrixOfMatrix
    {
        private bool right;
        private int nCols;
        private int nRows;
        private Matrix[,] matrix;
        public MatrixOfMatrix(Matrix m1, bool right)
        {
            this.right = right;
            nCols = (m1.GetnCols < 3) ? 1 : 2;
            nRows = (m1.GetnRows < 3) ? 1 : 2;
            matrix = new Matrix[nRows, nCols];

            if (right)
            {
                if (nRows == 1 && nCols == 1)
                {
                    matrix[0, 0] = new Matrix(m1.GetnRows, m1.GetnCols);
                    for (int i = 0; i < m1.GetnRows; i++)
                        for (int j = 0; j < m1.GetnCols; j++)
                            matrix[0, 0][i, j] = m1[i, j];
                }
                else if (nRows == 1)
                {
                    matrix[0, 0] = new Matrix(m1.GetnRows, 2);
                    matrix[0, 1] = new Matrix(m1.GetnRows, m1.GetnCols - 2);
                    for (int i = 0; i < m1.GetnRows; i++)
                        for (int j = 0; j < 2; j++)
                            matrix[0, 0][i, j] = m1[i, j];
                    for (int i = 0; i < m1.GetnRows; i++)
                        for (int j = 2; j < m1.GetnCols; j++)
                            matrix[0, 1][i, j - 2] = m1[i, j];
                }
                else if (nCols == 1)
                {
                    matrix[0, 0] = new Matrix(2, m1.GetnCols);
                    matrix[1, 0] = new Matrix(m1.GetnRows - 2, m1.GetnCols);
                    for (int i = 0; i < 2; i++)
                        for (int j = 0; j < m1.GetnCols; j++)
                            matrix[0, 0][i, j] = m1[i, j];
                    for (int i = 2; i < m1.GetnRows; i++)
                        for (int j = 0; j < m1.GetnCols; j++)
                            matrix[1, 0][i - 2, j] = m1[i, j];
                }
                else
                {
                    matrix[0, 0] = new Matrix(2, 2);
                    matrix[0, 1] = new Matrix(2, m1.GetnCols - 2);
                    matrix[1, 0] = new Matrix(m1.GetnRows - 2, 2);
                    matrix[1, 1] = new Matrix(m1.GetnRows - 2, m1.GetnCols - 2);
                    for (int i = 0; i < 2; i++)
                        for (int j = 0; j < 2; j++)
                            matrix[0, 0][i, j] = m1[i, j];
                    for (int i = 0; i < 2; i++)
                        for (int j = 2; j < m1.GetnCols; j++)
                            matrix[0, 1][i, j - 2] = m1[i, j];
                    for (int i = 2; i < m1.GetnRows; i++)
                        for (int j = 0; j < 2; j++)
                            matrix[1, 0][i - 2, j] = m1[i, j];
                    for (int i = 2; i < m1.GetnRows; i++)
                        for (int j = 2; j < m1.GetnCols; j++)
                            matrix[1, 1][i - 2, j - 2] = m1[i, j];
                }
            }
            else
            {
                if (nRows == 1 && nCols == 1)
                {
                    matrix[0, 0] = new Matrix(m1.GetnRows, m1.GetnCols);
                    for (int i = 0; i < m1.GetnRows; i++)
                        for (int j = 0; j < m1.GetnCols; j++)
                            matrix[0, 0][i, j] = m1[i, j];
                }
                else if (nRows == 1)
                {
                    matrix[0, 0] = new Matrix(m1.GetnRows, 2);
                    matrix[0, 1] = new Matrix(m1.GetnRows, m1.GetnCols - 2);
                    for (int i = 0; i < m1.GetnRows; i++)
                        for (int j = 0; j < 2; j++)
                            matrix[0, 0][i, j] = m1[i, j];
                    for (int i = 0; i < m1.GetnRows; i++)
                        for (int j = 2; j < m1.GetnCols; j++)
                            matrix[0, 1][i, j - 2] = m1[i, j];
                }
                else if (nCols == 1)
                {
                    matrix[0, 0] = new Matrix(m1.GetnRows - 2, 2);
                    matrix[1, 0] = new Matrix(2, 2);
                    for (int i = 0; i < m1.GetnRows - 2; i++)
                        for (int j = 0; j < 2; j++)
                            matrix[0, 0][i, j] = m1[i, j];
                    for (int i = 0; i < 2; i++)
                        for (int j = 0; j < 2; j++)
                            matrix[1, 0][i, j] = m1[i + m1.GetnRows - 2, j];
                }
                else
                {
                    matrix[0, 0] = new Matrix(m1.GetnRows - 2, 2);
                    matrix[0, 1] = new Matrix(m1.GetnRows - 2, m1.GetnCols - 2);
                    matrix[1, 0] = new Matrix(2, 2);
                    matrix[1, 1] = new Matrix(2, m1.GetnCols - 2);
                    for (int i = 0; i < m1.GetnRows - 2; i++)
                        for (int j = 0; j < 2; j++)
                            matrix[0, 0][i, j] = m1[i, j];
                    for (int i = 0; i < m1.GetnRows - 2; i++)
                        for (int j = 2; j < m1.GetnCols; j++)
                            matrix[0, 1][i, j - 2] = m1[i, j];
                    for (int i = 0; i < 2; i++)
                        for (int j = 0; j < 2; j++)
                            matrix[1, 0][i, j] = m1[i + m1.GetnRows - 2, j];
                    for (int i = 0; i < 2; i++)
                        for (int j = 2; j < m1.GetnCols; j++)
                            matrix[1, 1][i, j - 2] = m1[i+m1.GetnRows-2, j];
                }

            }
        }
        public MatrixOfMatrix(int rows, int cols, bool r)
        {
            right = r;
            nRows = rows;
            nCols = cols;
            matrix = new Matrix[rows, cols];
        }
        public static MatrixOfMatrix operator +(MatrixOfMatrix m1, MatrixOfMatrix m2)
        {
            if (m1.GetNCols != m2.GetNCols || m1.GetNRows != m2.GetNRows)
            {
                throw new Exception("Size of matrixes are different");
            }
            MatrixOfMatrix m3 = new MatrixOfMatrix(m1.GetNCols, m1.GetNRows, true);
            for (int i = 0; i < m1.GetNRows; i++)
                for (int j = 0; j < m1.GetNCols; j++)
                    m3[i, j] = m1[i, j] + m2[i, j];
            return m3;
        }
        public static MatrixOfMatrix operator -(MatrixOfMatrix m1, MatrixOfMatrix m2)
        {
            if (m1.GetNCols != m2.GetNCols || m1.GetNRows != m2.GetNRows)
            {
                throw new Exception("Size of matrixes are different");
            }
            MatrixOfMatrix m3 = new MatrixOfMatrix(m1.GetNCols, m1.GetNRows, true);
            for (int i = 0; i < m1.GetNRows; i++)
                for (int j = 0; j < m1.GetNCols; j++)
                    m3[i, j] = m1[i, j] - m2[i, j];
            return m3;
        }
        public static MatrixOfMatrix operator -(MatrixOfMatrix m)
        {
            MatrixOfMatrix res = new MatrixOfMatrix(m.nRows, m.nCols, m.right);
            for (int i = 0; i < m.nRows; i++)
                for (int j = 0; j < m.nCols; j++)
                    res[i, j] = -m[i, j];
            return res;
        }
        public static MatrixOfMatrix operator * (MatrixOfMatrix m1, MatrixOfMatrix m2)
        {
            if (m1.GetNCols != m2.GetNRows || ((m1.right == m2.right)&&(m1.GetNRows>1||m1.GetNCols>1)))
            {
                throw new Exception("The numbers of columns of the" +
                 " first matrix must be equal to the number of " +
                 " rows of the second matrix!");
            }

            MatrixOfMatrix mom = new MatrixOfMatrix(m1.nRows, m2.nCols, false);
            if (m1.GetNCols == m2.GetNCols && m1.GetNRows == m2.GetNRows && m1.GetNCols == 1 && m1.GetNRows == 1)
            {
                return new MatrixOfMatrix(new Matrix(m1[0, 0] * m2[0, 0]), m1.right);
            }
            else if (m1.GetNCols == 1)
            {
                mom[0, 0] = (new MatrixOfMatrix( m1[0, 0], false) * new MatrixOfMatrix( m2[0, 0], true)).ToMatrix();
                mom[0, 1] = (new MatrixOfMatrix(m1[0, 0], false) * new MatrixOfMatrix(m2[0, 1], true)).ToMatrix();
                mom[1, 0] = (new MatrixOfMatrix(m1[1, 0], false) * new MatrixOfMatrix(m2[0, 0], true)).ToMatrix();
                mom[1, 1] = (new MatrixOfMatrix(m1[1, 0], false) * new MatrixOfMatrix(m2[0, 1], true)).ToMatrix();
            }
            else if (m1.GetNRows == 1)
            {
                mom[0, 0] = (new MatrixOfMatrix(m1[0, 0], false) * new MatrixOfMatrix(m2[0, 0], true) + new MatrixOfMatrix(m1[0, 1], false) * new MatrixOfMatrix(m2[1, 0], true)).ToMatrix();
            }
            else
            {
                mom[0, 0] = (new MatrixOfMatrix(m1[0, 0], false) * new MatrixOfMatrix(m2[0, 0], true) + new MatrixOfMatrix(m1[0, 1], false) * new MatrixOfMatrix(m2[1, 0], true)).ToMatrix();
                mom[0, 1] = (new MatrixOfMatrix(m1[0, 0], false) * new MatrixOfMatrix(m2[0, 1], true) + new MatrixOfMatrix(m1[0, 1], false) * new MatrixOfMatrix(m2[1, 1], true)).ToMatrix();
                mom[1, 0] = (new MatrixOfMatrix(m1[1, 0], false) * new MatrixOfMatrix(m2[0, 0], true) + new MatrixOfMatrix(m1[1, 1], false) * new MatrixOfMatrix(m2[1, 0], true)).ToMatrix();
                mom[1, 1] = (new MatrixOfMatrix(m1[1, 0], false) * new MatrixOfMatrix(m2[0, 1], true) + new MatrixOfMatrix(m1[1, 1], false) * new MatrixOfMatrix(m2[1, 1], true)).ToMatrix();
            }
            return mom;
        }
        public MatrixOfMatrix Reverse()
        {
            if (nCols == 1 && nRows == 1 && matrix[0, 0].GetnCols <= 2 && matrix[0, 0].GetnRows <= 2)
            {
                return new MatrixOfMatrix(this.matrix[0, 0].Reverse(), true);
            }
            MatrixOfMatrix res = new MatrixOfMatrix(2, 2, true);
            MatrixOfMatrix Arev = new MatrixOfMatrix(this[0, 0], true).Reverse();
            MatrixOfMatrix Krev = (new MatrixOfMatrix(this[1, 1], true) - (new MatrixOfMatrix(this[1, 0], true) * Arev * new MatrixOfMatrix(this[0, 1], true))).Reverse();

            res[0, 0] = (Arev + (Arev * new MatrixOfMatrix(this[0, 1], true) * Krev * new MatrixOfMatrix(this[1, 0], true) * Arev)).ToMatrix();
            res[0, 1] = (-(Arev * new MatrixOfMatrix(this[0, 1], true) * Krev)).ToMatrix();
            res[1, 0] = (-(Krev * new MatrixOfMatrix(this[1, 0], true) * Arev)).ToMatrix();
            res[1, 1] = Krev.ToMatrix();
            return res;
        }
        public Matrix this[int m, int n]
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
        public override bool Equals(object obj)
        {
            return (obj is MatrixOfMatrix) && this.Equals((Matrix)obj);
        }
        public bool Equals(MatrixOfMatrix m)
        {
            if (!CompareDimension(this, m))
                return false;
            for (int i = 0; i < m.GetNRows; i++)
                for (int j = 0; j < m.GetNCols; j++)
                    if (this[i, j] != m[i, j])
                        return false;
            return true;
        }
        public override int GetHashCode()
        {
            return matrix.GetHashCode();
        }
        public Matrix ToMatrix()
        {
            Matrix m;
            if (this.GetNRows == 1 && this.GetNCols == 1)
            {
                m = new Matrix(matrix[0, 0].GetnRows, matrix[0, 0].GetnCols);
                for (int i = 0; i < matrix[0, 0].GetnRows; i++)
                    for (int j = 0; j < matrix[0, 0].GetnCols; j++)
                        m[i, j] = matrix[0, 0][i, j];
            }
            else if (this.GetNRows == 1)
            {
                m = new Matrix(matrix[0, 0].GetnRows, matrix[0, 0].GetnCols + matrix[0, 1].GetnCols);
                for (int i = 0; i < matrix[0, 0].GetnRows; i++)
                {
                    for (int j = 0; j < matrix[0, 0].GetnCols; j++)
                        m[i, j] = matrix[0, 0][i, j];
                    for (int j = 0; j < matrix[0, 1].GetnCols; j++)
                        m[i, j + matrix[0, 0].GetnCols] = matrix[0, 1][i, j];
                }
            }
            else if (this.GetNCols == 1)
            {
                m = new Matrix(matrix[0, 0].GetnRows + matrix[1, 0].GetnRows, matrix[0, 0].GetnCols);
                for (int i = 0; i < matrix[0, 0].GetnRows; i++)
                    for (int j = 0; j < matrix[0, 0].GetnCols; j++)
                        m[i, j] = matrix[0, 0][i, j];
                for (int i = 0; i < matrix[1, 0].GetnRows; i++)
                    for (int j = 0; j < matrix[1, 0].GetnCols; j++)
                        m[i + matrix[0, 0].GetnRows, j] = matrix[1, 0][i, j];
            }
            else
            {
                m = new Matrix(matrix[0, 0].GetnRows + matrix[1, 0].GetnRows, matrix[0, 0].GetnCols + matrix[0, 1].GetnCols);
                for (int i = 0; i < matrix[0, 0].GetnRows; i++)
                {
                    for (int j = 0; j < matrix[0, 0].GetnCols; j++)
                        m[i, j] = matrix[0, 0][i, j];
                    for (int j = 0; j < matrix[0, 1].GetnCols; j++)
                        m[i, j + matrix[0, 0].GetnCols] = matrix[0, 1][i, j];
                }
                for (int i = 0; i < matrix[1, 0].GetnRows; i++)
                {
                    for (int j = 0; j < matrix[1, 0].GetnCols; j++)
                        m[i + matrix[0, 0].GetnRows, j] = matrix[1, 0][i, j];
                    for (int j = 0; j < matrix[1, 1].GetnCols; j++)
                        m[i + matrix[0, 0].GetnRows, j + matrix[0, 0].GetnCols] = matrix[1, 1][i, j];
                }
            }
            return m;
        }
        public static bool CompareDimension(MatrixOfMatrix m1, MatrixOfMatrix m2)
        {
            if (m1.GetNCols == m2.GetNCols && m1.GetNRows == m2.GetNRows) 
                return true;
            else
                return false;
        }
        public int GetNCols
        {
            get { return nCols; }
        }
        public int GetNRows
        {
            get { return nRows; }
        }
    }

   
}
