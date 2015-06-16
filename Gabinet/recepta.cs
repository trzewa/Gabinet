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
        public List<string> bazylList = new List<string>();
        public List<string> ilosc = new List<string>();
        public List<string> odplatnosc = new List<string>();
        public List<string> dawkowanie = new List<string>();

        public recepta()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.dbconnection_lek = "Provider=" + mysettings.Default.provider + ";Data Source=" + mysettings.Default.dsdbf + ";Extended Properties=" + mysettings.Default.properties + ";";
            Update_comboboxes();
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

        private void Update_comboboxes()
        {
            comboBoxUprawnienia.Items.AddRange(new object[] { "X - brak uprawnień", "IB - inwalida wojenny", "IW - inwalida wojskowy", "ZK - zasłużony krwiodawca" });
            comboBoxUprawnienia.SelectedIndex = 0;
        }

        private void buttonZnajdz_Click(object sender, EventArgs e)
        {            
            try
            {
                string lek = this.textBoxLek.Text.ToUpper();
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
                Database database = new Database();
                myDataAdapter = database.SelectDbf("select * from PODSTAW.DBF where NAZWA like '%" + lek + "%'", dbconnection_lek);
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

        private void buttonDopisz_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Dopisz lek do recepty")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                if (dataGridViewLek.RowCount != 0)
                {
                    int row = dataGridViewLek.CurrentCell.RowIndex;
                    string id = dataGridViewLek.Rows[row].Cells[0].Value.ToString();
                    this.Opacity = 0.5;
                    lekRecepta f2 = new lekRecepta(id);
                    f2.Owner = this;
                    f2.ShowDialog();
                    this.Opacity = 1;
                    if (f2.flag)
                    {
                        ListViewItem item = new ListViewItem(f2.nazwa);
                        item.ToolTipText = f2.nazwa + " - " + f2.opakowanie + "\nIlość: " + f2.ilosc + "\nOdpłatnośc: " + f2.odplatnosc + "\nDawkowanie: " + f2.dawkowanie;
                        listViewRecepta.Items.Add(item);
                        bazylList.Add(f2.bazyl);
                        ilosc.Add(f2.ilosc);
                        odplatnosc.Add(f2.odplatnosc);
                        dawkowanie.Add(f2.dawkowanie);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Musisz wybrać lek!");
                }
            }
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            for (int i = listViewRecepta.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem itm = listViewRecepta.SelectedItems[i];
                listViewRecepta.Items[itm.Index].Remove();
                bazylList.RemoveAt(i);
                ilosc.RemoveAt(i);
                odplatnosc.RemoveAt(i);
                dawkowanie.RemoveAt(i);
            }
        }
        
    }
}
