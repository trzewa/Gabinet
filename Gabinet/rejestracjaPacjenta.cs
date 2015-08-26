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
    public partial class RejestracjaPacjenta : Form
    {
        //public string dbconnection_gabinet;
        private string idpacjent;
        private string godzOd;
        private string godzDo;
        private string godzWizyty;        
        private Rejestracja rodzicRejestracja;
        private PacjentWizyta rodzicWizyta;
        private bool form = false;
        private bool flag = false;

        public RejestracjaPacjenta(string idpacjentreceive)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.idpacjent = idpacjentreceive;
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            groupBox6.Visible = false;
            Update_danePacjent();
            Update_daneLekarza();            
        }

        public RejestracjaPacjenta(string idpacjentreceive, PacjentWizyta parent)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.idpacjent = idpacjentreceive;
            this.rodzicWizyta = parent;
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            groupBox6.Visible = false;
            Update_danePacjent();
            Update_daneLekarza();          
            comboBoxDaneLekarza.SelectedIndex = comboBoxDaneLekarza.FindStringExact(rodzicWizyta.pracownik);            
            monthCalendar1.SetDate(Convert.ToDateTime(rodzicWizyta.data));           
            this.form = true;
        }

        public RejestracjaPacjenta(Rejestracja parent)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.rodzicRejestracja = parent;
            this.flag = true;
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            groupBox1.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            this.Text = "Harmonogram wizyt";
            Update_daneLekarza();
        }

        public void Update_GodzinyPracy()
        {
            try
            {
                
                string selected_item = (comboBoxDaneLekarza.SelectedItem as ComboboxItem).Hidden_Id.ToString();
                DateTime selected_date = (DateTime)monthCalendar1.SelectionStart;
                string date = selected_date.ToString("yyyy-MM-dd");
                int dzienTygodnia = (int)selected_date.DayOfWeek;
                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter = database.Select("select godz_od, godz_do from godzinyprzyjec inner join pracownikgodziny on pracownikgodziny.idgodziny=godzinyprzyjec.idgodziny where dzien_tygodnia='" + dzienTygodnia + "' and idpracownik='" + selected_item + "'", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt); //godziny przyjęć

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_danePacjent()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from pacjent where idpacjent='" + this.idpacjent + "'", database.Conect());

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.textBoxDanePacjenta.Text = element["nazwisko"].ToString() + " " + element["imie"].ToString();
                }            
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_daneLekarza()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from pracownik where idstanowisko='1' or idstanowisko='3' or idstanowisko='4'", database.Conect());

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dt.Rows[i]["nazwisko"].ToString() + " " + dt.Rows[i]["imie"].ToString();
                    item.Hidden_Id = dt.Rows[i]["idpracownik"].ToString();
                    comboBoxDaneLekarza.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_Harmonogram()
        {
            try
            {
                string selected_item = (comboBoxDaneLekarza.SelectedItem as ComboboxItem).Hidden_Id.ToString();
                //string date = monthCalendar1.SelectionStart.ToString();
                DateTime selected_date = (DateTime)monthCalendar1.SelectionStart;
                string date = selected_date.ToString("yyyy-MM-dd");
                string stan = "0";
                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter = database.Select("select data, godzina, nazwisko, imie, pesel from wizyta inner join pacjent on pacjent.idpacjent=wizyta.idpacjent where idpracownik='" + selected_item + "' and data='" + date + "' and stan='" + stan + "'", database.Conect());               
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                dataGridViewTerminarz.DataSource = dt.DefaultView;

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
                string idpracownik_selected = (comboBoxDaneLekarza.SelectedItem as ComboboxItem).Hidden_Id.ToString();
                string stan = "0";
                DateTime selected_date = (DateTime)monthCalendar1.SelectionStart;
                string date = selected_date.ToString("yyyy-MM-dd");
                int dzienTygodnia = (int)selected_date.DayOfWeek;                
                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                MySqlDataAdapter myDA = new MySqlDataAdapter();
                myDataAdapter = database.Select("select godz_od, godz_do from godzinyprzyjec inner join pracownikgodziny on pracownikgodziny.idgodziny=godzinyprzyjec.idgodziny where dzien_tygodnia='" + dzienTygodnia + "' and idpracownik='" + idpracownik_selected + "'", database.Conect());
                myDA = database.Select("select * from wizyta where idpracownik='" + idpracownik_selected + "' and data='" + date + "' and stan='" + stan + "'", database.Conect());
                DataTable dt = new DataTable();
                DataTable dT = new DataTable();
                myDataAdapter.Fill(dt); //godziny przyjęć
                myDA.Fill(dT); //godziny zamówionych wizyt                

                if (dt.Rows.Count == 1)
                {                    
                    DataRow element = dt.Rows[0];
                    this.godzOd = element["godz_od"].ToString();
                    this.godzDo = element["godz_do"].ToString();


                    string hod = this.godzOd[0].ToString() + this.godzOd[1].ToString();
                    string mod = this.godzOd[3].ToString() + this.godzOd[4].ToString();
                    string hdo = this.godzDo[0].ToString() + this.godzDo[1].ToString();
                    string mdo = this.godzDo[3].ToString() + this.godzDo[4].ToString();

                    DateTime dateOd = new DateTime(selected_date.Year, selected_date.Month, selected_date.Day, Convert.ToInt32(hod), Convert.ToInt32(mod), 0);
                    DateTime dateDo = new DateTime(selected_date.Year, selected_date.Month, selected_date.Day, Convert.ToInt32(hdo), Convert.ToInt32(mdo), 0);
                    TimeSpan result = dateDo - dateOd;
                    double resulth = result.TotalMinutes;

                    this.listViewGodziny.Clear();
                    double skok = 20;
                    bool flaga = true;

                    for (int i = 0; i <= (resulth / 20); i++)
                    {
                        string dateOdControl = dateOd.ToString("HH:mm");
                        
                        for (int j =0; j < dT.Rows.Count; j++)
                        {
                            this.godzWizyty = dT.Rows[j]["godzina"].ToString();
                            if (this.godzWizyty.Contains(dateOdControl))
                            {
                                flaga = false;
                                dateOd = dateOd.AddMinutes(skok);
                            }
                        }

                        if (flaga)
                        {
                            ListViewItem item = new ListViewItem(dateOd.ToString("HH:mm"));
                            listViewGodziny.Items.Add(item);
                            dateOd = dateOd.AddMinutes(skok);
                        }
                        flaga = true;
                    }
                }
                else this.listViewGodziny.Clear();
             
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxDaneLekarza_DropDownClosed(object sender, EventArgs e)
        {
            if (flag)
            {
                Update_Harmonogram();
                Update_GodzinyPracy();
            }
            else
            {
                Update_Harmonogram();
                Update_Godziny();
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (comboBoxDaneLekarza.SelectedItem != null)
            {
                if (flag)
                {
                    Update_Harmonogram();
                    Update_GodzinyPracy();
                }
                else
                {
                    Update_Harmonogram();
                    Update_Godziny();
                }
            }
            else MessageBox.Show("Wybierz lekarza");
        } 
       


        private void listViewGodziny_MouseDoubleClick(object sender, EventArgs e)
        {
            string idpracownik_selected = (comboBoxDaneLekarza.SelectedItem as ComboboxItem).Hidden_Id.ToString();
            DateTime selected_date = (DateTime)monthCalendar1.SelectionStart;
            string date = selected_date.ToString("yyyy-MM-dd");
            string stan = "0";

                if (listViewGodziny.SelectedIndices.Count <= 0)
                {
                    return;
                }

                int intselectedindex = listViewGodziny.SelectedIndices[0];

                if (intselectedindex >= 0)
                {
                    if (form)
                    {
                        string wybranaGodzina = listViewGodziny.Items[intselectedindex].Text;
                        String message = "Czy napewno chcesz zmienić termin wizyty na \n" + date + " " + wybranaGodzina + "?";
                        String caption = "Zmiana terminu wizyty";
                        var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Database database = new Database();
                            database.Update("update wizyta set idpracownik='" + idpracownik_selected + "', data='" + date + "', godzina='" + wybranaGodzina + "' where idwizyta='" + rodzicWizyta.idwizyta + "'", database.Conect());
                            Update_Harmonogram();
                            Update_Godziny();
                        }
                        
                    }
                    else
                    {
                        string wybranaGodzina = listViewGodziny.Items[intselectedindex].Text;
                        String message = "Wybrano godzinę " + wybranaGodzina + "\n Czy chcesz zarejestrować wizyte?";
                        String caption = "Rejestracja wizyty";
                        var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Database database = new Database();
                            database.Insert("insert into wizyta (idpracownik, idpacjent, data, godzina, stan) values ('" + idpracownik_selected + "', '" + this.idpacjent + "', '" + date + "', '" + wybranaGodzina + "', '" + stan + "')", database.Conect());
                            Update_Harmonogram();
                            Update_Godziny();
                        }
                    }
                }            
        }

        
    }
}
