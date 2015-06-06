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
    public partial class Login : Form
    {
        private string idpracownika;
        public string dbconnection_gabinet;
       
        public Login()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
         
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //String myCon = "datasource=91.228.198.167;database=aneu_gabinet;port=3306;username=aneu_gabinet;password=kolunio1";
                MySqlConnection con = new MySqlConnection(this.dbconnection_gabinet);

                MySqlCommand com = new MySqlCommand("select * from user where login='" + this.textBoxLogin.Text + "' and haslo='" + this.textBoxPasword.Text + "';", con);
                con.Open();
                MySqlDataReader myRead = com.ExecuteReader();
                
                int count = 0;

                while (myRead.Read())
                {
                    count =+ 1;
                }
                if (count == 1)
                {
                    //MessageBox.Show("Login i Hasło są prawidłowe");
                    
                    this.idpracownika = myRead.GetString(1);
                    
                    this.Visible = false;
                    Start r = new Start(this.idpracownika, this);
                    r.Owner = this;
                    r.ShowDialog();
                    
                }
                else if (count > 1)
                {
                    MessageBox.Show("Użytkownik taki jest już zalogowany");
                }
                else
                    MessageBox.Show("Nieprawidłowy Login lub Hasło");
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
