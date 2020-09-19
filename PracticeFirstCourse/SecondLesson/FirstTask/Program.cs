using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FirstTask
{
    class Matrix
    {
        static private int Rank = 2;
        static private double[,] matrix = new double[Rank, Rank];
        static private double determinator;

        public double get_determinator()
        {
            Determinate();
            return determinator;
        }

        public void Determinate()
        {
            determinator = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        public double this[int x, int y]
        {
            get
            { 
                return matrix[x, y];
            }
            set
            {
                matrix[x, y] = value;
            }
        }

        public Matrix FindReverseMatrix()
        {
            Matrix reverse = new Matrix();
            Determinate();
            reverse[0, 0] = matrix[1, 1] / determinator;
            reverse[0, 1] = -matrix[0, 1] / determinator;
            reverse[1, 0] = -matrix[1, 0] / determinator;
            reverse[1, 1] = matrix[0, 0] / determinator;
            return reverse;
        }

        static public Matrix operator +(Matrix first, Matrix second)
        {
            Matrix sum = new Matrix();
            sum[0, 0] = first[0, 0] + second[0, 0];
            sum[1, 0] = first[1, 0] + second[1, 0];
            sum[0, 1] = first[0, 1] + second[0, 1];
            sum[1, 1] = first[1, 1] + second[1, 1];
            return sum;
        }

        static public bool operator <(Matrix first, Matrix second)
        {
            return first.get_determinator() < second.get_determinator() ? true : false;
        }

        static public bool operator >(Matrix first, Matrix second)
        {
            return first.get_determinator() > second.get_determinator() ? true : false;
        }

        static public bool operator ==(Matrix first, Matrix second)
        {
            return first[0, 0] == second[0, 0] && first[0, 1] == second[0, 1] && first[1, 0] == second[1, 0] && first[1, 1] == second[1, 1];
        }

        static public bool operator !=(Matrix first, Matrix second)
        {
            return !(first[0, 0] == second[0, 0] && first[0, 1] == second[0, 1] && first[1, 0] == second[1, 0] && first[1, 1] == second[1, 1]);
        }

        static public Matrix operator *(Matrix first, Matrix second)
        {
            Matrix result = new Matrix();
            result[0, 0] = first[0, 0] * second[0, 0] + first[0, 1] * second[1, 0];
            result[0, 1] = first[0, 0] * second[0, 1] + first[0, 1] * second[1, 1];
            result[1, 0] = first[1, 0] * second[0, 0] + first[1, 1] * second[1, 0];
            result[1, 1] = first[1, 0] * second[0, 1] + first[1, 1] * second[1, 1];
            return result;
        }

        static public double operator /(Matrix first, Matrix second)
        {
            return first.get_determinator() / second.get_determinator();
        }

        static public Matrix Parse(string str)
        {
            string[] str_array = str.Split(" ", 4);
            Matrix matr = new Matrix();
            matr[0, 0] = double.Parse(str_array[0]);
            matr[0, 1] = double.Parse(str_array[1]);
            matr[1, 0] = double.Parse(str_array[2]);
            matr[1, 1] = double.Parse(str_array[3]);
            return matr;
        }

        static public bool TryParse(string str, out Matrix matr)
        {
            string[] str_array = str.Split(" ", 4);
            byte result = 0;
            double number;
            Matrix tmp = new Matrix();

            if (double.TryParse(str_array[0], out number))
            {
                result++;
                tmp[0, 0] = number;
            }
            if (double.TryParse(str_array[1], out number))
            {
                result++;
                tmp[0, 1] = number;
            }
            if (double.TryParse(str_array[2], out number))
            {
                result++;
                tmp[1, 0] = number;
            }
            if (double.TryParse(str_array[3], out number))
            {
                result++;
                tmp[1, 1] = number;
            }
            if (result == 4)
            {
                matr = tmp;
                return true;
            }
            else
            {
                tmp[0, 0] = tmp[0, 1] = tmp[1, 0] = tmp[1, 1] = 0;
                matr = tmp;
                return false;
            }
        }
    }

    class ListOfMatrix
    {
        private List<Matrix> ListOfMatr;
        public Matrix this[int index]
        {
            get
            {
                return ListOfMatr[index];
            }
            set
            {
                ListOfMatr[index] = value;
            }
        }
        public ListOfMatrix SortList()
        {
            return (ListOfMatrix)ListOfMatr.OrderBy(x => x.get_determinator() >= x.get_determinator());
        }
        public Matrix FirstOfList()
        {
            return ListOfMatr.First();
        }
        public Matrix EndOfList()
        {
            return ListOfMatr.Last();
        }
        public void AppendToList(Matrix matr)
        {
            ListOfMatr.Append(matr);
        }
        public ListOfMatrix MinMatrix()
        {
            return (ListOfMatrix)ListOfMatr.Select(x => x.get_determinator() <= x.get_determinator());
        }
        public ListOfMatrix MaxMatrix()
        {
            return (ListOfMatrix)ListOfMatr.Select(x => x.get_determinator() >= x.get_determinator());
        }
        public Matrix[] ToArray()
        {
            return ListOfMatr.ToArray();
        }
        public void MatrixPrint()
        {
            foreach (Matrix i in ListOfMatr)
            {
                System.Console.WriteLine($"{i[0, 0]} {i[0, 1]} {i[1, 0]} {i[1, 1]}");
            }
        }
    }
    static class MatrixLnOut
    {
        static public ListOfMatrix EnterMatrix(string path)
        {
            ListOfMatrix ListMatr = new ListOfMatrix();
            try
            {
                string str = new string("");
                using (StreamReader StreamRead = new StreamReader(path))
                {
                    while ((str = StreamRead.ReadLine()) != null)
                    {
                        ListMatr.AppendToList(Matrix.Parse(str));
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ListMatr;
        }

        static public void OutMatrix(string path, ListOfMatrix ListMatr)
        {
            try
            {
                string str = new string("");
                using (StreamWriter StreamWrite = new StreamWriter(path))
                {
                    foreach (Matrix i in ListMatr.ToArray())
                    {
                        StreamWrite.WriteLine($"{i[0, 0]} {i[0, 1]} {i[1, 0]} {i[1, 1]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}