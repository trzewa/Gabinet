namespace Gabinet
{
    partial class edytujOpiekun
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
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBoxOpiekun = new System.Windows.Forms.ComboBox();
            this.textBoxLiczbaOpieka = new System.Windows.Forms.TextBox();
            this.textBoxMailOpieka = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxTelefonOpieka = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonZmien = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.comboBoxOpiekun);
            this.groupBox1.Controls.Add(this.textBoxLiczbaOpieka);
            this.groupBox1.Controls.Add(this.textBoxMailOpieka);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.textBoxTelefonOpieka);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista przypisanych opiekunów";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(108, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 13);
            this.label22.TabIndex = 35;
            this.label22.Text = "Nazwisko i imie";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.Location = new System.Drawing.Point(6, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 13);
            this.label24.TabIndex = 34;
            this.label24.Text = "Ilość opiekunów";
            // 
            // comboBoxOpiekun
            // 
            this.comboBoxOpiekun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxOpiekun.FormattingEnabled = true;
            this.comboBoxOpiekun.Location = new System.Drawing.Point(108, 31);
            this.comboBoxOpiekun.Name = "comboBoxOpiekun";
            this.comboBoxOpiekun.Size = new System.Drawing.Size(311, 21);
            this.comboBoxOpiekun.TabIndex = 33;
            this.comboBoxOpiekun.SelectedIndexChanged += new System.EventHandler(this.comboBoxOpiekun_DropDownClosed);
            // 
            // textBoxLiczbaOpieka
            // 
            this.textBoxLiczbaOpieka.Enabled = false;
            this.textBoxLiczbaOpieka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLiczbaOpieka.Location = new System.Drawing.Point(9, 32);
            this.textBoxLiczbaOpieka.Name = "textBoxLiczbaOpieka";
            this.textBoxLiczbaOpieka.Size = new System.Drawing.Size(28, 20);
            this.textBoxLiczbaOpieka.TabIndex = 32;
            this.textBoxLiczbaOpieka.Text = "0";
            // 
            // textBoxMailOpieka
            // 
            this.textBoxMailOpieka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMailOpieka.Location = new System.Drawing.Point(223, 71);
            this.textBoxMailOpieka.Name = "textBoxMailOpieka";
            this.textBoxMailOpieka.Size = new System.Drawing.Size(196, 20);
            this.textBoxMailOpieka.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(220, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "E-mail";
            // 
            // textBoxTelefonOpieka
            // 
            this.textBoxTelefonOpieka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTelefonOpieka.Location = new System.Drawing.Point(9, 71);
            this.textBoxTelefonOpieka.Name = "textBoxTelefonOpieka";
            this.textBoxTelefonOpieka.Size = new System.Drawing.Size(205, 20);
            this.textBoxTelefonOpieka.TabIndex = 29;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(6, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "Telefon *";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(12, 122);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(187, 23);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj opiekuna";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(372, 151);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 2;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // buttonZmien
            // 
            this.buttonZmien.Location = new System.Drawing.Point(372, 122);
            this.buttonZmien.Name = "buttonZmien";
            this.buttonZmien.Size = new System.Drawing.Size(75, 23);
            this.buttonZmien.TabIndex = 3;
            this.buttonZmien.Text = "Zmień dane";
            this.buttonZmien.UseVisualStyleBackColor = true;
            this.buttonZmien.Click += new System.EventHandler(this.buttonZmien_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(12, 151);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(187, 23);
            this.buttonUsun.TabIndex = 4;
            this.buttonUsun.Text = "Usuń opiekuna";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // edytujOpiekun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 182);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonZmien);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.groupBox1);
            this.Name = "edytujOpiekun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opiekun";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox comboBoxOpiekun;
        private System.Windows.Forms.TextBox textBoxLiczbaOpieka;
        private System.Windows.Forms.TextBox textBoxMailOpieka;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxTelefonOpieka;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonZmien;
        private System.Windows.Forms.Button buttonUsun;
    }
}