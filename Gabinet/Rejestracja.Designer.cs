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
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnRejestruj,
            this.toolStripZmien,
            this.toolStripSeparator1,
            this.toolStripBtnDodaj});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(689, 80);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnRejestruj
            // 
            this.toolStripBtnRejestruj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnRejestruj.Image = global::Gabinet.Properties.Resources.rejestruj2;
            this.toolStripBtnRejestruj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRejestruj.Name = "toolStripBtnRejestruj";
            this.toolStripBtnRejestruj.Size = new System.Drawing.Size(84, 77);
            this.toolStripBtnRejestruj.Text = "Rejestruj";
            this.toolStripBtnRejestruj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripBtnRejestruj.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripBtnRejestruj.ToolTipText = "Rejestruj";
            // 
            // toolStripZmien
            // 
            this.toolStripZmien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripZmien.Image = global::Gabinet.Properties.Resources.zmień;
            this.toolStripZmien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripZmien.Name = "toolStripZmien";
            this.toolStripZmien.Size = new System.Drawing.Size(84, 77);
            this.toolStripZmien.Text = "Zmień termin wizyty";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 80);
            // 
            // toolStripBtnDodaj
            // 
            this.toolStripBtnDodaj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnDodaj.Image = global::Gabinet.Properties.Resources.dodajpacjenta;
            this.toolStripBtnDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDodaj.Name = "toolStripBtnDodaj";
            this.toolStripBtnDodaj.Size = new System.Drawing.Size(84, 77);
            this.toolStripBtnDodaj.Text = "Dodaj pacjenta";
            this.toolStripBtnDodaj.Click += new System.EventHandler(this.toolStripBtnDodaj_Click);
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 565);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Rejestracja";
            this.Text = "Rejestracja";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnRejestruj;
        private System.Windows.Forms.ToolStripButton toolStripZmien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnDodaj;
    }
}