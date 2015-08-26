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
    public partial class edytujOpiekun : Form
    {
        //public string dbconnection_gabinet;
        public string idpacjent;
        public string idkontakt;
        public string idopiekun = null;        

        public edytujOpiekun(string idpacjentReceive)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            this.idpacjent = idpacjentReceive;
            Update_opiekun();
            Update_buttonDodaj();
        }

        public void Update_opiekun()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select nazwisko, imie, opiekun.idopiekun from pacjentopiekun left join opiekun on pacjentopiekun.idopiekun=opiekun.idopiekun where idpacjent='" + this.idpacjent + "'", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["nazwisko"].ToString() + " " + dt.Rows[i]["imie"].ToString();
                    item.Hidden_Id = dt.Rows[i]["idopiekun"].ToString();                    
                    comboBoxOpiekun.Items.Add(item);                    
                }
                this.textBoxLiczbaOpieka.Text = comboBoxOpiekun.Items.Count.ToString();
                dt.Clear();

                if (comboBoxOpiekun.Items.Count == 0)
                {
                    buttonUsun.Enabled = false;
                    buttonZmien.Enabled = false;                    
                    textBoxTelefonOpieka.Enabled = false;
                    textBoxMailOpieka.Enabled = false;
                    comboBoxOpiekun.Enabled = false;
                    buttonDodaj.Enabled = true;
                }
                else if (comboBoxOpiekun.Items.Count == 2)
                {
                    buttonUsun.Enabled = true;
                    buttonZmien.Enabled = true;                    
                    textBoxTelefonOpieka.Enabled = true;
                    textBoxMailOpieka.Enabled = true;
                    comboBoxOpiekun.Enabled = true;
                    buttonDodaj.Enabled = false;
                }
                else
                {
                    buttonUsun.Enabled = true;
                    buttonZmien.Enabled = true;                    
                    textBoxTelefonOpieka.Enabled = true;
                    textBoxMailOpieka.Enabled = true;
                    comboBoxOpiekun.Enabled = true;
                    buttonDodaj.Enabled = true;
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
                myDataAdapter = database.Select("select telefon, mail, kontakt.idkontakt from opiekunkontakt inner join kontakt on kontakt.idkontakt=opiekunkontakt.idkontakt WHERE opiekunkontakt.idopiekun='" + selected_item + "'", database.Conect());

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.textBoxMailOpieka.Text = element["mail"].ToString();
                    this.textBoxTelefonOpieka.Text = element["telefon"].ToString();                    
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
            if (comboBoxOpiekun.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz opiekuna", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mail = textBoxMailOpieka.Text.ToString();
                string tel = textBoxTelefonOpieka.Text.ToString();
                string selected_item = (comboBoxOpiekun.SelectedItem as ComboboxItem).Hidden_Id.ToString();

                try
                {
                    Database database = new Database();
                    database.Update("update kontakt set telefon = '" + tel.ToString() + "', mail = '" + mail.ToString() + "' where  idkontakt = '" + this.idkontakt + "'", database.Conect());
                    MessageBox.Show("Dane zmienione", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    All_clear();
                    Update_opiekun();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (comboBoxOpiekun.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz opiekuna", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selected_item = (comboBoxOpiekun.SelectedItem as ComboboxItem).Hidden_Id.ToString();

                try
                {
                    Database database = new Database();
                    database.Delete("delete from pacjentopiekun where idopiekun = '" + selected_item + "'", database.Conect());
                    DialogResult result = MessageBox.Show("Opiekun usunięty", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        All_clear();
                        Update_opiekun();
                        Update_buttonDodaj();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void All_clear()
        {
            comboBoxOpiekun.Items.Clear();
            comboBoxOpiekun.ResetText();           
            textBoxMailOpieka.Clear();
            textBoxTelefonOpieka.Clear();
        }

        public void Update_buttonDodaj()
        {
            if (comboBoxOpiekun.Items.Count == 1)
            {
                buttonDodaj.Text = "Dodaj drugiego opiekuna";
            }
            else if (comboBoxOpiekun.Items.Count == 0)
            {
                buttonDodaj.Text = "Dodaj opiekuna";
            }
            else
            {
                buttonDodaj.Text = "Niedostępne";
                buttonDodaj.Enabled = false;
            }
        }       

        private void buttonDodaj_Click(object sender, EventArgs e)
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
                if (comboBoxOpiekun.Items.Count <= 1)
                {
                    this.Opacity = 0.5;
                    dodajOpiekun f2 = new dodajOpiekun();                    
                    f2.ShowDialog();
                    this.idopiekun = f2.idopiekunSend;
                    this.Opacity = 1;
                    if (idopiekun != null)
                    {                        
                        try
                        {
                            Database database = new Database();
                            database.Insert("insert into pacjentopiekun (idpacjent, idopiekun) values ('" + this.idpacjent + "', '" + this.idopiekun + "')", database.Conect());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        All_clear();
                        Update_opiekun();
                        Update_buttonDodaj();
                    }
                }                
            }
        }
    }
}
