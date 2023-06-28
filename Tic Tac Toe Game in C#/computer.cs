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
    public partial class computer : Form
    {
        public computer()
        {
            InitializeComponent();
        }
        public static string Player1;
        public static string Player2;

        private void button1_Click(object sender, EventArgs e)
        {
            Player1 = textBox1.Text;
            Player2 = textBox2.Text;
            computer form2 = new computer();
            form2.Close();
            Form3 form1 = new Form3();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            this.Hide();
        }

        private void computer_Load(object sender, EventArgs e)
        {

        }
    }
}
