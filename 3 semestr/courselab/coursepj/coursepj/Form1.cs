﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursepj
{

    public partial class Form1 : Form
    {

        int money;
        private Bitmap hiImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/courselab/hi.jpg");

        private Bitmap kpImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab13/kp.jpg");
        private Bitmap tgImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab13/tg.jpeg");
        private Bitmap obImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab13/ob.jpg");
        private Bitmap mcImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab13/mc.jpg");
        private Bitmap btImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab13/bt.jpg");

        private Bitmap pushkImage = new Bitmap("C:\\Users\\UltraUser\\Программирование\\MaiLabs\\3 semestr\\courselab\\hi.jpg");
        private Bitmap esenImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/courselab/hi.jpg");
        private Bitmap tsvetImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/courselab/hi.jpg");
        private Bitmap lermImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/courselab/hi.jpg");
        private Bitmap mayakImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/courselab/hi.jpg");

        private Bitmap comImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/courselab/hi.jpg");
        private Bitmap dramImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/courselab/hi.jpg");
        private Bitmap multImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/courselab/hi.jpg");
        private Bitmap prikImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/courselab/hi.jpg");
        private Bitmap meloImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/courselab/hi.jpg");
        private Bitmap trillImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/courselab/hi.jpg");
        private Bitmap fantImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/courselab/hi.jpg");
        private Bitmap screamImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/courselab/hi.jpg");


        private Bitmap goodPhoto = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab14/good.jpg");

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = (Image)hiImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
            button2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            money = Convert.ToInt32(textBox1.Text);
            label11.Text = "Ваш остаток: " + money + "Р";
            label2.Visible = false;
            label3.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;
            label4.Visible = false;
            button3.Visible = true;
            pictureBox2.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            int minus = 0;
            {
                Tickets ticket = CheckPossibilities(money);

                TicketHandler tgTicketHandler = new mcTicketHandler();
                TicketHandler obTicketHandler = new obTicketHandler();
                TicketHandler mcTicketHandler = new tgTicketHandler();
                TicketHandler btTicketHandler = new btTicketHandler();
                obTicketHandler.Successor = tgTicketHandler;
                mcTicketHandler.Successor = obTicketHandler;
                btTicketHandler.Successor = mcTicketHandler;

                int switcher = btTicketHandler.Handle(ticket);
                switch (switcher)
                {
                    case 0:
                        pictureBox2.Image = (Image)kpImage;
                        label6.Text = "Красная Площадь";
                        break;
                    case 1:
                        pictureBox2.Image = (Image)tgImage;
                        label6.Text = "Третьяковская Галерея";
                        minus = 400;
                        break;
                    case 2:
                        pictureBox2.Image = (Image)obImage;
                        label6.Text = "Останкинская Башня";
                        minus = 900;
                        break;
                    case 3:
                        pictureBox2.Image = (Image)mcImage;
                        label6.Text = "Москва Сити";
                        minus = 1200;
                        break;
                    case 4:
                        pictureBox2.Image = (Image)btImage;
                        label6.Text = "Большой Театр";
                        minus = 2000;
                        break;
                    default:
                        MessageBox.Show("Ошибка в 110 cтроке Forms.cs", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                money = money - minus;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private Tickets CheckPossibilities(int money)
        {
            bool tgTicket = false;
            bool obTicket = false;
            bool mcTicket = false;
            bool btTicket = false;
            if (money > 400)
                tgTicket = true;
            if (money > 900)
                obTicket = true;
            if (money > 1200)
                mcTicket = true;
            if (money > 2000)
                btTicket = true;
            return new Tickets(tgTicket, obTicket, mcTicket, btTicket);
        }
        class Tickets
        {
            public bool tgTicket { get; set; }
            public bool obTicket { get; set; }
            public bool mcTicket { get; set; }
            public bool btTicket { get; set; }

            public Tickets(bool kp, bool tg, bool mc, bool bt)
            {
                tgTicket = kp;
                obTicket = tg;
                mcTicket = mc;
                btTicket = bt;
            }
        }
        abstract class TicketHandler
        {
            public TicketHandler Successor { get; set; }
            public abstract int Handle(Tickets ticket);
        }

        class obTicketHandler : TicketHandler
        {
            public override int Handle(Tickets ticket)
            {
                if (ticket.obTicket)
                    return 2;
                else if (Successor != null)
                    return Successor.Handle(ticket);
                else return -1;
            }
        }

        class mcTicketHandler : TicketHandler
        {
            public override int Handle(Tickets ticket)
            {
                if (ticket.tgTicket)
                    return 1;
                else return 0;
            }
        }

        class btTicketHandler : TicketHandler
        {
            public override int Handle(Tickets ticket)
            {
                if (ticket.btTicket)
                    return 4;
                else if (Successor != null)
                    return Successor.Handle(ticket);
                else return -1;
            }
        }

        class tgTicketHandler : TicketHandler
        {
            public override int Handle(Tickets ticket)
            {
                if (ticket.mcTicket)
                    return 3;
                else if (Successor != null)
                    return Successor.Handle(ticket);
                else return -1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label11.Text = "Ваш остаток: " + money + "Р";
            button3.Visible = false;
            pictureBox2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            button4.Visible = true;
            label7.Visible = true;
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int minus = 0;
            button4.Visible = false;
            label7.Visible = false;
            panel1.Visible = false;
            pictureBox3.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            button5.Visible = true;

            if (radioButton1.Checked == true)
            {
                pictureBox3.Image = (Image)pushkImage;
                label9.Text = "Музей А.С. Пушкина.";
                minus = 250;
            }
            else if (radioButton2.Checked == true)
            {
                pictureBox3.Image = (Image)esenImage;
                label9.Text = "Музей С.А. Есенина.";
                minus = 350;
            }
            else if (radioButton3.Checked == true)
            {
                pictureBox3.Image = (Image)tsvetImage;
                label9.Text = "Музей М.А. Цветаевой.";
                minus = 300;
            }
            else if (radioButton4.Checked == true)
            {
                pictureBox3.Image = (Image)lermImage;
                label9.Text = "Музей М.Ю. Лермонтова.";
                minus = 200;
            }
            else if (radioButton5.Checked == true)
            {
                pictureBox3.Image = (Image)mayakImage;
                label9.Text = "Музей В.В. Маяковского.";
                minus = 300;
            }
            money = money - minus;
            label11.Text = "Ваш остаток: " + money + "Р";
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label11.Text = "Ваш остаток: " + money + "Р";
            pictureBox3.Visible = false;
            label9.Visible = false;
            label8.Visible = false;
            button5.Visible = false;
            button6.Visible = true;
            label10.Visible = true;
            panel2.Visible = true;
            if (radioButton6.Checked == true)
                pictureBox4.Image = (Image)kpImage;//com
            else if (radioButton7.Checked == true)
                pictureBox4.Image = (Image)kpImage;//dram
            else if (radioButton8.Checked == true)
                pictureBox4.Image = (Image)trillImage;
            else if (radioButton9.Checked == true)
                pictureBox4.Image = (Image)multImage;
            else if (radioButton10.Checked == true)
                pictureBox4.Image = (Image)prikImage;
            else if (radioButton11.Checked == true)
                pictureBox4.Image = (Image)meloImage;
            else if (radioButton12.Checked == true)
                pictureBox4.Image = (Image)fantImage;
            else if (radioButton13.Checked == true)
                pictureBox4.Image = (Image)screamImage;
            money -= 360;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            label10.Visible = false;
            panel2.Visible = false;
            label11.Text = "Ваш остаток: " + money + "Р";
            label12.Visible = true;
            button6.Visible = false;
            button7.Visible = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            button7.Visible = false;
            label12.Visible = false;

            label11.Text = "Ваш остаток: " + money + "Р";

            label13.Visible = true;

            pictureBox4.Visible = true;
            button9.Visible = true;
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            MakePhoto command = new MakePhoto(receiver);
            invoker.SetCommand(command);
            invoker.Run();
            label26.Visible = true;
            pictureBox4.Image = Image.FromFile("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab14/bad.jpg");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            MakePhoto command = new MakePhoto(receiver);
            invoker.SetCommand(command);
            invoker.Run();
            label13.Text = "Восхитительно!";
            button9.Visible = false;
            button10.Visible = true;
            pictureBox4.Image = (Image)goodPhoto;
            label26.Visible = true;
            if (money >= 0)
            {
                label25.Text = "После путешествия у Вас осталось " + money + "Р";
            }
            else label25.Text = "Вам нужно накопить " + money*(-1) + "Р";
        }

    
        //

        private void label1_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton4_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton5_CheckedChanged(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void radioButton10_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton11_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton12_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton13_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton7_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton9_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton8_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton6_CheckedChanged(object sender, EventArgs e) { }
        private void pictureBox6_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label26.Visible = false;
            label28.Visible = true;
            label25.Visible = true;
            label11.Visible = false;
            label13.Visible = false;
            button9.Visible = false;
            pictureBox4.Visible = false;
            button10.Visible = false;

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
    abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }

    class MakePhoto : Command
    {
        Receiver receiver;
        public MakePhoto(Receiver r)
        {
            receiver = r;
        }
        public override void Execute()
        {
            receiver.Operation();
        }
        public override void Undo()
        { }
    }
    class Receiver
    {
        public void Operation()
        { }
    }
    class Invoker
    {
        Command command;
        public void SetCommand(Command c)
        {
            command = c;
        }
        public void Run()
        {
            command.Execute();
        }
        public void Cancel()
        {
            command.Undo();
        }
    }
}
