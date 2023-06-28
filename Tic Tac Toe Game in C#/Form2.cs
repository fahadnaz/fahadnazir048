using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
        public static string Player1;
        public static string Player2;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Player1 = textBox1.Text;
            Player2 = textBox2.Text;
            Form2 form2 = new Form2();
            form2.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void TITLE_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
