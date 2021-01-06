using System;
using System.Collections.Generic;

namespace Lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph_J J = new Graph_J(4);
            Graph_K K = new Graph_K(5);
            Graph_D D = new Graph_D(6);
            Graph_E E = new Graph_E(7);
            Graph_F F = new Graph_F(8);
            
            Graph_B B = new Graph_B(K, D, 2);
            Graph_C C = new Graph_C(E, F, 3);

            Graph_A A = new Graph_A(B, C, J, 1);

            System.Console.WriteLine($"1 A");
            A.MoveTo('B');
            A.MoveTo('C');
            A.MoveTo('J');
            A.MoveTo('K');
            A.MoveTo('D');
            A.MoveTo('E');
            A.MoveTo('F');
        }
    }
    class Graph_A
    {
        private int Value;
        private Graph_B B = null;
        private Graph_C C = null;
        private Graph_J J = null;

        public Graph_A(Graph_B _B, Graph_C _C, Graph_J _J, int value)
        {
            Value = value;
            B = _B;
            C = _C;
            J = _J;
        }
        ~Graph_A()
        {
        }
        public void MoveTo(char name)
        {
            System.Console.Write($"{Value} => ");
            if (name == 'B' || name == 'K' || name == 'D')
            {
                this.B.MoveTo(name);
            }
            else if (name == 'J')
            {
                this.J.MoveTo(name);
            }
            else
            {
                this.C.MoveTo(name);
            }

        }
    }
    class Graph_B
    {
        private int Value;
        private Graph_K K = null;
        private Graph_D D = null;

        public Graph_B(Graph_K _K, Graph_D _D, int value)
        {
            Value = value;
            K = _K;
            D = _D;
        }
        ~Graph_B()
        {
        }
        public void MoveTo(char name)
        {
            if (name == 'K')
            {
                System.Console.Write($"{Value} => ");
                this.K.MoveTo(name);
            }
            else if (name == 'D')
            {
                System.Console.Write($"{Value} => ");
                this.D.MoveTo(name);
            }
            else
            {
                System.Console.WriteLine($"{Value} B");
            }
        }
    }
    class Graph_C
    {
        private int Value;
        private Graph_E E = null;
        private Graph_F F = null;

        public Graph_C(Graph_E _E, Graph_F _F, int value)
        {
            Value = value;
            E = _E;
            F = _F;
        }
        ~Graph_C()
        {
        }
        public void MoveTo(char name)
        {
            if (name == 'E')
            {
                System.Console.Write($"{Value} => ");
                this.E.MoveTo(name);
            }
            else if (name == 'F')
            {
                System.Console.Write($"{Value} => ");
                this.F.MoveTo(name);
            }
            else
            {
                System.Console.WriteLine($"{Value} C");
            }
        }
    }
    class Graph_J
    {
        private int Value;

        public Graph_J(int value)
        {
            Value = value;
        }
        ~Graph_J()
        {
        }
        public void MoveTo(char name)
        {
            System.Console.WriteLine($"{Value} J");
        }
    }
    class Graph_K
    {
        private int Value;

        public Graph_K(int value)
        {
            Value = value;
        }
        ~Graph_K()
        {
        }
        public void MoveTo(char name)
        {
            System.Console.WriteLine($"{Value} K");
        }
    }
    class Graph_D
    {
        private int Value;

        public Graph_D(int value)
        {
            Value = value;
        }
        ~Graph_D()
        {
        }
        public void MoveTo(char name)
        {
            System.Console.WriteLine($"{Value} D");
        }
    }
    class Graph_E
    {
        private int Value;

        public Graph_E(int value)
        {
            Value = value;
        }
        ~Graph_E()
        {
        }
        public void MoveTo(char name)
        {
            System.Console.WriteLine($"{Value} E");
        }
    }
    class Graph_F
    {
        private int Value;

        public Graph_F(int value)
        {
            Value = value;
        }
        ~Graph_F()
        {
        }
        public void MoveTo(char name)
        {
            System.Console.WriteLine($"{Value} F");
        }
    }


}