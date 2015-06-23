using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace Gabinet
{
    public partial class pobranieBazyl : Form
    {
        private WebClient client = new WebClient();
        private string login = "kopalnia";
        private string haslo = "informacji";
        private string linke = "ftp://ftp.imspoland.com.pl/";
        
        public pobranieBazyl()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            if (File.Exists(@"c:\Baza\wersja.txt"))
            {
                string wersjaLokalna = File.ReadAllText(@"c:\Baza\wersja.txt");
                label1.Text = "Wersja aktualna:";
                label5.Text = wersjaLokalna;
            }
            else
            {
                label5.Text = "Brak pliku";
            }
        }

        private void buttonPobierz_Click(object sender, EventArgs e)
        {            
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(linke);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential(login, haslo);
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string wersjaFtp = reader.ReadToEnd().ToString().Substring(10, 4);
            reader.Close();
            response.Close(); 

            if (File.Exists(@"c:\Baza\wersja.txt"))
            {
                string wersjaLokalna = File.ReadAllText(@"c:\Baza\wersja.txt");

                if (wersjaLokalna.Equals(wersjaFtp))
                {
                    MessageBox.Show(this, "Posiadasz najnowszą wersję bazy leków BAZYL", "Kontrola wersji", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label5.Text = wersjaLokalna;
                    buttonPobierz.Enabled = true;
                    buttonAnuluj.Enabled = false;
                }
                else
                {
                    string link = "http://karnet.waw.pl/bazyl/pliki/" + wersjaFtp + "/mps/mpdbf.exe";                   
                    string[] temp = link.Split('/');
                    saveFileDialog1.FileName = @"c:\Baza\" + temp[temp.Length - 1];
                    
                    if (DialogResult.OK == saveFileDialog1.ShowDialog())
                    {                        
                        client.DownloadFileCompleted += client_DownloadFileComleted;
                        client.DownloadProgressChanged += client_DownloadProgresChanged;
                        client.DownloadFileAsync(new Uri(link), saveFileDialog1.FileName);
                        File.WriteAllText(@"c:\Baza\wersja.txt", wersjaFtp);
                        buttonPobierz.Enabled = false;
                        buttonAnuluj.Enabled = true;
                        
                        label5.Text = wersjaFtp;
                    }
                    else
                    {
                        MessageBox.Show(this, "Nie wybrano nazwy pliku", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    label1.Text = "Wersja pobierana:";
                }
            }
            else
            {
                System.IO.Directory.CreateDirectory(@"c:\Baza");
                string link = "http://karnet.waw.pl/bazyl/pliki/" + wersjaFtp + "/mps/mpdbf.exe";               
                string[] temp = link.Split('/');
                saveFileDialog1.FileName = @"c:\Baza\" + temp[temp.Length - 1];
                
                if (DialogResult.OK == saveFileDialog1.ShowDialog())
                {                    
                    client.DownloadFileCompleted += client_DownloadFileComleted;
                    client.DownloadProgressChanged += client_DownloadProgresChanged;
                    client.DownloadFileAsync(new Uri(link), saveFileDialog1.FileName);                    
                    File.WriteAllText(@"c:\Baza\wersja.txt", wersjaFtp);
                    buttonPobierz.Enabled = false;
                    buttonAnuluj.Enabled = true;
                    
                    label5.Text = wersjaFtp;
                }
                else
                {
                    MessageBox.Show(this, "Nie wybrano nazwy pliku", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                label1.Text = "Wersja pobierana:";
            }            
        }

        private void client_DownloadProgresChanged(object sender, DownloadProgressChangedEventArgs e)
        { 
            label4.Text = e.ProgressPercentage.ToString() + "%";
            progressBar1.Value = e.ProgressPercentage;
        }

        private void client_DownloadFileComleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show(this, "Anulowano pobieranie pliku", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar1.Value = 0;
                label4.Text = "";

            }
            else
            {
                MessageBox.Show(this, "Sciągnięto plik", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            label1.Text = "Wersja aktualna:";
            buttonPobierz.Enabled = true;
            buttonAnuluj.Enabled = false;
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            client.CancelAsync();
        }        
    }
}
