using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ZnajdzTekst = textBox1.Text;
            Form1.ZamienTekst = textBox2.Text;
            Form1.C1.Czynnosc1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Form1.matchcase = true;
            }
            else
            {
                Form1.matchcase = false;
            }
            Form1.ZnajdzTekst = textBox1.Text;
            Form1.ZamienTekst = textBox2.Text;
            Form1.C1.znajdźNastępnyToolStripMenuItem_Click(null, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.ZnajdzTekst = textBox1.Text;
            Form1.ZamienTekst = textBox2.Text;
            Form1.C1.ReplaceAll();
        }
    }
}

