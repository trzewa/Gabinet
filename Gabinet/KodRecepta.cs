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
            else
            {
                Int64 wynik = Convert.ToInt64(textBox2.Text.Substring(5, 15)) - Convert.ToInt64(textBox1.Text.Substring(5, 15)) + 1;
                label4.Text = wynik.ToString();

                if (Convert.ToInt64(label4.Text) < 0)
                {
                    label4.Text = "BŁĄD";
                    MessageBox.Show("Numer końcowy nie może być mniejszy od początkowego!");

                }
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

        
    }
}
