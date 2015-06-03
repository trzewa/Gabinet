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
    public partial class DodajPacjent : Form
    {
        public string dbconnection_gabinet;
        public string idopiekun;
        public string idpacjent;
        
        public DodajPacjent()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
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
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            buttonZapisz.Visible = false;
            this.Text = "Edycja danych pacjenta";
            textBoxImie.Enabled = false;
            textBoxPesel.Enabled = false;
            maskedTextBoxNip.Enabled = false;
            comboBoxPlec.Enabled = false;
            dateTimePickerUrodzenia.Enabled = false;
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
                myDataAdapter = database.Select("select * from ubezpieczenia", this.dbconnection_gabinet);

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
                myDataAdapter = database.Select("select * from fundusz", this.dbconnection_gabinet);

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
            database.Insert("insert into pacjent (idplec, idubezpieczenia, idfundusz, imie, nazwisko, data_urodzenia, pesel, nip, miejsce_pracy, zawod, nip_platnika) VALUES('" + plec + "','" + uprawnienia + "','" + nfz + "','" + imie.ToString() + "','" + nazwisko.ToString() + "','" + dataUrodzenia + "','" + pesel + "','" + nip.ToString() + "','" + zaklad.ToString() + "','" + zawod.ToString() + "','" + nipPraca.ToString() + "')", this.dbconnection_gabinet);
            database.Insert("insert into adres (wojewodztwo, miasto, kod_pocztowy, ulica, nr_budynku, nr_lokalu) VALUES('" + wojewodztwo.ToString() + "','" + miasto.ToString() + "','" + kod.ToString() + "','" + ulica.ToString() + "','" + nrDomu + "','" + nrMieszkania + "')", this.dbconnection_gabinet);
            database.Insert("insert into kontakt (telefon, mail) VALUES('" + telefon.ToString() + "','" + mail.ToString() + "')", this.dbconnection_gabinet);
            database.Insert("insert pacjentadres (idpacjent, idadres) select max(idpacjent), max(idadres) from pacjent, adres", this.dbconnection_gabinet);
            database.Insert("insert pacjentkontakt (idpacjent, idkontakt) select max(idpacjent), max(idkontakt) from pacjent, kontakt", this.dbconnection_gabinet);

            if (this.idopiekun != null)
            {
                database.Insert("insert pacjentopiekun (idpacjent, idopiekun) select max(idpacjent), '" + idopiekun + "' from pacjent, opiekun", this.dbconnection_gabinet);
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
                this.Opacity = 0.5;
                dodajOpiekun f2 = new dodajOpiekun();                
                f2.ShowDialog();
                this.idopiekun = f2.idopiekunSend;
                this.Opacity = 1;
            }

        }

        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
