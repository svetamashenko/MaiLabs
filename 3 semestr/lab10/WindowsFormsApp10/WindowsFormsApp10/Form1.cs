using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labka2
{
    public partial class Form1 : Form
    {
        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data data = controller.GetData(textBox1.Text);
            if (data.Name == "null")
            {
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
                label11.Text = "";
                label12.Text = "";
                label13.Text = "Простите, но в нашей кофейне нет такого напитка";
            }
            else
            {
                label2.Text = "Объём";
                label3.Text = "Цена";
                label4.Text = "Калорийность";
                label5.Text = "Сахар";
                label6.Text = "Альтернативное молоко";
                label7.Text = data.Price.ToString();
                label8.Text = data.Volume.ToString();
                label9.Text = data.Calories.ToString();
                label10.Text = data.Sugar;
                label11.Text = data.Milk.ToString();
                label12.Text = "Информация о напитке:";
                label13.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
