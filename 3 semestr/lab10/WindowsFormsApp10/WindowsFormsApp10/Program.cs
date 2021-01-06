using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labka2
{
    struct Data
    {
        public Data(string n, int p, int v, byte c, string s, char m)
        {
            Name = n;
            Price = p;
            Volume = v;
            Calories = c;
            Sugar = s;
            Milk = m;
        }
        public string Name;
        public int Price;
        public int Volume;
        public int Calories;
        public string Sugar;
        public char Milk;
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Controller
    {
        DataBase Base = new DataBase();
        public Data GetData(string name)
        {
            return Base.CheckInBase(name);
        }
    }
    class DataBase
    {
        Data[] Base =
        {
            new Data("Латте", 250, 100, 31, "+/-", '+'),
            new Data("Капучино", 250, 100, 25, "+/-", '+'),
            new Data("Американо", 100, 80, 21, "+/-", '+'),
            new Data("Эспрессо", 30, 60, 9, "+/-", '+'),
            new Data("Карамельный мокко", 250, 150, 72, "-", '+')
        };
        Data notInBase = new Data()
        {
            Name = "null"
        };
        public Data CheckInBase(string coffee)
        {
            for (int i = 0; i < Base.Length; i++)
                if (Base[i].Name == coffee)
                    return Base[i];
            return notInBase;
        }
    }
}
