﻿namespace Gabinet
{
    partial class panelLekarza
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnWizyta = new System.Windows.Forms.ToolStripButton();
            this.groupBoxLekarz = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxImieNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxStanowisko = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewWizyta = new System.Windows.Forms.DataGridView();
            this.godzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGodzOd = new System.Windows.Forms.TextBox();
            this.textBoxGodzDo = new System.Windows.Forms.TextBox();
            this.toolStrip2.SuspendLayout();
            this.groupBoxLekarz.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWizyta)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnWizyta});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(717, 80);
            this.toolStrip2.Stretch = true;
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripBtnWizyta
            // 
            this.toolStripBtnWizyta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnWizyta.Image = global::Gabinet.Properties.Resources.depositphotos_38100335_Stethoscope_icon;
            this.toolStripBtnWizyta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnWizyta.Name = "toolStripBtnWizyta";
            this.toolStripBtnWizyta.Size = new System.Drawing.Size(84, 77);
            this.toolStripBtnWizyta.Text = "Rozpocznij wizyte";
            this.toolStripBtnWizyta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripBtnWizyta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripBtnWizyta.ToolTipText = "Rozpocznij wizyte";
            // 
            // groupBoxLekarz
            // 
            this.groupBoxLekarz.Controls.Add(this.textBoxStanowisko);
            this.groupBoxLekarz.Controls.Add(this.textBoxImieNazwisko);
            this.groupBoxLekarz.Controls.Add(this.label2);
            this.groupBoxLekarz.Controls.Add(this.label1);
            this.groupBoxLekarz.Location = new System.Drawing.Point(12, 83);
            this.groupBoxLekarz.Name = "groupBoxLekarz";
            this.groupBoxLekarz.Size = new System.Drawing.Size(200, 104);
            this.groupBoxLekarz.TabIndex = 2;
            this.groupBoxLekarz.TabStop = false;
            this.groupBoxLekarz.Text = "Dane lekarza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwisko i imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stanowisko";
            // 
            // textBoxImieNazwisko
            // 
            this.textBoxImieNazwisko.Enabled = false;
            this.textBoxImieNazwisko.Location = new System.Drawing.Point(23, 32);
            this.textBoxImieNazwisko.Name = "textBoxImieNazwisko";
            this.textBoxImieNazwisko.Size = new System.Drawing.Size(171, 20);
            this.textBoxImieNazwisko.TabIndex = 2;
            // 
            // textBoxStanowisko
            // 
            this.textBoxStanowisko.Enabled = false;
            this.textBoxStanowisko.Location = new System.Drawing.Point(23, 71);
            this.textBoxStanowisko.Name = "textBoxStanowisko";
            this.textBoxStanowisko.Size = new System.Drawing.Size(171, 20);
            this.textBoxStanowisko.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 205);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kalendarz";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(23, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewWizyta);
            this.groupBox2.Location = new System.Drawing.Point(218, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 395);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista zarejestrowanych pacjentów";
            // 
            // dataGridViewWizyta
            // 
            this.dataGridViewWizyta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewWizyta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWizyta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.godzina,
            this.nazwisko,
            this.imie,
            this.pesel});
            this.dataGridViewWizyta.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewWizyta.Name = "dataGridViewWizyta";
            this.dataGridViewWizyta.Size = new System.Drawing.Size(475, 358);
            this.dataGridViewWizyta.TabIndex = 5;
            // 
            // godzina
            // 
            this.godzina.DataPropertyName = "godzina";
            this.godzina.HeaderText = "Godzina";
            this.godzina.Name = "godzina";
            this.godzina.ReadOnly = true;
            // 
            // nazwisko
            // 
            this.nazwisko.DataPropertyName = "nazwisko";
            this.nazwisko.HeaderText = "Nazwisko pacjenta";
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.ReadOnly = true;
            // 
            // imie
            // 
            this.imie.DataPropertyName = "imie";
            this.imie.HeaderText = "Imie pacjenta";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxGodzDo);
            this.groupBox3.Controls.Add(this.textBoxGodzOd);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 74);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Godziny pracy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Od";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Do";
            // 
            // textBoxGodzOd
            // 
            this.textBoxGodzOd.Enabled = false;
            this.textBoxGodzOd.Location = new System.Drawing.Point(15, 39);
            this.textBoxGodzOd.Name = "textBoxGodzOd";
            this.textBoxGodzOd.Size = new System.Drawing.Size(76, 20);
            this.textBoxGodzOd.TabIndex = 3;
            // 
            // textBoxGodzDo
            // 
            this.textBoxGodzDo.Enabled = false;
            this.textBoxGodzDo.Location = new System.Drawing.Point(111, 39);
            this.textBoxGodzDo.Name = "textBoxGodzDo";
            this.textBoxGodzDo.Size = new System.Drawing.Size(75, 20);
            this.textBoxGodzDo.TabIndex = 4;
            // 
            // panelLekarza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 489);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxLekarz);
            this.Controls.Add(this.toolStrip2);
            this.Name = "panelLekarza";
            this.Text = "Panel lekarza";
            this.Load += new System.EventHandler(this.panelLekarza_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBoxLekarz.ResumeLayout(false);
            this.groupBoxLekarz.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWizyta)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripBtnWizyta;
        private System.Windows.Forms.GroupBox groupBoxLekarz;
        private System.Windows.Forms.TextBox textBoxStanowisko;
        private System.Windows.Forms.TextBox textBoxImieNazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewWizyta;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzina;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxGodzDo;
        private System.Windows.Forms.TextBox textBoxGodzOd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;

    }
}