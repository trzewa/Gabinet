﻿namespace Gabinet
{
    partial class rejestracjaPacjenta
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
            this.textBoxDanePacjenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxDaneLekarza = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTerminarz = new System.Windows.Forms.DataGridView();
            this.Godzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pacjent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listViewGodziny = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTerminarz)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDanePacjenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacjent";
            // 
            // textBoxDanePacjenta
            // 
            this.textBoxDanePacjenta.Enabled = false;
            this.textBoxDanePacjenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDanePacjenta.Location = new System.Drawing.Point(9, 32);
            this.textBoxDanePacjenta.Name = "textBoxDanePacjenta";
            this.textBoxDanePacjenta.Size = new System.Drawing.Size(185, 20);
            this.textBoxDanePacjenta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwisko i Imie";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxDaneLekarza);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 67);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lekarz";
            // 
            // comboBoxDaneLekarza
            // 
            this.comboBoxDaneLekarza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxDaneLekarza.Location = new System.Drawing.Point(9, 32);
            this.comboBoxDaneLekarza.Name = "comboBoxDaneLekarza";
            this.comboBoxDaneLekarza.Size = new System.Drawing.Size(185, 21);
            this.comboBoxDaneLekarza.TabIndex = 0;
            this.comboBoxDaneLekarza.SelectedIndexChanged += new System.EventHandler(this.comboBoxDaneLekarza_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko i Imie";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.monthCalendar1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(12, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 200);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Harmonogram";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewTerminarz);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(218, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(474, 342);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ustalone wizyty";
            // 
            // dataGridViewTerminarz
            // 
            this.dataGridViewTerminarz.AllowUserToDeleteRows = false;
            this.dataGridViewTerminarz.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewTerminarz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTerminarz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Godzina,
            this.Pacjent,
            this.imie,
            this.Pesel});
            this.dataGridViewTerminarz.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewTerminarz.Name = "dataGridViewTerminarz";
            this.dataGridViewTerminarz.ReadOnly = true;
            this.dataGridViewTerminarz.Size = new System.Drawing.Size(454, 320);
            this.dataGridViewTerminarz.TabIndex = 1;
            // 
            // Godzina
            // 
            this.Godzina.DataPropertyName = "data";
            this.Godzina.HeaderText = "Termin";
            this.Godzina.Name = "Godzina";
            this.Godzina.ReadOnly = true;
            // 
            // Pacjent
            // 
            this.Pacjent.DataPropertyName = "nazwisko";
            this.Pacjent.HeaderText = "Nazwisko pacjenta";
            this.Pacjent.Name = "Pacjent";
            this.Pacjent.ReadOnly = true;
            // 
            // imie
            // 
            this.imie.DataPropertyName = "imie";
            this.imie.HeaderText = "Imie pacjenta";
            this.imie.Name = "imie";
            this.imie.ReadOnly = true;
            // 
            // Pesel
            // 
            this.Pesel.DataPropertyName = "pesel";
            this.Pesel.HeaderText = "PESEL";
            this.Pesel.Name = "Pesel";
            this.Pesel.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listViewGodziny);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(713, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(122, 342);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dostępne godziny";
            // 
            // listViewGodziny
            // 
            this.listViewGodziny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewGodziny.GridLines = true;
            this.listViewGodziny.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewGodziny.Location = new System.Drawing.Point(6, 16);
            this.listViewGodziny.Name = "listViewGodziny";
            this.listViewGodziny.Size = new System.Drawing.Size(110, 320);
            this.listViewGodziny.TabIndex = 0;
            this.listViewGodziny.UseCompatibleStateImageBehavior = false;
            this.listViewGodziny.View = System.Windows.Forms.View.SmallIcon;
            // 
            // rejestracjaPacjenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 366);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "rejestracjaPacjenta";
            this.Text = "Rejestracja pacjenta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTerminarz)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDanePacjenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxDaneLekarza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewTerminarz;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listViewGodziny;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godzina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pacjent;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pesel;
    }
}