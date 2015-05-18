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
using mysettings = Gabinet.Properties.Settings;

namespace Gabinet
{
    public partial class harmonogramZmien : Form
    {
        private string idpracownik;
        private int dzien;
        private string idPracownikGodziny;
        private string idgodziny;
        private string idGodzinyCompare;
        private string dzienCompare;
        private string godz_od;
        private string godz_do;
        private string godzod;
        private string minod;
        private string godzdo;
        private string mindo;
        private bool flag;
        public string dbconnection_gabinet;

        public harmonogramZmien(string idgodzinyR, string idPracownikGodzinyR, string idpracownikR, int dzienR, string godz_odR, string godz_doR)
        {
            InitializeComponent();
            this.dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password;
            this.idgodziny = idgodzinyR;
            this.idPracownikGodziny = idPracownikGodzinyR;
            this.idpracownik = idpracownikR;
            this.dzien = dzienR;
            this.godz_od = godz_odR;
            this.godz_do = godz_doR;
            Update_Dane();

            if (this.godz_od.Contains("00:00:00"))
            {
                this.buttonZmien.Visible = false;
            }
            else this.buttonDodaj.Visible = false;
        }

        public void Update_Dane()
        {
            switch (this.dzien)
            {
                case 1:
                    this.textBoxDzien.Text = "Poniedziałek";
                    break;
                case 2:
                    this.textBoxDzien.Text = "Wtorek";
                    break;
                case 3:
                    this.textBoxDzien.Text = "Środa";
                    break;
                case 4:
                    this.textBoxDzien.Text = "Czwartek";
                    break;
                case 5:
                    this.textBoxDzien.Text = "Piątek";
                    break;
                case 6:
                    this.textBoxDzien.Text = "Sobota";
                    break;
                default :
                    break;
            }
            this.godzod = this.godz_od[0].ToString() + this.godz_od[1].ToString();
            this.minod = this.godz_od[3].ToString() + this.godz_od[4].ToString();
            this.godzdo = this.godz_do[0].ToString() + this.godz_do[1].ToString();
            this.mindo = this.godz_do[3].ToString() + this.godz_do[4].ToString();
            this.numericUpDownHOd.Value = Convert.ToInt32(godzod);
            this.numericUpDownMOd.Value = Convert.ToInt32(minod);
            this.numericUpDownHDo.Value = Convert.ToInt32(godzdo);
            this.numericUpDownMDo.Value = Convert.ToInt32(mindo);
        }

        private void buttonZmien_Click(object sender, EventArgs e)
        {
            if (this.numericUpDownHOd.Value < 10)
            {
                this.godzod = "0" + this.numericUpDownHOd.Value.ToString();
            }
            else this.godzod = this.numericUpDownHOd.Value.ToString();

            if (this.numericUpDownHDo.Value < 10)
            {
                this.godzdo = "0" + this.numericUpDownHDo.Value.ToString();
            }
            else this.godzdo = this.numericUpDownHDo.Value.ToString();

            if (this.numericUpDownMOd.Value < 10)
            {
                this.minod = "0" + this.numericUpDownMOd.Value.ToString();
            }
            else this.minod = this.numericUpDownMOd.Value.ToString();

            if (this.numericUpDownMDo.Value < 10)
            {
                this.mindo = "0" + this.numericUpDownMDo.Value.ToString();
            }
            else this.mindo = this.numericUpDownMDo.Value.ToString();

            this.godz_od = this.godzod.ToString() + ":" + this.minod.ToString() + ":00";
            this.godz_do = this.godzdo.ToString() + ":" + this.mindo.ToString() + ":00";

            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            Database database = new Database();
            myDataAdapter = database.Select("select * from godzinyprzyjec", this.dbconnection_gabinet);

            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);

            this.flag = false;
            for (int i = 0; i < dt.Rows.Count; i++) // Kontrola czy jest w bazie wpis z takim dniem i godzinami
            {
                DataRow element = dt.Rows[i];
                this.godzod = element["godz_od"].ToString();
                this.godzdo = element["godz_do"].ToString();
                this.dzienCompare = element["dzien_tygodnia"].ToString();
                this.idGodzinyCompare = element["idgodziny"].ToString();
                if (this.godzod.Contains(this.godz_od) && this.godzdo.Contains(this.godz_do)&&this.dzienCompare.Contains(this.dzien.ToString()))
                {
                    this.idgodziny = this.idGodzinyCompare;
                    this.flag = true;                    
                }
            }

            if (this.flag)
            {
                database.Update("update pracownikgodziny set idgodziny='" + this.idgodziny + "' where id='" + this.idPracownikGodziny + "'", this.dbconnection_gabinet);
            }
            else 
            {
                database.Insert("insert into godzinyprzyjec (dzien_tygodnia, godz_od, godz_do) VALUES('" + this.dzien + "','" + this.godz_od + "', '" + this.godz_do + "')", this.dbconnection_gabinet);
                database.Update("update pracownikgodziny set idgodziny=(select max(idgodziny) from godzinyprzyjec) where id='" + this.idPracownikGodziny + "'", this.dbconnection_gabinet);
            }
            
            DialogResult result = MessageBox.Show("Zmieniono godziny");

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                harmonogramZmien.ActiveForm.Close();
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (this.numericUpDownHOd.Value < 10)
            {
                this.godzod = "0" + this.numericUpDownHOd.Value.ToString();
            }
            else this.godzod = this.numericUpDownHOd.Value.ToString();

            if (this.numericUpDownHDo.Value < 10)
            {
                this.godzdo = "0" + this.numericUpDownHDo.Value.ToString();
            }
            else this.godzdo = this.numericUpDownHDo.Value.ToString();

            if (this.numericUpDownMOd.Value < 10)
            {
                this.minod = "0" + this.numericUpDownMOd.Value.ToString();
            }
            else this.minod = this.numericUpDownMOd.Value.ToString();

            if (this.numericUpDownMDo.Value < 10)
            {
                this.mindo = "0" + this.numericUpDownMDo.Value.ToString();
            }
            else this.mindo = this.numericUpDownMDo.Value.ToString();

            this.godz_od = this.godzod.ToString() + ":" + this.minod.ToString() + ":00";
            this.godz_do = this.godzdo.ToString() + ":" + this.mindo.ToString() + ":00";

            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            Database database = new Database();
            myDataAdapter = database.Select("select * from godzinyprzyjec", this.dbconnection_gabinet);

            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);

            this.flag = false;
            for (int i = 0; i < dt.Rows.Count; i++) // Kontrola czy jest w bazie wpis z takim dniem i godzinami
            {
                DataRow element = dt.Rows[i];
                this.godzod = element["godz_od"].ToString();
                this.godzdo = element["godz_do"].ToString();
                this.dzienCompare = element["dzien_tygodnia"].ToString();
                this.idGodzinyCompare = element["idgodziny"].ToString();
                if (this.godzod.Contains(this.godz_od) && this.godzdo.Contains(this.godz_do) && this.dzienCompare.Contains(this.dzien.ToString()))
                {
                    this.idgodziny = this.idGodzinyCompare;
                    this.flag = true;
                }
            }

            if (this.flag)
            {
                database.Insert("insert into pracownikgodziny (idgodziny, idpracownik) values ('" + this.idgodziny + "','" + this.idpracownik + "')", this.dbconnection_gabinet);
            }
            else
            {
                database.Insert("insert into godzinyprzyjec (dzien_tygodnia, godz_od, godz_do) VALUES('" + this.dzien + "','" + this.godz_od + "', '" + this.godz_do + "')", this.dbconnection_gabinet);
                database.Insert("insert into pracownikgodziny (idgodziny, idpracownik) values ((select max(idgodziny) from godzinyprzyjec),'" + this.idpracownik + "')", this.dbconnection_gabinet);
            }

            DialogResult result = MessageBox.Show("Dodano godziny");

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                harmonogramZmien.ActiveForm.Close();
            }
        }
    }
}
