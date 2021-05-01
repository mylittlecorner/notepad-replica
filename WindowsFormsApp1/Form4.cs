using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        MultiCast s;
        public Form4(MultiCast f)
        {
            s = f;
            InitializeComponent();
            try
            {
                if (Form1.filepath.FileName != null)
                {
                    label2.Text = Path.GetDirectoryName(Form1.filepath.FileName) + "?";
                }
                else
                {
                    label1.Text = label1.Text + " Bez tytułu?";
                }
            } 
            catch
            {
                label1.Text = label1.Text + " Bez tytułu?";
            }
        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.save = false;
            Form1.changed = false;
            s(null,null);
            Form1.changed = false;
            Form1.save = false;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.save=true;
            Form1.changed = false;
            s(null, null);
            Form1.changed = false;
            Form1.save = true;
            this.Close();
        }
    }
}
