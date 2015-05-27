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
        public bazaDane()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            Update_daneBaza();
        }

        public void Update_daneBaza()
        {
            this.textBoxAdres.Text = mysettings.Default.datasource;
            this.textBoxNazwa.Text = mysettings.Default.database;
            this.textBoxPort.Text = mysettings.Default.port;
            this.textBoxUser.Text = mysettings.Default.user;
            this.textBoxPass.Text = mysettings.Default.password;
        }

        private void buttonZmien_Click(object sender, EventArgs e)
        {            
            String message = "Czy chcesz zatwierdzić te zmiany?\nUWAGA!\nZmiany będą działać po zrestartowaniu programu.";
            String caption = "Zmiana ustawień";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                mysettings.Default.datasource = this.textBoxAdres.Text.ToString();
                mysettings.Default.database = this.textBoxNazwa.Text.ToString();
                mysettings.Default.port = this.textBoxPort.Text.ToString();
                mysettings.Default.user = this.textBoxUser.Text.ToString();
                mysettings.Default.password = this.textBoxPass.Text.ToString();
                mysettings.Default.Save();
                this.Close();
            }
        }
    }
}
