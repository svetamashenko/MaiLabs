using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form2 : Form
    {
        public Form2(double[] x, double[] xy, double y)
        {
            InitializeComponent();
        }
        private void function(object sender, EventArgs e)
        {
            double x = 0;
            this.chart1.Series["f(x)"].Points.Clear();/*
            for(int i = 0; i< Dots.x.Length; i++)
            {
                double y = Dots.x[i];
                this.chart1.Series["f(x)"].Points.AddXY(x, y);
                x += Dots.step;
            }*/

            this.chart1.Series[1].Points.AddXY(1, 2);
            this.chart1.Series[1].Points.AddXY(1, 3);
        }
    }
    class Dots
    {
        public static double[] x;
        public static double[] gran;
        public static double step;
        public Dots(double[] coef, double[] xs, double x1)
        {
            x = coef;
            gran = xs;
            step = x1;
        }
    }
}
