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
    public partial class panelLekarza : Form
    {
        public string dbconnection_gabinet;
        private string idpracownik;

        public panelLekarza(string idpracownikReceive)
        {
            InitializeComponent();
            this.idpracownik = idpracownikReceive;
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            Update_daneLekarza();
            Update_wizyta();
        }

        private void panelLekarza_Load(object sender, EventArgs e)
        {

        }

        public void Update_daneLekarza()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from pracownik inner join stanowisko on stanowisko.idstanowisko=pracownik.idstanowisko where idpracownik='" + this.idpracownik + "'", this.dbconnection_gabinet);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    textBoxImieNazwisko.Text = element["nazwisko"].ToString() + " " + element["imie"].ToString();
                    textBoxStanowisko.Text = element["nazwa"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_wizyta()
        {
            try
            {
                
                string date = monthCalendar1.SelectionStart.ToString();
                string stan = "0";
                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter = database.Select("select godzina, nazwisko, imie, pesel from wizyta inner join pacjent on pacjent.idpacjent=wizyta.idpacjent where idpracownik='" + this.idpracownik + "' and data='" + date + "' and stan='" + stan + "'", this.dbconnection_gabinet);
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                dataGridViewWizyta.DataSource = dt.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
