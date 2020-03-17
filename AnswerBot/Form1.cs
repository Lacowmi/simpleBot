using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnswerBot
{
    public partial class Form1 : Form
    {
        Bot bot = new Bot();

        public Form1()
        {
            InitializeComponent();
            textBox1.Text += "Bot: Привет,чем могу помочь?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addMessage();
        }

        private void addMessage()
        {
            if(String.IsNullOrWhiteSpace(textBox2.Text) != true && bot.answer(textBox2.Text) != "")
            {
                textBox1.Text += "\r\nUser: " + textBox2.Text;
                textBox1.Text += "\r\n" + bot.answer(textBox2.Text);
            }
            else if(String.IsNullOrWhiteSpace(textBox2.Text) != true)
            {
                textBox1.Text += "\r\nUser: " + textBox2.Text;
                textBox1.Text += "\r\nBot: Я не совсем Вас понимаю!";
            }
            textBox2.Text = "";
        }
    }
}
