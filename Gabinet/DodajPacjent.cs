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
        public string dbconnection_gabinet;
        public string dbconnection_gus;

        public DodajPacjent()
        {
            InitializeComponent();
            this.dbconnection_gabinet = "datasource=localhost;database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            this.dbconnection_gus = "datasource=localhost;database=" + mysettings.Default.database1 + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            Update_comboBoxUprawnienia();
            Update_comboBoxNfz();            
            Update_comboBoxWojewodztwo();
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
                myDataAdapter = database.Select("select * from ubezpieczenia", this.dbconnection_gabinet);

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
                myDataAdapter = database.Select("select * from fundusz", this.dbconnection_gabinet);

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
                myDataAdapter = database.Select("SELECT distinct wojewodztwo FROM mytable ORDER BY wojewodztwo ASC", this.dbconnection_gus);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["wojewodztwo"].ToString();
                    //item.Hidden_Id = dt.Rows[i]["id"].ToString();
                    comboBoxWojewodztwo.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxMiasto_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                string selected_item = (comboBoxMiasto.SelectedItem as ComboboxItem).Text.ToString();
                string selected_item1 = (comboBoxWojewodztwo.SelectedItem as ComboboxItem).Text.ToString();
                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter = database.Select("select distinct adres from mytable WHERE (miejscowosc='" + selected_item + "' and wojewodztwo='" + selected_item1 + "') order by adres ASC", this.dbconnection_gus);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                comboBoxUlica.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["adres"].ToString();
                    comboBoxUlica.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxWojewodztwo_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                string selected_item = (comboBoxWojewodztwo.SelectedItem as ComboboxItem).Text.ToString();
                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter = database.Select("select distinct miejscowosc from mytable WHERE wojewodztwo='" + selected_item + "' order by miejscowosc ASC", this.dbconnection_gus);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                
                comboBoxUlica.Items.Clear();
                comboBoxUlica.ResetText();
                comboBoxMiasto.Items.Clear();
                comboBoxMiasto.ResetText();
                

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
