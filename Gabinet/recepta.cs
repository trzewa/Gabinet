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
using MySql.Data.MySqlClient;
using System.IO;
using mysettings = Gabinet.Properties.Settings;

namespace Gabinet
{
    public partial class Recepta : Form
    {
        public string dbconnection_lek;
        //public string dbconnection_gabinet;
        public string idrecepta = null;
        
        public Recepta()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.dbconnection_lek = "Provider=" + mysettings.Default.provider + ";Data Source=" + mysettings.Default.dsdbf + ";Extended Properties=" + mysettings.Default.properties + ";";
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            Update_comboboxes();
            if (File.Exists(@"c:\Baza\wersja.txt"))
            {
                string wersjaLokalna = File.ReadAllText(@"c:\Baza\wersja.txt");                
                label5.Text = wersjaLokalna;
            }
            else
            {                
                label5.Text = "!Brak pliku!";
                buttonZnajdz.Visible = false;
                buttonDopisz.Enabled = false;
                buttonZapisz.Enabled = false;
                textBoxLek.Visible = false;
                label1.Text = "UWAGA!Brak pliku bazy BAZYL!Brak możliwości wyboru leków.\nPoinformuj administratora lub jeśli masz uprawnienia przejdź do sekcji Organizacja i pobierz plik";
            }
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

        private void Update_listView()
        {
            if (listViewRecepta.Items.Count != 0)
            {
                listViewRecepta.BackColor = System.Drawing.Color.SpringGreen;
            }
            else listViewRecepta.BackColor = System.Drawing.Color.White;
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
                //throw new Exception("Brak plików bazy BAZYL!\nPoinformuj administratora lub jeśli masz uprawnienia przejdź do sekcji Organizacja i pobierz plik", ex);
                
                //MessageBox.Show("Poinformuj administratora lub jeśli masz uprawnienia przejdź do sekcji Organizacja i pobierz plik","Brak plików bazy BAZYL", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    LekRecepta f2 = new LekRecepta(id);
                    f2.Owner = this;
                    f2.ShowDialog();
                    this.Opacity = 1;
                    if (f2.flag)
                    {
                        ListViewItem item = new ListViewItem(f2.nazwa);
                        item.SubItems.Add(f2.bazyl);
                        item.SubItems.Add(f2.ilosc);
                        item.SubItems.Add(f2.odplatnosc);
                        item.SubItems.Add(f2.dawkowanie);
                        item.ToolTipText = f2.nazwa + " - " + f2.opakowanie + "\nIlość: " + f2.ilosc + "\nOdpłatnośc: " + f2.odplatnosc + "\nDawkowanie: " + f2.dawkowanie;
                        listViewRecepta.Items.Add(item);
                        Update_listView();                        
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
                Update_listView();
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            try
            {

                string uprawnienia = comboBoxUprawnienia.SelectedItem.ToString();
                string dataRealizacji;
                if (checkBox1.CheckState == CheckState.Checked) 
                {
                    dataRealizacji = this.dateTimePickerRealizacja.Text;                    
                }
                else dataRealizacji = "X";


                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                database.Insert("insert into recepta (data_realizacji, uprawnienia_dodatkowe) VALUES('" + dataRealizacji + "','" + uprawnienia + "')", database.Conect());

                myDataAdapter = database.Select("select max(idrecepty) from recepta", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                                
                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.idrecepta = element["max(idrecepty)"].ToString();
                }

                for (int i = 0; i <= listViewRecepta.Items.Count - 1; i++)
                
                {
                    string bazyl = listViewRecepta.Items[i].SubItems[1].Text.ToString();
                    string dawkowanie = listViewRecepta.Items[i].SubItems[4].Text.ToString();
                    string ilosc = listViewRecepta.Items[i].SubItems[2].Text.ToString();
                    string odplatnosc = listViewRecepta.Items[i].SubItems[3].Text.ToString();

                    database.Insert("insert into receptalek (idrecepty, bazyl, dawkowanie, ilosc, odplatnosc) VALUES('" + this.idrecepta + "','" + bazyl + "','" + dawkowanie + "', '" + ilosc + "','" + odplatnosc + "')", database.Conect());
                }


                DialogResult result = MessageBox.Show("Recepta utworzona", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            dateTimePickerRealizacja.Enabled = (checkBox1.CheckState == CheckState.Checked);
        }
        
    }
}
