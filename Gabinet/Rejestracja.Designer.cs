namespace Gabinet
{
    partial class Rejestracja
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
            this.toolStripBtnRejestruj = new System.Windows.Forms.ToolStripButton();
            this.toolStripZmien = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnDodaj = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDanePacjent = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewPacjenci = new System.Windows.Forms.DataGridView();
            this.nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpacjent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonZnajdz = new System.Windows.Forms.Button();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacjenci)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnRejestruj,
            this.toolStripZmien,
            this.toolStripSeparator1,
            this.toolStripBtnDodaj,
            this.toolStripBtnDanePacjent});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 80);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnRejestruj
            // 
            this.toolStripBtnRejestruj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnRejestruj.Image = global::Gabinet.Properties.Resources.download_3_icon;
            this.toolStripBtnRejestruj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRejestruj.Name = "toolStripBtnRejestruj";
            this.toolStripBtnRejestruj.Size = new System.Drawing.Size(84, 77);
            this.toolStripBtnRejestruj.Text = "Rejestruj";
            this.toolStripBtnRejestruj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripBtnRejestruj.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripBtnRejestruj.ToolTipText = "Rejestruj";
            this.toolStripBtnRejestruj.Click += new System.EventHandler(this.toolStripBtnRejestruj_Click);
            // 
            // toolStripZmien
            // 
            this.toolStripZmien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripZmien.Image = global::Gabinet.Properties.Resources.pencil_icon;
            this.toolStripZmien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripZmien.Name = "toolStripZmien";
            this.toolStripZmien.Size = new System.Drawing.Size(84, 77);
            this.toolStripZmien.Text = "Zmień termin wizyty";
            this.toolStripZmien.Click += new System.EventHandler(this.toolStripZmien_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 80);
            // 
            // toolStripBtnDodaj
            // 
            this.toolStripBtnDodaj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripBtnDodaj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnDodaj.Image = global::Gabinet.Properties.Resources.addition_icon;
            this.toolStripBtnDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDodaj.Name = "toolStripBtnDodaj";
            this.toolStripBtnDodaj.Size = new System.Drawing.Size(84, 77);
            this.toolStripBtnDodaj.Text = "Dodaj pacjenta";
            this.toolStripBtnDodaj.Click += new System.EventHandler(this.toolStripBtnDodaj_Click);
            // 
            // toolStripBtnDanePacjent
            // 
            this.toolStripBtnDanePacjent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripBtnDanePacjent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnDanePacjent.Image = global::Gabinet.Properties.Resources.info_icon;
            this.toolStripBtnDanePacjent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDanePacjent.Name = "toolStripBtnDanePacjent";
            this.toolStripBtnDanePacjent.Size = new System.Drawing.Size(84, 77);
            this.toolStripBtnDanePacjent.Text = "Informacja o pacjencie";
            this.toolStripBtnDanePacjent.Click += new System.EventHandler(this.toolStripBtnDanePacjent_Click);
            // 
            // dataGridViewPacjenci
            // 
            this.dataGridViewPacjenci.AllowUserToAddRows = false;
            this.dataGridViewPacjenci.AllowUserToDeleteRows = false;
            this.dataGridViewPacjenci.AllowUserToResizeColumns = false;
            this.dataGridViewPacjenci.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPacjenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacjenci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwisko,
            this.imie,
            this.pesel,
            this.telefon,
            this.mail,
            this.idpacjent,
            this.plec});
            this.dataGridViewPacjenci.Location = new System.Drawing.Point(6, 60);
            this.dataGridViewPacjenci.MultiSelect = false;
            this.dataGridViewPacjenci.Name = "dataGridViewPacjenci";
            this.dataGridViewPacjenci.ReadOnly = true;
            this.dataGridViewPacjenci.RowHeadersWidth = 110;
            this.dataGridViewPacjenci.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPacjenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPacjenci.Size = new System.Drawing.Size(813, 262);
            this.dataGridViewPacjenci.TabIndex = 1;
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
            this.pesel.HeaderText = "PESEL";
            this.pesel.Name = "pesel";
            this.pesel.ReadOnly = true;
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            this.telefon.ReadOnly = true;
            this.telefon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // mail
            // 
            this.mail.DataPropertyName = "mail";
            this.mail.HeaderText = "Mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idpacjent
            // 
            this.idpacjent.DataPropertyName = "idpacjent";
            this.idpacjent.HeaderText = "ID pacjenta";
            this.idpacjent.Name = "idpacjent";
            this.idpacjent.ReadOnly = true;
            // 
            // plec
            // 
            this.plec.DataPropertyName = "plec";
            this.plec.HeaderText = "Plec";
            this.plec.Name = "plec";
            this.plec.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonZnajdz);
            this.groupBox1.Controls.Add(this.textBoxPesel);
            this.groupBox1.Controls.Add(this.textBoxNazwisko);
            this.groupBox1.Controls.Add(this.textBoxImie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridViewPacjenci);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 328);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyszukiwanie pacjenta";
            // 
            // buttonZnajdz
            // 
            this.buttonZnajdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZnajdz.Location = new System.Drawing.Point(444, 32);
            this.buttonZnajdz.Name = "buttonZnajdz";
            this.buttonZnajdz.Size = new System.Drawing.Size(75, 23);
            this.buttonZnajdz.TabIndex = 8;
            this.buttonZnajdz.Text = "Znajdz";
            this.buttonZnajdz.UseVisualStyleBackColor = true;
            this.buttonZnajdz.Click += new System.EventHandler(this.buttonZnajdz_Click);
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(298, 34);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(140, 20);
            this.textBoxPesel.TabIndex = 7;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(152, 34);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(140, 20);
            this.textBoxNazwisko.TabIndex = 6;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(6, 34);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(140, 20);
            this.textBoxImie.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(295, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PESEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(149, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Rejestracja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel rejestracja";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacjenci)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnRejestruj;
        private System.Windows.Forms.ToolStripButton toolStripZmien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnDodaj;
        private System.Windows.Forms.DataGridView dataGridViewPacjenci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonZnajdz;
        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpacjent;
        private System.Windows.Forms.DataGridViewTextBoxColumn plec;
        private System.Windows.Forms.ToolStripButton toolStripBtnDanePacjent;
    }
}