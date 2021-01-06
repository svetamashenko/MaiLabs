using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namecode = textBox1.Text;
            string namepr = textBox2.Text;
            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR clr = new CLR();

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);
            label3.Text = (programmer.CreateApplication(ide) + "\n\nСоздание программы завершено успешно.\nПрограммист " + namepr + " создал программу " + namecode + '.');
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        class TextEditor
        {
            public string CreateCode()
            {
                return("Написание кода...\n");
            }
            public string Save()
            {
                return("Сохранение кода...\n");
            }
        }
        class Compiller
        {
            public string Compile()
            {
                return("Компиляция приложения...\n");
            }
        }
        class CLR
        {
            public string Execute()
            {
                return("Выполнение приложения...\n");
            }
            public string Finish()
            {
                return("Завершение работы приложения.");
            }
        }

        class VisualStudioFacade
        {
            TextEditor textEditor;
            Compiller compiller;
            CLR clr;
            public VisualStudioFacade(TextEditor te, Compiller compil, CLR clr)
            {
                this.textEditor = te;
                this.compiller = compil;
                this.clr = clr;
            }
            public string Start()
            {
                return (textEditor.CreateCode() + textEditor.Save() + compiller.Compile() + clr.Execute());
            }
            public string Stop()
            {
                return clr.Finish();
            }
        }

        class Programmer
        {
            public string CreateApplication(VisualStudioFacade facade)
            {
                return (facade.Start() + facade.Stop());
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
