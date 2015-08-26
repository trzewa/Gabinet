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
    public partial class zwolnienie : Form
    {
        private Wizyta rodzicWizyta;
        //public string dbconnection_gabinet;
        public string idpracownik;
        public string idpacjent;
        public string idzwolnienia;
        public string data;

        public zwolnienie(Wizyta parent)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.rodzicWizyta = parent;
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            Set_IDs();
            Update_danePacjent();
            Update_adresPacjent();
            Update_danePracownik();
            Update_comboBoxes();
        }

        public zwolnienie(string idzwolnieniaReceive, Wizyta parent)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            this.idzwolnienia = idzwolnieniaReceive;
            this.rodzicWizyta = parent;
            this.Text = "Zwolnienie";
            buttonZapisz.Visible = false;
            comboBoxUbezpieczonyW.Enabled = false;
            dateTimePickerOd.Enabled = false;
            dateTimePickerDo.Enabled = false;
            textBoxSzpital.Enabled = false;
            comboBoxKody.Enabled = false;
            comboBoxWskazania.Enabled = false;
            Set_IDs();
            Update_danePacjent();
            Update_adresPacjent();
            Update_danePracownik();
            Update_daneNiezdolnosci();
            
        }

        public void Set_IDs()
        {
            Database database = new Database();
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter = database.Select("select idpracownik, idpacjent, data from wizyta where idwizyta='" + this.rodzicWizyta.idwizyta + "'", database.Conect());
            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);
            

            if (dt.Rows.Count == 1)
            {
                DataRow element = dt.Rows[0];
                this.idpacjent = element["idpacjent"].ToString();
                this.idpracownik = element["idpracownik"].ToString();
                this.data = element["data"].ToString();
            }
        }

        public void Update_danePacjent()
        {
            Database database = new Database();
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter = database.Select("select * from pacjent where idpacjent='" + this.idpacjent + "'", database.Conect());
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
            myDataAdapter = database.Select("select * from adres inner join pacjentadres on adres.idadres=pacjentadres.idadres where idpacjent='" + this.idpacjent + "'", database.Conect());
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
            myDataAdapter = database.Select("select numer_pwz from pracownik where idpracownik='" + this.idpracownik + "'", database.Conect());
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

        public void Update_daneNiezdolnosci()
        {
            Update_comboBoxes();
            this.dateTimePickerWystawienia.Text = this.data.ToString();
            Database database = new Database();
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter = database.Select("select * from zwolnienie where idzwolnienia='" + this.idzwolnienia + "'", database.Conect());
            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                DataRow element = dt.Rows[0];
                dateTimePickerOd.Text = element["od"].ToString();
                dateTimePickerDo.Text = element["do"].ToString();
                this.textBoxSzpital.Text = element["szpital"].ToString();
                this.comboBoxUbezpieczonyW.SelectedIndex = comboBoxUbezpieczonyW.FindStringExact(element["ubezpieczony"].ToString());
                this.comboBoxKody.SelectedIndex = comboBoxKody.FindStringExact(element["kody"].ToString());
                this.comboBoxWskazania.SelectedIndex = comboBoxWskazania.FindStringExact(element["wskazania"].ToString());
            }
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
            database.Insert("insert into zwolnienie (od, do, wskazania, szpital, kody, ubezpieczony) values ('" + dataOd + "','" + dataDo + "','" + wskazania.ToString() + "','" + szpital.ToString() + "','" + kody.ToString() + "','" + ubezpieczony.ToString() + "')", database.Conect());
            this.Opacity = 0.5;
            String message = "Zwolnienie zostało utworzone.";
            String caption = "Zwolnienie";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
                {
                    MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                    myDataAdapter = database.Select("select max(idzwolnienia) from zwolnienie", database.Conect());
                    DataTable dt = new DataTable();
                    myDataAdapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        DataRow element = dt.Rows[0];
                        rodzicWizyta.idzwolnienie = element["max(idzwolnienia)"].ToString();
                    }
                    this.Close();
                }
        }
    }
}
