using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using mysettings = Gabinet.Properties.Settings;

namespace Gabinet
{
    public partial class lekRecepta : Form
    {
        public string bazyl;
        public string dbconnection_lek;
        public string ilosc;
        public string odplatnosc;
        public string dawkowanie;
        public string nazwa;
        public string opakowanie;
        public string postac;
        public bool flag;

        public lekRecepta()
        {
            InitializeComponent();
        }

        public lekRecepta(string idBazyl)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.dbconnection_lek = "Provider=" + mysettings.Default.provider + ";Data Source=" + mysettings.Default.dsdbf + ";Extended Properties=" + mysettings.Default.properties + ";";
            this.bazyl = idBazyl;
            Update_lek();
            Update_comboBoxes();
        }

        public void Update_lek()
        {
            try
            {
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
                Database database = new Database();
                myDataAdapter = database.SelectDbf("select NAZWA, POSTAC, OPAKOWANIE from PODSTAW.DBF where BAZYL='" + this.bazyl + "'", dbconnection_lek);
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.nazwa = this.textBoxNazwa.Text = element["NAZWA"].ToString();
                    this.postac = this.textBoxPostac.Text = element["POSTAC"].ToString();
                    this.opakowanie = this.textBoxIlosc.Text = element["OPAKOWANIE"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_comboBoxes()
        {
            comboBoxIlosc.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBoxIlosc.SelectedIndex = 0;
            comboBoxOdplatnosc.Items.AddRange(new object[] { "B - bezpłatnie", "R - ryczałt", "30%", "50%", "100%", "P", "X" });
            comboBoxOdplatnosc.SelectedIndex = 4;
        }

        private void buttonWróć_Click(object sender, EventArgs e)
        {
            flag = false;
            this.Close();
        }

        private void buttonWypisz_Click(object sender, EventArgs e)
        {
            this.ilosc = comboBoxIlosc.SelectedItem.ToString();
            this.odplatnosc = comboBoxOdplatnosc.SelectedItem.ToString();
            this.dawkowanie = textBoxDawkowanie.Text.ToString();
            flag = true;
            this.Close();
        }
    }
}
