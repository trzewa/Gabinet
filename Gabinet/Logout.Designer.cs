namespace Gabinet
{
    partial class Logout
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
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonZakoncz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAnuluj.BackgroundImage = global::Gabinet.Properties.Resources.home_icon;
            this.buttonAnuluj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAnuluj.Location = new System.Drawing.Point(324, 12);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(150, 150);
            this.buttonAnuluj.TabIndex = 2;
            this.buttonAnuluj.Tag = "";
            this.buttonAnuluj.UseVisualStyleBackColor = false;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLogout.BackgroundImage = global::Gabinet.Properties.Resources.unlock_icon;
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogout.Location = new System.Drawing.Point(168, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(150, 150);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonZakoncz
            // 
            this.buttonZakoncz.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonZakoncz.BackgroundImage = global::Gabinet.Properties.Resources.stop_icon;
            this.buttonZakoncz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZakoncz.Location = new System.Drawing.Point(12, 12);
            this.buttonZakoncz.Name = "buttonZakoncz";
            this.buttonZakoncz.Size = new System.Drawing.Size(150, 150);
            this.buttonZakoncz.TabIndex = 0;
            this.buttonZakoncz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonZakoncz.UseVisualStyleBackColor = false;
            this.buttonZakoncz.Click += new System.EventHandler(this.buttonZakoncz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ZAMKNIJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "WYLOGUJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "WRÓĆ";
            // 
            // Logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(486, 180);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonZakoncz);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zakończ pracę ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZakoncz;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}