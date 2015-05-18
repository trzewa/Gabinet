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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnGabinet_Click(object sender, EventArgs e)
        {

        }

        private void btnRejestracja_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Rejestracja")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                Rejestracja f2 = new Rejestracja();
                f2.ShowDialog();                
            }
        }

        private void btnKonfiguracja_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Zarządzanie przychodnią")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                organizacjaPrzychodni f2 = new organizacjaPrzychodni();
                f2.Show();                
            }
        }

        private void btnZakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
