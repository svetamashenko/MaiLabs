using System;
using System.Collections.Generic;

namespace Lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph A = new Graph(1);
            Graph B = new Graph(2);
            Graph C = new Graph(3);
            Graph J = new Graph(4);

            System.Console.WriteLine($"1 A");
            A.Add(B);
            A.MoveTo(B,'B');
            A.Add(C);
            A.MoveTo(C,'C');
            A.Add(J);
            A.MoveTo(J,'J');

            Graph K = new Graph(5);
            Graph D = new Graph(6);

            B.Add(K);
            A.MoveTo(K,'K');
            B.Add(D);
            A.MoveTo(D,'D');

            Graph E = new Graph(7);
            Graph F = new Graph(8);

            C.Add(E);
            A.MoveTo(E,'E');
            C.Add(F);
            A.MoveTo(F,'F');
        }
    }

    class Graph
    {
        private int Value;
        private List<Graph> Childs;
        public void Add(Graph new_child)
        {
            Childs.Add(new_child);
        }
        public Graph(int value)
        {
            Childs = new List<Graph>();
            Value = value;
        }
        public void MoveTo(Graph gr, char ch)
        {
            System.Console.Write($"{Value} => ");
            foreach (Graph k in Childs)
            {
                if (k.Value == gr.Value)
                {
                    System.Console.WriteLine($"{k.Value} {ch}");
                    return;
                }
                foreach (Graph h in k.Childs)
                {
                    if (h.Value == gr.Value)
                    {
                        System.Console.WriteLine($"{k.Value} => {h.Value} {ch}");
                        return;
                    }
                }
            }

        }
    }
}
