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
    public partial class DodajPacjent : Form
    {
        public string dbconnection_string;
        public string dbconnection;

        public DodajPacjent()
        {
            InitializeComponent();
            this.dbconnection_string = "datasource=localhost;database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            Update_comboBoxUprawnienia();
            Update_comboBoxNfz();
            
            Update_comboBoxMiasto();
        }

        private void comboBoxUprawnienia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNfz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Update_comboBoxUprawnienia()
        {
           
            try
            {
                
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from ubezpieczenia", this.dbconnection_string);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                comboBoxUprawnienia.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["kod"].ToString();
                    item.Hidden_Id = dt.Rows[i]["idubezpieczenia"].ToString();
                    comboBoxUprawnienia.Items.Add(item);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_comboBoxNfz()
        {
            try
            {
                
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from fundusz", this.dbconnection_string);

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
                Update_comboBoxMiasto();
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
                this.dbconnection = "datasource=localhost;database=" + mysettings.Default.database1 + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("SELECT DISTINCT miejscowosc FROM mytable ORDER BY miejscowosc ASC", this.dbconnection);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                comboBoxMiasto.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["miejscowosc"].ToString();
                    //item.Hidden_Id = dt.Rows[i]["id"].ToString();
                    comboBoxMiasto.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
