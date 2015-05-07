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
        public string dbconnection_gus;
        

        public DodajPacjent()
        {
            InitializeComponent();
            this.dbconnection_gabinet = "datasource=localhost;database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            this.dbconnection_gus = "datasource=localhost;database=" + mysettings.Default.database1 + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            Update_comboBoxUprawnienia();
            Update_comboBoxNfz();            
            Update_comboBoxWojewodztwo();
            Update_comboBoxMiasto();
            Update_comboBoxUlica();            
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
        
        public void Update_comboBoxWojewodztwo()
        {
            try
            {
                
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("SELECT distinct wojewodztwo FROM mytable ORDER BY wojewodztwo ASC", this.dbconnection_gus);

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
                myDataAdapter = database.Select("SELECT distinct miejscowosc FROM mytable ORDER BY miejscowosc ASC", this.dbconnection_gus);

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
                myDataAdapter = database.Select("SELECT distinct adres FROM mytable ORDER BY adres ASC", this.dbconnection_gus);

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
            string imie = this.textBoxImie.Text;
            string nazwisko = this.textBoxNazwisko.Text;
            string dataUrodzenia = this.dateTimePickerUrodzenia.Text;
            string pesel = this.textBoxPesel.Text;
            string nip = this.maskedTextBoxNip.Text;

            string wojewodztwo = (comboBoxWojewodztwo.SelectedItem as ComboboxItem).Text.ToString();
            string miasto = (comboBoxMiasto.SelectedItem as ComboboxItem).Text.ToString();
            string ulica = (comboBoxUlica.SelectedItem as ComboboxItem).Text.ToString();
            string nrDomu = this.textBoxNrDomu.Text;
            string nrMieszkania = this.textBoxNrMieszkania.Text;
            string kod = this.maskedTextBoxKod.Text;
            string telefon = this.textBoxTelefon.Text;
            string mail = this.textBoxMail.Text;

            string uprawnienia = (comboBoxUprawnienia.SelectedItem as ComboboxItem).Text.ToString();
            string nfz = (comboBoxNfz.SelectedItem as ComboboxItem).Text.ToString();

            string zaklad = this.textBoxZakladNazwa.Text;
            string zawod = this.textBoxZawod.Text;
            string nipPraca = this.maskedTextBoxNipPraca.Text;


        }
        
    }
}
