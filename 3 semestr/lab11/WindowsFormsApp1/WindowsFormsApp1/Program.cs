using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labka3
{
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

    public sealed class Singleton
    {
        private Singleton()
        {
            Value = 0;
        }

        private static Singleton source = null;
        public int Value { get; set; }
        public static Singleton Source
        {
            get
            {
                if (source == null)
                    source = new Singleton();

                return source;
            }
        }
    }
}
