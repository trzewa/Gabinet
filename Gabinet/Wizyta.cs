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
    public partial class Wizyta : Form
    {

        //public string dbconnection_gabinet;
        public string idwizyta;
        public string idpacjent;
        public string idrecepta = null;
        public string idzwolnienie = null;
        public string kod;
        public string nazwa;
        public string idChoroby = null;
        public string idTypBadania = null;
        public string data;
        public bool stan;
        private bool flag;

        public Wizyta(string idwizytaReceive, bool flagreceive)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            this.idwizyta = idwizytaReceive;
            this.flag = flagreceive;
            Update_danePacjent();
            buttonZamknij.Visible = false;
            if (this.flag)
            {
                this.Text = "Szczegóły wizyty";
                buttonZakoncz.Visible = false;
                buttonAnuluj.Visible = false;
                buttonZamknij.Visible = true;
                toolStrip1.Visible = false;
                buttonSzukajChoroby.Visible = false;
                buttonSzukajProcedury.Visible = false;
                textBoxWywiad.Enabled = false;
                Update_badanie();
                Update_choroba();
                Update_wizyta();
            }
            
        }

        public void Update_danePacjent()
        {
            try
            {
                Database database = new Database();

                MySqlDataAdapter myDA = new MySqlDataAdapter();
                myDA = database.Select("select idpacjent from wizyta where idwizyta='" + this.idwizyta + "'", database.Conect());
                DataTable dT = new DataTable();
                myDA.Fill(dT);

                if (dT.Rows.Count == 1)
                {
                    DataRow element = dT.Rows[0];
                    this.idpacjent = element["idpacjent"].ToString();
                }

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();                
                myDataAdapter = database.Select("select nazwisko, imie, ulica, nr_budynku, nr_lokalu, miasto, kod_pocztowy, mail, telefon from pacjent inner join pacjentadres on pacjent.idpacjent=pacjentadres.idpacjent inner join adres on adres.idadres=pacjentadres.idadres inner join pacjentkontakt on pacjent.idpacjent=pacjentkontakt.idpacjent inner join kontakt on pacjentkontakt.idkontakt=kontakt.idkontakt where pacjent.idpacjent='" + this.idpacjent + "'", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    DataRow element = dt.Rows[0];
                    this.labelNazwiskoImie.Text = element["nazwisko"].ToString() + " " + element["imie"].ToString();
                    this.labelAdres.Text = element["ulica"].ToString() + " " + element["nr_budynku"].ToString() + " m." + element["nr_lokalu"].ToString() + "; " + element["kod_pocztowy"].ToString() + " " + element["miasto"].ToString();
                    
                    this.labelTelefon.Text = element["telefon"].ToString();
                    this.linkLabelMail.Text = element["mail"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSzukajProcedury_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Wyszukiwanie")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                this.Opacity = 0.5;
                int button = 1;
                SzukajProcedury f2 = new SzukajProcedury(this, button);
                f2.Owner = this;
                f2.ShowDialog();
                textBoxKod.Text = kod;
                textBoxNazwa.Text = nazwa;
                this.Opacity = 1;
            }
        }

        private void buttonSzukajChoroby_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Wyszukiwanie")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                this.Opacity = 0.5;
                int button = 2;
                SzukajProcedury f2 = new SzukajProcedury(this, button);
                f2.Owner = this;
                f2.ShowDialog();
                textBoxKodChoroby.Text = kod;
                textBoxNazwaChoroby.Text = nazwa;
                this.Opacity = 1;
            }
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Database database = new Database();  
            
            if (this.idzwolnienie != null)
            {
                try
                {
                    database.Delete("delete from zwolnienie where idzwolnienia='" + this.idzwolnienie + "'", database.Conect());                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (this.idrecepta != null)
            {
                try
                {
                    database.Delete("delete from receptalek where idrecepty='" + this.idrecepta + "'", database.Conect());

                    database.Delete("delete from recepta where idrecepty='" + this.idrecepta + "'", database.Conect());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Close();
        }

        private void buttonZakoncz_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string data = dt.ToString("yyyy-MM-dd");
            string godzina = dt.ToString("HH:mm:ss");
            string wywiad = this.textBoxWywiad.Text;

            if (idTypBadania != null && idChoroby != null)
            {
                this.Opacity = 0.5;
                String message = "Czy chcesz zatwierdzić wizyte?\nUWAGA!\nPo zatwierdzeniu wizyty nie będzie możliwości wykonania w niej żadnych zmian!";
                String caption = "Kończenie wizyty";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Database database = new Database();
                        database.Update("update wizyta set idchoroby='" + this.idChoroby + "', idtyp_badania='" + idTypBadania + "', data='" + data + "', godzina='" + godzina + "', wywiad='" + wywiad + "', stan='1' where idwizyta='" + idwizyta + "'", database.Conect());
                        if (this.idzwolnienie != null)
                        {
                            database.Update("update wizyta set idzwolnienia='" + idzwolnienie + "' where idwizyta='" + idwizyta + "'", database.Conect());
                        }
                        if (this.idrecepta != null)
                        {
                            database.Update("update wizyta set idrecepty='" + this.idrecepta + "' where idwizyta='" + idwizyta + "'", database.Conect());

                        }
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);                        
                    }
                }
                else this.Opacity = 1;
                
            }
            else MessageBox.Show("Wprowadź typ badania i/lub rozpoznanie!", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            
        }

        private void buttonZwolnienie_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            if (flag)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "Zwolnienie")
                    {
                        IsOpen = true;
                        f.Focus();
                        break;
                    }
                }
                if (IsOpen == false)
                {                    
                        this.Visible = false;
                        Zwolnienie f2 = new Zwolnienie(this.idzwolnienie, this);
                        f2.Owner = this;    
                        f2.ShowDialog();
                        this.Visible = true;                                            
                }
            }
            else
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "Tworzenie zwolnienia")
                    {
                        IsOpen = true;
                        f.Focus();
                        break;
                    }
                }
                if (IsOpen == false)
                {
                    if (idChoroby != null)
                    {
                        this.Opacity = 0.5;
                        Zwolnienie f2 = new Zwolnienie(this);
                        f2.Owner = this;
                        f2.ShowDialog();
                        this.Opacity = 1;
                        if (idzwolnienie != null)
                        {
                            buttonZwolnienie.Enabled = false;
                        }
                    }
                    else MessageBox.Show("Aby wystawić zwolnienie trzeba wybrać kod choroby!", "Brak rozpoznania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void toolStripButtonInfo_Click(object sender, EventArgs e)
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
                    this.Opacity = 0.5;
                    DanePacjent f2 = new DanePacjent(this.idpacjent);
                    f2.ShowDialog();
                    this.Opacity = 1;
                
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
                
                    this.Opacity = 0.5;                    
                    PacjentWizyta f2 = new PacjentWizyta(this.idpacjent, true);
                    f2.ShowDialog();
                    this.Opacity = 1;
                
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
                    this.Opacity = 0.5;                    
                    PacjentWizyta f2 = new PacjentWizyta(this.idpacjent, false);
                    f2.ShowDialog();
                    this.Opacity = 1;               
            }
        }

        public void Update_choroba()
        {
            try
            {
                Database database = new Database();
                MySqlDataAdapter myDA = new MySqlDataAdapter();
                myDA = database.Select("select kod_mkch, nazwa_choroby from choroba inner join wizyta on choroba.idchoroby=wizyta.idchoroby where idwizyta = '" + this.idwizyta + "'", database.Conect());
                DataTable dT = new DataTable();
                myDA.Fill(dT);

                if (dT.Rows.Count == 1)
                {
                    DataRow element = dT.Rows[0];
                    this.textBoxKodChoroby.Text = element["kod_mkch"].ToString();
                    this.textBoxNazwaChoroby.Text = element["nazwa_choroby"].ToString();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_badanie()
        {
            try
            {
                Database database = new Database();
                MySqlDataAdapter myDA = new MySqlDataAdapter();
                myDA = database.Select("select kod_badania, nazwa_badania from typbadania inner join wizyta on typbadania.idtyp_badania=wizyta.idtyp_badania where idwizyta = '" + this.idwizyta + "'", database.Conect());
                DataTable dT = new DataTable();
                myDA.Fill(dT);

                if (dT.Rows.Count == 1)
                {
                    DataRow element = dT.Rows[0];
                    this.textBoxKod.Text = element["kod_badania"].ToString();
                    this.textBoxNazwa.Text = element["nazwa_badania"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_wizyta()
        {
            try
            {
                Database database = new Database();
                MySqlDataAdapter myDA = new MySqlDataAdapter();
                myDA = database.Select("select idrecepty, idzwolnienia, wywiad from wizyta where idwizyta = '" + this.idwizyta + "'", database.Conect());
                DataTable dT = new DataTable();
                myDA.Fill(dT);

                if (dT.Rows.Count == 1)
                {
                    DataRow element = dT.Rows[0];                    
                    this.idrecepta = element["idrecepty"].ToString();
                    this.idzwolnienie = element["idzwolnienia"].ToString();
                    textBoxWywiad.Text = element["wywiad"].ToString();
                }

                if (this.idrecepta == "")
                {
                    this.buttonRecepta.Enabled = false;
                }

                if (this.idzwolnienie == "")
                {
                    this.buttonZwolnienie.Enabled = false;
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

        private void Update_stan()
        {
            try
            {
                Database database = new Database();
                MySqlDataAdapter myDA = new MySqlDataAdapter();
                myDA = database.Select("select data, stan from wizyta where idwizyta = '" + this.idwizyta + "'", database.Conect());
                DataTable dT = new DataTable();
                myDA.Fill(dT);

                if (dT.Rows.Count == 1)
                {
                    string stanBool;
                    DataRow element = dT.Rows[0];                    
                    stanBool = element["stan"].ToString();
                    if (stanBool.Equals("1"))
                    {
                        this.stan = true;
                    }
                    else this.stan = false;
                    this.data = element["data"].ToString();                    
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void buttonRecepta_Click(object sender, EventArgs e)
        {
            Update_stan();

            if (this.stan == false)
            {
                DateTime dt = DateTime.Now;
                this.data = dt.ToString("yyyy-MM-dd");
            }

            bool IsOpen = false;
            if (flag)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "Widok recepty")
                    {
                        IsOpen = true;
                        f.Focus();
                        break;
                    }
                }
                if (IsOpen == false)
                {
                    this.Visible = false;
                    ReceptaWidok f2 = new ReceptaWidok(this.idrecepta, this.idpacjent, this.data);                    
                    f2.ShowDialog();
                    this.Visible = true;
                }
            }
            else
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "Recepta")
                    {
                        IsOpen = true;
                        f.Focus();
                        break;
                    }
                }
                if (IsOpen == false)
                {
                    this.Opacity = 0.5;
                    Recepta f2 = new Recepta();
                    f2.Owner = this;
                    f2.ShowDialog();
                    if (f2.idrecepta != null)
                    {
                        this.idrecepta = f2.idrecepta;
                        buttonRecepta.Enabled = false;
                        //flag = true;
                        //buttonRecepta.Text = "Wygeneruj recepte";
                    }
                    this.Opacity = 1;
                }
            }
        }
    }
}
