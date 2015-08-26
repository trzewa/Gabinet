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
    public partial class Gabinet : Form
    {
        //public string dbconnection_gabinet;
        private string idprzychodnia;
        private string idadres;
        private string idkontakt;

        public Gabinet()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            Gabinet_Check();            
        }

        private void Gabinet_Check()
        {
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            Database database = new Database();
            myDataAdapter = database.Select("select * from przychodnia ORDER BY idprzychodnia DESC LIMIT 1", database.Conect());
            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                buttonZapisz.Visible = false;
                buttonZmien.Visible = true;                
                DataRow element = dt.Rows[0];
                this.idprzychodnia = element["idprzychodnia"].ToString();
                this.Text = "Edycja danych przychodni";
                Update_danePodstawowe();
                Update_daneAdresowe();
                Update_daneKontaktowe();
            }
            else
            {
                buttonZapisz.Visible = true;
                buttonZmien.Visible = false;                
                Update_comboBoxNfz();
                Update_comboBoxWojewodztwo();
                Update_comboBoxMiasto();
                Update_comboBoxUlica();
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
            try
            {
                string nazwa = this.textBoxNazwa.Text;                
                string regon = this.textBoxRegon.Text;                

                string wojewodztwo = (comboBoxWojewodztwo.SelectedItem as ComboboxItem).Text.ToString();
                string miasto = (comboBoxMiasto.SelectedItem as ComboboxItem).Text.ToString();
                string ulica = (comboBoxUlica.SelectedItem as ComboboxItem).Text.ToString();
                string nrDomu = this.textBoxNrDomu.Text;                
                string kod = this.maskedTextBoxKod.Text;
                string telefon = this.textBoxTelefon.Text;
                string mail = this.textBoxMail.Text;

                string nfz = (comboBoxNfz.SelectedItem as ComboboxItem).Hidden_Id.ToString();
                
                Database database = new Database();
                database.Insert("insert into przychodnia (idfundusz, nazwa, regon) VALUES('" + nfz + "','" + nazwa + "','" + regon + "')", database.Conect());
                database.Insert("insert into adres (wojewodztwo, miasto, kod_pocztowy, ulica, nr_budynku) VALUES('" + wojewodztwo.ToString() + "','" + miasto.ToString() + "','" + kod.ToString() + "','" + ulica.ToString() + "','" + nrDomu + "')", database.Conect());
                database.Insert("insert into kontakt (telefon, mail) VALUES('" + telefon.ToString() + "','" + mail.ToString() + "')", database.Conect());
                database.Insert("insert przychodniaadres (idprzychodnia, idadres) select max(idprzychodnia), max(idadres) from przychodnia, adres", database.Conect());
                database.Insert("insert przychodniakontakt (idprzychodnia, idkontakt) select max(idprzychodnia), max(idkontakt) from przychodnia, kontakt", database.Conect());

                DialogResult result = MessageBox.Show("Dane przychodni dodane!","Dodawanie", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public void Update_daneAdresowe()
        {
            Update_comboBoxMiasto();
            Update_comboBoxUlica();
            Update_comboBoxWojewodztwo();

            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from adres inner join przychodniaadres on adres.idadres=przychodniaadres.idadres where idprzychodnia='" + this.idprzychodnia + "'", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.comboBoxWojewodztwo.SelectedIndex = comboBoxWojewodztwo.FindStringExact(element["wojewodztwo"].ToString());
                    this.comboBoxMiasto.SelectedIndex = comboBoxMiasto.FindStringExact(element["miasto"].ToString());
                    this.comboBoxUlica.SelectedIndex = comboBoxUlica.FindStringExact(element["ulica"].ToString());
                    this.textBoxNrDomu.Text = element["nr_budynku"].ToString();                    
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
                myDataAdapter = database.Select("select * from kontakt inner join przychodniakontakt on kontakt.idkontakt=przychodniakontakt.idkontakt where idprzychodnia='" + this.idprzychodnia + "'", database.Conect());
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

        public void Update_danePodstawowe()
        {
            Update_comboBoxNfz();

            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from przychodnia inner join fundusz on fundusz.idfundusz=przychodnia.idfundusz where idprzychodnia='" + this.idprzychodnia + "'", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.textBoxNazwa.Text = element["nazwa"].ToString();
                    this.textBoxRegon.Text = element["regon"].ToString();
                    this.comboBoxNfz.SelectedIndex = comboBoxNfz.FindStringExact(element["oddzial"].ToString());
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
                string nazwa = this.textBoxNazwa.Text;
                string regon = this.textBoxRegon.Text;

                string wojewodztwo = (comboBoxWojewodztwo.SelectedItem as ComboboxItem).Text.ToString();
                string miasto = (comboBoxMiasto.SelectedItem as ComboboxItem).Text.ToString();
                string ulica = (comboBoxUlica.SelectedItem as ComboboxItem).Text.ToString();
                string nrDomu = this.textBoxNrDomu.Text;                
                string kod = this.maskedTextBoxKod.Text;
                string telefon = this.textBoxTelefon.Text;
                string mail = this.textBoxMail.Text;

                string nfz = (comboBoxNfz.SelectedItem as ComboboxItem).Hidden_Id.ToString();

                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter = database.Select("select idadres from przychodniaadres where idprzychodnia='" + this.idprzychodnia + "'", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.idadres = element["idadres"].ToString();
                    dt.Clear();
                }

                myDataAdapter = database.Select("select idkontakt from przychodniakontakt where idprzychodnia='" + this.idprzychodnia + "'", database.Conect());
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.idkontakt = element["idkontakt"].ToString();
                }

                database.Update("update przychodnia set idfundusz = '" + nfz + "', nazwa = '" + nazwa + "', regon = '" + regon + "' where idprzychodnia = '" + this.idprzychodnia + "'", database.Conect());
                database.Update("update adres set wojewodztwo = '" + wojewodztwo.ToString() + "', miasto = '" + miasto.ToString() + "', kod_pocztowy = '" + kod.ToString() + "', ulica = '" + ulica.ToString() + "', nr_budynku = '" + nrDomu + "' where idadres = '" + this.idadres + "'", database.Conect());
                database.Update("update kontakt set telefon = '" + telefon.ToString() + "', mail = '" + mail.ToString() + "' where idkontakt = '" + this.idkontakt + "'", database.Conect());

                DialogResult result = MessageBox.Show("Zaktualizowano dane przychodni", "Edycja", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
