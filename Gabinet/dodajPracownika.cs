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
using System.Net.Mail;
using mysettings = Gabinet.Properties.Settings;

namespace Gabinet
{
    public partial class dodajPracownika : Form
    {
        public string dbconnection_gabinet;
        private string idpracownik;

        public dodajPracownika()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;

            Update_comboBoxPlec();
            Update_comboBoxWojewodztwo();
            Update_comboBoxMiasto();
            Update_comboBoxUlica();
            Update_comboBoxStanowisko();
        }

        public void Update_comboBoxPlec()
        {
            try
            {

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("SELECT * FROM plec", this.dbconnection_gabinet);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["plec"].ToString();
                    item.Hidden_Id = dt.Rows[i]["idplec"].ToString();
                    comboBoxPlec.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_comboBoxStanowisko()
        {
            try
            {

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("SELECT * FROM stanowisko", this.dbconnection_gabinet);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["nazwa"].ToString();
                    item.Hidden_Id = dt.Rows[i]["idstanowisko"].ToString();
                    comboBoxStanowisko.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_comboBoxWojewodztwo()
        {
            try
            {

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("SELECT distinct wojewodztwo FROM gus ORDER BY wojewodztwo ASC", this.dbconnection_gabinet);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["wojewodztwo"].ToString();
                    //item.Hidden_Id = dt.Rows[i]["miasto"].ToString();                    
                    comboBoxWojewodztwo.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_comboBoxMiasto()
        {
            try
            {

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("SELECT distinct miejscowosc FROM gus ORDER BY miejscowosc ASC", this.dbconnection_gabinet);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["miejscowosc"].ToString();
                    //item.Hidden_Id = dt.Rows[i]["miasto"].ToString();                    
                    comboBoxMiasto.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_comboBoxUlica()
        {
            try
            {

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("SELECT distinct adres FROM gus ORDER BY adres ASC", this.dbconnection_gabinet);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["adres"].ToString();
                    //item.Hidden_Id = dt.Rows[i]["miasto"].ToString();                    
                    comboBoxUlica.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                string imie = this.textBoxImie.Text;
                string nazwisko = this.textBoxNazwisko.Text;
                string dataZatrudnienia = this.dateTimePickerZatrudnienia.Text;
                string pesel = this.textBoxPesel.Text;
                string plec = (comboBoxPlec.SelectedItem as ComboboxItem).Hidden_Id.ToString();
                string pwz = this.textBoxPwz.Text;

                string wojewodztwo = (comboBoxWojewodztwo.SelectedItem as ComboboxItem).Text.ToString();
                string miasto = (comboBoxMiasto.SelectedItem as ComboboxItem).Text.ToString();
                string ulica = (comboBoxUlica.SelectedItem as ComboboxItem).Text.ToString();
                string nrDomu = this.textBoxNrDomu.Text;
                string nrMieszkania = this.textBoxNrMieszkania.Text;
                string kod = this.maskedTextBoxKod.Text;
                string telefon = this.textBoxTelefon.Text;
                string mail = this.textBoxMail.Text;

                string login = this.textBoxLogin.Text;
                string haslo = this.textBoxHaslo.Text;
                string hasloRepeat = this.textBoxHasloRepeat.Text;
                string stanowisko = (comboBoxStanowisko.SelectedItem as ComboboxItem).Hidden_Id.ToString();

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                database.Insert("insert into pracownik (idstanowisko, idplec, imie, nazwisko, pesel, numer_pwz) VALUES('" + stanowisko + "','" + plec + "','" + imie.ToString() + "','" + nazwisko.ToString() + "','" + pesel + "','" + pwz.ToString() + "')", this.dbconnection_gabinet);
                database.Insert("insert into adres (wojewodztwo, miasto, kod_pocztowy, ulica, nr_budynku, nr_lokalu) VALUES('" + wojewodztwo.ToString() + "','" + miasto.ToString() + "','" + kod.ToString() + "','" + ulica.ToString() + "','" + nrDomu + "','" + nrMieszkania + "')", this.dbconnection_gabinet);
                database.Insert("insert into kontakt (telefon, mail) VALUES('" + telefon.ToString() + "','" + mail.ToString() + "')", this.dbconnection_gabinet);
                database.Insert("insert pracownikadres (idpracownik, idadres) select max(idpracownik), max(idadres) from pracownik, adres", this.dbconnection_gabinet);
                database.Insert("insert pracownikkontakt (idpracownik, idkontakt) select max(idpracownik), max(idkontakt) from pracownik, kontakt", this.dbconnection_gabinet);

                myDataAdapter = database.Select("select max(idpracownik) from pracownik", this.dbconnection_gabinet);
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                //string idpracownik = null;
                if (dt.Rows.Count == 1)
                {

                    DataRow element = dt.Rows[0];
                    this.idpracownik = element["max(idpracownik)"].ToString();
                }
                database.Insert("insert user (idpracownik, login, haslo) VALUES('" + this.idpracownik + "','" + login.ToString() + "','" + haslo.ToString() + "')", this.dbconnection_gabinet);


                DialogResult result = MessageBox.Show("Pracownik dodany");

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    DodajPacjent.ActiveForm.Close();
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
    }
}
