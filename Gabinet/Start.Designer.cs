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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnZakoncz = new System.Windows.Forms.Button();
            this.btnKonfiguracja = new System.Windows.Forms.Button();
            this.btnRejestracja = new System.Windows.Forms.Button();
            this.btnGabinet = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(63, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gabinet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(246, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rejestracja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(430, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Organizacja";
            // 
            // btnZakoncz
            // 
            this.btnZakoncz.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnZakoncz.BackgroundImage = global::Gabinet.Properties.Resources.close_icon;
            this.btnZakoncz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZakoncz.Location = new System.Drawing.Point(497, 188);
            this.btnZakoncz.Name = "btnZakoncz";
            this.btnZakoncz.Size = new System.Drawing.Size(39, 37);
            this.btnZakoncz.TabIndex = 3;
            this.btnZakoncz.UseVisualStyleBackColor = false;
            this.btnZakoncz.Click += new System.EventHandler(this.btnZakoncz_Click);
            // 
            // btnKonfiguracja
            // 
            this.btnKonfiguracja.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnKonfiguracja.BackgroundImage = global::Gabinet.Properties.Resources.settings_3_icon;
            this.btnKonfiguracja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKonfiguracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKonfiguracja.Location = new System.Drawing.Point(416, 27);
            this.btnKonfiguracja.Name = "btnKonfiguracja";
            this.btnKonfiguracja.Size = new System.Drawing.Size(120, 120);
            this.btnKonfiguracja.TabIndex = 2;
            this.btnKonfiguracja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKonfiguracja.UseVisualStyleBackColor = false;
            this.btnKonfiguracja.Click += new System.EventHandler(this.btnKonfiguracja_Click);
            // 
            // btnRejestracja
            // 
            this.btnRejestracja.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRejestracja.BackgroundImage = global::Gabinet.Properties.Resources.myspace_icon;
            this.btnRejestracja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRejestracja.Enabled = false;
            this.btnRejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRejestracja.Location = new System.Drawing.Point(229, 27);
            this.btnRejestracja.Name = "btnRejestracja";
            this.btnRejestracja.Size = new System.Drawing.Size(120, 120);
            this.btnRejestracja.TabIndex = 1;
            this.btnRejestracja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRejestracja.UseVisualStyleBackColor = false;
            this.btnRejestracja.Click += new System.EventHandler(this.btnRejestracja_Click);
            // 
            // btnGabinet
            // 
            this.btnGabinet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGabinet.BackgroundImage = global::Gabinet.Properties.Resources.myspace_2_icon;
            this.btnGabinet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGabinet.Location = new System.Drawing.Point(39, 27);
            this.btnGabinet.Name = "btnGabinet";
            this.btnGabinet.Size = new System.Drawing.Size(120, 120);
            this.btnGabinet.TabIndex = 0;
            this.btnGabinet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGabinet.UseVisualStyleBackColor = false;
            this.btnGabinet.Click += new System.EventHandler(this.btnGabinet_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 252);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZakoncz);
            this.Controls.Add(this.btnKonfiguracja);
            this.Controls.Add(this.btnRejestracja);
            this.Controls.Add(this.btnGabinet);
            this.MaximizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel główny";
            this.Load += new System.EventHandler(this.Start_Closing);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

