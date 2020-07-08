using System;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Input your text:");
            string Input;
            Input = Console.ReadLine();
            Input = Input.Replace("капибар", "суперзвезд");
            Input = Input.Replace("Капибар", "Суперзвезд");
            System.Console.WriteLine(Input);
        }
    }
}
