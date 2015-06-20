using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gabinet
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Start());
            //Application.Run(new Rejestracja());            
            //Application.Run(new Logout());
            //Application.Run(new DodajPacjent());
            //Application.Run(new dodajOpiekun());
            //Application.Run(new organizacjaPrzychodni());
            //Application.Run(new danePacjent());
            //Application.Run(new bazaDane());
            //Application.Run(new zwolnienie());
            //Application.Run(new recepta());
            Application.Run(new Login());
        }
    }
}
