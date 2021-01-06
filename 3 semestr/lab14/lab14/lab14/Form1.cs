using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab14
{
    public partial class Form1 : Form
    {
        //private Bitmap badPhoto = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab14/bad.jpg");
        private Bitmap goodPhoto = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab14/good.jpg");

        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            MakePhoto command = new MakePhoto(receiver);
            invoker.SetCommand(command);
            invoker.Run();
            invoker.SetCommand(command);
            invoker.Run();
            label2.Text = "Попробуй ещё раз!";
            label3.Text = "Фокус настроен.";
            button1.Visible = false;
            button2.Visible = true;
            button2.Text = "Сделать ещё кадр.";
            label1.Text = " ";
            pictureBox1.Image = Image.FromFile("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab14/bad.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            MakePhoto command = new MakePhoto(receiver);
            invoker.SetCommand(command);
            invoker.Run();
            invoker.SetCommand(command);
            invoker.Run();
            label2.Text = "Восхитительно!";
            label3.Text = " ";
            button2.Visible = false;
            pictureBox1.Image = (Image)goodPhoto;
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