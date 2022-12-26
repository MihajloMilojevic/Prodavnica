using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Prodavnica
{
    public class Korisnik
    {
        public static readonly string DATOTEKA = "korisnici.txt";
        private string ime, prezime, korisnickoIme, lozinka, uloga;
        private int id;
        public Korisnik() { }
        public Korisnik(string ime, string prezime, string korisnickoIme, string lozinka, string uloga, int id)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.uloga = uloga;
            this.id = id;
        }

        public int ID
        {
            get { return id; }
        }
        public string Ime
        {
            get { return ime; }
        }
        public string Prezime
        {
            get { return prezime; }
        }
        public string KorisnickoIme
        {
            get { return korisnickoIme; }
        }
        public string Uloga
        {
            get { return uloga; }
        }
        public void Upisi(StreamWriter sw)
        {
                sw.WriteLine("{0} {1} {2} {3} {4} {5}", this.ID, this.ime, this.prezime, this.korisnickoIme, this.lozinka, this.uloga);
        }
        public static Korisnik Ucitaj(StreamReader sr)
        {
            string linija = sr.ReadLine();
            Korisnik k = new Korisnik();
            string[] podaci = linija.Split(' ');
            k.id = int.Parse(podaci[0]);
            k.ime = podaci[1];
            k.prezime= podaci[2];
            k.korisnickoIme= podaci[3];
            k.lozinka = podaci[4];
            k.uloga = podaci[5];
            return k;
        }
        public static bool DodajNovog(string ime, string prezime, string korisnickoIme, string lozinka, string uloga)
        {
            try
            {
                Korisnik k = Korisnik.Pronadji(korisnickoIme);
                if (k != null) throw new Exception("Korisnik već postoji");

                Korisnik kor = new Korisnik(ime, prezime, korisnickoIme, lozinka, uloga, Korisnik.BrojKorisnika() + 1);
                StreamWriter sw = new StreamWriter(Korisnik.DATOTEKA, true);
                kor.Upisi(sw);
                sw.Close();
                return true;
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static Korisnik Pronadji(string korisnickoIme)
        {
            StreamReader sr = new StreamReader(Korisnik.DATOTEKA);
            while (!sr.EndOfStream)
            {
                Korisnik k = Korisnik.Ucitaj(sr);
                if (k.korisnickoIme == korisnickoIme)
                {
                    sr.Close();
                    return k;
                }
            }
            sr.Close();
            return null;
        }
        public static int BrojKorisnika()
        {
            int br = 0;
            StreamReader sr = new StreamReader(Korisnik.DATOTEKA);
            while (!sr.EndOfStream)
            {
                if(sr.ReadLine() != String.Empty)
                    br++;
            }
            sr.Close();
            return br;
        }
        public static Korisnik Prijava(string korisnickoIme, string lozinka)
        {
            try
            {
                Korisnik k = Korisnik.Pronadji(korisnickoIme);
                if (k == null) throw new Exception("Korisnik nije pronadjen");
                if (k.lozinka != lozinka) throw new Exception("Pogrešna lozinka");
                return k; 
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
