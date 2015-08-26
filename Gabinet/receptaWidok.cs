using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using Microsoft.Reporting.WinForms;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using mysettings = Gabinet.Properties.Settings;


namespace Gabinet
{
    public partial class receptaWidok : Form
    {
        double HardMarginX = 4;
        double HardMarginY = 4;
        Font BoldFont;
        Font NormalFont;
        Graphics g;
        double PageWidth;
        double PageHeight;
        double MedListWidth;
        double MedListHeight;
        public string dbconnection_lek;
        //public string dbconnection_gabinet;        
        public string idrecepta;
        public string idpacjent;
        public string ImieNazwisko;
        public string Adres;
        public string Pesel;
        public string Fundusz;
        public string danePrzychodni;
        public string Nfz;
        public string dataRealizacji;
        public string uprawnienia;
        public string data;
        public Wizyta rodzicWizyta;

        public receptaWidok()
        {
            InitializeComponent();
        }

        public receptaWidok(string idreceptaReceive, string idpacjentReceive, string dataReceive)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.dbconnection_lek = "Provider=" + mysettings.Default.provider + ";Data Source=" + mysettings.Default.dsdbf + ";Extended Properties=" + mysettings.Default.properties + ";";
            //database.Conect() = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + mysettings.Default.password + ";charset=utf8";
            this.idrecepta = idreceptaReceive;
            this.idpacjent = idpacjentReceive;
            this.data = dataReceive;
        }

        void ReadInitialValuesFromRDLC(Stream xmlStream, out double Width, out double Height, out double MedListWidth, out double MedListHeight)
        {
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(xmlStream);
            xmlStream.Close();

            XmlNamespaceManager manager = new XmlNamespaceManager(doc.NameTable);
            manager.AddNamespace("ns", "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition");

            XmlNode nodeWidth = doc.SelectSingleNode("//ns:PageWidth", manager);
            Width = System.Convert.ToDouble(nodeWidth.InnerText.Replace("cm", "").Replace(".", ","));

            XmlNode nodeHeight = doc.SelectSingleNode("//ns:PageHeight", manager);
            Height = System.Convert.ToDouble(nodeHeight.InnerText.Replace("cm", "").Replace(".", ","));


            XmlNode nodeMedListHeight = doc.SelectSingleNode("//ns:ReportItems/*[@Name = 'Rp_Middle_MedicinesListRect']", manager);
            MedListHeight = 0;
            foreach (XmlNode node in nodeMedListHeight.ChildNodes)
            {
                if (node.Name == "Height")
                {
                    MedListHeight = System.Convert.ToDouble(node.InnerText.Replace("cm", "").Replace(".", ","));
                    break;
                }
            }

            nodeMedListHeight = doc.SelectSingleNode("//ns:ReportItems/*[@Name = 'Rp_Middle_MedicinesList']", manager);
            MedListWidth = 0;
            foreach (XmlNode node in nodeMedListHeight.ChildNodes)
            {
                if (node.Name == "Width")
                {
                    MedListWidth = System.Convert.ToDouble(node.InnerText.Replace("cm", "").Replace(".", ","));
                    break;
                }
            }
        }

        bool Setup;
        string PrinterName;
        string ReportPath;
        private void receptaWidok_Load(object sender, EventArgs e)
        {
            this.Setup = true;
            this.numHCProvider.Minimum = 1.0m;
            this.numHCProvider.Maximum = 2.75m;
            this.numHCProvider.Increment = 0.25m;
            this.numHCProvider.Value = 2.75m;

            this.numMedList.Minimum = 5.5m;
            this.numMedList.Maximum = 7.5m;
            this.numMedList.Increment = 0.25m;
            this.numMedList.Value = 7.5m;

            this.numLeftMargin.Minimum = 0.0m;
            this.numLeftMargin.Maximum = 20.0m;
            this.numLeftMargin.Increment = 1.0m;
            this.numLeftMargin.Value = 0.0m;

            this.numTopMargin.Minimum = 0.0m;
            this.numTopMargin.Maximum = 20.0m;
            this.numTopMargin.Increment = 1.0m;
            this.numTopMargin.Value = 0.0m;

            this.numDateFields.Minimum = 0.6m;
            this.numDateFields.Maximum = 1.1m;
            this.numDateFields.Increment = 0.1m;
            this.numDateFields.Value = 0.6m;
            this.Setup = false;

            this.BoldFont = new Font("Arial", 8, FontStyle.Bold);
            this.NormalFont = new Font("Arial", 8);

            this.g = this.CreateGraphics();
            this.g.PageUnit = GraphicsUnit.Millimeter;

            this.ReportPath = @"Rp.rdlc";
            this.ReadInitialValuesFromRDLC(new FileStream(this.ReportPath, FileMode.Open), out this.PageWidth, out this.PageHeight, out MedListWidth, out this.MedListHeight);
            this.MakeReport(0.0 + this.HardMarginX, 0.0 + this.HardMarginX);
            this.tabControl1.SelectedTab = tabPage2;
            
        }

        

        void MakeReport(double LeftMargin, double RightMargin)
        {
            
            this.RpViewer.CancelRendering(0);
            this.RpViewer.Reset();

            Stream s = new FileStream(this.ReportPath, FileMode.Open);
            this.RpViewer.LocalReport.LoadReportDefinition(RecalcPrescriptionLayout(ChangeMargins(s, this.PageWidth, this.PageHeight + 0.25, LeftMargin, RightMargin), (double)this.numHCProvider.Maximum, (double)this.numHCProvider.Value, (double)this.numMedList.Maximum, (double)this.numMedList.Value, (double)this.numDateFields.Minimum, (double)this.numDateFields.Value));

            int MedWidthMax = (int)(this.MedListWidth * 10.0 - 2.5);
            int MedHeightMax = (int)(this.numMedList.Value * 10.0m);

            #region Budowanie listy leków
            Medicines med = new Medicines(MedWidthMax, MedHeightMax, -1, this.NormalFont, this.BoldFont, this.g);
            this.LoadData(med);

            this.RpViewer.LocalReport.DataSources.Clear();
            this.RpViewer.LocalReport.DataSources.Add(med.GetDataSource());
            #endregion

            #region Ustawienie parametrów

            Update_danePacjent();
            Update_danePrzychodni();
            Update_daneRecepta();

            ReportParameter PrintWireframe = new ReportParameter("PrintWireframe", this.cbPrintFrames.Checked.ToString());
            ReportParameter PrintLabels = new ReportParameter("PrintLabels", this.cbPrintLabels.Checked.ToString());
            ReportParameter PrintPrescriptionNumber = new ReportParameter("PrintPrescriptionNumber", this.cbPrintPrescNum.Checked.ToString());
            ReportParameter PrintHCProvider = new ReportParameter("PrintHCProvider", this.cbPrintHCProvider.Checked.ToString());

            ReportParameter HCP = new ReportParameter("HealthcareProvider", this.danePrzychodni);
            ReportParameter PNum = new ReportParameter("PrescriptionNumber", this.GenerateRandomRpNumber());
            ReportParameter NFZ = new ReportParameter("NFZDivision", this.Nfz);
            ReportParameter PP = new ReportParameter("PatientPersmissions", this.uprawnienia);
            ReportParameter PESEL = new ReportParameter("PESEL", this.Pesel);
            ReportParameter PatientData = new ReportParameter("PatientData", ImieNazwisko + Environment.NewLine + Adres);
            ReportParameter PrescriptionDate = new ReportParameter("PrescriptionDate", Convert.ToDateTime(this.data).ToString("yyyy-MM-dd"));
            ReportParameter FromDate = new ReportParameter("FromDate", this.dataRealizacji);

            this.RpViewer.LocalReport.SetParameters(new ReportParameter[] { PrintWireframe, PrintLabels, HCP, PNum, NFZ, PP, PESEL, PatientData, PrescriptionDate, FromDate, PrintPrescriptionNumber, PrintHCProvider });
            #endregion

            this.RpViewer.LocalReport.AddTrustedCodeModuleInCurrentAppDomain("System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
            this.RpViewer.LocalReport.AddTrustedCodeModuleInCurrentAppDomain("I25, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

            this.RpViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.RpViewer.ZoomPercent = 100;
            this.RpViewer.ZoomMode = ZoomMode.Percent;

            this.RpViewer.RefreshReport();
        }

        private void Update_danePrzychodni()
        {
            try
            {
                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter = database.Select("select nazwa, regon, ulica, nr_budynku, miasto, kod_pocztowy, mail, telefon from przychodnia inner join przychodniaadres on przychodnia.idprzychodnia=przychodniaadres.idprzychodnia inner join adres on adres.idadres=przychodniaadres.idadres inner join przychodniakontakt on przychodnia.idprzychodnia=przychodniakontakt.idprzychodnia inner join kontakt on przychodniakontakt.idkontakt=kontakt.idkontakt where przychodnia.idprzychodnia=(select max(idprzychodnia) from przychodnia)", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.danePrzychodni = element["nazwa"].ToString() + "\n " + element["kod_pocztowy"].ToString() + " " + element["miasto"].ToString() + ", " + element["ulica"].ToString() + " " + element["nr_budynku"].ToString() + "\n Regon " + element["regon"].ToString() + "\n tel. " + element["telefon"].ToString() + ", mail: " + element["mail"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_danePacjent()
        {
            try
            {
                Database database = new Database();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter = database.Select("select nazwisko, imie, pesel, idfundusz, ulica, nr_budynku, nr_lokalu, miasto, kod_pocztowy, mail, telefon from pacjent inner join pacjentadres on pacjent.idpacjent=pacjentadres.idpacjent inner join adres on adres.idadres=pacjentadres.idadres inner join pacjentkontakt on pacjent.idpacjent=pacjentkontakt.idpacjent inner join kontakt on pacjentkontakt.idkontakt=kontakt.idkontakt where pacjent.idpacjent='" + this.idpacjent + "'", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                                
                if (dt.Rows.Count == 1)
                {
                    string idfundusz;
                    DataRow element = dt.Rows[0];
                    this.ImieNazwisko = element["nazwisko"].ToString() + " " + element["imie"].ToString();
                    this.Adres = element["ulica"].ToString() + " " + element["nr_budynku"].ToString() + " m." + element["nr_lokalu"].ToString() + "; " + element["kod_pocztowy"].ToString() + " " + element["miasto"].ToString();
                    this.Pesel = element["pesel"].ToString();
                    idfundusz = element["idfundusz"].ToString();
                    myDataAdapter = database.Select("select oddzial from fundusz where idfundusz = '" + idfundusz + "'", database.Conect());                    
                    myDataAdapter.Fill(dt);
                    element = dt.Rows[1];
                    this.Nfz = element["oddzial"].ToString().Substring(0,2);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_daneRecepta()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                Database database = new Database();
                myDataAdapter = database.Select("select * from recepta where idrecepty = '" + this.idrecepta + "'", database.Conect());
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    DataRow element = dt.Rows[0];
                    this.dataRealizacji = element["data_realizacji"].ToString();
                    if (!dataRealizacji.Equals("X"))
                    {
                        this.dataRealizacji = Convert.ToDateTime(this.dataRealizacji).ToString("yyyy-MM-dd");
                    }
                    this.uprawnienia = element["uprawnienia_dodatkowe"].ToString().Substring(0, 2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadData(Medicines med)
        {

            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            Database database = new Database();
            myDataAdapter = database.Select("select * from receptalek where idrecepty = '" + this.idrecepta + "'", database.Conect());
            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string bazyl = dt.Rows[i]["bazyl"].ToString();
                string dawka = dt.Rows[i]["dawkowanie"].ToString();
                string ilosc = dt.Rows[i]["ilosc"].ToString();
                string odplatnosc = dt.Rows[i]["odplatnosc"].ToString();
                string nazwa;                
                string opakowanie;
                bool LastItem = false;                

                OleDbDataAdapter myDataAdapterOleDb = new OleDbDataAdapter();
                Database databaseOleDb = new Database();                
                myDataAdapterOleDb = databaseOleDb.SelectDbf("select * from PODSTAW.DBF where BAZYL = '" + bazyl + "'", dbconnection_lek);
                DataTable dtOleDb = new DataTable();                
                myDataAdapterOleDb.Fill(dtOleDb);
                if (dtOleDb.Rows.Count == 1)
                {
                    DataRow element = dtOleDb.Rows[0];
                    nazwa = element["NAZWA"].ToString();                    
                    opakowanie = element["OPAKOWANIE"].ToString();
                    if (i == (dt.Rows.Count))
                    {
                        LastItem = true;
                    }

                    med.AddMedicine(nazwa + ", " + opakowanie + " (Ilość: " + ilosc + ")" + "     Odpłatność:" + odplatnosc, "Dawka: " + dawka, LastItem);
                    dtOleDb.Clear();
                }
            }
        }

        string GenerateRandomRpNumber()
        {
            Random r = new Random(DateTime.Now.Second);

            string nr = "";
            for (int i = 0; i < 22; i++)
            {
                nr += r.Next(10).ToString();
            }
            return nr;
        }

        void LockControls(bool Lock)
        {
            this.numTopMargin.Enabled = !Lock;
            this.numMedList.Enabled = !Lock;
            this.numLeftMargin.Enabled = !Lock;
            this.numHCProvider.Enabled = !Lock;

            this.cbPrintFrames.Enabled = !Lock;
            this.cbPrintHCProvider.Enabled = !Lock;
            this.cbPrintLabels.Enabled = !Lock;
            this.cbPrintPrescNum.Enabled = !Lock;

            //this.HCProvRefresh.Enabled = !Lock;
        }

        Stream RecalcPrescriptionLayout(Stream xmlStream, double MaxHealthCareProviderHeight, double CurHealthCareProviderHeight, double MaxMedicinesListHeight, double CurMedicinesListHeight, double MinDatesHeight, double CurDatesHeight)
        {
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(xmlStream);
            xmlStream.Close();

            XmlNamespaceManager manager = new XmlNamespaceManager(doc.NameTable);
            manager.AddNamespace("ns", "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition");

            // Sections:
            // 1. top bar with "Const". Affected by nothing.
            // 2. affected by HealthCareProvider text field height. Elements with "Rp" and not "Const"
            // 3. affected by MedicinesList height. Elements with "Rp" and not "Const" and not "Middle"
            // 4. affected by coś tam height. Elements with "HCP_ML_cośtam_"

            #region Resized by HealthCareProvider
            XmlNodeList HCPnodes = doc.SelectNodes("//ns:ReportItems/*[contains(@Name, 'Rp_') and not(contains(@Name, 'Const_'))]", manager);

            foreach (XmlNode node in HCPnodes)
            {
                foreach (XmlNode NodeParam in node.ChildNodes)
                {
                    if (NodeParam.Name == "Top")
                    {
                        double t = System.Convert.ToDouble(NodeParam.InnerText.Replace("cm", "").Replace(".", ","));
                        NodeParam.InnerText = (t - (MaxHealthCareProviderHeight - CurHealthCareProviderHeight)).ToString("n2").Replace(",", ".") + "cm";
                    }
                }
            }

            SaveChangesToXML(ref doc, true);

            XmlNode HCP = doc.SelectSingleNode("//ns:Textbox[@Name='Rp_Const_HealthCareProvider']", manager);
            foreach (XmlNode node in HCP.ChildNodes)
            {
                if (node.Name == "Height")
                {
                    node.InnerText = CurHealthCareProviderHeight.ToString("n2").Replace(",", ".") + "cm";
                }
            }

            SaveChangesToXML(ref doc, true);
            #endregion

            #region Resized by MedicinesList

            XmlNode ML = doc.SelectSingleNode("//ns:Rectangle[@Name='Rp_Middle_MedicinesListRect']", manager);
            foreach (XmlNode node in ML.ChildNodes)
            {
                if (node.Name == "Height")
                {
                    //double h = System.Convert.ToDouble(node.InnerText.Replace("cm", "").Replace(".", ","));
                    node.InnerText = CurMedicinesListHeight.ToString("n2").Replace(",", ".") + "cm";
                }
            }

            SaveChangesToXML(ref doc, true);

            XmlNodeList MLnodes = doc.SelectNodes("//ns:ReportItems/*[contains(@Name, 'Rp_') and not(contains(@Name, 'Const_')) and not(contains(@Name, 'Middle_'))]", manager);
            foreach (XmlNode node in MLnodes)
            {
                foreach (XmlNode NodeParam in node.ChildNodes)
                {
                    if (NodeParam.Name == "Top")
                    {
                        double t = System.Convert.ToDouble(NodeParam.InnerText.Replace("cm", "").Replace(".", ","));
                        NodeParam.InnerText = (t - (MaxMedicinesListHeight - CurMedicinesListHeight)).ToString("n2").Replace(",", ".") + "cm";
                    }
                }
            }

            SaveChangesToXML(ref doc, true);
            #endregion

            #region Resized by Dates

            XmlNode DateNode = doc.SelectSingleNode("//ns:Textbox[@Name='Rp_Dates_Date']", manager);
            foreach (XmlNode node in DateNode.ChildNodes)
            {
                if (node.Name == "Height")
                {
                    node.InnerText = CurDatesHeight.ToString("n2").Replace(",", ".") + "cm";
                }
            }

            SaveChangesToXML(ref doc, true);

            XmlNodeList DatesFromNodes = doc.SelectNodes("//ns:ReportItems/*[contains(@Name, 'Rp_Dates_From')]", manager);
            foreach (XmlNode node in DatesFromNodes)
            {
                foreach (XmlNode NodeParam in node.ChildNodes)
                {
                    if (NodeParam.Name == "Top")
                    {
                        double t = System.Convert.ToDouble(NodeParam.InnerText.Replace("cm", "").Replace(".", ","));
                        NodeParam.InnerText = (t + (CurDatesHeight - MinDatesHeight)).ToString("n2").Replace(",", ".") + "cm";
                    }
                }
            }

            SaveChangesToXML(ref doc, true);

            XmlNode DateFromNode = doc.SelectSingleNode("//ns:Textbox[@Name='Rp_Dates_From_DateFrom']", manager);
            foreach (XmlNode node in DateFromNode.ChildNodes)
            {
                if (node.Name == "Height")
                {
                    node.InnerText = CurDatesHeight.ToString("n2").Replace(",", ".") + "cm";
                }
            }

            return SaveChangesToXML(ref doc, false);
            #endregion
        }

        Stream SaveChangesToXML(ref XmlDocument doc, bool Reload)
        {
            MemoryStream ResultStream = null;

            using (MemoryStream tmpStream = new MemoryStream())
            {
                doc.Save(tmpStream);
                tmpStream.Seek(0, SeekOrigin.Begin);
                if (Reload)
                {
                    doc.Load(tmpStream);
                }
                else
                {
                    ResultStream = new MemoryStream();
                    tmpStream.WriteTo(ResultStream);
                    ResultStream.Seek(0, SeekOrigin.Begin);
                }
            }

            return ResultStream;
        }

        Stream ChangeMargins(Stream xmlStream, double PrescriptionWidth, double PrescriptionHeight, double LeftMargin, double TopMargin)
        {
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(xmlStream);
            xmlStream.Close();
            XmlNode report = doc.SelectSingleNode("./*");
            foreach (XmlNode node in report.ChildNodes)
            {
                if (node.Name == "LeftMargin")
                {
                    node.InnerText = LeftMargin.ToString().Replace(",", ".") + "mm";
                }

                if (node.Name == "TopMargin")
                {
                    node.InnerText = TopMargin.ToString().Replace(",", ".") + "mm";
                }

                if (node.Name == "PageWidth")
                {
                    node.InnerText = (PrescriptionWidth * 10.0 + LeftMargin).ToString().Replace(",", ".") + "mm";
                }

                if (node.Name == "PageHeight")
                {
                    node.InnerText = (PrescriptionHeight * 10.0 + TopMargin).ToString().Replace(",", ".") + "mm";
                }
            }
            MemoryStream stream = new
            MemoryStream(); doc.Save(stream);
            stream.Seek(0, SeekOrigin.Begin);

            return stream;
        }

        private LocalReport PrintReportSilently(string ReportPath)
        {
            LocalReport lrep = new LocalReport();

            Stream s = new FileStream(ReportPath, FileMode.Open);
            lrep.LoadReportDefinition(RecalcPrescriptionLayout(ChangeMargins(s, this.PageWidth, this.PageHeight + 0.25, 0, 0), (double)this.numHCProvider.Maximum, (double)this.numHCProvider.Value, (double)this.numMedList.Maximum, (double)this.numMedList.Value, (double)this.numDateFields.Minimum, (double)this.numDateFields.Value));

            int RpWidth = 85;  // odczytywać z raportu!
            int MedHMax = 75 - (20 - (int)this.numMedList.Value * 10);  // odczytać z raportu!

            #region Budowanie listy leków
            Medicines med = new Medicines(RpWidth, MedHMax, -1, this.NormalFont, this.BoldFont, this.g);
            this.LoadData(med);

            lrep.DataSources.Clear();
            lrep.DataSources.Add(med.GetDataSource());
            #endregion

            #region Ustawienie parametrów
            Update_danePacjent();
            Update_danePrzychodni();
            ReportParameter PrintWireframe = new ReportParameter("PrintWireframe", this.cbPrintFrames.Checked.ToString());
            ReportParameter PrintLabels = new ReportParameter("PrintLabels", this.cbPrintLabels.Checked.ToString());
            ReportParameter PrintPrescriptionNumber = new ReportParameter("PrintPrescriptionNumber", this.cbPrintPrescNum.Checked.ToString());
            ReportParameter PrintHCProvider = new ReportParameter("PrintHCProvider", this.cbPrintHCProvider.Checked.ToString());

            ReportParameter HCP = new ReportParameter("HealthcareProvider", this.danePrzychodni);
            ReportParameter PNum = new ReportParameter("PrescriptionNumber", this.GenerateRandomRpNumber());

            ReportParameter PESEL = new ReportParameter("PESEL", "12345678901");
            ReportParameter PatientData = new ReportParameter("PatientData", "Joanna Kołodziejczyk-Krasnodębska" + Environment.NewLine + "90-110 Łódź, Prosta 6 m. 2");
            ReportParameter PrescriptionDate = new ReportParameter("PrescriptionDate", DateTime.Now.ToString("dd-MM-yyyy"));
            ReportParameter FromDate = new ReportParameter("FromDate", DateTime.Now.ToString("dd-MM-yyyy"));

            lrep.SetParameters(new ReportParameter[] { PrintWireframe, PrintLabels, HCP, PNum, PESEL, PatientData, PrescriptionDate, FromDate, PrintPrescriptionNumber, PrintHCProvider });
            #endregion

            lrep.AddTrustedCodeModuleInCurrentAppDomain("System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
            lrep.AddTrustedCodeModuleInCurrentAppDomain("I25, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

            return lrep;
        }

        private void RpViewer_RenderingBegin(object sender, CancelEventArgs e)
        {
            this.LockControls(true);
        }

        private void RpViewer_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            this.LockControls(false);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == this.tabPage1)
            {
                if (this.panRpComponents.Controls.Contains(this.RpViewer)) this.panRpComponents.Controls.Remove(this.RpViewer);
                this.panRpMargins.Controls.Add(this.RpViewer);
                this.RpViewer.Dock = DockStyle.Fill;

            }
            else if (tabControl1.SelectedTab == this.tabPage2)
            {
                if (this.panRpMargins.Controls.Contains(this.RpViewer)) this.panRpMargins.Controls.Remove(this.RpViewer);
                this.panRpComponents.Controls.Add(this.RpViewer);
                this.RpViewer.Dock = DockStyle.Fill;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void numLeftMargin_ValueChanged_1(object sender, EventArgs e)
        {
            if (!this.Setup) this.MakeReport((double)this.numLeftMargin.Value + this.HardMarginX, (double)this.numTopMargin.Value + this.HardMarginY);
        }

        private void numTopMargin_ValueChanged_1(object sender, EventArgs e)
        {
            if (!this.Setup) this.MakeReport((double)this.numLeftMargin.Value + this.HardMarginX, (double)this.numTopMargin.Value + this.HardMarginY);
        }

        private void numHCProvider_ValueChanged_1(object sender, EventArgs e)
        {
            if (!this.Setup) this.MakeReport((double)this.numLeftMargin.Value + this.HardMarginX, (double)this.numTopMargin.Value + this.HardMarginY);
        }

        private void numMedList_ValueChanged_1(object sender, EventArgs e)
        {
            if (!this.Setup) this.MakeReport((double)this.numLeftMargin.Value + this.HardMarginX, (double)this.numTopMargin.Value + this.HardMarginY);
        }

        private void numDateFields_ValueChanged_1(object sender, EventArgs e)
        {
            if (!this.Setup) this.MakeReport((double)this.numLeftMargin.Value + this.HardMarginX, (double)this.numTopMargin.Value + this.HardMarginY);
        }

        private void cbPrintFrames_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.Setup) this.MakeReport((double)this.numLeftMargin.Value + this.HardMarginX, (double)this.numTopMargin.Value + this.HardMarginY);
        }

        private void cbPrintLabels_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.Setup) this.MakeReport((double)this.numLeftMargin.Value + this.HardMarginX, (double)this.numTopMargin.Value + this.HardMarginY);
        }

        private void cbPrintPrescNum_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.Setup) this.MakeReport((double)this.numLeftMargin.Value + this.HardMarginX, (double)this.numTopMargin.Value + this.HardMarginY);
        }

        private void cbPrintHCProvider_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.Setup) this.MakeReport((double)this.numLeftMargin.Value + this.HardMarginX, (double)this.numTopMargin.Value + this.HardMarginY);
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            PrintingProvider prn = new PrintingProvider(this.PrintReportSilently(this.ReportPath),
                (int)this.numLeftMargin.Value, (int)this.numTopMargin.Value, this.PrinterName);
            prn.PrintIt();

            this.LockControls(false);
        }
    }

    class Medicines
    {
        Rp.MedicinesDataTable mdt;
        int Width;
        int Height;
        int dY;
        Font NormalFont;
        Font BoldFont;
        Graphics g;
        int H;

        public Medicines(int Width, int Height, int dY, Font NormalFont, Font BoldFont, Graphics g)
        {
            this.mdt = new Rp.MedicinesDataTable();
            this.Width = Width;
            this.Height = Height;
            this.NormalFont = NormalFont;
            this.BoldFont = BoldFont;
            this.g = g;

            this.dY = (dY > -1) ? dY : (int)this.g.MeasureString("#", this.NormalFont, this.Width).Height * 2;
        }

        public void AddMedicine(string Medicine, string Dosage, bool LastItem)
        {
            this.H += (int)this.g.MeasureString(Medicine, this.BoldFont, this.Width).Height;
            this.H += (int)this.g.MeasureString(Dosage, this.NormalFont, this.Width).Height;

            this.H += (LastItem) ? 0 : this.dY;

            if (this.H < this.Height)
            {
                Rp.MedicinesRow row = mdt.NewMedicinesRow();

                row.Name = Medicine;
                mdt.Rows.Add(row);
                row = mdt.NewMedicinesRow();
                row.Name = Dosage;
                mdt.Rows.Add(row);
            }
        }

        public ReportDataSource GetDataSource()
        {
            return new ReportDataSource("Rp_Medicines", this.mdt);
        }
    }
}
