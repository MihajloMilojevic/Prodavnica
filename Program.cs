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
        static void ProveriFajlove()
        {
            if (!File.Exists(Korisnik.DATOTEKA))
            {
                File.Create(Korisnik.DATOTEKA).Close();
                Korisnik.DodajNovog("Sara", "Spasojevic", "sara.spasojevic", "Sara123", "admin");
                Korisnik.DodajNovog("Mihajlo", "Milojevic", "mihajlo.milojevic", "Mihajlo123", "magacin");
                Korisnik.DodajNovog("Nikola", "Rogonjic", "nikola.rogonjic", "Nikola123", "kasa");
            }

        }
        static void Main()
        {
            ProveriFajlove();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Prijava());
        }
    }
}
