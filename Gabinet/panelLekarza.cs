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
    public partial class PanelLekarza : Form
    {
        //public string dbconnection_gabinet;
        private string idpracownik;
        private string idwizyta;        

        public PanelLekarza(string idpracownikReceive)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.idpracownik = idpracownikReceive;
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            Update_daneLekarza();               
            Update_Godziny();
        }

        private void panelLekarza_Load(object sender, EventArgs e)
        {

        }

        public void Update_daneLekarza()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from pracownik inner join stanowisko on stanowisko.idstanowisko=pracownik.idstanowisko where idpracownik='" + this.idpracownik + "'", database.Conect());

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    textBoxImieNazwisko.Text = element["nazwisko"].ToString() + " " + element["imie"].ToString();
                    textBoxStanowisko.Text = element["nazwa"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        public void Update_Godziny()
        {
            try
            {               
                string stan = "0";
                DateTime selected_date = (DateTime)monthCalendar1.SelectionStart;
                string date = selected_date.ToString("yyyy-MM-dd");
                int dzienTygodnia = (int)selected_date.DayOfWeek;
                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                MySqlDataAdapter myDA = new MySqlDataAdapter();
                myDataAdapter = database.Select("select godz_od, godz_do from godzinyprzyjec inner join pracownikgodziny on pracownikgodziny.idgodziny=godzinyprzyjec.idgodziny where dzien_tygodnia='" + dzienTygodnia + "' and idpracownik='" + this.idpracownik + "'", database.Conect());
                myDA = database.Select("select godzina, nazwisko, imie, pesel, idwizyta, wizyta.idpacjent from wizyta inner join pacjent on pacjent.idpacjent=wizyta.idpacjent where idpracownik='" + this.idpracownik + "' and data='" + date + "' and stan='" + stan + "'", database.Conect());
                DataTable dt = new DataTable();
                DataTable dT = new DataTable();
                myDataAdapter.Fill(dt); //godziny przyjęć
                myDA.Fill(dT); //godziny zamówionych wizyt                

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    textBoxGodzOd.Text = element["godz_od"].ToString();
                    textBoxGodzDo.Text = element["godz_do"].ToString();
                }
                else
                {
                    textBoxGodzOd.Text = "brak";
                    textBoxGodzDo.Text = "brak";
                }               

                dataGridViewWizyta.DataSource = dT.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            Update_Godziny();
        }

        private void toolStripBtnWizyta_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Wizyta")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                if (dataGridViewWizyta.RowCount != 0)
                {
                    this.Visible = false;
                    int row = dataGridViewWizyta.CurrentCell.RowIndex;
                    this.idwizyta = dataGridViewWizyta.Rows[row].Cells[4].Value.ToString();
                    Wizyta f2 = new Wizyta(this.idwizyta, false);                    
                    f2.ShowDialog();
                    this.Visible = true;
                    Update_Godziny();
                }
                else
                {
                    MessageBox.Show("Musisz wybrać wizyte!");
                }
            }
        }

        private void toolStripButtonDanePacjenta_Click(object sender, EventArgs e)
        {
           
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Dane pacjenta")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                if (dataGridViewWizyta.RowCount != 0)
                {
                    int row = dataGridViewWizyta.CurrentCell.RowIndex;
                    string id = dataGridViewWizyta.Rows[row].Cells[5].Value.ToString();
                    this.Opacity = 0.5;
                    DanePacjent f2 = new DanePacjent(id);
                    f2.ShowDialog();
                    this.Opacity = 1;
                }
                else
                {
                    MessageBox.Show("Musisz wybrać pacjenta!");
                }
            }
        }

        private void toolStripButtonHistoria_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Historia wizyt pacjenta")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                if (dataGridViewWizyta.RowCount != 0)
                {
                    this.Opacity = 0.5;
                    int row = dataGridViewWizyta.CurrentCell.RowIndex;
                    string id = dataGridViewWizyta.Rows[row].Cells[5].Value.ToString();
                    PacjentWizyta f2 = new PacjentWizyta(id, true);
                    f2.ShowDialog();
                    this.Opacity = 1;
                }
                else
                {
                    MessageBox.Show("Musisz wybrać pacjenta!");
                }
            }
        }

        private void toolStripButtonPlan_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Zaplanowane wizyty pacjenta")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                if (dataGridViewWizyta.RowCount != 0)
                {
                    this.Opacity = 0.5;
                    int row = dataGridViewWizyta.CurrentCell.RowIndex;
                    string id = dataGridViewWizyta.Rows[row].Cells[5].Value.ToString();
                    PacjentWizyta f2 = new PacjentWizyta(id, false);
                    f2.ShowDialog();
                    this.Opacity = 1;
                }
                else
                {
                    MessageBox.Show("Musisz wybrać pacjenta!");
                }
            }
        }
    }
}
