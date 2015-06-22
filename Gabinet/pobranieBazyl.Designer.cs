namespace Gabinet
{
    partial class pobranieBazyl
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
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPobierz = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Enabled = false;
            this.textBoxAdres.Location = new System.Drawing.Point(12, 25);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.ReadOnly = true;
            this.textBoxAdres.ShortcutsEnabled = false;
            this.textBoxAdres.Size = new System.Drawing.Size(378, 20);
            this.textBoxAdres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adres:";
            // 
            // buttonPobierz
            // 
            this.buttonPobierz.Location = new System.Drawing.Point(315, 51);
            this.buttonPobierz.Name = "buttonPobierz";
            this.buttonPobierz.Size = new System.Drawing.Size(75, 23);
            this.buttonPobierz.TabIndex = 2;
            this.buttonPobierz.Text = "Pobierz";
            this.buttonPobierz.UseVisualStyleBackColor = true;
            this.buttonPobierz.Click += new System.EventHandler(this.buttonPobierz_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 80);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(378, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // pobranieBazyl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(402, 115);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonPobierz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdres);
            this.Name = "pobranieBazyl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pobieranie plików bazy leków BAZYL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPobierz;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
    }
}