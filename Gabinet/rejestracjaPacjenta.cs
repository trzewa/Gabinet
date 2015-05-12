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
    public partial class rejestracjaPacjenta : Form
    {
        public string dbconnection_gabinet;
        private string idpacjent;

        public rejestracjaPacjenta(string idpacjentreceive)
        {
            InitializeComponent();
            this.idpacjent = idpacjentreceive;
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            Update_danePacjent();
        }

        public void Update_danePacjent()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from pacjent where idpacjent='" + this.idpacjent + "'", this.dbconnection_gabinet);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.textBoxDanePacjenta.Text = element["nazwisko"].ToString() + " " + element["imie"].ToString();
                }            
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
