using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            D d = new D();
            
            b.function_A();
            d.function_A();
            d.function_C();
        }
    }
    interface A
    {
        void function_A();
    }
    class B : A
    {
        public virtual void function_A()
        {
            System.Console.WriteLine("Function A");
        }
    }
    interface C : A
    {
        void function_C();
    }
    class D : B, C
    {
        public override void function_A()
        {
            System.Console.Write("That`s override ");
            base.function_A();
        }
        public void function_C(){
            System.Console.WriteLine("Function_C");
        } 
    }
}