using System;

namespace _1_lab
{
    class Function{
        public string a;
        public Function(){
            a = " ";
        }
        public Function(string str){
            a = str;
        }

        public static void F1 (string examp1){
            System.Console.WriteLine($"{examp1}\nIt's a string!");
        }
        public static string F2 (string examp2){
            return ($"{examp2}\nIt's also a string!");
        }
        public void F3 (Function examp3){
            System.Console.WriteLine($"{examp3.a}\nIt's a string too!");
        }
        public string F4 (Function examp4){
            return ($"{examp4.a}\nAnd it's a string!");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string a = new string("0");
            string b = new string("Hello World!");
            Function c = new Function("NULL");
            Function d = new Function(".");
            Function.F1(a);
            System.Console.WriteLine(Function.F2(b));
            c.F3(c);
            System.Console.WriteLine(d.F4(d));
        }
    }
}
