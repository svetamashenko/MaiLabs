using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            F ff = new F(10);
            F df = new D(10);
            F gf = new G(10);

            D dd = new D(10);
            D gd = new G(10);

            G gg = new G(10);


            System.Console.WriteLine($"ff = {ff.get_value()}");
            System.Console.WriteLine($"df = {df.get_value()}");
            System.Console.WriteLine($"gf = {gf.get_value()}");
            System.Console.WriteLine($"dd = {dd.get_value()}");
            System.Console.WriteLine($"gd = {gd.get_value()}");
            System.Console.WriteLine($"gg = {gg.get_value()}");

        }
    }
    class F
    {
        protected int value = 0;
        public F(int a)
        {
            System.Console.WriteLine($"Used class: {this.ToString()}");
            value = a;
        }
        public virtual int get_value()
        {
            return value;
        }
    }
    class D : F
    {
        public D(int a) : base(a) { }
        public override int get_value()
        {
            return base.get_value() + 5;
        }
    }
    sealed class G : D
    {
        public G(int a) : base(a) { }
        public override int get_value()
        {
            return base.get_value() + 10;
        }
    }
}
