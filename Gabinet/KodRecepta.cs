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
    public partial class KodRecepta : Form
    {
        public KodRecepta()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 22)
            {
                MessageBox.Show("Wprowadzony numer jest za krótki!");
                textBox1.Select();
            }            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.TextLength != 22)
            {
                MessageBox.Show("Wprowadzony numer jest za krótki!");
                textBox2.Select();
            } 
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8)
                {
                    MessageBox.Show("Można używaż tylko cyfr!");
                    e.KeyChar = (char)0;
                }
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
          
                string start = textBox1.Text.Substring(5, 15);
                string startall = textBox1.Text;
                string end = textBox2.Text.Substring(5, 15);
                string dwaend = startall.Substring(20, 2);
                Int64 wynik = Convert.ToInt64(textBox2.Text.Substring(5, 15)) - Convert.ToInt64(textBox1.Text.Substring(5, 15)) + 1;
                label4.Text = wynik.ToString();

                if (Convert.ToInt64(label4.Text) < 0)
                {
                    label4.Text = "BŁĄD";
                    MessageBox.Show("Numer końcowy nie może być mniejszy od początkowego!");

                }
                else
                {
                    try
                    {
                        for (Int64 i = Convert.ToInt64(start); i <= Convert.ToInt64(end); i++)
                        {
                            string wielkosc = i.ToString();
                            string wpis = startall.Insert((20 - wielkosc.Length), i.ToString());
                            string final = wpis.Insert(20, dwaend);
                            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                            Database database = new Database();
                            database.Insert("insert into receptakod (kod_recepty, stan) VALUES('" + final + "', 0)", database.Conect());                            
                        }

                        DialogResult result = MessageBox.Show("Kody dodane!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }           
            
        }
   
}
