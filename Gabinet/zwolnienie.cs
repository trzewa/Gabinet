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
    public partial class zwolnienie : Form
    {
        private Wizyta rodzicWizyta;
        public string dbconnection_gabinet;
        public string idpracownik;
        public string idpacjent;

        public zwolnienie(Wizyta parent)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.rodzicWizyta = parent;
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            Set_IDs();
            Update_danePacjent();
            Update_adresPacjent();
            Update_danePracownik();
            Update_comboBoxes();
        }

        public void Set_IDs()
        {
            Database database = new Database();
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter = database.Select("select idpracownik, idpacjent from wizyta where idwizyta='" + this.rodzicWizyta.idwizyta + "'", this.dbconnection_gabinet);
            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);
            

            if (dt.Rows.Count == 1)
            {
                DataRow element = dt.Rows[0];
                this.idpacjent = element["idpacjent"].ToString();
                this.idpracownik = element["idpracownik"].ToString();
            }
        }

        public void Update_danePacjent()
        {
            Database database = new Database();
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter = database.Select("select * from pacjent where idpacjent='" + this.idpacjent + "'", this.dbconnection_gabinet);
            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                DataRow element = dt.Rows[0];
                textBoxImie.Text = element["imie"].ToString();
                textBoxNazwisko.Text = element["nazwisko"].ToString();
                textBoxPesel.Text = element["pesel"].ToString();
                dateTimePicker1.Text = element["data_urodzenia"].ToString();
                textBoxZaklad.Text = element["miejsce_pracy"].ToString();
                textBoxNip.Text = element["nip_platnika"].ToString();
            }
            textBoxChoroba.Text = this.rodzicWizyta.textBoxKodChoroby.Text;
        }

        public void Update_adresPacjent()
        {
            Database database = new Database();
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter = database.Select("select * from adres inner join pacjentadres on adres.idadres=pacjentadres.idadres where idpacjent='" + this.idpacjent + "'", this.dbconnection_gabinet);
            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                DataRow element = dt.Rows[0];
                textBoxMiasto.Text = element["miasto"].ToString();
                textBoxKod.Text = element["kod_pocztowy"].ToString();
                textBoxUlica.Text = element["ulica"].ToString();
                textBoxNrDomu.Text = element["nr_budynku"].ToString();
                textBoxNrLokalu.Text = element["nr_lokalu"].ToString();
            }
        }

        public void Update_danePracownik()
        {
            Database database = new Database();
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter = database.Select("select numer_pwz from pracownik where idpracownik='" + this.idpracownik + "'", this.dbconnection_gabinet);
            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                DataRow element = dt.Rows[0];
                textBoxLekarz.Text = element["numer_pwz"].ToString();                
            }
        }

        public void Update_comboBoxes()
        {
            Dictionary<string, string> itemKod = new Dictionary<string, string>();
            itemKod.Add("1", "A");
            itemKod.Add("2", "B");
            itemKod.Add("3", "C");
            itemKod.Add("4", "D");
            comboBoxKody.DataSource = new BindingSource(itemKod, null);
            comboBoxKody.DisplayMember = "Value";
            comboBoxKody.ValueMember = "Key";

            Dictionary<string, string> itemUbezpieczony = new Dictionary<string, string>();
            itemUbezpieczony.Add("1", "ZUS");
            itemUbezpieczony.Add("2", "KRUS");
            itemUbezpieczony.Add("3", "inny w Polsce");
            itemUbezpieczony.Add("4", "w innym państwie");
            comboBoxUbezpieczonyW.DataSource = new BindingSource(itemUbezpieczony, null);
            comboBoxUbezpieczonyW.DisplayMember = "Value";
            comboBoxUbezpieczonyW.ValueMember = "Key";

            Dictionary<string, string> itemWskazania = new Dictionary<string, string>();
            itemWskazania.Add("1", "Chory powinien leżeć");
            itemWskazania.Add("2", "Chory może chodzić");
            comboBoxWskazania.DataSource = new BindingSource(itemWskazania, null);
            comboBoxWskazania.DisplayMember = "Value";
            comboBoxWskazania.ValueMember = "Key";

        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            string dataOd = dateTimePickerOd.Text;
            string dataDo = dateTimePickerDo.Text;
            string ubezpieczony = ((KeyValuePair<string, string>)comboBoxUbezpieczonyW.SelectedItem).Value;
            string wskazania = ((KeyValuePair<string, string>)comboBoxWskazania.SelectedItem).Value;
            string szpital = textBoxSzpital.Text;
            string kody = ((KeyValuePair<string, string>)comboBoxKody.SelectedItem).Value;

            Database database = new Database();
            

        }
    }
}
