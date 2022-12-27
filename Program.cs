using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prodavnica
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ProveriFajlove();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Prijava());
        }
        [STAThread]
        static void ProveriFajlove()
        {
            if (!File.Exists(Korisnik.DATOTEKA))
            {
                File.Create(Korisnik.DATOTEKA).Close();
                Korisnik.DodajNovog("Sara", "Spasojevic", "sara.spasojevic", "Sara123", "admin", new DateTime(2022, 9, 1), 2300);
                Korisnik.DodajNovog("Mihajlo", "Milojevic", "mihajlo.milojevic", "Mihajlo123", "magacin", new DateTime(2022, 9, 2), 1750);
            }
            if (!Directory.Exists(Proizvod.FOLDER))
            {
                Directory.CreateDirectory(Proizvod.FOLDER);
            }
            if (!File.Exists(Proizvod.DATOTEKA))
            {
                File.Create(Proizvod.DATOTEKA).Close();

            }

        }
    }
}
