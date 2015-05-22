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
    public partial class szukajProcedury : Form
    {
        public string dbconnection_gabinet;
        private string _searchText = string.Empty;
        private int _searchColumnID = 1;
        private int _searchRowID = 0;
        private Wizyta rodzicWizyta;
        private int button;

        public szukajProcedury(Wizyta parent, int buttonReceive)
        {
            InitializeComponent();
            
            this.rodzicWizyta = parent;
            this.button = buttonReceive;
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            if (this.button.Equals(1))
            {
                Update_Procedury();
                dataGridViewChoroba.Visible = false;
            }
            else if (this.button.Equals(2))
            {
                Update_Choroba();
                dataGridViewProcedury.Visible = false;
            }
            
        }

        public void Update_Procedury()
        {
            try
            {                
                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();                
                myDataAdapter = database.Select("select * from typbadania", this.dbconnection_gabinet);
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                dataGridViewProcedury.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_Choroba()
        {
            try
            {
                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter = database.Select("select * from choroba", this.dbconnection_gabinet);
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                dataGridViewChoroba.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSzukaj_Click(object sender, EventArgs e)
        {
            if (textBoxNazwa.Text != string.Empty)
            {
                if (textBoxNazwa.Text != _searchText)
                {
                    _searchText = textBoxNazwa.Text;
                    _searchRowID = 0;                    
                }
                Search();
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić tekst!");
            }
        }

        private void Search()
        {

            string searchText = textBoxNazwa.Text.ToUpper();
            bool found = false;

            for (int i = _searchRowID; i < dataGridViewProcedury.Rows.Count; i++)
            {
                string columnText = dataGridViewProcedury.Rows[i].Cells[_searchColumnID].Value.ToString().ToUpper();
                if (columnText.Contains(searchText))
                {
                    found = true;
                    if (i <= dataGridViewProcedury.Rows.Count - 1)
                    {
                        _searchRowID = i + 1;
                    }
                    else
                    {
                        _searchRowID = 0;
                    }
                    dataGridViewProcedury.Rows[i].Selected = true;
                    dataGridViewProcedury.FirstDisplayedScrollingRowIndex = i;                    
                    break;
                }
            }

            for (int i = _searchRowID; i < dataGridViewChoroba.Rows.Count; i++)
            {
                string columnText = dataGridViewChoroba.Rows[i].Cells[_searchColumnID].Value.ToString().ToUpper();
                if (columnText.Contains(searchText))
                {
                    found = true;
                    if (i <= dataGridViewChoroba.Rows.Count - 1)
                    {
                        _searchRowID = i + 1;
                    }
                    else
                    {
                        _searchRowID = 0;
                    }
                    dataGridViewChoroba.Rows[i].Selected = true;
                    dataGridViewChoroba.FirstDisplayedScrollingRowIndex = i;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Nie znaleziono szukanego tekstu!");
                _searchRowID = 0;
            }
        }

        private void buttonWybierz_Click(object sender, EventArgs e)
        {
            int row;

            if (button.Equals(1))
            {
                row = dataGridViewProcedury.CurrentCell.RowIndex;
                rodzicWizyta.kodChoroby = dataGridViewProcedury.Rows[row].Cells[1].Value.ToString();
                rodzicWizyta.nazwaChoroby = dataGridViewProcedury.Rows[row].Cells[2].Value.ToString();
                rodzicWizyta.idTypBadania = dataGridViewProcedury.Rows[row].Cells[0].Value.ToString();
            }
            else
            {
                row = dataGridViewChoroba.CurrentCell.RowIndex;
                rodzicWizyta.kodChoroby = dataGridViewChoroba.Rows[row].Cells[1].Value.ToString();
                rodzicWizyta.nazwaChoroby = dataGridViewChoroba.Rows[row].Cells[2].Value.ToString();
                rodzicWizyta.idChoroby = dataGridViewChoroba.Rows[row].Cells[0].Value.ToString();
            }           
            
            Close();
        }      
    }
}
