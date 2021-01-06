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

            this.comboBox2.Items.AddRange(new string[] { "Tecla", "XIA", "Fort" });
            this.comboBox3.Items.AddRange(new string[] { "Кожаный салон", "Кожзам", "Зам. кожзама" });
            this.Lexus = new Dealer();
            this.label2.Hide();

        }
        private Dealer Lexus = null;

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            Lexus.order_machine(Convert.ToString(comboBox2.SelectedItem), Convert.ToString(comboBox1.SelectedItem), Convert.ToString(comboBox3.SelectedItem));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mark = Convert.ToString(this.comboBox2.SelectedItem);
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.AddRange(Lexus.find_model(mark));
        }
        public class Dealer
        {
            private DB_katlog DataBase = new DB_katlog();
            Machine_Factory General_Motore = new Machine_Factory();
            public void order_machine(string mark, string model, string interior) => General_Motore.make_machine(mark, model, interior);
            public string[] find_model(string mark) => this.DataBase.get_models(mark);

        }

        public class Machine_Factory
        {
            public void make_machine(string mark, string model, string interior)
            {
                System.Console.WriteLine($"Congrats! You {mark} {model} with {interior} interior will be make soon!");
                //make something with comment)

                Main_Builder(mark, model, interior);
                System.Console.WriteLine("goodbye!");
            }

            public void Main_Builder(string mark, string model, string interior) //abstract factory
            {
                car Car = null;

                switch (mark)
                {
                    case "Tecla":
                        Car = new Tecla_factory(model, interior);

                        break;
                    case "XIA":
                        Car = new XIA_factory(model, interior);

                        break;
                    case "Fort":
                        Car = new Fort_factory(model, interior);

                        break;
                }
                System.Console.WriteLine($"Gongrats! Your {mark} {model} is ready! \n Characteistics:");
                Car.Print_cahracteristic();

            }


        }

        public class DB_katlog
        {
            public string[] get_models(string mark)
            {
                switch (mark)
                {
                    case "Tecla": return Tecla_model;
                    case "XIA": return XIA_model;
                    case "Fort": return Fort_model;
                    default: return new string[] { };
                }
            }
            private string[] Tecla_model = new string[] { "Model 3 SR", "Model S P100D", "Model X P100D" };
            private string[] XIA_model = new string[] { "Sportage", "Seltos", "Picanto" };
            private string[] Fort_model = new string[] { "Mustang", "Explorer", "RAM" };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public class car
        {
            protected string engine = "None";
            protected string wheel = "None";
            protected string frame = "None";
            protected string interior = "None";
            protected string model = "None";

            public void Print_cahracteristic()
            {
                System.Console.WriteLine("Model = " + model);
                System.Console.WriteLine("Interior = " + interior);
                System.Console.WriteLine("Wheel = " + wheel);
                System.Console.WriteLine("Frame = " + frame);
                System.Console.WriteLine("Engine = " + engine);
            }
        }

        public class Fort_factory : car
        {


            delegate void Adder();

            public Fort_factory(string model_new, string interior_new)
            {
                //chain of responsibility
                this.model = model_new;
                Adder add = null;
                if (model_new == "RAM")
                {
                    add += Wheels;
                }
                if (model_new.Equals("Explorer"))
                {
                    add += Engine;
                }
                if (model_new.Equals("Mustang"))
                {
                    add += Frame;
                }
                interior = interior_new;

                add.Invoke();

            }

            private void Wheels()
            {
                this.wheel = "Cool wheel 10x16";
            }
            private void Engine()
            {
                this.engine = "Cool eng V8";
            }
            private void Frame()
            {
                this.frame = "Cool titan frame";
            }
        }

        public class XIA_factory : car
        {


            public XIA_factory(string model, string interior_new)
            {
                this.model = model;
                Make_machine(model, interior_new);
            }
            private void Make_machine(string model, string interior_new) //facade
            {
                Random rand = new Random();
                if (rand.Next(100) > 50)
                {
                    Wheels();
                }
                if (rand.Next(100) < 50)
                {
                    Frame();
                }
                if (rand.Next(100) == 50)
                {
                    Engine();
                }
            }

            private void Wheels()
            {
                this.wheel = "Cool wheel";
            }
            private void Engine()
            {
                this.engine = "Cool eng";
            }
            private void Frame()
            {
                this.frame = "Cool frame";
            }
        }

        public class Tecla_factory : car
        {
            public Tecla_factory(string model, string interior_new)
            {
                this.model = model;
                wheel = model + "`s electric wheel";
                engine = model + "`s electric engine";
                frame = model + "`s electric frame";
                interior = "plastic";
            }

        }
    }
}
