using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var lineCount = Form1.C1.documentTextBox.Lines.Count();
                int lineNumber;
                if (!int.TryParse(textBox1.Text, out lineNumber) || lineNumber < 0)
                {
                    Form1.C1.documentTextBox.Select(0, 0);
                    return;
                }

                int position = Form1.C1.documentTextBox.GetFirstCharIndexFromLine(lineNumber - 1);
                if (position < 0)
                {
                    throw new System.InvalidOperationException("2137");
                }
                else
                {
                    int lineEnd = Form1.C1.documentTextBox.Text.IndexOf(Environment.NewLine, position);
                  
                    if (lineEnd < 0)
                    {
                        lineEnd = Form1.C1.documentTextBox.Text.Length;
                    }
                  
                    Form1.C1.documentTextBox.Select(position, 0);
                    Form1.C1.documentTextBox.ScrollToCaret();
                    Form1.C1.documentTextBox.Focus();
                }
            }
            catch
            {
                string messageBoxText = "Numer wiersza przekracza całkowitą liczbę wierszy";
                string caption = "Notatnik - Przejdź do wiersza";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.None;
                System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }
