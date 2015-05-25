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
    public partial class Rejestracja : Form
    {
        public string dbconnection_gabinet;
        
        public Rejestracja()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            
        }
        
        private void toolStripBtnDodaj_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Dodawanie pacjenta")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                this.Visible = false;
                DodajPacjent f2 = new DodajPacjent();
                f2.ShowDialog();
                this.Visible = true;
            }
        }

        private void toolStripBtnRejestruj_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Rejestracja pacjenta")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                if (dataGridViewPacjenci.RowCount != 0)
                {
                    this.Visible = false;
                    int row = dataGridViewPacjenci.CurrentCell.RowIndex;
                    string id = dataGridViewPacjenci.Rows[row].Cells[5].Value.ToString();
                    rejestracjaPacjenta f2 = new rejestracjaPacjenta(id);
                    f2.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Musisz wybrać pacjenta!");
                }
            }
        }

        private void buttonZnajdz_Click(object sender, EventArgs e)
        {            
            try
            {                
                string imie = this.textBoxImie.Text;
                string nazwisko = this.textBoxNazwisko.Text;
                string pesel = this.textBoxPesel.Text;

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select nazwisko, imie, pesel, telefon, mail, pacjent.idpacjent, plec from pacjentkontakt inner join pacjent on pacjentkontakt.idpacjent=pacjent.idpacjent inner join plec on plec.idplec=pacjent.idplec inner join kontakt on pacjentkontakt.idkontakt=kontakt.idkontakt where pesel like '%" + pesel + "%' and nazwisko like '%" + nazwisko.ToString() + "%' and imie like '%" + imie.ToString() + "%'", this.dbconnection_gabinet);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);               

                dataGridViewPacjenci.DataSource = dt.DefaultView;
                textBoxImie.Clear();
                textBoxNazwisko.Clear();
                textBoxPesel.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripBtnDanePacjent_Click(object sender, EventArgs e)
        {
            int row = dataGridViewPacjenci.CurrentCell.RowIndex;
            string id = dataGridViewPacjenci.Rows[row].Cells[5].Value.ToString();
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Dane pacjenta")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                this.Opacity = 0.5;
                danePacjent f2 = new danePacjent(id);
                f2.ShowDialog();
                this.Opacity = 1;
            }
        }        
    }
}
