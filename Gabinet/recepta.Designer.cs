namespace Gabinet
{
    partial class recepta
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLek = new System.Windows.Forms.TextBox();
            this.dataGridViewLek = new System.Windows.Forms.DataGridView();
            this.buttonZnajdz = new System.Windows.Forms.Button();
            this.buttonDopisz = new System.Windows.Forms.Button();
            this.bazyl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dawka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opakowanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wersja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLek)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDopisz);
            this.groupBox1.Controls.Add(this.buttonZnajdz);
            this.groupBox1.Controls.Add(this.dataGridViewLek);
            this.groupBox1.Controls.Add(this.textBoxLek);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyszukaj lek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa leku";
            // 
            // textBoxLek
            // 
            this.textBoxLek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLek.Location = new System.Drawing.Point(116, 19);
            this.textBoxLek.Name = "textBoxLek";
            this.textBoxLek.Size = new System.Drawing.Size(282, 20);
            this.textBoxLek.TabIndex = 1;
            // 
            // dataGridViewLek
            // 
            this.dataGridViewLek.AllowUserToAddRows = false;
            this.dataGridViewLek.AllowUserToDeleteRows = false;
            this.dataGridViewLek.AllowUserToResizeRows = false;
            this.dataGridViewLek.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewLek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bazyl,
            this.nazwa,
            this.postac,
            this.dawka,
            this.opakowanie,
            this.sl_prod,
            this.wersja});
            this.dataGridViewLek.Location = new System.Drawing.Point(6, 45);
            this.dataGridViewLek.MultiSelect = false;
            this.dataGridViewLek.Name = "dataGridViewLek";
            this.dataGridViewLek.ReadOnly = true;
            this.dataGridViewLek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLek.Size = new System.Drawing.Size(654, 273);
            this.dataGridViewLek.TabIndex = 1;
            // 
            // buttonZnajdz
            // 
            this.buttonZnajdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZnajdz.Location = new System.Drawing.Point(404, 17);
            this.buttonZnajdz.Name = "buttonZnajdz";
            this.buttonZnajdz.Size = new System.Drawing.Size(75, 23);
            this.buttonZnajdz.TabIndex = 2;
            this.buttonZnajdz.Text = "Znajdź";
            this.buttonZnajdz.UseVisualStyleBackColor = true;
            this.buttonZnajdz.Click += new System.EventHandler(this.buttonZnajdz_Click);
            // 
            // buttonDopisz
            // 
            this.buttonDopisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDopisz.Location = new System.Drawing.Point(532, 339);
            this.buttonDopisz.Name = "buttonDopisz";
            this.buttonDopisz.Size = new System.Drawing.Size(128, 23);
            this.buttonDopisz.TabIndex = 3;
            this.buttonDopisz.Text = "Dopisz do recepty";
            this.buttonDopisz.UseVisualStyleBackColor = true;
            // 
            // bazyl
            // 
            this.bazyl.DataPropertyName = "BAZYL";
            this.bazyl.HeaderText = "Bazyl";
            this.bazyl.Name = "bazyl";
            this.bazyl.ReadOnly = true;
            this.bazyl.Visible = false;
            // 
            // nazwa
            // 
            this.nazwa.DataPropertyName = "NAZWA";
            this.nazwa.HeaderText = "Nazwa leku";
            this.nazwa.MinimumWidth = 50;
            this.nazwa.Name = "nazwa";
            this.nazwa.ReadOnly = true;
            this.nazwa.Width = 360;
            // 
            // postac
            // 
            this.postac.DataPropertyName = "POSTAC";
            this.postac.HeaderText = "Postać";
            this.postac.Name = "postac";
            this.postac.ReadOnly = true;
            this.postac.Width = 120;
            // 
            // dawka
            // 
            this.dawka.DataPropertyName = "DAWKA";
            this.dawka.HeaderText = "Dawka";
            this.dawka.Name = "dawka";
            this.dawka.ReadOnly = true;
            this.dawka.Visible = false;
            this.dawka.Width = 120;
            // 
            // opakowanie
            // 
            this.opakowanie.DataPropertyName = "OPAKOWANIE";
            this.opakowanie.HeaderText = "Opakowanie";
            this.opakowanie.Name = "opakowanie";
            this.opakowanie.ReadOnly = true;
            // 
            // sl_prod
            // 
            this.sl_prod.DataPropertyName = "SL_PROD";
            this.sl_prod.HeaderText = "Sl_prod";
            this.sl_prod.Name = "sl_prod";
            this.sl_prod.ReadOnly = true;
            this.sl_prod.Visible = false;
            // 
            // wersja
            // 
            this.wersja.DataPropertyName = "WERSJA";
            this.wersja.HeaderText = "Wersja";
            this.wersja.Name = "wersja";
            this.wersja.ReadOnly = true;
            this.wersja.Visible = false;
            // 
            // recepta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 392);
            this.Controls.Add(this.groupBox1);
            this.Name = "recepta";
            this.Text = "Recepta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLek;
        private System.Windows.Forms.Button buttonDopisz;
        private System.Windows.Forms.Button buttonZnajdz;
        private System.Windows.Forms.DataGridViewTextBoxColumn bazyl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn postac;
        private System.Windows.Forms.DataGridViewTextBoxColumn dawka;
        private System.Windows.Forms.DataGridViewTextBoxColumn opakowanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn wersja;
    }
}