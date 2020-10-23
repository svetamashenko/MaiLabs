using System;
using System.Collections.Generic;
using System.IO;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph_A A = new Graph_A(new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
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
        public Graph_A(int[] value)
        {
            Value = value[0];
            B = new Graph_B(value);
            C = new Graph_C(value);
            J = new Graph_J(value);
        }
        ~Graph_A() { }
        private Graph_B B = null;
        private Graph_C C = null;
        private Graph_J J = null;
        class Graph_J
        {
            private int Value;
            public Graph_J(int[] value)
            {
                Value = value[3];
            }
            public void MoveTo(char name)
            {
                System.Console.WriteLine($"{Value} J");
            }
        }
        class Graph_C
        {
            private int Value;
            public Graph_C(int[] value)
            {
                Value = value[2];
                E = new Graph_E(value);
                F = new Graph_F(value);
                
            }
            private Graph_E E = null;
            private Graph_F F = null;
            class Graph_E
            {
                private int Value;
                public Graph_E(int[] value)
                {
                    Value = value[6];
                }
                public void MoveTo(char name)
                {
                    System.Console.WriteLine($"{Value} E");
                }
            }
            class Graph_F
            {
                private int Value;
                public Graph_F(int[] value)
                {
                    Value = value[7];
                }
                public void MoveTo(char name)
                {
                    System.Console.WriteLine($"{Value} F");
                }
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
        class Graph_B
        {
            private int Value;
            public Graph_B(int[] value)
            {
                Value = value[1];
                K = new Graph_K(value);
                D = new Graph_D(value);
                
            }
            private Graph_K K = null;
            private Graph_D D = null;
            class Graph_K
            {
                private int Value;
                public Graph_K(int[] value)
                {
                    Value = value[4];
                }
                public void MoveTo(char name)
                {
                    System.Console.WriteLine($"{Value} K");
                }
            }
            class Graph_D
            {
                private int Value;
                public Graph_D(int[] value)
                {
                    Value = value[5];
                }
                public void MoveTo(char name)
                {
                    System.Console.WriteLine($"{Value} D");
                }
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
         public void MoveTo(char name)
        {
            System.Console.Write($"{Value} => ");
            if (name == 'J')
            {
                this.J.MoveTo(name);
            }
            else if (name == 'C'|| name == 'E' || name == 'F')
            {
                this.C.MoveTo(name);
            }
            else
            {
                this.B.MoveTo(name);
            }

        }
    
    }
}