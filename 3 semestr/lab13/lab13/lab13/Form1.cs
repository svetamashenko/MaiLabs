using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab13
{
    public partial class Form1 : Form
    {
        private Bitmap kpImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab13/kp.jpg");
        private Bitmap tgImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab13/tg.jpeg");
        private Bitmap obImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab13/ob.jpg");
        private Bitmap mcImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab13/mc.jpg");
        private Bitmap btImage = new Bitmap("C:/Users/UltraUser/Программирование/MaiLabs/3 semestr/lab13/bt.jpg");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = Convert.ToInt32(textBox1.Text);
            Tickets ticket = CheckPossibilities(money);

            TicketHandler tgTicketHandler = new mcTicketHandler();
            TicketHandler obTicketHandler = new obTicketHandler();
            TicketHandler mcTicketHandler = new tgTicketHandler();
            TicketHandler btTicketHandler = new btTicketHandler();
            obTicketHandler.Successor = tgTicketHandler;
            mcTicketHandler.Successor = obTicketHandler;
            btTicketHandler.Successor = mcTicketHandler;

            label1.Text = "Советуем Вам посетить в Москве:";
            int switcher = btTicketHandler.Handle(ticket);
            switch (switcher)
            {
                case 0:
                    pictureBox1.Image = (Image)kpImage;
                    break;
                case 1:
                    pictureBox1.Image = (Image)tgImage;
                    break;
                case 2:
                    pictureBox1.Image = (Image)obImage;
                    break;
                case 3:
                    pictureBox1.Image = (Image)mcImage;
                    break;
                case 4:
                    pictureBox1.Image = (Image)btImage;
                    break;
                default:
                    MessageBox.Show("Ошибка в 63 строке Forms.cs", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
