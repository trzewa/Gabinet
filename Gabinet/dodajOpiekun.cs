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
    public partial class dodajOpiekun : Form
    {
        public string dbconnection_gabinet;
        public string idopiekunSend = null;

        public dodajOpiekun()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            //this.idopiekunSend = idopiekun;
            Update_comboBoxTelefon();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.idopiekunSend = null;
            this.Close();
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                string imie = this.textBoxImie.Text;
                string nazwisko = this.textBoxNazwisko.Text;
                string telefon = this.textBoxTelefon.Text;
                string mail = this.textBoxMail.Text;

                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();

                if (this.idopiekunSend == null)
                {
                    database.Insert("insert into opiekun (imie, nazwisko) VALUES('" + imie.ToString() + "','" + nazwisko.ToString() + "')", this.dbconnection_gabinet);
                    database.Insert("insert into kontakt (telefon, mail) VALUES('" + telefon.ToString() + "','" + mail.ToString() + "')", this.dbconnection_gabinet);
                    database.Insert("insert opiekunkontakt (idopiekun, idkontakt) select max(idopiekun), max(idkontakt) from opiekun, kontakt", this.dbconnection_gabinet);
                    myDataAdapter = database.Select("select max(idopiekun) from opiekun", this.dbconnection_gabinet);
                    DataTable dt = new DataTable();
                    myDataAdapter.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        DataRow element = dt.Rows[0];
                        this.idopiekunSend = element["max(idopiekun)"].ToString();
                    }                    
                }
                
                DialogResult result = MessageBox.Show("Opiekun dodany", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == System.Windows.Forms.DialogResult.OK)
                    {                    
                        dodajOpiekun.ActiveForm.Close();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Nie zostały wypełnione pola obowiązkowe");
            }
        }

        public void Update_comboBoxTelefon()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("SELECT * FROM kontakt INNER JOIN opiekunkontakt ON kontakt.idkontakt = opiekunkontakt.idkontakt ORDER BY telefon ASC", this.dbconnection_gabinet);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["telefon"].ToString();
                    item.Hidden_Id = dt.Rows[i]["idkontakt"].ToString();                    
                    comboBoxTelefon.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxTelefon_SelectedDropDownClosed(object sender, EventArgs e)
        {
            try
            {
                string selected_item = (comboBoxTelefon.SelectedItem as ComboboxItem).Hidden_Id.ToString();
                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter = database.Select("select opiekunkontakt.idopiekun, imie, nazwisko, telefon, mail from opiekunkontakt INNER JOIN opiekun ON opiekun.idopiekun = opiekunkontakt.idopiekun INNER JOIN kontakt ON kontakt.idkontakt = opiekunkontakt.idkontakt WHERE opiekunkontakt.idkontakt='" + selected_item + "'", this.dbconnection_gabinet);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {

                    DataRow element = dt.Rows[0];
                    this.textBoxImie.Text = element["imie"].ToString();
                    this.textBoxNazwisko.Text = element["nazwisko"].ToString();
                    this.textBoxTelefon.Text = element["telefon"].ToString();
                    this.textBoxMail.Text = element["mail"].ToString();
                    this.idopiekunSend = element["idopiekun"].ToString();
                    
                }                    
                else
                {
                    //ERROR
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxImie_TextChanged(object sender, EventArgs e)
        {
            this.idopiekunSend = null;
        }

        private void textBoxNazwisko_TextChanged(object sender, EventArgs e)
        {
            this.idopiekunSend = null;
        }

        private void textBoxTelefon_TextChanged(object sender, EventArgs e)
        {
            this.idopiekunSend = null;
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            this.idopiekunSend = null;
        }        
    }
}

