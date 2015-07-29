using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Printing;


namespace Gabinet
{
    class PrintingProvider
    {
        private int m_currentPageIndex;
        private IList<Stream> m_streams;
        private Microsoft.Reporting.WinForms.LocalReport Raport;

        decimal MarginLeft;
        decimal MarginTop;

        string PrinterName;

        public PrintingProvider(Microsoft.Reporting.WinForms.LocalReport Raport, decimal MarginLeft, decimal MarginTop, string PrinterName)
        {
            this.Raport = Raport;
            this.MarginLeft = MarginLeft;
            this.MarginTop = MarginTop;
            this.PrinterName = PrinterName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Export();
            m_currentPageIndex = 0;
            PrintIt();
        }

        private Stream CreateStream(string name, string fileNameExtension,
        Encoding encoding,
            string mimeType, bool willSeek)
        {
            System.IO.MemoryStream memStream = new System.IO.MemoryStream();
            m_streams.Add(memStream);
            return memStream;
        }

        enum FileTypes
        {
            PDF,
            PNG,
            TIFF
        }

        private void ExportToFile(FileTypes Type, string FileName)
        {
            Microsoft.Reporting.WinForms.Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            string type = "";
            string format = "";

            switch (Type)
            {
                case FileTypes.PDF:
                    type = "PDF";
                    format = "PDF";
                    break;

                case FileTypes.PNG:
                    type = "PNG";
                    format = "IMAGE";
                    break;

                case FileTypes.TIFF:
                    type = "TIFF";
                    format = "IMAGE";
                    break;
            }

            string deviceInfo =
                         "<DeviceInfo>" +
                         "  <OutputFormat>" + type + "</OutputFormat>" +
                            "  <PageWidth>21cm</PageWidth>" +
                            "  <PageHeight>29.7cm</PageHeight>" +
                         "  <MarginTop>" + this.MarginTop.ToString("n2").Replace(",", ".") + "mm</MarginTop>" +
                         "  <MarginLeft>" + this.MarginLeft.ToString("n2").Replace(",", ".") + "mm</MarginLeft>" +
                         "  <MarginRight>0.0in</MarginRight>" +
                         "  <MarginBottom>0.0in</MarginBottom>" +
                         "</DeviceInfo>";

            byte[] bytes = this.Raport.Render(format, deviceInfo, out mimeType, out encoding, out extension, out streamids, out warnings);

            FileStream fs = new FileStream(FileName, FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(bytes);
            bw.Close(); 
        }

        private void Export()
        {
            string deviceInfo =
              "<DeviceInfo>" +
              "  <OutputFormat>EMF</OutputFormat>" +
                 "  <PageWidth>21cm</PageWidth>" +
                 "  <PageHeight>29.7cm</PageHeight>" +
              "  <MarginTop>" + this.MarginTop.ToString("n2").Replace(",", ".") + "mm</MarginTop>" +
              "  <MarginLeft>" + this.MarginLeft.ToString("n2").Replace(",", ".") + "mm</MarginLeft>" +
              "  <MarginRight>0.0in</MarginRight>" +
              "  <MarginBottom>0.0in</MarginBottom>" +
              "</DeviceInfo>";
            Microsoft.Reporting.WinForms.Warning[] warnings;
            m_streams = new List<Stream>();

            this.Raport.Render("Image", deviceInfo, this.CreateStream, out warnings);

            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new Metafile(m_streams[m_currentPageIndex]);
            ev.Graphics.DrawImage(pageImage, ev.PageBounds);

            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        private void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                return;

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = this.PrinterName;
            if (!printDoc.PrinterSettings.IsValid)
            {
                string msg = String.Format("Can't find printer \"{0}\".", this.PrinterName);
                Console.WriteLine(msg);
                return;
            }
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
            printDoc.DocumentName = "Recepta";
            printDoc.PrintController = new StandardPrintController();
            printDoc.Print();
        }

        public void PrintIt()
        {
            ExportToFile(FileTypes.PDF, "Rp.pdf");

            this.Export();
            this.m_currentPageIndex = 0;
            this.Print();
        }
    }
}
