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
            this.buttonDopisz = new System.Windows.Forms.Button();
            this.buttonZnajdz = new System.Windows.Forms.Button();
            this.dataGridViewLek = new System.Windows.Forms.DataGridView();
            this.bazyl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dawka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opakowanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wersja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxLek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.comboBoxUprawnienia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerRealizacja = new System.Windows.Forms.DateTimePicker();
            this.listViewRecepta = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLek)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
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
            // buttonDopisz
            // 
            this.buttonDopisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDopisz.Location = new System.Drawing.Point(532, 339);
            this.buttonDopisz.Name = "buttonDopisz";
            this.buttonDopisz.Size = new System.Drawing.Size(128, 23);
            this.buttonDopisz.TabIndex = 3;
            this.buttonDopisz.Text = "Dopisz do recepty";
            this.buttonDopisz.UseVisualStyleBackColor = true;
            this.buttonDopisz.Click += new System.EventHandler(this.buttonDopisz_Click);
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
            // textBoxLek
            // 
            this.textBoxLek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLek.Location = new System.Drawing.Point(116, 19);
            this.textBoxLek.Name = "textBoxLek";
            this.textBoxLek.Size = new System.Drawing.Size(282, 20);
            this.textBoxLek.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonUsun);
            this.groupBox2.Controls.Add(this.comboBoxUprawnienia);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePickerRealizacja);
            this.groupBox2.Controls.Add(this.listViewRecepta);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(675, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 333);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recepta";
            // 
            // buttonUsun
            // 
            this.buttonUsun.BackColor = System.Drawing.Color.Transparent;
            this.buttonUsun.BackgroundImage = global::Gabinet.Properties.Resources.usun;
            this.buttonUsun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUsun.Location = new System.Drawing.Point(6, 17);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(23, 23);
            this.buttonUsun.TabIndex = 5;
            this.buttonUsun.UseVisualStyleBackColor = false;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // comboBoxUprawnienia
            // 
            this.comboBoxUprawnienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxUprawnienia.FormattingEnabled = true;
            this.comboBoxUprawnienia.Location = new System.Drawing.Point(9, 297);
            this.comboBoxUprawnienia.Name = "comboBoxUprawnienia";
            this.comboBoxUprawnienia.Size = new System.Drawing.Size(182, 21);
            this.comboBoxUprawnienia.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Uprawnienia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data realizacji";
            // 
            // dateTimePickerRealizacja
            // 
            this.dateTimePickerRealizacja.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerRealizacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerRealizacja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRealizacja.Location = new System.Drawing.Point(9, 258);
            this.dateTimePickerRealizacja.Name = "dateTimePickerRealizacja";
            this.dateTimePickerRealizacja.ShowUpDown = true;
            this.dateTimePickerRealizacja.Size = new System.Drawing.Size(110, 20);
            this.dateTimePickerRealizacja.TabIndex = 1;
            // 
            // listViewRecepta
            // 
            this.listViewRecepta.BackColor = System.Drawing.Color.White;
            this.listViewRecepta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewRecepta.FullRowSelect = true;
            this.listViewRecepta.Location = new System.Drawing.Point(6, 45);
            this.listViewRecepta.MultiSelect = false;
            this.listViewRecepta.Name = "listViewRecepta";
            this.listViewRecepta.RightToLeftLayout = true;
            this.listViewRecepta.ShowItemToolTips = true;
            this.listViewRecepta.Size = new System.Drawing.Size(185, 194);
            this.listViewRecepta.TabIndex = 0;
            this.listViewRecepta.UseCompatibleStateImageBehavior = false;
            this.listViewRecepta.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dopisane leki";
            this.columnHeader1.Width = 178;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 0;
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(797, 351);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 2;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(716, 351);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisz.TabIndex = 3;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prezentowane dane pochodzą z wydania";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(214, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Farmaceutycznej Bazy Danych BAZYL firmy IMS HEALTH";
            // 
            // recepta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 392);
            this.ControlBox = false;
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "recepta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLek)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.ListView listViewRecepta;
        private System.Windows.Forms.ComboBox comboBoxUprawnienia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerRealizacja;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}