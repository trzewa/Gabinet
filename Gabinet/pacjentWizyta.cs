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
//using mysettings = Gabinet.Properties.Settings;

namespace Gabinet
{
    public partial class PacjentWizyta : Form
    {
        //public string dbconnection_gabinet;
        private string idpacjent;
        public string idwizyta;
        public string pracownik;
        public string data;
        //private Rejestracja rodzicRejestracja;
        private bool flag = false;

        public PacjentWizyta(string idpacjentreceive)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.idpacjent = idpacjentreceive;
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            buttonInfo.Visible = false;
            Update_wizyta();
            
        }

        public PacjentWizyta(string idpacjentreceive, bool flagreceive)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.idpacjent = idpacjentreceive;
            //this.rodzicRejestracja = parent;
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            this.flag = flagreceive;
            if (flag)
            {
                this.Text = "Historia wizyt pacjenta";
                buttonInfo.Visible = true;
            }
            else
            {
                this.Text = "Zaplanowane wizyty pacjenta";
                buttonInfo.Visible = false;
            }
            groupBox1.Text = "Lista wizyt pacjenta";
            buttonZmien.Visible = false;
            buttonUsun.Visible = false;
            
            Update_wizyta();
        }

        public void Update_wizyta()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                if (flag)
                {
                    myDataAdapter = database.Select("select data, godzina, idwizyta, wizyta.idpracownik, nazwisko, imie from wizyta inner join pracownik on pracownik.idpracownik=wizyta.idpracownik where idpacjent='" + this.idpacjent + "' and stan='1'", database.Conect());
                } else
                myDataAdapter = database.Select("select data, godzina, idwizyta, wizyta.idpracownik, nazwisko, imie from wizyta inner join pracownik on pracownik.idpracownik=wizyta.idpracownik where idpacjent='" + this.idpacjent + "' and stan='0'", database.Conect());

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                dataGridViewWizyty.DataSource = dt.DefaultView;               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonZmien_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Rejestracja pacjenta")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                if (dataGridViewWizyty.RowCount != 0)
                {
                    this.Visible = false;                    
                    int row = dataGridViewWizyty.CurrentCell.RowIndex;
                    this.idwizyta = dataGridViewWizyty.Rows[row].Cells[2].Value.ToString();
                    this.pracownik = dataGridViewWizyty.Rows[row].Cells[4].Value.ToString() + " " + dataGridViewWizyty.Rows[row].Cells[5].Value.ToString();
                    this.data = dataGridViewWizyty.Rows[row].Cells[0].Value.ToString();
                    RejestracjaPacjenta f2 = new RejestracjaPacjenta(this.idpacjent, this);
                    f2.Owner = this;
                    f2.ShowDialog();
                    this.Visible = true;
                    Update_wizyta();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Brak wizyt do edycji!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewWizyty.RowCount != 0)
            {
                int row = dataGridViewWizyty.CurrentCell.RowIndex;
                this.idwizyta = dataGridViewWizyty.Rows[row].Cells[2].Value.ToString();                
                String message = "Czy napewno chcesz usunąć wizyte?";
                String caption = "Usuwanie wizyty";
                var result = MessageBox.Show(message, caption,
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Database database = new Database();
                    database.Delete("delete from wizyta where idwizyta='" + this.idwizyta + "'", database.Conect());
                    Update_wizyta();
                }
            }
            else
            {
                MessageBox.Show("Brak wizyt do edycji!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Szczegóły wizyty")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                if (dataGridViewWizyty.RowCount != 0)
                {
                    this.Visible = false;
                    int row = dataGridViewWizyty.CurrentCell.RowIndex;
                    this.idwizyta = dataGridViewWizyty.Rows[row].Cells[2].Value.ToString();
                    Wizyta f2 = new Wizyta(this.idwizyta, true);
                    f2.ShowDialog();
                    this.Visible = true;                    
                }
                else
                {
                    MessageBox.Show("Musisz wybrać wizyte!");
                }
            }
        }
    }
}
