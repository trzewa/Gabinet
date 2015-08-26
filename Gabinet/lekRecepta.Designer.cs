namespace Gabinet
{
    partial class LekRecepta
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
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.textBoxPostac = new System.Windows.Forms.TextBox();
            this.textBoxIlosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDawkowanie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxOdplatnosc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxIlosc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonWróć = new System.Windows.Forms.Button();
            this.buttonWypisz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNazwa);
            this.groupBox1.Controls.Add(this.textBoxPostac);
            this.groupBox1.Controls.Add(this.textBoxIlosc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane leku";
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Enabled = false;
            this.textBoxNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNazwa.Location = new System.Drawing.Point(21, 42);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(165, 20);
            this.textBoxNazwa.TabIndex = 1;
            // 
            // textBoxPostac
            // 
            this.textBoxPostac.Enabled = false;
            this.textBoxPostac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPostac.Location = new System.Drawing.Point(192, 42);
            this.textBoxPostac.Name = "textBoxPostac";
            this.textBoxPostac.Size = new System.Drawing.Size(120, 20);
            this.textBoxPostac.TabIndex = 2;
            // 
            // textBoxIlosc
            // 
            this.textBoxIlosc.Enabled = false;
            this.textBoxIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIlosc.Location = new System.Drawing.Point(321, 42);
            this.textBoxIlosc.Name = "textBoxIlosc";
            this.textBoxIlosc.Size = new System.Drawing.Size(116, 20);
            this.textBoxIlosc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(318, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ilość w opakowaniu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(189, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Postać";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDawkowanie);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxOdplatnosc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBoxIlosc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane do recepty";
            // 
            // textBoxDawkowanie
            // 
            this.textBoxDawkowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDawkowanie.Location = new System.Drawing.Point(21, 81);
            this.textBoxDawkowanie.Multiline = true;
            this.textBoxDawkowanie.Name = "textBoxDawkowanie";
            this.textBoxDawkowanie.Size = new System.Drawing.Size(416, 49);
            this.textBoxDawkowanie.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(18, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dawkowanie";
            // 
            // comboBoxOdplatnosc
            // 
            this.comboBoxOdplatnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxOdplatnosc.FormattingEnabled = true;
            this.comboBoxOdplatnosc.Location = new System.Drawing.Point(117, 41);
            this.comboBoxOdplatnosc.Name = "comboBoxOdplatnosc";
            this.comboBoxOdplatnosc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOdplatnosc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(114, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Odpłatność";
            // 
            // comboBoxIlosc
            // 
            this.comboBoxIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxIlosc.FormattingEnabled = true;
            this.comboBoxIlosc.Location = new System.Drawing.Point(21, 41);
            this.comboBoxIlosc.Name = "comboBoxIlosc";
            this.comboBoxIlosc.Size = new System.Drawing.Size(67, 21);
            this.comboBoxIlosc.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(18, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ilość";
            // 
            // buttonWróć
            // 
            this.buttonWróć.Location = new System.Drawing.Point(231, 244);
            this.buttonWróć.Name = "buttonWróć";
            this.buttonWróć.Size = new System.Drawing.Size(143, 23);
            this.buttonWróć.TabIndex = 2;
            this.buttonWróć.Text = "Wróć do wyszukiwania";
            this.buttonWróć.UseVisualStyleBackColor = true;
            this.buttonWróć.Click += new System.EventHandler(this.buttonWróć_Click);
            // 
            // buttonWypisz
            // 
            this.buttonWypisz.Location = new System.Drawing.Point(380, 244);
            this.buttonWypisz.Name = "buttonWypisz";
            this.buttonWypisz.Size = new System.Drawing.Size(75, 23);
            this.buttonWypisz.TabIndex = 3;
            this.buttonWypisz.Text = "Wypisz lek";
            this.buttonWypisz.UseVisualStyleBackColor = true;
            this.buttonWypisz.Click += new System.EventHandler(this.buttonWypisz_Click);
            // 
            // lekRecepta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 279);
            this.Controls.Add(this.buttonWypisz);
            this.Controls.Add(this.buttonWróć);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "lekRecepta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dopisz lek do recepty";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.TextBox textBoxPostac;
        private System.Windows.Forms.TextBox textBoxIlosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDawkowanie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxOdplatnosc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxIlosc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonWróć;
        private System.Windows.Forms.Button buttonWypisz;
    }
}