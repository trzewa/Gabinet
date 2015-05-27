using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mysettings = Gabinet.Properties.Settings;

namespace Gabinet
{
    public partial class bazaDane : Form
    {
        public Baza baza = new Baza();

        public bazaDane()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            Update_daneBaza();
        }

        public void Update_daneBaza()
        {
            this.textBoxHost.Text = baza.Datasource;
            this.textBoxBaza.Text = baza.Database;
            this.textBoxPort.Text = baza.Port;
            this.textBoxUser.Text = baza.User;
            this.textBoxPass.Text = baza.Password;
        }

        private void buttonZmien_Click(object sender, EventArgs e)
        {
            baza.Datasource = this.textBoxHost.Text.ToString();
            baza.Database = this.textBoxBaza.Text.ToString();
            baza.Port = this.textBoxPort.Text.ToString();
            baza.User = this.textBoxUser.Text.ToString();
            baza.Password = this.textBoxPass.Text.ToString();

            MessageBox.Show("Zmieniono ustawienia serwera bazy danych!");
            
        }
    }
}
