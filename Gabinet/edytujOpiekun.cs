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
    public partial class edytujOpiekun : Form
    {
        public string dbconnection_gabinet;
        public string idpacjent;
        public string idkontakt;

        public edytujOpiekun(string idpacjentReceive)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            this.idpacjent = idpacjentReceive;
            Update_opiekun();
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

                if (textBoxLiczbaOpieka.Text.Equals("0"))
                {
                    buttonUsun.Enabled = false;
                    buttonZmien.Enabled = false;
                    textBoxImie.Enabled = false;
                    textBoxNazwisko.Enabled = false;
                    textBoxTelefonOpieka.Enabled = false;
                    textBoxMailOpieka.Enabled = false;
                    comboBoxOpiekun.Enabled = false;
                }
                else if (textBoxLiczbaOpieka.Text.Equals("2"))
                {
                    buttonDodaj.Enabled = false;
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
                myDataAdapter = database.Select("select telefon, mail, imie, nazwisko, kontakt.idkontakt from opiekunkontakt inner join kontakt on kontakt.idkontakt=opiekunkontakt.idkontakt inner join opiekun on opiekunkontakt.idopiekun=opiekun.idopiekun WHERE opiekunkontakt.idopiekun='" + selected_item + "'", this.dbconnection_gabinet);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.textBoxMailOpieka.Text = element["mail"].ToString();
                    this.textBoxTelefonOpieka.Text = element["telefon"].ToString();
                    this.textBoxNazwisko.Text = element["nazwisko"].ToString();
                    this.textBoxImie.Text = element["imie"].ToString();
                    this.idkontakt = element["idkontakt"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonZmien_Click(object sender, EventArgs e)
        {
            string mail = textBoxMailOpieka.Text.ToString();
            string tel = textBoxTelefonOpieka.Text.ToString();
            string imie = textBoxImie.Text.ToString();
            string nazwisko = textBoxNazwisko.Text.ToString();
            string selected_item = (comboBoxOpiekun.SelectedItem as ComboboxItem).Hidden_Id.ToString();

            try 
            {                
                Database database = new Database();
                database.Update("update kontakt set telefon = '" + tel.ToString() + "', mail = '" + mail.ToString() + "' where  idkontakt = '" + this.idkontakt + "'", this.dbconnection_gabinet);
                database.Update("update opiekun set imie = '" + imie.ToString() + "', nazwisko = '" + nazwisko.ToString() + "' where idopiekun = '" + selected_item + "'", this.dbconnection_gabinet);
                MessageBox.Show("Dane zmienione");
                comboBoxOpiekun.Items.Clear();
                Update_opiekun();
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

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            string selected_item = (comboBoxOpiekun.SelectedItem as ComboboxItem).Hidden_Id.ToString();

            try
            {
                Database database = new Database();
                database.Delete("delete from pacjentopiekun where idopiekun = '" + selected_item + "'", this.dbconnection_gabinet);
                DialogResult result = MessageBox.Show("Opiekun usunięty");
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    Update_opiekun();
                }
                /*comboBoxOpiekun.Items.Clear();
                comboBoxOpiekun.Text = "";
                textBoxImie.Clear();
                textBoxNazwisko.Clear();
                textBoxMailOpieka.Clear();
                textBoxTelefonOpieka.Clear();
                Update_opiekun();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
    }
}
