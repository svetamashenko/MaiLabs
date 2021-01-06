using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Barista barista = new VictorBarista("Виктор");
                Coffee coffee = barista.MakeCoffee();
                MessageBox.Show("Ваш бариста: " + barista.Name + "\n" + coffee.PrintCoffee(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Barista barista = new AlexBarista("Александра");
            Coffee coffee = barista.MakeCoffee();
            MessageBox.Show("Ваш бариста: " + barista.Name + "\n" + coffee.PrintCoffee(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Barista barista = new MashaBarista("Мария");
            Coffee coffee = barista.MakeCoffee();
            MessageBox.Show("Ваш бариста: " + barista.Name + "\n" + coffee.PrintCoffee(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Barista barista = new OlegBarista("Олег");
            Coffee coffee = barista.MakeCoffee();
            MessageBox.Show("Ваш бариста: " + barista.Name + "\n" + coffee.PrintCoffee(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        abstract class Barista
        {
            public string Name { get; set; }

            public Barista(string name)
            {
                Name = name;
            }
            abstract public Coffee MakeCoffee();

        }
        //Описание конкретных классов создателей
        class VictorBarista : Barista
        {
            public VictorBarista(string name) : base(name) { }
            public override Coffee MakeCoffee()
            {
                return new latte();
            }
        }

        class AlexBarista : Barista
        {
            public AlexBarista(string name) : base(name) { }
            public override Coffee MakeCoffee()
            {
                return new kapuchino();
            }
        }

        class MashaBarista : Barista
        {
            public MashaBarista(string name) : base(name) { }
            public override Coffee MakeCoffee()
            {
                return new amerikano();
            }
        }

        class OlegBarista : Barista
        {
            public OlegBarista(string name) : base(name) { }
            public override Coffee MakeCoffee()
            {
                return new espresso();
            }
        }
        
        abstract class Coffee
        {
            public int Volume { get; set; }
            public int Price { get; set; }
            public Coffee() { }
            public string PrintCoffee()
            {
                return "Объём Вашего напитка: " + this.Volume.ToString() + "мл" + "\n" + "Цена: " + this.Price.ToString() + "р.";
            }
        }
       
        class latte : Coffee
        {
            public latte()
            {
                Volume = 250;
                Price = 100;
            }
        }

        class kapuchino : Coffee
        {
            public kapuchino()
            {
                Volume = 250;
                Price = 100;
            }
        }

        class amerikano : Coffee
        {
            public amerikano()
            {
                Volume = 100;
                Price = 80;
            }
        }

        class espresso : Coffee
        {
            public espresso()
            {
                Volume = 60;
                Price = 60;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Font = new Font(label1.Font.Name, 15, label1.Font.Style);
                label1.Location = new Point(59, 76);
            }
            else
            {
                label1.Font = new Font(label1.Font.Name, 8, label1.Font.Style);
                label1.Location = new Point(200, 76);
            }
        }
    }
}
