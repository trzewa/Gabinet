namespace Gabinet
{
    partial class szukajProcedury
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.buttonSzukaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewChoroba = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwachoroby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idchoroby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewProcedury = new System.Windows.Forms.DataGridView();
            this.kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtypbadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonWybierz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoroba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedury)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa";
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(46, 25);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(251, 20);
            this.textBoxNazwa.TabIndex = 1;
            // 
            // buttonSzukaj
            // 
            this.buttonSzukaj.Location = new System.Drawing.Point(303, 23);
            this.buttonSzukaj.Name = "buttonSzukaj";
            this.buttonSzukaj.Size = new System.Drawing.Size(75, 23);
            this.buttonSzukaj.TabIndex = 2;
            this.buttonSzukaj.Text = "Szukaj";
            this.buttonSzukaj.UseVisualStyleBackColor = true;
            this.buttonSzukaj.Click += new System.EventHandler(this.buttonSzukaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewChoroba);
            this.groupBox1.Controls.Add(this.dataGridViewProcedury);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 283);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyniki wyszukiwania";
            // 
            // dataGridViewChoroba
            // 
            this.dataGridViewChoroba.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewChoroba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChoroba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nazwachoroby,
            this.idchoroby});
            this.dataGridViewChoroba.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewChoroba.MultiSelect = false;
            this.dataGridViewChoroba.Name = "dataGridViewChoroba";
            this.dataGridViewChoroba.Size = new System.Drawing.Size(367, 258);
            this.dataGridViewChoroba.TabIndex = 4;
            // 
            // id
            // 
            this.id.DataPropertyName = "kod_mkch";
            this.id.HeaderText = "Kod ICD-10";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 70;
            // 
            // nazwachoroby
            // 
            this.nazwachoroby.DataPropertyName = "nazwa_choroby";
            this.nazwachoroby.HeaderText = "Nazwa choroby";
            this.nazwachoroby.Name = "nazwachoroby";
            this.nazwachoroby.ReadOnly = true;
            this.nazwachoroby.Width = 250;
            // 
            // idchoroby
            // 
            this.idchoroby.DataPropertyName = "idchoroby";
            this.idchoroby.HeaderText = "Column1";
            this.idchoroby.Name = "idchoroby";
            this.idchoroby.ReadOnly = true;
            this.idchoroby.Visible = false;
            // 
            // dataGridViewProcedury
            // 
            this.dataGridViewProcedury.AllowUserToAddRows = false;
            this.dataGridViewProcedury.AllowUserToDeleteRows = false;
            this.dataGridViewProcedury.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProcedury.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcedury.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kod,
            this.nazwa,
            this.idtypbadania});
            this.dataGridViewProcedury.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewProcedury.MultiSelect = false;
            this.dataGridViewProcedury.Name = "dataGridViewProcedury";
            this.dataGridViewProcedury.ReadOnly = true;
            this.dataGridViewProcedury.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcedury.Size = new System.Drawing.Size(367, 258);
            this.dataGridViewProcedury.TabIndex = 0;
            // 
            // kod
            // 
            this.kod.DataPropertyName = "kod_badania";
            this.kod.HeaderText = "Kod ICD-9";
            this.kod.Name = "kod";
            this.kod.ReadOnly = true;
            this.kod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kod.Width = 70;
            // 
            // nazwa
            // 
            this.nazwa.DataPropertyName = "nazwa_badania";
            this.nazwa.HeaderText = "Nazwa procedury";
            this.nazwa.Name = "nazwa";
            this.nazwa.ReadOnly = true;
            this.nazwa.Width = 250;
            // 
            // idtypbadania
            // 
            this.idtypbadania.DataPropertyName = "idtyp_badania";
            this.idtypbadania.HeaderText = "Column1";
            this.idtypbadania.Name = "idtypbadania";
            this.idtypbadania.ReadOnly = true;
            this.idtypbadania.Visible = false;
            // 
            // buttonWybierz
            // 
            this.buttonWybierz.Location = new System.Drawing.Point(303, 340);
            this.buttonWybierz.Name = "buttonWybierz";
            this.buttonWybierz.Size = new System.Drawing.Size(75, 23);
            this.buttonWybierz.TabIndex = 1;
            this.buttonWybierz.Text = "Wybierz";
            this.buttonWybierz.UseVisualStyleBackColor = true;
            this.buttonWybierz.Click += new System.EventHandler(this.buttonWybierz_Click);
            // 
            // szukajProcedury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 367);
            this.Controls.Add(this.buttonWybierz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSzukaj);
            this.Controls.Add(this.textBoxNazwa);
            this.Controls.Add(this.label1);
            this.Name = "szukajProcedury";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wyszukiwanie";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoroba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedury)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.Button buttonSzukaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewProcedury;
        private System.Windows.Forms.Button buttonWybierz;
        private System.Windows.Forms.DataGridView dataGridViewChoroba;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtypbadania;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwachoroby;
        private System.Windows.Forms.DataGridViewTextBoxColumn idchoroby;
    }
}