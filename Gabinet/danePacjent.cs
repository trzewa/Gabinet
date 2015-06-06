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
    public partial class danePacjent : Form
    {

        public string dbconnection_gabinet;
        public string idpacjent;        

        public danePacjent(string idpacjentReceive)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            this.idpacjent = idpacjentReceive;
            Update_danePodstawowe();
            Update_daneAdresowe();
            Update_daneKontaktowe();
            Update_opiekun();
        }



        public void Update_danePodstawowe()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from pacjent inner join ubezpieczenia on ubezpieczenia.idubezpieczenia=pacjent.idubezpieczenia inner join fundusz on fundusz.idfundusz=pacjent.idfundusz inner join plec on plec.idplec=pacjent.idplec where idpacjent='" + this.idpacjent + "'", this.dbconnection_gabinet);
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt); 

                if (dt.Rows.Count == 1)
                    {
                        DataRow element = dt.Rows[0];
                        this.textBoxImie.Text = element["imie"].ToString();
                        this.textBoxNazwisko.Text = element["nazwisko"].ToString();
                        DateTime dateTime = (DateTime)element["data_urodzenia"];
                        this.textBoxDataUrodzenia.Text = dateTime.ToString("yyyy-MM-dd");
                        this.textBoxPesel.Text = element["pesel"].ToString();
                        this.maskedTextBoxNipPracownika.Text = element["nip"].ToString();
                        this.textBoxZakladNazwa.Text = element["miejsce_pracy"].ToString();
                        this.textBoxZawod.Text = element["zawod"].ToString();
                        this.maskedTextBoxNipPraca.Text = element["nip_platnika"].ToString();
                        this.textBoxPlec.Text = element["plec"].ToString();
                        this.textBoxUprawnienia.Text = element["kod"].ToString();
                        this.textBoxOddzialNfz.Text = element["oddzial"].ToString();                        
                    }            
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        public void Update_daneAdresowe()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from adres inner join pacjentadres on adres.idadres=pacjentadres.idadres where idpacjent='" + this.idpacjent + "'", this.dbconnection_gabinet);
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.textBoxWojewodztwo.Text = element["wojewodztwo"].ToString();
                    this.textBoxMiasto.Text = element["miasto"].ToString();
                    this.textBoxUlica.Text = element["ulica"].ToString();
                    this.textBoxNrDomu.Text = element["nr_budynku"].ToString();
                    this.textBoxNrMieszkania.Text = element["nr_lokalu"].ToString();
                    this.textBoxKod.Text = element["kod_pocztowy"].ToString();                  
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
                myDataAdapter = database.Select("select * from kontakt inner join pacjentkontakt on kontakt.idkontakt=pacjentkontakt.idkontakt where idpacjent='" + this.idpacjent + "'", this.dbconnection_gabinet);
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

        public void Update_opiekun()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select nazwisko, imie, opiekun.idopiekun from pacjentopiekun left join opiekun on pacjentopiekun.idopiekun=opiekun.idopiekun where idpacjent='" + this.idpacjent + "'", this.dbconnection_gabinet);
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["nazwisko"].ToString() + " " + dt.Rows[i]["imie"].ToString();
                    item.Hidden_Id = dt.Rows[i]["idopiekun"].ToString();
                    comboBoxOpiekun.Items.Add(item);
                    this.textBoxLiczbaOpieka.Text = comboBoxOpiekun.Items.Count.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxOpiekun_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                string selected_item = (comboBoxOpiekun.SelectedItem as ComboboxItem).Hidden_Id.ToString();
                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter = database.Select("select telefon, mail from kontakt inner join opiekunkontakt on kontakt.idkontakt=opiekunkontakt.idkontakt WHERE idopiekun='" + selected_item + "'", this.dbconnection_gabinet);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.textBoxMailOpieka.Text = element["mail"].ToString();
                    this.textBoxTelefonOpieka.Text = element["telefon"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
