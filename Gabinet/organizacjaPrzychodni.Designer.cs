namespace Gabinet
{
    partial class OrganizacjaPrzychodni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodaj = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdytuj = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHarmonogram = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBazyl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPracownicy = new System.Windows.Forms.DataGridView();
            this.nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPracownicy)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodaj,
            this.toolStripButtonEdytuj,
            this.toolStripButtonHarmonogram,
            this.toolStripButton1,
            this.toolStripButtonBazyl,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(701, 80);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonDodaj
            // 
            this.toolStripButtonDodaj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDodaj.Image = global::Gabinet.Properties.Resources.addition_icon1;
            this.toolStripButtonDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodaj.Name = "toolStripButtonDodaj";
            this.toolStripButtonDodaj.Size = new System.Drawing.Size(84, 77);
            this.toolStripButtonDodaj.Text = "Dodaj pracownika";
            this.toolStripButtonDodaj.Click += new System.EventHandler(this.toolStripButtonDodaj_Click);
            // 
            // toolStripButtonEdytuj
            // 
            this.toolStripButtonEdytuj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdytuj.Image = global::Gabinet.Properties.Resources.pencil_icon;
            this.toolStripButtonEdytuj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdytuj.Name = "toolStripButtonEdytuj";
            this.toolStripButtonEdytuj.Size = new System.Drawing.Size(84, 77);
            this.toolStripButtonEdytuj.Text = "Edytuj dane pracownika";
            this.toolStripButtonEdytuj.Click += new System.EventHandler(this.toolStripButtonEdytuj_Click);
            // 
            // toolStripButtonHarmonogram
            // 
            this.toolStripButtonHarmonogram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHarmonogram.Image = global::Gabinet.Properties.Resources.clock_icon;
            this.toolStripButtonHarmonogram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHarmonogram.Name = "toolStripButtonHarmonogram";
            this.toolStripButtonHarmonogram.Size = new System.Drawing.Size(84, 77);
            this.toolStripButtonHarmonogram.Text = "Ustaw harmonogram pracownika";
            this.toolStripButtonHarmonogram.Click += new System.EventHandler(this.toolStripButtonHarmonogram_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Gabinet.Properties.Resources.share_2_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(84, 77);
            this.toolStripButton1.Text = "Konfiguracja serwera";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonBazyl
            // 
            this.toolStripButtonBazyl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonBazyl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBazyl.Image = global::Gabinet.Properties.Resources.download_icon;
            this.toolStripButtonBazyl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBazyl.Name = "toolStripButtonBazyl";
            this.toolStripButtonBazyl.Size = new System.Drawing.Size(84, 77);
            this.toolStripButtonBazyl.Text = "Pobranie pliku bazy leków BAZYL";
            this.toolStripButtonBazyl.Click += new System.EventHandler(this.toolStripButtonBazyl_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 80);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Gabinet.Properties.Resources.heart_plus_icon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(84, 77);
            this.toolStripButton2.Text = "Dodanie / Edycja danych przychodni";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 80);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Gabinet.Properties.Resources.note_icon;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(84, 77);
            this.toolStripButton3.Text = "Import kodów recept";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Gabinet.Properties.Resources.download_3_icon1;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(84, 77);
            this.toolStripButton4.Text = "Backup bazy";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewPracownicy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(55, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 263);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pracownicy przychodni";
            // 
            // dataGridViewPracownicy
            // 
            this.dataGridViewPracownicy.AllowUserToAddRows = false;
            this.dataGridViewPracownicy.AllowUserToDeleteRows = false;
            this.dataGridViewPracownicy.AllowUserToResizeRows = false;
            this.dataGridViewPracownicy.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPracownicy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwisko,
            this.imie,
            this.pesel,
            this.rola,
            this.id});
            this.dataGridViewPracownicy.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewPracownicy.MultiSelect = false;
            this.dataGridViewPracownicy.Name = "dataGridViewPracownicy";
            this.dataGridViewPracownicy.ReadOnly = true;
            this.dataGridViewPracownicy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPracownicy.Size = new System.Drawing.Size(564, 238);
            this.dataGridViewPracownicy.TabIndex = 2;
            // 
            // nazwisko
            // 
            this.nazwisko.DataPropertyName = "nazwisko";
            this.nazwisko.HeaderText = "Nazwisko";
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.ReadOnly = true;
            // 
            // imie
            // 
            this.imie.DataPropertyName = "imie";
            this.imie.HeaderText = "Imie";
            this.imie.Name = "imie";
            this.imie.ReadOnly = true;
            // 
            // pesel
            // 
            this.pesel.DataPropertyName = "pesel";
            this.pesel.HeaderText = "Pesel";
            this.pesel.Name = "pesel";
            this.pesel.ReadOnly = true;
            // 
            // rola
            // 
            this.rola.DataPropertyName = "nazwa";
            this.rola.HeaderText = "Rola";
            this.rola.Name = "rola";
            this.rola.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "idpracownik";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // OrganizacjaPrzychodni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(701, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "OrganizacjaPrzychodni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarządzanie przychodnią";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPracownicy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewPracownicy;
        private System.Windows.Forms.ToolStripButton toolStripButtonHarmonogram;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn rola;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdytuj;
        private System.Windows.Forms.ToolStripButton toolStripButtonBazyl;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}