﻿using System;
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
            Application.Run(new Rejestracja());
            //Application.Run(new Login());
            //Application.Run(new DodajPacjent());
            //Application.Run(new dodajOpiekun());
        }
    }
}
