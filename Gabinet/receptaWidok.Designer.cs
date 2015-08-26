namespace Gabinet
{
    partial class receptaWidok
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
            this.panRpComponents = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panRpMargins = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numTopMargin = new System.Windows.Forms.NumericUpDown();
            this.numLeftMargin = new System.Windows.Forms.NumericUpDown();
            this.numHCProvider = new System.Windows.Forms.NumericUpDown();
            this.numMedList = new System.Windows.Forms.NumericUpDown();
            this.numDateFields = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPrintHCProvider = new System.Windows.Forms.CheckBox();
            this.cbPrintPrescNum = new System.Windows.Forms.CheckBox();
            this.cbPrintLabels = new System.Windows.Forms.CheckBox();
            this.cbPrintFrames = new System.Windows.Forms.CheckBox();
            this.RpViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTopMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeftMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHCProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDateFields)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panRpComponents
            // 
            this.panRpComponents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panRpComponents.Location = new System.Drawing.Point(268, 6);
            this.panRpComponents.Name = "panRpComponents";
            this.panRpComponents.Size = new System.Drawing.Size(578, 680);
            this.panRpComponents.TabIndex = 23;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 718);
            this.tabControl1.TabIndex = 29;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage1.Controls.Add(this.panRpMargins);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.numTopMargin);
            this.tabPage1.Controls.Add(this.numLeftMargin);
            this.tabPage1.Controls.Add(this.numHCProvider);
            this.tabPage1.Controls.Add(this.numMedList);
            this.tabPage1.Controls.Add(this.numDateFields);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(852, 692);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Marginesy i rozmiar recepty";
            // 
            // panRpMargins
            // 
            this.panRpMargins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panRpMargins.BackColor = System.Drawing.Color.Transparent;
            this.panRpMargins.Location = new System.Drawing.Point(132, 51);
            this.panRpMargins.Name = "panRpMargins";
            this.panRpMargins.Size = new System.Drawing.Size(491, 618);
            this.panRpMargins.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(786, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "cm";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.Location = new System.Drawing.Point(694, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 18);
            this.label16.TabIndex = 39;
            this.label16.Text = "Wysokość pól daty";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Górny margines recepty";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "mm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Location = new System.Drawing.Point(9, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Lewy margines recepty\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "mm";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Location = new System.Drawing.Point(629, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Wysokość pola świadczeniodawcy";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(785, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "cm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(786, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "cm";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.Location = new System.Drawing.Point(694, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "Wysokość listy leków";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // numTopMargin
            // 
            this.numTopMargin.Location = new System.Drawing.Point(212, 25);
            this.numTopMargin.Name = "numTopMargin";
            this.numTopMargin.Size = new System.Drawing.Size(56, 20);
            this.numTopMargin.TabIndex = 0;
            this.numTopMargin.ValueChanged += new System.EventHandler(this.numTopMargin_ValueChanged_1);
            // 
            // numLeftMargin
            // 
            this.numLeftMargin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numLeftMargin.Location = new System.Drawing.Point(38, 165);
            this.numLeftMargin.Name = "numLeftMargin";
            this.numLeftMargin.Size = new System.Drawing.Size(58, 20);
            this.numLeftMargin.TabIndex = 1;
            this.numLeftMargin.ValueChanged += new System.EventHandler(this.numLeftMargin_ValueChanged_1);
            // 
            // numHCProvider
            // 
            this.numHCProvider.DecimalPlaces = 2;
            this.numHCProvider.Location = new System.Drawing.Point(723, 123);
            this.numHCProvider.Name = "numHCProvider";
            this.numHCProvider.Size = new System.Drawing.Size(55, 20);
            this.numHCProvider.TabIndex = 2;
            this.numHCProvider.ValueChanged += new System.EventHandler(this.numHCProvider_ValueChanged_1);
            // 
            // numMedList
            // 
            this.numMedList.DecimalPlaces = 2;
            this.numMedList.Location = new System.Drawing.Point(723, 209);
            this.numMedList.Name = "numMedList";
            this.numMedList.Size = new System.Drawing.Size(55, 20);
            this.numMedList.TabIndex = 3;
            this.numMedList.ValueChanged += new System.EventHandler(this.numMedList_ValueChanged_1);
            // 
            // numDateFields
            // 
            this.numDateFields.DecimalPlaces = 2;
            this.numDateFields.Location = new System.Drawing.Point(723, 278);
            this.numDateFields.Name = "numDateFields";
            this.numDateFields.Size = new System.Drawing.Size(55, 20);
            this.numDateFields.TabIndex = 4;
            this.numDateFields.ValueChanged += new System.EventHandler(this.numDateFields_ValueChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage2.Controls.Add(this.buttonZapisz);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.panRpComponents);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbPrintHCProvider);
            this.tabPage2.Controls.Add(this.cbPrintPrescNum);
            this.tabPage2.Controls.Add(this.cbPrintLabels);
            this.tabPage2.Controls.Add(this.cbPrintFrames);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(852, 692);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wybór komponentów recepty";
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(46, 217);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(136, 23);
            this.buttonZapisz.TabIndex = 25;
            this.buttonZapisz.Text = "Zapisz recepte";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Visible = false;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "które mają być wyświetlone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wybierz komponenty recepty, ";
            // 
            // cbPrintHCProvider
            // 
            this.cbPrintHCProvider.AutoSize = true;
            this.cbPrintHCProvider.Checked = true;
            this.cbPrintHCProvider.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrintHCProvider.Location = new System.Drawing.Point(46, 164);
            this.cbPrintHCProvider.Name = "cbPrintHCProvider";
            this.cbPrintHCProvider.Size = new System.Drawing.Size(138, 17);
            this.cbPrintHCProvider.TabIndex = 4;
            this.cbPrintHCProvider.Text = "Drukuj dane przychodni";
            this.cbPrintHCProvider.UseVisualStyleBackColor = true;
            this.cbPrintHCProvider.CheckedChanged += new System.EventHandler(this.cbPrintHCProvider_CheckedChanged);
            // 
            // cbPrintPrescNum
            // 
            this.cbPrintPrescNum.AutoSize = true;
            this.cbPrintPrescNum.Checked = true;
            this.cbPrintPrescNum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrintPrescNum.Location = new System.Drawing.Point(46, 141);
            this.cbPrintPrescNum.Name = "cbPrintPrescNum";
            this.cbPrintPrescNum.Size = new System.Drawing.Size(107, 17);
            this.cbPrintPrescNum.TabIndex = 3;
            this.cbPrintPrescNum.Text = "Drukuj nr recepty";
            this.cbPrintPrescNum.UseVisualStyleBackColor = true;
            this.cbPrintPrescNum.CheckedChanged += new System.EventHandler(this.cbPrintPrescNum_CheckedChanged);
            // 
            // cbPrintLabels
            // 
            this.cbPrintLabels.AutoSize = true;
            this.cbPrintLabels.Checked = true;
            this.cbPrintLabels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrintLabels.Location = new System.Drawing.Point(46, 118);
            this.cbPrintLabels.Name = "cbPrintLabels";
            this.cbPrintLabels.Size = new System.Drawing.Size(96, 17);
            this.cbPrintLabels.TabIndex = 2;
            this.cbPrintLabels.Text = "Drukuj etykiety";
            this.cbPrintLabels.UseVisualStyleBackColor = true;
            this.cbPrintLabels.CheckedChanged += new System.EventHandler(this.cbPrintLabels_CheckedChanged);
            // 
            // cbPrintFrames
            // 
            this.cbPrintFrames.AutoSize = true;
            this.cbPrintFrames.Checked = true;
            this.cbPrintFrames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrintFrames.Location = new System.Drawing.Point(46, 95);
            this.cbPrintFrames.Name = "cbPrintFrames";
            this.cbPrintFrames.Size = new System.Drawing.Size(85, 17);
            this.cbPrintFrames.TabIndex = 18;
            this.cbPrintFrames.Text = "Drukuj ramki";
            this.cbPrintFrames.UseVisualStyleBackColor = true;
            this.cbPrintFrames.CheckedChanged += new System.EventHandler(this.cbPrintFrames_CheckedChanged);
            // 
            // RpViewer
            // 
            this.RpViewer.Location = new System.Drawing.Point(0, 0);
            this.RpViewer.Name = "ReportViewer";
            this.RpViewer.ShowDocumentMapButton = false;
            this.RpViewer.ShowExportButton = false;
            this.RpViewer.ShowParameterPrompts = false;
            this.RpViewer.ShowPromptAreaButton = false;
            this.RpViewer.Size = new System.Drawing.Size(400, 250);
            this.RpViewer.TabIndex = 0;
            // 
            // receptaWidok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 741);
            this.Controls.Add(this.tabControl1);
            this.Name = "receptaWidok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Widok recepty";
            this.Load += new System.EventHandler(this.receptaWidok_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTopMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeftMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHCProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDateFields)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panRpComponents;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numTopMargin;
        private System.Windows.Forms.NumericUpDown numLeftMargin;
        private System.Windows.Forms.NumericUpDown numHCProvider;
        private System.Windows.Forms.NumericUpDown numMedList;
        private System.Windows.Forms.NumericUpDown numDateFields;
        private System.Windows.Forms.Panel panRpMargins;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbPrintHCProvider;
        private System.Windows.Forms.CheckBox cbPrintPrescNum;
        private System.Windows.Forms.CheckBox cbPrintLabels;
        private System.Windows.Forms.CheckBox cbPrintFrames;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonZapisz;
        private Microsoft.Reporting.WinForms.ReportViewer RpViewer;

    }
}