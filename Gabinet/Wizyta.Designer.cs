namespace Gabinet
{
    partial class Wizyta
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
            this.labelNazwiskoImie = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.icd10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSzukajChoroby = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSzukajProcedury = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonZakoncz = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonRecepta = new System.Windows.Forms.Button();
            this.buttonZwolnienie = new System.Windows.Forms.Button();
            this.buttonSkierowanie = new System.Windows.Forms.Button();
            this.linkLabelMail = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.linkLabelMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelTelefon);
            this.groupBox1.Controls.Add(this.labelAdres);
            this.groupBox1.Controls.Add(this.labelNazwiskoImie);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane pacjenta";
            // 
            // labelNazwiskoImie
            // 
            this.labelNazwiskoImie.AutoSize = true;
            this.labelNazwiskoImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwiskoImie.Location = new System.Drawing.Point(22, 18);
            this.labelNazwiskoImie.Name = "labelNazwiskoImie";
            this.labelNazwiskoImie.Size = new System.Drawing.Size(13, 13);
            this.labelNazwiskoImie.TabIndex = 1;
            this.labelNazwiskoImie.Text = "1";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdres.Location = new System.Drawing.Point(22, 44);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(13, 13);
            this.labelAdres.TabIndex = 5;
            this.labelAdres.Text = "2";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTelefon.Location = new System.Drawing.Point(161, 67);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(13, 13);
            this.labelTelefon.TabIndex = 9;
            this.labelTelefon.Text = "5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSzukajChoroby);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 187);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rozpoznanie";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.icd10,
            this.nazwa});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.Location = new System.Drawing.Point(6, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(236, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // icd10
            // 
            this.icd10.Text = "Kod ICD-10";
            this.icd10.Width = 75;
            // 
            // nazwa
            // 
            this.nazwa.Text = "Nazwa choroby";
            this.nazwa.Width = 154;
            // 
            // buttonSzukajChoroby
            // 
            this.buttonSzukajChoroby.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSzukajChoroby.Location = new System.Drawing.Point(72, 16);
            this.buttonSzukajChoroby.Name = "buttonSzukajChoroby";
            this.buttonSzukajChoroby.Size = new System.Drawing.Size(110, 23);
            this.buttonSzukajChoroby.TabIndex = 11;
            this.buttonSzukajChoroby.Text = "Szukaj choroby";
            this.buttonSzukajChoroby.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(266, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 187);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wywiad";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 162);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.buttonSzukajProcedury);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(272, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(445, 99);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Badanie";
            // 
            // buttonSzukajProcedury
            // 
            this.buttonSzukajProcedury.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSzukajProcedury.Location = new System.Drawing.Point(98, 18);
            this.buttonSzukajProcedury.Name = "buttonSzukajProcedury";
            this.buttonSzukajProcedury.Size = new System.Drawing.Size(126, 23);
            this.buttonSzukajProcedury.TabIndex = 0;
            this.buttonSzukajProcedury.Text = "Szukaj procedury";
            this.buttonSzukajProcedury.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kod ICD-9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(116, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Typ badania";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(6, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(98, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(341, 20);
            this.textBox3.TabIndex = 14;
            // 
            // buttonZakoncz
            // 
            this.buttonZakoncz.Location = new System.Drawing.Point(561, 337);
            this.buttonZakoncz.Name = "buttonZakoncz";
            this.buttonZakoncz.Size = new System.Drawing.Size(75, 23);
            this.buttonZakoncz.TabIndex = 13;
            this.buttonZakoncz.Text = "Zakończ";
            this.buttonZakoncz.UseVisualStyleBackColor = true;
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(642, 337);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 14;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonSkierowanie);
            this.groupBox5.Controls.Add(this.buttonZwolnienie);
            this.groupBox5.Controls.Add(this.buttonRecepta);
            this.groupBox5.Location = new System.Drawing.Point(12, 318);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 51);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dokumenty";
            // 
            // buttonRecepta
            // 
            this.buttonRecepta.Location = new System.Drawing.Point(6, 19);
            this.buttonRecepta.Name = "buttonRecepta";
            this.buttonRecepta.Size = new System.Drawing.Size(75, 23);
            this.buttonRecepta.TabIndex = 0;
            this.buttonRecepta.Text = "Recepta";
            this.buttonRecepta.UseVisualStyleBackColor = true;
            // 
            // buttonZwolnienie
            // 
            this.buttonZwolnienie.Location = new System.Drawing.Point(87, 19);
            this.buttonZwolnienie.Name = "buttonZwolnienie";
            this.buttonZwolnienie.Size = new System.Drawing.Size(75, 23);
            this.buttonZwolnienie.TabIndex = 1;
            this.buttonZwolnienie.Text = "Zwolnienie";
            this.buttonZwolnienie.UseVisualStyleBackColor = true;
            // 
            // buttonSkierowanie
            // 
            this.buttonSkierowanie.Location = new System.Drawing.Point(168, 19);
            this.buttonSkierowanie.Name = "buttonSkierowanie";
            this.buttonSkierowanie.Size = new System.Drawing.Size(75, 23);
            this.buttonSkierowanie.TabIndex = 2;
            this.buttonSkierowanie.Text = "Skierowanie";
            this.buttonSkierowanie.UseVisualStyleBackColor = true;
            // 
            // linkLabelMail
            // 
            this.linkLabelMail.AutoSize = true;
            this.linkLabelMail.Location = new System.Drawing.Point(57, 67);
            this.linkLabelMail.Name = "linkLabelMail";
            this.linkLabelMail.Size = new System.Drawing.Size(14, 13);
            this.linkLabelMail.TabIndex = 10;
            this.linkLabelMail.TabStop = true;
            this.linkLabelMail.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(127, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tel.:";
            // 
            // Wizyta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 375);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonZakoncz);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Wizyta";
            this.Text = "Wizyta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelNazwiskoImie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSzukajChoroby;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader icd10;
        private System.Windows.Forms.ColumnHeader nazwa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSzukajProcedury;
        private System.Windows.Forms.Button buttonZakoncz;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonSkierowanie;
        private System.Windows.Forms.Button buttonZwolnienie;
        private System.Windows.Forms.Button buttonRecepta;
        private System.Windows.Forms.LinkLabel linkLabelMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

    }
}