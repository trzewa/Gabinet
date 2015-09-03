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
//using mysettings = Gabinet.Properties.Settings;

namespace Gabinet
{
    public partial class DodajPracownik : Form
    {
        //public string dbconnection_gabinet;
        private string idpracownik;
        private string idkontakt;
        private string idadres;
        private string inputLogin, inputHaslo;

        public DodajPracownik()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            buttonZmien.Visible = false;
            Update_comboBoxPlec();
            Update_comboBoxWojewodztwo();
            Update_comboBoxMiasto();
            Update_comboBoxUlica();
            Update_comboBoxStanowisko();
        }

        public DodajPracownik(string idpracownikReceive)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            this.idpracownik = idpracownikReceive;
            buttonZapisz.Visible = false;
            this.Text = "Edycja danych pracownika";
            //textBoxImie.Enabled = false;
            textBoxPesel.Enabled = false;
            comboBoxPlec.Enabled = false;
            dateTimePickerZatrudnienia.Enabled = false;
            Update_daneAdresowe();
            Update_daneKontaktowe();
            Update_danePodstawowe();
        }

        public void Update_comboBoxPlec()
        {
            try
            {

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("SELECT * FROM plec", database.Conect());

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
                myDataAdapter = database.Select("SELECT * FROM stanowisko", database.Conect());

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
                myDataAdapter = database.Select("SELECT distinct wojewodztwo FROM gus ORDER BY wojewodztwo ASC", database.Conect());

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
                myDataAdapter = database.Select("SELECT distinct miejscowosc FROM gus ORDER BY miejscowosc ASC", database.Conect());

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
                myDataAdapter = database.Select("SELECT distinct adres FROM gus ORDER BY adres ASC", database.Conect());

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
            string plec, wojewodztwo, miasto, ulica, stanowisko = ""; 

            try
            {
                string imie = this.textBoxImie.Text;
                string nazwisko = this.textBoxNazwisko.Text;
                string dataZatrudnienia = this.dateTimePickerZatrudnienia.Text;
                string pesel = this.textBoxPesel.Text;
                plec = (comboBoxPlec.SelectedItem as ComboboxItem).Hidden_Id.ToString();
                string pwz = this.textBoxPwz.Text;

                wojewodztwo = (comboBoxWojewodztwo.SelectedItem as ComboboxItem).Text.ToString();
                miasto = (comboBoxMiasto.SelectedItem as ComboboxItem).Text.ToString();
                ulica = (comboBoxUlica.SelectedItem as ComboboxItem).Text.ToString();
                string nrDomu = this.textBoxNrDomu.Text;
                string nrMieszkania = this.textBoxNrMieszkania.Text;
                string kod = this.maskedTextBoxKod.Text;
                string telefon = this.textBoxTelefon.Text;
                string mail = this.textBoxMail.Text;

                string login = this.textBoxLogin.Text;
                string haslo = this.textBoxHaslo.Text;
                string hasloRepeat = this.textBoxHasloRepeat.Text;
                stanowisko = (comboBoxStanowisko.SelectedItem as ComboboxItem).Hidden_Id.ToString();
               
                    MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                    Database database = new Database();

                    if (imie.Equals("") || nazwisko.Equals("") || pesel.Equals("") || plec.Equals("") || stanowisko.Equals(""))
                    {
                        MessageBox.Show("Brak danych w sekcji Dane podstawowe");
                    }
                    else if (wojewodztwo.Equals("") || miasto.Equals("") || kod.Equals("") || ulica.Equals("") || nrDomu.Equals("") || telefon.Equals(""))
                    {
                        MessageBox.Show("Brak danych w sekcji Adres zamieszkania");
                    }
                    else if (login.Equals("") || haslo.Equals(""))
                    {
                        MessageBox.Show("Login i hasło są wymagane");
                    }
                    else
                    {
                        database.Insert("insert into pracownik (idstanowisko, idplec, imie, nazwisko, pesel, numer_pwz, data_zatrudnienia) VALUES('" + stanowisko + "','" + plec + "','" + imie.ToString() + "','" + nazwisko.ToString() + "','" + pesel + "','" + pwz.ToString() + "','" + dataZatrudnienia + "')", database.Conect());
                        database.Insert("insert into adres (wojewodztwo, miasto, kod_pocztowy, ulica, nr_budynku, nr_lokalu) VALUES('" + wojewodztwo.ToString() + "','" + miasto.ToString() + "','" + kod.ToString() + "','" + ulica.ToString() + "','" + nrDomu + "','" + nrMieszkania + "')", database.Conect());
                        database.Insert("insert into kontakt (telefon, mail) VALUES('" + telefon.ToString() + "','" + mail.ToString() + "')", database.Conect());
                        database.Insert("insert pracownikadres (idpracownik, idadres) select max(idpracownik), max(idadres) from pracownik, adres", database.Conect());
                        database.Insert("insert pracownikkontakt (idpracownik, idkontakt) select max(idpracownik), max(idkontakt) from pracownik, kontakt", database.Conect());

                        myDataAdapter = database.Select("select max(idpracownik) from pracownik", database.Conect());
                        DataTable dt = new DataTable();
                        myDataAdapter.Fill(dt);


                        if (dt.Rows.Count == 1)
                        {

                            DataRow element = dt.Rows[0];
                            this.idpracownik = element["max(idpracownik)"].ToString();
                        }

                        Cryption hasloSzyfr = new Cryption();
                        string hs = hasloSzyfr.CryptMd5(haslo);

                            database.Insert("insert user (idpracownik, login, haslo) VALUES('" + this.idpracownik + "','" + login.ToString() + "','" + hs + "')", database.Conect());


                            DialogResult result = MessageBox.Show("Pracownik dodany");

                            if (result == System.Windows.Forms.DialogResult.OK)
                            {
                                DodajPacjent.ActiveForm.Close();
                            }
                        
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

        public void Update_danePodstawowe()
        {
            Update_comboBoxStanowisko();
            Update_comboBoxPlec();

            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from pracownik inner join stanowisko on stanowisko.idstanowisko=pracownik.idstanowisko inner join plec on plec.idplec=pracownik.idplec inner join user on user.idpracownik=pracownik.idpracownik where pracownik.idpracownik='" + this.idpracownik + "'", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.textBoxImie.Text = element["imie"].ToString();
                    this.textBoxNazwisko.Text = element["nazwisko"].ToString();
                    DateTime dateTime = (DateTime)element["data_zatrudnienia"];
                    this.dateTimePickerZatrudnienia.Text = dateTime.ToString("yyyy-MM-dd");
                    this.textBoxPesel.Text = element["pesel"].ToString();
                    this.textBoxPwz.Text = element["numer_pwz"].ToString();                    
                    this.comboBoxPlec.SelectedIndex = comboBoxPlec.FindStringExact(element["plec"].ToString());
                    this.comboBoxStanowisko.SelectedIndex = comboBoxStanowisko.FindStringExact(element["nazwa"].ToString());
                    this.textBoxLogin.Text = this.inputLogin = element["login"].ToString();
                    this.textBoxHaslo.Text = this.inputHaslo = element["haslo"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Update_daneAdresowe()
        {
            Update_comboBoxMiasto();
            Update_comboBoxUlica();
            Update_comboBoxWojewodztwo();

            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from adres inner join pracownikadres on adres.idadres=pracownikadres.idadres where idpracownik='" + this.idpracownik + "'", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.comboBoxWojewodztwo.SelectedIndex = comboBoxWojewodztwo.FindStringExact(element["wojewodztwo"].ToString());
                    this.comboBoxMiasto.SelectedIndex = comboBoxMiasto.FindStringExact(element["miasto"].ToString());
                    this.comboBoxUlica.SelectedIndex = comboBoxUlica.FindStringExact(element["ulica"].ToString());
                    this.textBoxNrDomu.Text = element["nr_budynku"].ToString();
                    this.textBoxNrMieszkania.Text = element["nr_lokalu"].ToString();
                    this.maskedTextBoxKod.Text = element["kod_pocztowy"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_daneKontaktowe()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from kontakt inner join pracownikkontakt on kontakt.idkontakt=pracownikkontakt.idkontakt where idpracownik='" + this.idpracownik + "'", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.textBoxMail.Text = element["mail"].ToString();
                    this.textBoxTelefon.Text = element["telefon"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonZmien_Click(object sender, EventArgs e)
        {
            try
            {
                string imie = this.textBoxImie.Text;
                string nazwisko = this.textBoxNazwisko.Text;
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
                string stanowisko = (comboBoxStanowisko.SelectedItem as ComboboxItem).Hidden_Id.ToString();
                
                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter = database.Select("select idadres from pracownikadres where idpracownik='" + this.idpracownik + "'", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.idadres = element["idadres"].ToString();
                    dt.Clear();
                }

                myDataAdapter = database.Select("select idkontakt from pracownikkontakt where idpracownik='" + this.idpracownik + "'", database.Conect());
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.idkontakt = element["idkontakt"].ToString();
                }

                if (imie.Equals("") || nazwisko.Equals("") || stanowisko.Equals(""))
                {
                    MessageBox.Show("Brak danych w sekcji Dane podstawowe");
                }
                else if (wojewodztwo.Equals("") || miasto.Equals("") || kod.Equals("") || ulica.Equals("") || nrDomu.Equals("") || telefon.Equals(""))
                {
                    MessageBox.Show("Brak danych w sekcji Adres zamieszkania");
                }
                else if (login.Equals("") || haslo.Equals(""))
                {
                    MessageBox.Show("Login i hasło są wymagane");
                }
                else
                {
                    if (haslo.Equals(this.inputHaslo))
                    {
                        database.Update("update user set haslo = '" + haslo.ToString() + "' where idpracownik = '" + this.idpracownik + "'", database.Conect());
                    }
                    else
                    {
                        Cryption hasloSzyfr = new Cryption();
                        string hs = hasloSzyfr.CryptMd5(haslo);
                        database.Update("update user set haslo = '" + hs + "' where idpracownik = '" + this.idpracownik + "'", database.Conect());
                    }                   
                    
                    database.Update("update pracownik set idstanowisko = '" + stanowisko + "', imie = '" + imie.ToString() + "', nazwisko = '" + nazwisko.ToString() + "', numer_pwz = '" + pwz.ToString() + "'  where idpracownik = '" + this.idpracownik + "'", database.Conect());
                    database.Update("update user set login = '" + login.ToString() + "' where idpracownik = '" + this.idpracownik + "'", database.Conect());
                    database.Update("update adres set wojewodztwo = '" + wojewodztwo.ToString() + "', miasto = '" + miasto.ToString() + "', kod_pocztowy = '" + kod.ToString() + "', ulica = '" + ulica.ToString() + "', nr_budynku = '" + nrDomu + "', nr_lokalu = '" + nrMieszkania + "' where idadres = '" + this.idadres + "'", database.Conect());
                    database.Update("update kontakt set telefon = '" + telefon.ToString() + "', mail = '" + mail.ToString() + "' where idkontakt = '" + this.idkontakt + "'", database.Conect());

                    DialogResult result = MessageBox.Show("Zaktualizowano dane pracownika", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        DodajPracownik.ActiveForm.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxPesel_Leave(object sender, EventArgs e)
        {
            if (textBoxPesel.TextLength != 11)
            {
                MessageBox.Show("Numer PESEL ma za mało cyfr!");
                textBoxPesel.Select();
            }
        }

        private void textBoxPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8)
                {
                    MessageBox.Show("Można używaż tylko cyfr!");
                    e.KeyChar = (char)0;
                }
            }
        }

        private void textBoxMail_Leave(object sender, EventArgs e)
        {
            if ((textBoxMail.Text.IndexOf("@") == -1 || textBoxMail.Text.IndexOf(".") == -1))
            {
                MessageBox.Show("Nieprawidłowy adres mailowy!");
                textBoxMail.Select();
            }
        }

        private void textBoxHaslo_TextChanged(object sender, EventArgs e)
        {            
                
        }

        private void textBoxPesel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
