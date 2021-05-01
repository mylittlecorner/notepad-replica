namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.documentTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzCtrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńDelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.znajdźCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.znajdźNastępnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamieńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przejdźDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.godzinaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zawijanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasekStanuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyświetlPomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notatnikIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // documentTextBox
            // 
            this.documentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentTextBox.Location = new System.Drawing.Point(0, 24);
            this.documentTextBox.Name = "documentTextBox";
            this.documentTextBox.Size = new System.Drawing.Size(800, 426);
            this.documentTextBox.TabIndex = 0;
            this.documentTextBox.Text = "";
            this.documentTextBox.SelectionChanged += new System.EventHandler(this.documentTextBox_SelectionChanged);
            this.documentTextBox.TextChanged += new System.EventHandler(this.documentTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzCtrlToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ustawieniaToolStripMenuItem,
            this.drukujToolStripMenuItem,
            this.toolStripMenuItem2,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            this.plikToolStripMenuItem.Click += new System.EventHandler(this.plikToolStripMenuItem_Click);
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzCtrlToolStripMenuItem
            // 
            this.otwórzCtrlToolStripMenuItem.Name = "otwórzCtrlToolStripMenuItem";
            this.otwórzCtrlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzCtrlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otwórzCtrlToolStripMenuItem.Text = "Otwórz...";
            this.otwórzCtrlToolStripMenuItem.Click += new System.EventHandler(this.otwórzCtrlToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia strony...";
            this.ustawieniaToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaToolStripMenuItem_Click);
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drukujToolStripMenuItem.Text = "Drukuj...";
            this.drukujToolStripMenuItem.Click += new System.EventHandler(this.drukujToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem,
            this.toolStripMenuItem3,
            this.wytnijToolStripMenuItem,
            this.wklejCtrlNToolStripMenuItem,
            this.nowyCtrlNToolStripMenuItem,
            this.usuńDelToolStripMenuItem,
            this.toolStripMenuItem4,
            this.znajdźCtrlNToolStripMenuItem,
            this.znajdźNastępnyToolStripMenuItem,
            this.zamieńToolStripMenuItem,
            this.przejdźDoToolStripMenuItem,
            this.toolStripMenuItem5,
            this.zaznaczWszystkoToolStripMenuItem,
            this.godzinaDataToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            this.edycjaToolStripMenuItem.Click += new System.EventHandler(this.edycjaToolStripMenuItem_Click);
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cofnijToolStripMenuItem.Text = "Cofnij";
            this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(205, 6);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Enabled = false;
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // wklejCtrlNToolStripMenuItem
            // 
            this.wklejCtrlNToolStripMenuItem.Enabled = false;
            this.wklejCtrlNToolStripMenuItem.Name = "wklejCtrlNToolStripMenuItem";
            this.wklejCtrlNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.wklejCtrlNToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.wklejCtrlNToolStripMenuItem.Text = "Kopiuj";
            this.wklejCtrlNToolStripMenuItem.Click += new System.EventHandler(this.wklejCtrlNToolStripMenuItem_Click);
            // 
            // nowyCtrlNToolStripMenuItem
            // 
            this.nowyCtrlNToolStripMenuItem.Name = "nowyCtrlNToolStripMenuItem";
            this.nowyCtrlNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.nowyCtrlNToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.nowyCtrlNToolStripMenuItem.Text = "Wklej";
            this.nowyCtrlNToolStripMenuItem.Click += new System.EventHandler(this.nowyCtrlNToolStripMenuItem_Click);
            // 
            // usuńDelToolStripMenuItem
            // 
            this.usuńDelToolStripMenuItem.Enabled = false;
            this.usuńDelToolStripMenuItem.Name = "usuńDelToolStripMenuItem";
            this.usuńDelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.usuńDelToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.usuńDelToolStripMenuItem.Text = "Usuń";
            this.usuńDelToolStripMenuItem.Click += new System.EventHandler(this.usuńDelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(205, 6);
            // 
            // znajdźCtrlNToolStripMenuItem
            // 
            this.znajdźCtrlNToolStripMenuItem.Enabled = false;
            this.znajdźCtrlNToolStripMenuItem.Name = "znajdźCtrlNToolStripMenuItem";
            this.znajdźCtrlNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.znajdźCtrlNToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.znajdźCtrlNToolStripMenuItem.Text = "Znajdź...";
            this.znajdźCtrlNToolStripMenuItem.Click += new System.EventHandler(this.znajdźCtrlNToolStripMenuItem_Click);
            // 
            // znajdźNastępnyToolStripMenuItem
            // 
            this.znajdźNastępnyToolStripMenuItem.Enabled = false;
            this.znajdźNastępnyToolStripMenuItem.Name = "znajdźNastępnyToolStripMenuItem";
            this.znajdźNastępnyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.znajdźNastępnyToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.znajdźNastępnyToolStripMenuItem.Text = "Znajdź następny";
            this.znajdźNastępnyToolStripMenuItem.Click += new System.EventHandler(this.znajdźNastępnyToolStripMenuItem_Click);
            // 
            // zamieńToolStripMenuItem
            // 
            this.zamieńToolStripMenuItem.Name = "zamieńToolStripMenuItem";
            this.zamieńToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.zamieńToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.zamieńToolStripMenuItem.Text = "Zamień...";
            this.zamieńToolStripMenuItem.Click += new System.EventHandler(this.zamieńToolStripMenuItem_Click);
            // 
            // przejdźDoToolStripMenuItem
            // 
            this.przejdźDoToolStripMenuItem.Enabled = false;
            this.przejdźDoToolStripMenuItem.Name = "przejdźDoToolStripMenuItem";
            this.przejdźDoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.przejdźDoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.przejdźDoToolStripMenuItem.Text = "Przejdź do...";
            this.przejdźDoToolStripMenuItem.Click += new System.EventHandler(this.przejdźDoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(205, 6);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            this.zaznaczWszystkoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
            // 
            // godzinaDataToolStripMenuItem
            // 
            this.godzinaDataToolStripMenuItem.Name = "godzinaDataToolStripMenuItem";
            this.godzinaDataToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.godzinaDataToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.godzinaDataToolStripMenuItem.Text = "Godzina/data";
            this.godzinaDataToolStripMenuItem.Click += new System.EventHandler(this.godzinaDataToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zawijanieToolStripMenuItem,
            this.czcionkaToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // zawijanieToolStripMenuItem
            // 
            this.zawijanieToolStripMenuItem.Checked = true;
            this.zawijanieToolStripMenuItem.CheckOnClick = true;
            this.zawijanieToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zawijanieToolStripMenuItem.Name = "zawijanieToolStripMenuItem";
            this.zawijanieToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zawijanieToolStripMenuItem.Text = "Zawijanie wierszy";
            this.zawijanieToolStripMenuItem.Click += new System.EventHandler(this.zawijanieToolStripMenuItem_Click);
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.czcionkaToolStripMenuItem.Text = "Czcionka...";
            this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasekStanuToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            this.widokToolStripMenuItem.Click += new System.EventHandler(this.widokToolStripMenuItem_Click);
            // 
            // pasekStanuToolStripMenuItem
            // 
            this.pasekStanuToolStripMenuItem.Enabled = false;
            this.pasekStanuToolStripMenuItem.Name = "pasekStanuToolStripMenuItem";
            this.pasekStanuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasekStanuToolStripMenuItem.Text = "Pasek stanu";
            this.pasekStanuToolStripMenuItem.Click += new System.EventHandler(this.pasekStanuToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyświetlPomocToolStripMenuItem,
            this.notatnikIToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // wyświetlPomocToolStripMenuItem
            // 
            this.wyświetlPomocToolStripMenuItem.Name = "wyświetlPomocToolStripMenuItem";
            this.wyświetlPomocToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.wyświetlPomocToolStripMenuItem.Text = "Wyświetl Pomoc";
            this.wyświetlPomocToolStripMenuItem.Click += new System.EventHandler(this.wyświetlPomocToolStripMenuItem_Click);
            // 
            // notatnikIToolStripMenuItem
            // 
            this.notatnikIToolStripMenuItem.Name = "notatnikIToolStripMenuItem";
            this.notatnikIToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.notatnikIToolStripMenuItem.Text = "Notatnik - informacje";
            this.notatnikIToolStripMenuItem.Click += new System.EventHandler(this.notatnikIToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.documentTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notatnik";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzCtrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńDelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem znajdźCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem znajdźNastępnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamieńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przejdźDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem godzinaDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zawijanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasekStanuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyświetlPomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notatnikIToolStripMenuItem;
        public System.Windows.Forms.RichTextBox documentTextBox;
    }
}

