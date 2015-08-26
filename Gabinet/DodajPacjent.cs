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
    public partial class DodajPacjent : Form
    {
        //public string dbconnection_gabinet;
        public string idopiekun = null;
        public string idopiekunDrugi = null;
        public string idpacjent;
        private string idadres;
        private string idkontakt;
        
        public DodajPacjent()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            //this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            this.idopiekun = null;
            buttonZmien.Visible = false;
            Update_comboBoxUprawnienia();
            Update_comboBoxNfz();
            Update_comboBoxPlec();
            Update_comboBoxWojewodztwo();
            Update_comboBoxMiasto();
            Update_comboBoxUlica();            
        }

        public DodajPacjent(string idpacjentReceive)
        {
            InitializeComponent();
                
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.idpacjent = idpacjentReceive;
            //this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";            
            buttonZapisz.Visible = false;
            buttonDodajOpiekun.Visible = false;
            this.Text = "Edycja danych pacjenta";
            textBoxImie.Enabled = false;
            textBoxPesel.Enabled = false;
            maskedTextBoxNip.Enabled = false;
            comboBoxPlec.Enabled = false;
            dateTimePickerUrodzenia.Enabled = false;                      
            Update_danePodstawowe();
            Update_daneAdresowe();
            Update_daneKontaktowe();
        }

        private void comboBoxUprawnienia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNfz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Update_comboBoxUprawnienia()
        {
           
            try
            {
                
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from ubezpieczenia", database.Conect());

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                comboBoxUprawnienia.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["kod"].ToString();
                    item.Hidden_Id = dt.Rows[i]["idubezpieczenia"].ToString();
                    comboBoxUprawnienia.Items.Add(item);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_comboBoxNfz()
        {
            try
            {
                
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from fundusz", database.Conect());

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                comboBoxNfz.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["oddzial"].ToString();
                    item.Hidden_Id = dt.Rows[i]["idfundusz"].ToString();
                    comboBoxNfz.Items.Add(item);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void comboBoxUlica_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxMiasto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            try
            {            
            string imie = this.textBoxImie.Text;
            string nazwisko = this.textBoxNazwisko.Text;
            string dataUrodzenia = this.dateTimePickerUrodzenia.Text;
            string pesel = this.textBoxPesel.Text;
            string nip = this.maskedTextBoxNip.Text;
            string plec = (comboBoxPlec.SelectedItem as ComboboxItem).Hidden_Id.ToString();

            string wojewodztwo = (comboBoxWojewodztwo.SelectedItem as ComboboxItem).Text.ToString();
            string miasto = (comboBoxMiasto.SelectedItem as ComboboxItem).Text.ToString();
            string ulica = (comboBoxUlica.SelectedItem as ComboboxItem).Text.ToString();
            string nrDomu = this.textBoxNrDomu.Text;
            string nrMieszkania = this.textBoxNrMieszkania.Text;
            string kod = this.maskedTextBoxKod.Text;
            string telefon = this.textBoxTelefon.Text;
            string mail = this.textBoxMail.Text;

            string uprawnienia = (comboBoxUprawnienia.SelectedItem as ComboboxItem).Hidden_Id.ToString();
            string nfz = (comboBoxNfz.SelectedItem as ComboboxItem).Hidden_Id.ToString();

            string zaklad = this.textBoxZakladNazwa.Text;
            string zawod = this.textBoxZawod.Text;
            string nipPraca = this.maskedTextBoxNipPraca.Text;
            
            Database database = new Database();
            database.Insert("insert into pacjent (idplec, idubezpieczenia, idfundusz, imie, nazwisko, data_urodzenia, pesel, nip, miejsce_pracy, zawod, nip_platnika) VALUES('" + plec + "','" + uprawnienia + "','" + nfz + "','" + imie.ToString() + "','" + nazwisko.ToString() + "','" + dataUrodzenia + "','" + pesel + "','" + nip.ToString() + "','" + zaklad.ToString() + "','" + zawod.ToString() + "','" + nipPraca.ToString() + "')", database.Conect());
            database.Insert("insert into adres (wojewodztwo, miasto, kod_pocztowy, ulica, nr_budynku, nr_lokalu) VALUES('" + wojewodztwo.ToString() + "','" + miasto.ToString() + "','" + kod.ToString() + "','" + ulica.ToString() + "','" + nrDomu + "','" + nrMieszkania + "')", database.Conect());
            database.Insert("insert into kontakt (telefon, mail) VALUES('" + telefon.ToString() + "','" + mail.ToString() + "')", database.Conect());
            database.Insert("insert pacjentadres (idpacjent, idadres) select max(idpacjent), max(idadres) from pacjent, adres", database.Conect());
            database.Insert("insert pacjentkontakt (idpacjent, idkontakt) select max(idpacjent), max(idkontakt) from pacjent, kontakt", database.Conect());

            if (this.idopiekun != null)
            {
                database.Insert("insert pacjentopiekun (idpacjent, idopiekun) select max(idpacjent), '" + idopiekun + "' from pacjent, opiekun", database.Conect());
            }

            if (this.idopiekunDrugi != null)
            {
                database.Insert("insert pacjentopiekun (idpacjent, idopiekun) select max(idpacjent), '" + idopiekunDrugi + "' from pacjent, opiekun", database.Conect());
            }

            DialogResult result = MessageBox.Show("Pacjent dodany");

            if (result == System.Windows.Forms.DialogResult.OK)
                {                    
                    DodajPacjent.ActiveForm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Nie zostały wypełnione pola obowiązkowe");
            }
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodajOpiekun_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Dodawanie opiekuna")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                if (idopiekun == null)
                {
                    this.Opacity = 0.5;
                    dodajOpiekun f2 = new dodajOpiekun();
                    f2.ShowDialog();
                    this.idopiekun = f2.idopiekunSend;
                    this.Opacity = 1;
                    if (idopiekun != null)
                    {
                        buttonDodajOpiekun.Text = "Dodaj drugiego opiekuna";
                    }
                }
                else
                {
                    this.Opacity = 0.5;
                    dodajOpiekun f2 = new dodajOpiekun();
                    f2.ShowDialog();
                    this.idopiekunDrugi = f2.idopiekunSend;
                    this.Opacity = 1;
                    if (idopiekunDrugi != null)
                    {
                        buttonDodajOpiekun.Text = "Niedostępne";
                        buttonDodajOpiekun.Enabled = false;
                    }
                }                
            }
        }

        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        public void Update_danePodstawowe()
        {
            Update_comboBoxUprawnienia();
            Update_comboBoxNfz();
            Update_comboBoxPlec(); 

            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from pacjent inner join ubezpieczenia on ubezpieczenia.idubezpieczenia=pacjent.idubezpieczenia inner join fundusz on fundusz.idfundusz=pacjent.idfundusz inner join plec on plec.idplec=pacjent.idplec where idpacjent='" + this.idpacjent + "'", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.textBoxImie.Text = element["imie"].ToString();
                    this.textBoxNazwisko.Text = element["nazwisko"].ToString();
                    DateTime dateTime = (DateTime)element["data_urodzenia"];
                    this.dateTimePickerUrodzenia.Text = dateTime.ToString("yyyy-MM-dd");
                    this.textBoxPesel.Text = element["pesel"].ToString();
                    this.maskedTextBoxNip.Text = element["nip"].ToString();
                    this.textBoxZakladNazwa.Text = element["miejsce_pracy"].ToString();
                    this.textBoxZawod.Text = element["zawod"].ToString();
                    this.maskedTextBoxNipPraca.Text = element["nip_platnika"].ToString();
                    this.comboBoxPlec.SelectedIndex = comboBoxPlec.FindStringExact(element["plec"].ToString());
                    this.comboBoxUprawnienia.SelectedIndex = comboBoxUprawnienia.FindStringExact(element["kod"].ToString());
                    this.comboBoxNfz.SelectedIndex = comboBoxNfz.FindStringExact(element["oddzial"].ToString());
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
                myDataAdapter = database.Select("select * from adres inner join pacjentadres on adres.idadres=pacjentadres.idadres where idpacjent='" + this.idpacjent + "'", database.Conect());
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
                myDataAdapter = database.Select("select * from kontakt inner join pacjentkontakt on kontakt.idkontakt=pacjentkontakt.idkontakt where idpacjent='" + this.idpacjent + "'", database.Conect());
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
                string nazwisko = this.textBoxNazwisko.Text;                

                string wojewodztwo = (comboBoxWojewodztwo.SelectedItem as ComboboxItem).Text.ToString();
                string miasto = (comboBoxMiasto.SelectedItem as ComboboxItem).Text.ToString();
                string ulica = (comboBoxUlica.SelectedItem as ComboboxItem).Text.ToString();
                string nrDomu = this.textBoxNrDomu.Text;
                string nrMieszkania = this.textBoxNrMieszkania.Text;
                string kod = this.maskedTextBoxKod.Text;
                string telefon = this.textBoxTelefon.Text;
                string mail = this.textBoxMail.Text;

                string uprawnienia = (comboBoxUprawnienia.SelectedItem as ComboboxItem).Hidden_Id.ToString();
                string nfz = (comboBoxNfz.SelectedItem as ComboboxItem).Hidden_Id.ToString();

                string zaklad = this.textBoxZakladNazwa.Text;
                string zawod = this.textBoxZawod.Text;
                string nipPraca = this.maskedTextBoxNipPraca.Text;

                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter = database.Select("select idadres from pacjentadres where idpacjent='" + idpacjent + "'", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.idadres = element["idadres"].ToString();
                    dt.Clear();
                }

                myDataAdapter = database.Select("select idkontakt from pacjentkontakt where idpacjent='" + idpacjent + "'", database.Conect());
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.idkontakt = element["idkontakt"].ToString();                   
                }

                database.Update("update pacjent set idubezpieczenia = '" + uprawnienia + "', idfundusz = '" + nfz + "', nazwisko = '" + nazwisko.ToString() + "', miejsce_pracy = '" + zaklad.ToString() + "', zawod = '" + zawod.ToString() + "', nip_platnika = '" + nipPraca.ToString() + "' where idpacjent = '" + this.idpacjent + "'", database.Conect());
                database.Update("update adres set wojewodztwo = '" + wojewodztwo.ToString() + "', miasto = '" + miasto.ToString() + "', kod_pocztowy = '" + kod.ToString() + "', ulica = '" + ulica.ToString() + "', nr_budynku = '" + nrDomu + "', nr_lokalu = '" + nrMieszkania + "' where idadres = '" + this.idadres + "'", database.Conect());
                database.Update("update kontakt set telefon = '" + telefon.ToString() + "', mail = '" + mail.ToString() + "' where idkontakt = '" + this.idkontakt + "'", database.Conect());
                
                DialogResult result = MessageBox.Show("Zaktualizowano dane pacjenta");

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

        private void textBoxPesel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPesel_Leave(object sender, EventArgs e)
        {
            if (textBoxPesel.TextLength != 11)
            {
                MessageBox.Show("Numer PESEL ma za mało cyfr!");
                textBoxPesel.Select();
            }
        }

        private void maskedTextBoxNip_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxMail_Leave(object sender, EventArgs e)
        {
            if ((textBoxMail.Text.IndexOf("@") == -1 || textBoxMail.Text.IndexOf(".") == -1))
            {
                MessageBox.Show("Nieprawidłowy adres mailowy!");
                textBoxMail.Select();
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
    }
}
