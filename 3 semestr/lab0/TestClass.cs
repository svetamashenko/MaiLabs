using System;
namespace _1_task
{
    class TestClass
    {
        public int a;
        private int b;

        public TestClass()
        {
            a = 0;
            b = 0;
            System.Console.WriteLine("First Way of creating (Without arguments)");
        }
        public TestClass(int c, int d)
        {
            this.a = c;
            this.b = d;
            System.Console.WriteLine("Second Way of creating (With two arguments)");
        }
        public TestClass(TestClass old)
        {
            this.a = old.a;
            this.b = old.b;
            System.Console.WriteLine("Third Way of creating (Copying objects)");
        }

        public void F()
        {
            System.Console.WriteLine("First Way of function");
            System.Console.WriteLine(($"This object from {this.ToString()} class\na = {this.a}\nb = {this.b}\n"));
        }
        public void F(int c, int d)
        {
            System.Console.WriteLine("Second Way of function (With creation of object)");
            System.Console.WriteLine($"This object from {this.ToString()} class\na = {this.a}\nb = {this.b}\nnew numbers = [{c},{d}]\n");
        }
        public void F(TestClass example)
        {
            System.Console.WriteLine("Third Way of function (With copying of object)");
            System.Console.WriteLine($"This object from {this.ToString()} class\na = {this.a}\nb = {this.b}\n");
            System.Console.WriteLine($"New object from {example.ToString()} class\na = {example.a}\nb = {example.b}\n");
        }
    }
}