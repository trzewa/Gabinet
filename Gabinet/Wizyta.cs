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
    public partial class Wizyta : Form
    {

        public string dbconnection_gabinet;
        private string idwizyta;
        private string idpacjent;
        

        public Wizyta(string idwizytaReceive)
        {
            InitializeComponent();
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            this.idwizyta = idwizytaReceive;
            Update_danePacjent();
        }

        public void Update_danePacjent()
        {
            try
            {
                Database database = new Database();

                MySqlDataAdapter myDA = new MySqlDataAdapter();
                myDA = database.Select("select idpacjent from wizyta where idwizyta='" + this.idwizyta + "'", this.dbconnection_gabinet);
                DataTable dT = new DataTable();
                myDA.Fill(dT);

                if (dT.Rows.Count == 1)
                {
                    DataRow element = dT.Rows[0];
                    this.idpacjent = element["idpacjent"].ToString();
                }

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();                
                myDataAdapter = database.Select("select nazwisko, imie, ulica, nr_budynku, nr_lokalu, miasto, kod_pocztowy, mail, telefon from wizyta inner join pacjent on pacjent.idpacjent=wizyta.idpacjent inner join pacjentadres on wizyta.idpacjent=pacjentadres.idpacjent inner join adres on adres.idadres=pacjentadres.idadres inner join pacjentkontakt on wizyta.idpacjent=pacjentkontakt.idpacjent inner join kontakt on pacjentkontakt.idkontakt=kontakt.idkontakt where wizyta.idpacjent='" + this.idpacjent + "'", this.dbconnection_gabinet);
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    DataRow element = dt.Rows[0];
                    this.labelNazwiskoImie.Text = element["nazwisko"].ToString() + " " + element["imie"].ToString();
                    this.labelAdres.Text = element["ulica"].ToString() + " " + element["nr_budynku"].ToString() + " m." + element["nr_lokalu"].ToString() + "; " + element["kod_pocztowy"].ToString() + " " + element["miasto"].ToString();
                    
                    this.labelTelefon.Text = element["telefon"].ToString();
                    this.linkLabelMail.Text = element["mail"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
