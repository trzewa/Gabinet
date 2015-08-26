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
//using mysettings = Gabinet.Properties.Settings;

namespace Gabinet
{
    public partial class Rejestracja : Form
    {
        //public string dbconnection_gabinet;
        private string idprzychodni;

        public Rejestracja()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            Update_Przychodnia();
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
                    RejestracjaPacjenta f2 = new RejestracjaPacjenta(id);                    
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
                myDataAdapter = database.Select("select nazwisko, imie, pesel, telefon, mail, pacjent.idpacjent, plec from pacjentkontakt inner join pacjent on pacjentkontakt.idpacjent=pacjent.idpacjent inner join plec on plec.idplec=pacjent.idplec inner join kontakt on pacjentkontakt.idkontakt=kontakt.idkontakt where pesel like '%" + pesel + "%' and nazwisko like '%" + nazwisko.ToString() + "%' and imie like '%" + imie.ToString() + "%'", database.Conect());

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
                if (dataGridViewPacjenci.RowCount != 0)
                {
                    int row = dataGridViewPacjenci.CurrentCell.RowIndex;
                    string id = dataGridViewPacjenci.Rows[row].Cells[5].Value.ToString();
                    this.Opacity = 0.5;
                    DanePacjent f2 = new DanePacjent(id);
                    f2.ShowDialog();
                    this.Opacity = 1;
                }
                else
                {
                    MessageBox.Show("Musisz wybrać pacjenta!");
                }
            }
        }

        private void toolStripZmien_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Edycja terminu wizyty")
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
                    PacjentWizyta f2 = new PacjentWizyta(id);
                    f2.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Musisz wybrać pacjenta!");
                }
            }
        }

        private void toolStripButtonHarmonogram_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Harmonogram wizyt")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                this.Visible = false;
                RejestracjaPacjenta f2 = new RejestracjaPacjenta(this);
                f2.ShowDialog();
                this.Visible = true;              
            }
        }

        private void toolStripButtonHistoria_Click(object sender, EventArgs e)
        {
            
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Historia wizyt pacjenta")
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
                    this.Opacity = 0.5;                    
                    int row = dataGridViewPacjenci.CurrentCell.RowIndex;
                    string id = dataGridViewPacjenci.Rows[row].Cells[5].Value.ToString();
                    PacjentWizyta f2 = new PacjentWizyta(id, true);                    
                    f2.ShowDialog();
                    this.Opacity = 1;
                }
                else
                {
                    MessageBox.Show("Musisz wybrać pacjenta!");
                }
            }
        }

        private void toolStripButtonListaWizyt_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Zaplanowane wizyty pacjenta")
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
                    this.Opacity = 0.5;
                    int row = dataGridViewPacjenci.CurrentCell.RowIndex;
                    string id = dataGridViewPacjenci.Rows[row].Cells[5].Value.ToString();
                    PacjentWizyta f2 = new PacjentWizyta(id, false);
                    f2.ShowDialog();
                    this.Opacity = 1;
                }
                else
                {
                    MessageBox.Show("Musisz wybrać pacjenta!");
                }
            }
        }

        private void toolStripButtonEdycjaDane_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Edycja danych pacjenta")
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
                    int row = dataGridViewPacjenci.CurrentCell.RowIndex;
                    string id = dataGridViewPacjenci.Rows[row].Cells[5].Value.ToString();
                    this.Visible = false;
                    DodajPacjent f2 = new DodajPacjent(id);
                    f2.ShowDialog();
                    this.Visible = true;
                    while (dataGridViewPacjenci.Rows.Count != 0)
                    {
                        dataGridViewPacjenci.Rows.RemoveAt(0);
                    }                    
                }
                else
                {
                    MessageBox.Show("Musisz wybrać pacjenta!");
                }
            }
        }

        private void toolStripButtonOpiekun_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Opiekun")
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
                    int row = dataGridViewPacjenci.CurrentCell.RowIndex;
                    string id = dataGridViewPacjenci.Rows[row].Cells[5].Value.ToString();
                    this.Opacity = 0.5;
                    EdytujOpiekun f2 = new EdytujOpiekun(id);
                    f2.ShowDialog();
                    this.Opacity = 1;
                }
                else
                {
                    MessageBox.Show("Musisz wybrać pacjenta!");
                }
            }
        }

        public void Update_Przychodnia()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from przychodnia ORDER BY idprzychodnia DESC LIMIT 1", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.label4.Text = element["nazwa"].ToString();
                    this.idprzychodni = element["idprzychodnia"].ToString();
                }

                myDataAdapter = database.Select("select * from przychodniaadres where idprzychodnia='" + this.idprzychodni + "'", database.Conect());
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    DataRow element = dt.Rows[1];
                    string idadres = element["idadres"].ToString();
                    myDataAdapter = database.Select("select * from adres where idadres='" + idadres + "'", database.Conect());

                    myDataAdapter.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        element = dt.Rows[2];
                        this.label5.Text = element["ulica"].ToString() + " " + element["nr_budynku"].ToString() + ", " + element["kod_pocztowy"].ToString() + " " + element["miasto"].ToString();
                    }
                }

                myDataAdapter = database.Select("select * from przychodniakontakt where idprzychodnia='" + this.idprzychodni + "'", database.Conect());
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    DataRow element = dt.Rows[3];
                    string idkontakt = element["idkontakt"].ToString();
                    myDataAdapter = database.Select("select * from kontakt where idkontakt='" + idkontakt + "'", database.Conect());

                    myDataAdapter.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        element = dt.Rows[4];
                        this.label6.Text = element["telefon"].ToString() + " ; " + element["mail"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
