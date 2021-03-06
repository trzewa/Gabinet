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
//using mysettings = Gabinet.Properties.Settings;

namespace Gabinet
{
    public partial class Start : Form
    {
        public string idpracownik;
        private int idstanowiska;
        //public string dbconnection_gabinet;
        public Login rodzic;

        public Start(string idpracownikReceive, Login login)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;           
            this.idpracownik = idpracownikReceive;
            this.rodzic = login;
            //String password = Szyfrowanie.DecryptRijndael(mysettings.Default.password);
            //this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + password + ";charset=utf8";
            User_Control();
        }

        private void btnGabinet_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Panel lekarza")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                this.Visible = false;
                PanelLekarza f2 = new PanelLekarza(this.idpracownik);
                f2.ShowDialog();
                this.Visible = true;
            }
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
                this.Visible = false;
                Rejestracja f2 = new Rejestracja();
                f2.ShowDialog();
                this.Visible = true;
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
                this.Visible = false;
                OrganizacjaPrzychodni f2 = new OrganizacjaPrzychodni();
                f2.ShowDialog();
                this.Visible = true;
            }
        }

        private void btnZakoncz_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Zakończ pracę ...")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                this.Opacity = 0.5;
                Logout f2 = new Logout(this);
                f2.Owner = this;
                f2.ShowDialog();
                //this.Close();
                
            }
        }

        public void User_Control()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from pracownik where idpracownik='" + this.idpracownik + "'", database.Conect());

                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.idstanowiska = (int)element["idstanowisko"];
                    label2.Text = element["nazwisko"].ToString() + " " + element["imie"].ToString();
                }

            switch (this.idstanowiska)
                {
                    case 1:
                        this.btnRejestracja.Enabled = false;
                        this.label4.Enabled = false;
                        this.btnKonfiguracja.Enabled = false;
                        this.label5.Enabled = false;
                        this.btnGabinet.Enabled = true;
                        this.label3.Enabled = true;
                        break;

                    case 2:
                        this.btnGabinet.Enabled = false;
                        this.label3.Enabled = false;
                        this.btnKonfiguracja.Enabled = false;
                        this.label5.Enabled = false;
                        this.btnRejestracja.Enabled = true;
                        this.label4.Enabled = true;
                        break;

                    case 3:
                        this.btnRejestracja.Enabled = true;
                        this.label4.Enabled = true;
                        this.btnKonfiguracja.Enabled = true;
                        this.label5.Enabled = true;
                        this.btnGabinet.Enabled = true;
                        this.label3.Enabled = true;
                        break;

                    /*case 4:
                        this.btnRejestracja.Enabled = true;
                        this.btnKonfiguracja.Enabled = true;
                        this.btnGabinet.Enabled = true;
                        break;*/

                    default :
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Start_Closing(object sender, EventArgs e)
        {

        }
    }
}
