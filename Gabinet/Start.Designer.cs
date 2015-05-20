namespace Gabinet
{
    partial class Start
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnZakoncz = new System.Windows.Forms.Button();
            this.btnKonfiguracja = new System.Windows.Forms.Button();
            this.btnRejestracja = new System.Windows.Forms.Button();
            this.btnGabinet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZakoncz
            // 
            this.btnZakoncz.BackgroundImage = global::Gabinet.Properties.Resources.x;
            this.btnZakoncz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZakoncz.Location = new System.Drawing.Point(497, 188);
            this.btnZakoncz.Name = "btnZakoncz";
            this.btnZakoncz.Size = new System.Drawing.Size(39, 37);
            this.btnZakoncz.TabIndex = 3;
            this.btnZakoncz.UseVisualStyleBackColor = true;
            this.btnZakoncz.Click += new System.EventHandler(this.btnZakoncz_Click);
            // 
            // btnKonfiguracja
            // 
            this.btnKonfiguracja.BackgroundImage = global::Gabinet.Properties.Resources.ustawienia;
            this.btnKonfiguracja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKonfiguracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKonfiguracja.Location = new System.Drawing.Point(416, 27);
            this.btnKonfiguracja.Name = "btnKonfiguracja";
            this.btnKonfiguracja.Size = new System.Drawing.Size(120, 120);
            this.btnKonfiguracja.TabIndex = 2;
            this.btnKonfiguracja.Text = "Organizacja";
            this.btnKonfiguracja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKonfiguracja.UseVisualStyleBackColor = true;
            this.btnKonfiguracja.Click += new System.EventHandler(this.btnKonfiguracja_Click);
            // 
            // btnRejestracja
            // 
            this.btnRejestracja.BackgroundImage = global::Gabinet.Properties.Resources.pacjent;
            this.btnRejestracja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRejestracja.Enabled = false;
            this.btnRejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRejestracja.Location = new System.Drawing.Point(229, 27);
            this.btnRejestracja.Name = "btnRejestracja";
            this.btnRejestracja.Size = new System.Drawing.Size(120, 120);
            this.btnRejestracja.TabIndex = 1;
            this.btnRejestracja.Text = "Rejestracja";
            this.btnRejestracja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRejestracja.UseVisualStyleBackColor = true;
            this.btnRejestracja.Click += new System.EventHandler(this.btnRejestracja_Click);
            // 
            // btnGabinet
            // 
            this.btnGabinet.BackgroundImage = global::Gabinet.Properties.Resources.lekarz;
            this.btnGabinet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGabinet.Location = new System.Drawing.Point(39, 27);
            this.btnGabinet.Name = "btnGabinet";
            this.btnGabinet.Size = new System.Drawing.Size(120, 120);
            this.btnGabinet.TabIndex = 0;
            this.btnGabinet.Text = "Gabinet";
            this.btnGabinet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGabinet.UseVisualStyleBackColor = true;
            this.btnGabinet.Click += new System.EventHandler(this.btnGabinet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zalogowany:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 252);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZakoncz);
            this.Controls.Add(this.btnKonfiguracja);
            this.Controls.Add(this.btnRejestracja);
            this.Controls.Add(this.btnGabinet);
            this.MaximizeBox = false;
            this.Name = "Start";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGabinet;
        private System.Windows.Forms.Button btnRejestracja;
        private System.Windows.Forms.Button btnKonfiguracja;
        private System.Windows.Forms.Button btnZakoncz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

