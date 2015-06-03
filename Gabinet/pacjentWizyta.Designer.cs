namespace Gabinet
{
    partial class pacjentWizyta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewWizyty = new System.Windows.Forms.DataGridView();
            this.dzien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonZmien = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWizyty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewWizyty);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista terminów pacjenta";
            // 
            // dataGridViewWizyty
            // 
            this.dataGridViewWizyty.AllowUserToAddRows = false;
            this.dataGridViewWizyty.AllowUserToDeleteRows = false;
            this.dataGridViewWizyty.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewWizyty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWizyty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dzien,
            this.godzina,
            this.lekarz,
            this.imie,
            this.idw,
            this.idp});
            this.dataGridViewWizyty.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewWizyty.MultiSelect = false;
            this.dataGridViewWizyty.Name = "dataGridViewWizyty";
            this.dataGridViewWizyty.ReadOnly = true;
            this.dataGridViewWizyty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWizyty.Size = new System.Drawing.Size(466, 195);
            this.dataGridViewWizyty.TabIndex = 0;
            // 
            // dzien
            // 
            this.dzien.DataPropertyName = "data";
            this.dzien.HeaderText = "Dzień";
            this.dzien.Name = "dzien";
            this.dzien.ReadOnly = true;
            // 
            // godzina
            // 
            this.godzina.DataPropertyName = "godzina";
            this.godzina.HeaderText = "Godzina";
            this.godzina.Name = "godzina";
            this.godzina.ReadOnly = true;
            // 
            // lekarz
            // 
            this.lekarz.DataPropertyName = "nazwisko";
            this.lekarz.HeaderText = "Nazwisko lekarza";
            this.lekarz.Name = "lekarz";
            this.lekarz.ReadOnly = true;
            this.lekarz.Width = 120;
            // 
            // imie
            // 
            this.imie.DataPropertyName = "imie";
            this.imie.HeaderText = "Imie lekarza";
            this.imie.Name = "imie";
            this.imie.ReadOnly = true;
            // 
            // idw
            // 
            this.idw.DataPropertyName = "idwizyta";
            this.idw.HeaderText = "IDW";
            this.idw.Name = "idw";
            this.idw.ReadOnly = true;
            this.idw.Visible = false;
            // 
            // idp
            // 
            this.idp.DataPropertyName = "idpracownik";
            this.idp.HeaderText = "IDP";
            this.idp.Name = "idp";
            this.idp.ReadOnly = true;
            this.idp.Visible = false;
            // 
            // buttonZmien
            // 
            this.buttonZmien.Location = new System.Drawing.Point(415, 244);
            this.buttonZmien.Name = "buttonZmien";
            this.buttonZmien.Size = new System.Drawing.Size(75, 23);
            this.buttonZmien.TabIndex = 1;
            this.buttonZmien.Text = "Zmień";
            this.buttonZmien.UseVisualStyleBackColor = true;
            this.buttonZmien.Click += new System.EventHandler(this.buttonZmien_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(334, 244);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 23);
            this.buttonUsun.TabIndex = 2;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.button1_Click);
            // 
            // pacjentWizyta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 275);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonZmien);
            this.Controls.Add(this.groupBox1);
            this.Name = "pacjentWizyta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edycja terminu wizyty";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWizyty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewWizyty;
        private System.Windows.Forms.Button buttonZmien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dzien;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzina;
        private System.Windows.Forms.DataGridViewTextBoxColumn lekarz;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn idw;
        private System.Windows.Forms.DataGridViewTextBoxColumn idp;
        private System.Windows.Forms.Button buttonUsun;
    }
}