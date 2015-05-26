namespace Gabinet
{
    partial class organizacjaPrzychodni
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPracownicy = new System.Windows.Forms.DataGridView();
            this.nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButtonDodaj = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHarmonogram = new System.Windows.Forms.ToolStripButton();
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
            this.toolStripButtonHarmonogram});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(596, 80);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewPracownicy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 263);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pracownicy przychodni";
            // 
            // dataGridViewPracownicy
            // 
            this.dataGridViewPracownicy.AllowUserToAddRows = false;
            this.dataGridViewPracownicy.AllowUserToDeleteRows = false;
            this.dataGridViewPracownicy.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPracownicy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwisko,
            this.imie,
            this.pesel,
            this.rola,
            this.id});
            this.dataGridViewPracownicy.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewPracownicy.Name = "dataGridViewPracownicy";
            this.dataGridViewPracownicy.ReadOnly = true;
            this.dataGridViewPracownicy.Size = new System.Drawing.Size(556, 238);
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
            // organizacjaPrzychodni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "organizacjaPrzychodni";
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
    }
}