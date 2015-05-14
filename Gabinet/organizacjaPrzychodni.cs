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
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            Update_dataGridViewPracownicy();
        }

        public void Update_dataGridViewPracownicy()
        {
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            Database database = new Database();
            myDataAdapter = database.Select("select nazwisko, imie, pesel, telefon, mail, nazwa from pracownikkontakt inner join pracownik on pracownikkontakt.idpracownik=pracownik.idpracownik inner join kontakt on  kontakt.idkontakt=pracownikkontakt.idkontakt inner join stanowisko on stanowisko.idstanowisko=pracownik.idstanowisko ", this.dbconnection_gabinet);

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
                dodajPracownika f2 = new dodajPracownika();
                f2.ShowDialog();
                Update_dataGridViewPracownicy();
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
                harmonogram f2 = new harmonogram();
                f2.ShowDialog();                
            }
        }
    }
}
