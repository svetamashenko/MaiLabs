using System;

namespace lab9._1
{
    class Program
    {
        delegate void Non_return();
        delegate int Int_return();
        delegate void Action<T>(T value);
        delegate T Func<T>(T value);

        static void Main(string[] args)
        {
            
            Non_return NR = print1;
            Int_return IR = one;
            NR();
            System.Console.WriteLine(IR());
            System.Console.WriteLine();
            
            NR+=print2;
            NR+=print3;
            NR();
            System.Console.WriteLine();
            
            NR = delegate(){
                System.Console.WriteLine("Anonymous delegate");
            };
            NR();
            System.Console.WriteLine();
            
            Func<string> oper = STR;
            System.Console.WriteLine(oper("Template delegate"));
            Action<string> act = Integer<string>;
            act("String's output");
        }
        public static int one()=>1;

        public static void print1()=>System.Console.WriteLine("Print 1");
        public static void print2()=>System.Console.WriteLine("Print 2");
        public static void print3()=>System.Console.WriteLine("Print 3");
        public static string STR(string str)=>str;
        public static void Integer<T>(T val)=>System.Console.WriteLine(val.ToString());
    }
}