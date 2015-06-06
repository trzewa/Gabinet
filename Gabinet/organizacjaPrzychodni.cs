using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using mysettings = Gabinet.Properties.Settings;

namespace Gabinet
{
    public partial class organizacjaPrzychodni : Form
    {

        public string dbconnection_gabinet;

        public organizacjaPrzychodni()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            Update_dataGridViewPracownicy();
        }

        public void Update_dataGridViewPracownicy()
        {
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            Database database = new Database();
            myDataAdapter = database.Select("select nazwisko, imie, pesel, nazwa, idpracownik from pracownik inner join stanowisko on stanowisko.idstanowisko=pracownik.idstanowisko ", this.dbconnection_gabinet);

            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);
            dataGridViewPracownicy.DataSource = dt.DefaultView;
             
        }

        private void toolStripButtonDodaj_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Dodawanie pracownika")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                this.Visible = false;
                dodajPracownika f2 = new dodajPracownika();
                f2.ShowDialog();
                Update_dataGridViewPracownicy();
                this.Visible = true;
            }
        }

        private void toolStripButtonHarmonogram_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Harmonogram pracy")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                if (dataGridViewPracownicy.RowCount != 0)
                {
                    this.Visible = false;
                    int row = dataGridViewPracownicy.CurrentCell.RowIndex;
                    string id = dataGridViewPracownicy.Rows[row].Cells[4].Value.ToString();
                    harmonogram f2 = new harmonogram(id);
                    f2.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Musisz wybrać pracownika!");
                }                              
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Ustawienia dostępu do bazy")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                this.Visible = false;
                bazaDane f2 = new bazaDane();
                f2.ShowDialog();
                Update_dataGridViewPracownicy();
                this.Visible = true;
            }
        }
    }
}
