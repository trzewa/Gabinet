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
    public partial class recepta : Form
    {
        public string dbconnection_lek;

        public recepta()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.dbconnection_lek = "Provider=" + mysettings.Default.provider + ";Data Source=" + mysettings.Default.dsdbf + ";Extended Properties=" + mysettings.Default.properties + ";";
            
        }

        public void Update_lek()
        {        
            try
            {
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
                Database database = new Database();
                myDataAdapter = database.SelectDbf("select * from PODSTAW.DBF", dbconnection_lek);
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                dataGridViewLek.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonZnajdz_Click(object sender, EventArgs e)
        {            
            try
            {
                string lek = this.textBoxLek.Text.ToUpper();
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
                Database database = new Database();
                myDataAdapter = database.SelectDbf("select NAZWA, POSTAC, OPAKOWANIE from PODSTAW.DBF where NAZWA like '%" + lek + "%'", dbconnection_lek);
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                dataGridViewLek.DataSource = dt.DefaultView;
                textBoxLek.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
