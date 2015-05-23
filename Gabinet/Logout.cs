using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gabinet
{
    public partial class Logout : Form
    {
        private Start rodzic;

        public Logout(Start parent)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.rodzic = parent;
        }

        private void buttonZakoncz_Click(object sender, EventArgs e)
        {
            //rodzic.Close();
            rodzic.rodzic.Close();
            //this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            
            rodzic.rodzic.Visible = true;
            rodzic.rodzic.textBoxLogin.Text = "";
            rodzic.rodzic.textBoxPasword.Text = "";
            this.Close();
            rodzic.Close();
            
                        
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            rodzic.Opacity = 1;
            this.Close();            
        }
    }
}
