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


namespace Gabinet
{
    public partial class Login : Form
    {
                
        public Login()
        {
            InitializeComponent();
            
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
                String myCon = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection con = new MySqlConnection(myCon);

                MySqlCommand com = new MySqlCommand("select * from gabinet.user where login='" + this.textBoxLogin.Text + "' and haslo='" + this.textBoxPasword.Text + "';",con);
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
                    this.Visible = false;
                    Rejestracja r = new Rejestracja();
                    r.ShowDialog();
                    this.Close();
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
