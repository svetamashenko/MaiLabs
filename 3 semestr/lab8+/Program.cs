using System;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Template<int> number = new Template<int>(100);
            Template<string> quote = new Template<string>("string");
            Template<Template<int>> TT = new Template<Template<int>>(number);
            number.print_value();
            quote.print_value();
            TT.print_value();

            int int1 = 1, int2 = 2;
            System.Console.WriteLine($"int1 = {int1}, int 2 = {int2}");
            Template<int>.swap(ref int1, ref int2);
            System.Console.WriteLine($"int1 = {int1}, int 2 = {int2}");
        }
    }
    class Template<T>
    {
        private T value;
        public Template(T arg)
        {
            value = arg;
            if (arg is int)
            {
                System.Console.WriteLine("New int object was created.");
                return;
            }
            if (arg is string)
            {
                System.Console.WriteLine("New string object was created.");
                return;
            }
            if (arg is Template<int>)
            {
                System.Console.WriteLine("New Template<int> object was created.");
                return;
            }
            else
            {
                System.Console.WriteLine("Unknown type of object. Creation wasn't done.");
            }
        }
        public void print_value() =>
            System.Console.WriteLine($"{this.ToString()} = {this.value}");
        

        public static void swap(ref T frst, ref T scnd)
        {
            T thrd = frst;
            frst = scnd;
            scnd = thrd;
            System.Console.WriteLine("Swap of two objects was done succesfully.");
        }
    }
}