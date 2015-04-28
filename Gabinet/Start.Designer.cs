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
            this.btnGabinet = new System.Windows.Forms.Button();
            this.btnRejestracja = new System.Windows.Forms.Button();
            this.btnKonfiguracja = new System.Windows.Forms.Button();
            this.btnZakoncz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGabinet
            // 
            this.btnGabinet.Location = new System.Drawing.Point(39, 27);
            this.btnGabinet.Name = "btnGabinet";
            this.btnGabinet.Size = new System.Drawing.Size(120, 120);
            this.btnGabinet.TabIndex = 0;
            this.btnGabinet.Text = "Gabinet";
            this.btnGabinet.UseVisualStyleBackColor = true;
            // 
            // btnRejestracja
            // 
            this.btnRejestracja.Location = new System.Drawing.Point(229, 27);
            this.btnRejestracja.Name = "btnRejestracja";
            this.btnRejestracja.Size = new System.Drawing.Size(120, 120);
            this.btnRejestracja.TabIndex = 1;
            this.btnRejestracja.Text = "Rejestracja";
            this.btnRejestracja.UseVisualStyleBackColor = true;
            // 
            // btnKonfiguracja
            // 
            this.btnKonfiguracja.Location = new System.Drawing.Point(416, 27);
            this.btnKonfiguracja.Name = "btnKonfiguracja";
            this.btnKonfiguracja.Size = new System.Drawing.Size(120, 120);
            this.btnKonfiguracja.TabIndex = 2;
            this.btnKonfiguracja.Text = "Konfiguracja";
            this.btnKonfiguracja.UseVisualStyleBackColor = true;
            // 
            // btnZakoncz
            // 
            this.btnZakoncz.Location = new System.Drawing.Point(416, 294);
            this.btnZakoncz.Name = "btnZakoncz";
            this.btnZakoncz.Size = new System.Drawing.Size(120, 30);
            this.btnZakoncz.TabIndex = 3;
            this.btnZakoncz.Text = "Zakończ";
            this.btnZakoncz.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gabinet.Properties.Resources._023333859;
            this.ClientSize = new System.Drawing.Size(572, 374);
            this.Controls.Add(this.btnZakoncz);
            this.Controls.Add(this.btnKonfiguracja);
            this.Controls.Add(this.btnRejestracja);
            this.Controls.Add(this.btnGabinet);
            this.Name = "Start";
            this.Text = "Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGabinet;
        private System.Windows.Forms.Button btnRejestracja;
        private System.Windows.Forms.Button btnKonfiguracja;
        private System.Windows.Forms.Button btnZakoncz;
    }
}

