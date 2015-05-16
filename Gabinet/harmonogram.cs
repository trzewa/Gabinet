﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using mysettings = Gabinet.Properties.Settings;

namespace Gabinet
{
    public partial class harmonogram : Form
    {
        private string idpracownik;
        private string id1, id2, id3, id4, id5, id6;
        private string idPracownikGodziny;
        public string dbconnection_gabinet;

        public harmonogram(string idpracownikreceive)
        {
            InitializeComponent();
            this.idpracownik = idpracownikreceive;
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            Update_daneLekarza();
            Update_Czas();
        }

        public void Update_daneLekarza()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from pracownik inner join stanowisko on stanowisko.idstanowisko=pracownik.idstanowisko where idpracownik='" + this.idpracownik + "'", this.dbconnection_gabinet);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.textBoxDanePracownika.Text = element["nazwisko"].ToString() + " " + element["imie"].ToString();
                    this.textBoxStanowisko.Text = element["nazwa"].ToString();
                }     

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_Czas()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from pracownikgodziny inner join godzinyprzyjec on godzinyprzyjec.idgodziny=pracownikgodziny.idgodziny where idpracownik='" + this.idpracownik + "'", this.dbconnection_gabinet);

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow element = dt.Rows[i];
                    int dzien = (int)element["dzien_tygodnia"];
                    //this.idPracownikGodziny = element["id"].ToString();

                    switch (dzien)
                    {
                        case 1:
                            this.textBoxPonOd.Text = element["godz_od"].ToString();
                            this.textBoxPonDo.Text = element["godz_do"].ToString();
                            this.id1 = element["id"].ToString();
                            break;
                        case 2:
                            this.textBoxWtOd.Text = element["godz_od"].ToString();
                            this.textBoxWtDo.Text = element["godz_do"].ToString();
                            this.id2 = element["id"].ToString();
                            break;
                        case 3:
                            this.textBoxSrOd.Text = element["godz_od"].ToString();
                            this.textBoxSrDo.Text = element["godz_do"].ToString();
                            this.id3 = element["id"].ToString();
                            break;
                        case 4:
                            this.textBoxCzOd.Text = element["godz_od"].ToString();
                            this.textBoxCzDo.Text = element["godz_do"].ToString();
                            this.id4 = element["id"].ToString();
                            break;
                        case 5:
                            this.textBoxPiOd.Text = element["godz_od"].ToString();
                            this.textBoxPiDo.Text = element["godz_do"].ToString();
                            this.id5 = element["id"].ToString();
                            break;
                        case 6:
                            this.textBoxSoOd.Text = element["godz_od"].ToString();
                            this.textBoxSoDo.Text = element["godz_do"].ToString();
                            this.id6 = element["id"].ToString();
                            break;
                        default :                           
                            break;
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPon_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Zmień godziny")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {                
                harmonogramZmien f2 = new harmonogramZmien(this.id1, this.idpracownik, 1, this.textBoxPonOd.Text.ToString() , this.textBoxPonDo.Text.ToString());
                f2.ShowDialog();
                Update_Czas();
            }
        }

        private void buttonWt_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Zmień godziny")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                harmonogramZmien f2 = new harmonogramZmien(this.id2, this.idpracownik, 2, this.textBoxWtOd.Text.ToString(), this.textBoxWtDo.Text.ToString());
                f2.ShowDialog();
                Update_Czas();
            }
        }

        private void buttonSr_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Zmień godziny")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                harmonogramZmien f2 = new harmonogramZmien(this.id3, this.idpracownik, 3, this.textBoxSrOd.Text.ToString(), this.textBoxSrDo.Text.ToString());
                f2.ShowDialog();
                Update_Czas();
            }
        }

        private void buttonCz_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Zmień godziny")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                harmonogramZmien f2 = new harmonogramZmien(this.id4, this.idpracownik, 4, this.textBoxCzOd.Text.ToString(), this.textBoxCzDo.Text.ToString());
                f2.ShowDialog();
                Update_Czas();
            }
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Zmień godziny")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                harmonogramZmien f2 = new harmonogramZmien(this.id5, this.idpracownik, 5, this.textBoxPiOd.Text.ToString(), this.textBoxPiDo.Text.ToString());
                f2.ShowDialog();
                Update_Czas();
            }
        }

        private void buttonSo_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Zmień godziny")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                harmonogramZmien f2 = new harmonogramZmien(this.id6, this.idpracownik, 6, this.textBoxSoOd.Text.ToString(), this.textBoxSoDo.Text.ToString());
                f2.ShowDialog();
                Update_Czas();
            }
        }        
    }
}