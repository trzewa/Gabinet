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

namespace Gabinet
{
    public partial class pobranieBazyl : Form
    {
        public pobranieBazyl()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;           
            this.textBoxAdres.Text = "http://karnet.waw.pl/bazyl/pliki/1525/mps/mpdbf.exe";
            //this.textBoxLogin.Text = "kopalnia";
            //this.textBoxHaslo.Text = "informacji";
        }

        private void buttonPobierz_Click(object sender, EventArgs e)
        {
            string link = this.textBoxAdres.Text.ToString();
            //string login = this.textBoxLogin.Text.ToString();
            //string haslo = this.textBoxHaslo.Text.ToString();

            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                /*FtpWebRequest request = (FtpWebRequest)WebRequest.Create(link);
                request.Method = WebRequestMethods.Ftp.DownloadFile;                
                request.Credentials = new NetworkCredential(login, haslo);
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();*/

                
                WebClient client = new WebClient();
                client.DownloadFileCompleted += client_DownloadFileComleted;
                client.DownloadProgressChanged += client_DownloadProgresChanged;
                client.DownloadFileAsync(new Uri(link), saveFileDialog1.FileName);                
                buttonPobierz.Enabled = false;
            }
            else
            {
                MessageBox.Show("Nie wybrano nazwy pliku", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void client_DownloadProgresChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double sciagniete = Convert.ToDouble(e.BytesReceived);
            double suma = Convert.ToDouble(e.TotalBytesToReceive);
            double procenty = sciagniete / suma * 100;
            int wartosc = Convert.ToInt32(Math.Truncate(procenty));
            label4.Text = wartosc.ToString() + "%";
            progressBar1.Value = wartosc;
        }

        private void client_DownloadFileComleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Sciągnięto plik", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonPobierz.Enabled = true;
        }
    }
}
