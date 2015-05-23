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
    public partial class Wizyta : Form
    {

        public string dbconnection_gabinet;
        private string idwizyta;
        private string idpacjent;
        private string idrecepta;
        private string idzwolnienie;
        public string kod;
        public string nazwa;
        public string idChoroby = null;
        public string idTypBadania = null;
        

        public Wizyta(string idwizytaReceive)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            this.idwizyta = idwizytaReceive;
            Update_danePacjent();
        }

        public void Update_danePacjent()
        {
            try
            {
                Database database = new Database();

                MySqlDataAdapter myDA = new MySqlDataAdapter();
                myDA = database.Select("select idpacjent from wizyta where idwizyta='" + this.idwizyta + "'", this.dbconnection_gabinet);
                DataTable dT = new DataTable();
                myDA.Fill(dT);

                if (dT.Rows.Count == 1)
                {
                    DataRow element = dT.Rows[0];
                    this.idpacjent = element["idpacjent"].ToString();
                }

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();                
                myDataAdapter = database.Select("select nazwisko, imie, ulica, nr_budynku, nr_lokalu, miasto, kod_pocztowy, mail, telefon from pacjent inner join pacjentadres on pacjent.idpacjent=pacjentadres.idpacjent inner join adres on adres.idadres=pacjentadres.idadres inner join pacjentkontakt on pacjent.idpacjent=pacjentkontakt.idpacjent inner join kontakt on pacjentkontakt.idkontakt=kontakt.idkontakt where pacjent.idpacjent='" + this.idpacjent + "'", this.dbconnection_gabinet);
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    DataRow element = dt.Rows[0];
                    this.labelNazwiskoImie.Text = element["nazwisko"].ToString() + " " + element["imie"].ToString();
                    this.labelAdres.Text = element["ulica"].ToString() + " " + element["nr_budynku"].ToString() + " m." + element["nr_lokalu"].ToString() + "; " + element["kod_pocztowy"].ToString() + " " + element["miasto"].ToString();
                    
                    this.labelTelefon.Text = element["telefon"].ToString();
                    this.linkLabelMail.Text = element["mail"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSzukajProcedury_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Wyszukiwanie")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                this.Opacity = 0.5;
                int button = 1;
                szukajProcedury f2 = new szukajProcedury(this, button);
                f2.Owner = this;
                f2.ShowDialog();
                textBoxKod.Text = kod;
                textBoxNazwa.Text = nazwa;
                this.Opacity = 1;
            }
        }

        private void buttonSzukajChoroby_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Wyszukiwanie")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                this.Opacity = 0.5;
                int button = 2;
                szukajProcedury f2 = new szukajProcedury(this, button);
                f2.Owner = this;
                f2.ShowDialog();
                textBoxKodChoroby.Text = kod;
                textBoxNazwaChoroby.Text = nazwa;
                this.Opacity = 1;
            }
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZakoncz_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string data = dt.ToString("yyyy-MM-dd");
            string godzina = dt.ToString("HH:mm:ss");

            if (idTypBadania != null && idChoroby != null)
            {
                this.Opacity = 0.5;
                String message = "Czy chcesz zatwierdzić wizyte?\nUWAGA!\nPo zatwierdzeniu wizyty nie będzie możliwości wykonania w niej żadnych zmian!";
                String caption = "Kończenie wizyty";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Database database = new Database();
                        database.Update("update wizyta set idchoroby='" + idChoroby + "', idtyp_badania='" + idTypBadania + "', data='" + data + "', godzina='" + godzina + "', stan='1' where idwizyta='" + idwizyta + "'", this.dbconnection_gabinet);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);                        
                    }
                }
                else this.Opacity = 1;
                
            }
            else MessageBox.Show("Wprowadź typ badania i/lub rozpoznanie!", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            
        }
    }
}
