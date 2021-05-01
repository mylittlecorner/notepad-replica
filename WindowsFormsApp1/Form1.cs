using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Drawing.Printing;


namespace WindowsFormsApp1
{
    public delegate void MultiCast(object sender, EventArgs e);
    public partial class Form1 : Form
    {
        public static Form1 C1;
        int startIndex;
        int endIndex;
        int findIndex;
        public static string ZnajdzTekst;
        public static string ZamienTekst;
        Form2 myForm2 = null;
        Form3 myForm3 = null;
        public static Boolean matchcase;
        public static Boolean UP;
        public static Boolean save=true;
        public static Boolean changed=false;
        public static OpenFileDialog filepath;
        MultiCast otworz, nowy, zakoncz,wyjscie;
        Stream myStream;

        public Form1()
        {
            C1 = this;
            InitializeComponent();
            nowy =nowyToolStripMenuItem_Click;
            otworz =otwórzCtrlToolStripMenuItem_Click;
            zakoncz =zakończToolStripMenuItem_Click;
            wyjscie =zakończToolStripMenuItem_Click;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changed == false)
            {
                if (save==false)
                {
                    filepath = null;
                    zapiszToolStripMenuItem_Click(null, null);
                    this.Text = "Bez tytułu — Notatnik";
                    this.documentTextBox.Clear();
                }
                else
                {

                    filepath = null;
                    this.Text = "Bez tytułu — Notatnik";
                    this.documentTextBox.Clear();

                }

            }
            else
            {
                Form4 s = new Form4(nowy)
                { Owner = this };
                s.ShowDialog();
            }
        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wklejCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            documentTextBox.Copy();
        }

        private void otwórzCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changed == false)
            {
                if (save == false)
                {
                    zapiszToolStripMenuItem_Click(null, null);
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    dlg.Multiselect = false;
                    dlg.Title = "Otwieranie";
                    dlg.Filter = "Dokumenty tekstowe|*.txt|Wszystkie pliki|*.*";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        documentTextBox.Text = File.ReadAllText(Path.GetFileName(dlg.FileName));
                        this.Text = dlg.SafeFileName + " — Notatnik";

                    }
                    else
                    {
                        changed = true;
                    }
                    filepath = dlg;
                    filepath.FileName = dlg.FileName;
                }
                else
                {
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    dlg.Multiselect = false;
                    dlg.Title = "Otwieranie";
                    dlg.Filter = "Dokumenty tekstowe|*.txt|Wszystkie pliki|*.*";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        documentTextBox.Text = File.ReadAllText(Path.GetFileName(dlg.FileName));
                        this.Text = dlg.SafeFileName + " — Notatnik";

                    }
                    else
                    {
                        changed = true;
                    }
                    filepath = dlg;
                    filepath.FileName = dlg.FileName;
                }

            }
            else
            {
                Form4 s = new Form4(otworz)
                { Owner = this };
                s.ShowDialog();
            }
        }

        public void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filepath != null)
            {
                    File.WriteAllText(Path.GetFileName(filepath.FileName), documentTextBox.Text);
                changed = false;
            }
            else
            {
                zapiszJakoToolStripMenuItem_Click(null, null);
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changed == false)
            {
                if (save == false)
                {
                    zapiszToolStripMenuItem_Click(null, null);
                    this.Close();
                }
                else
                {
                    this.Close();
                }

            }
            else
            {
                Form4 s = new Form4(zakoncz)
                { Owner = this };
                s.ShowDialog();
            }
            
        }

        private void edycjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            documentTextBox.Cut();
        }

        private void nowyCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            documentTextBox.Paste();
        }

        private void zawijanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (documentTextBox.WordWrap)
            {
                documentTextBox.WordWrap = false;
                zawijanieToolStripMenuItem.Checked = false;
                documentTextBox.ScrollBars = RichTextBoxScrollBars.Both;
                przejdźDoToolStripMenuItem.Enabled = true;
            }
            else
            {
                documentTextBox.WordWrap = true;
                zawijanieToolStripMenuItem.Checked = true;
                documentTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
                przejdźDoToolStripMenuItem.Enabled = false;
            }
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog k = new FontDialog();
            if (k.ShowDialog() == DialogResult.OK)
            {
                documentTextBox.Font = k.Font;
            }
        }

        private void notatnikIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data wykonania: 20.05.2019", "Notatnik - informacje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            documentTextBox.Undo();
        }

        private void znajdźCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myForm2 == null)
            {
                myForm2 = new Form2()
                { Owner = this };
                myForm2.Show(Owner);
            }
            else
            {
                myForm2.Show(Owner);
            }

            if ((ZnajdzTekst != "") && (ZnajdzTekst != null))
            {
                findIndex = documentTextBox.Find(ZnajdzTekst);
            }
        }

        private void documentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (documentTextBox.Text.Length > 0)
            {
                znajdźCtrlNToolStripMenuItem.Enabled = true;
                znajdźNastępnyToolStripMenuItem.Enabled = true;
            }
            else
            {
                znajdźCtrlNToolStripMenuItem.Enabled = false;
                znajdźNastępnyToolStripMenuItem.Enabled = false;
            }
        }

        private void usuńDelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = documentTextBox.SelectionLength;
            documentTextBox.Text = documentTextBox.Text.Remove(documentTextBox.SelectionStart, a);
        }

        public void znajdźNastępnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBoxFinds options = new RichTextBoxFinds();
                if (UP) options |= RichTextBoxFinds.Reverse;
                if (matchcase) options |= RichTextBoxFinds.MatchCase;
                if (UP == false) options |= RichTextBoxFinds.None;

                if ((ZnajdzTekst != "") && (ZnajdzTekst != null))
                {
                    if (UP == true)
                    {
                        if ((options & RichTextBoxFinds.Reverse) == RichTextBoxFinds.Reverse)
                        {
                            startIndex = 0;
                            endIndex = this.documentTextBox.SelectionStart;
                        }
                        else
                        {
                            startIndex = this.documentTextBox.SelectionStart + this.documentTextBox.SelectionLength;
                            endIndex = this.documentTextBox.Text.Length;
                        }
                        findIndex = this.documentTextBox.Find(ZnajdzTekst, startIndex, endIndex, options);
                        documentTextBox.Focus();
                        if (startIndex==endIndex)
                        {
                            throw new System.InvalidOperationException("666");
                        }
                    }
                    else
                    {
                        if ((options & RichTextBoxFinds.None) == RichTextBoxFinds.None)
                        {
                            startIndex = findIndex + 1;
                            endIndex = this.documentTextBox.Text.Length;
                        }
                        findIndex = this.documentTextBox.Find(ZnajdzTekst, startIndex, endIndex, options);
                        documentTextBox.Focus();
                        if (startIndex == endIndex)
                        {
                            throw new System.InvalidOperationException("666");
                        }
                    }



                }
                else
                {
                    znajdźCtrlNToolStripMenuItem_Click(null, null);
                }


            }
            catch
            {
                string message = "Nie można odnaleźć " + '"' + ZnajdzTekst + '"' + '.';
                string caption = "Notatnik";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void przejdźDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 sd = new Form5()
            { Owner = this };
            sd.Show(Owner);
        }

        private void documentTextBox_SelectionChanged(object sender, EventArgs e)
        {
            changed = true;
            if (documentTextBox.SelectedText.Length > 0)
            {
                wytnijToolStripMenuItem.Enabled = true;
                wklejCtrlNToolStripMenuItem.Enabled = true;
                usuńDelToolStripMenuItem.Enabled = true;
            }
            else
            {
                wytnijToolStripMenuItem.Enabled = false;
                wklejCtrlNToolStripMenuItem.Enabled = false;
                usuńDelToolStripMenuItem.Enabled = false;
            }
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            documentTextBox.SelectAll();
        }

        private void godzinaDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            documentTextBox.Text = Convert.ToString(DateTime.Now);
        }

        private void zamieńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((myForm3 == null))
            {
                myForm3 = new Form3()
                { Owner = this };
                myForm3.Show(Owner);
            }
            else
            {
                myForm3.Show(Owner);
            }
        }

        private void widokToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (changed == false)
            {
                if (save == false)
                {
                    zapiszToolStripMenuItem_Click(null, null);
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = false;
                }

            }
            else
            {
                e.Cancel = true;
                Form4 s = new Form4(zakoncz)
                { Owner = this };
                s.ShowDialog();
            }
            
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog pgSetup = new PageSetupDialog();
            pgSetup.PageSettings = new System.Drawing.Printing.PageSettings();
            pgSetup.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            pgSetup.ShowNetwork = false;

            pgSetup.ShowDialog();

        }

        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void wyświetlPomocToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Process.Start("https://pl.wikipedia.org/wiki/Specjalna:Losowa_strona");
        }

        private void pasekStanuToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        public void Czynnosc1()
        {
            try
            {
                {
                    documentTextBox.Text = documentTextBox.Text.Remove(findIndex, ZnajdzTekst.Length);
                    documentTextBox.Text = documentTextBox.Text.Insert(findIndex, ZamienTekst);
                    znajdźNastępnyToolStripMenuItem_Click(null, null);
                    documentTextBox.Focus();
                }
            }
            catch 
            {
                string message = "Nie można odnaleźć " + '"' + ZnajdzTekst + '"' + '.';
                string caption = "Notatnik";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
        public void ReplaceAll()
        {
            int i = 0;
            int a = ZamienTekst.Length - ZnajdzTekst.Length;
            foreach (Match m in Regex.Matches(documentTextBox.Text, ZnajdzTekst))
            {
                documentTextBox.Select(m.Index + i, ZnajdzTekst.Length);
                i += a;
                documentTextBox.SelectedText = ZamienTekst;
            }
            documentTextBox.Focus();
        }

        public void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Zapisywanie jako";
            saveFileDialog1.Filter = "Dokumenty tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                  File.WriteAllText(Path.GetFileName(saveFileDialog1.FileName), documentTextBox.Text);
                    if (filepath == null)
                    {
                        OpenFileDialog dlg = new OpenFileDialog();
                        dlg.FileName = saveFileDialog1.FileName;
                        filepath = dlg;
                        filepath.FileName = dlg.FileName;
                        this.Text = dlg.SafeFileName + " — Notatnik";
                    }
                    else
                    {
                        filepath.FileName = saveFileDialog1.FileName;
                        this.Text = filepath.SafeFileName + " — Notatnik";
                    }
                }
                


            }
        }
    }
}
