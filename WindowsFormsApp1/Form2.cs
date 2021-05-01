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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0)
            {
                Form1.ZnajdzTekst = textBox1.Text;
            }
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                Form1.matchcase = true;
            }
            else
            {
                Form1.matchcase = false;
            }
            Form1.ZnajdzTekst = textBox1.Text;
            Form1.C1.znajdźNastępnyToolStripMenuItem_Click(null,null);
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length>0)
            {
                button2.Enabled = true;
                
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = !radioButton2.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                Form1.UP = true;
            }
            else
            {
                Form1.UP = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
         protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }

    }
}
