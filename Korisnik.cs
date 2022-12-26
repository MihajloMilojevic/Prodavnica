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
        private int id, dnevnica;
        private DateTime datumZaposljenja;
        public Korisnik() { }
        public Korisnik(int id, string ime, string prezime, string korisnickoIme, string lozinka, string uloga, DateTime datumZaposljenja, int dnevnica)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.uloga = uloga;
            this.datumZaposljenja = datumZaposljenja;
            this.dnevnica = dnevnica;
        }
        public int ID
        {
            get { return id; }
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public string KorisnickoIme
        {
            get { return korisnickoIme; }
            set { korisnickoIme = value; }
        }
        public string Uloga
        {
            get { return uloga; }
            set { uloga = value; }
        }
        public DateTime DatumZaposljenja
        {
            get { return datumZaposljenja; }
        }
        public int Dnevnicna
        {
            get { return dnevnica; }
            set { dnevnica = value; }
        }
        public void Upisi(StreamWriter sw)
        {
                sw.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", this.ID, this.ime, this.prezime, this.korisnickoIme, this.lozinka, this.uloga, this.datumZaposljenja.ToString("dd.MM.yyyy"), this.dnevnica);
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
            k.datumZaposljenja = DateTime.ParseExact(podaci[6], "dd.MM.yyyy", null);
            k.dnevnica = int.Parse(podaci[7]);
            return k;
        }
        public static bool DodajNovog(string ime, string prezime, string korisnickoIme, string lozinka, string uloga, DateTime datumZaposljenja, int dnevnica)
        {
            try
            {
                Korisnik k = Korisnik.Pronadji(korisnickoIme);
                if (k != null) throw new Exception("Korisnik već postoji");

                Korisnik kor = new Korisnik(Korisnik.PoslednjiID() + 1, ime, prezime, korisnickoIme, lozinka, uloga, datumZaposljenja, dnevnica);
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
        public static int PoslednjiID()
        {
            int id = 0;
            StreamReader sr = new StreamReader(Korisnik.DATOTEKA);
            while (!sr.EndOfStream)
            {
                Korisnik k = Korisnik.Ucitaj(sr);
                id = k.id;
            }
            sr.Close();
            return id;
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
        public static List<Korisnik> SviKorisnici()
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            StreamReader sr = new StreamReader(Korisnik.DATOTEKA);
            while (!sr.EndOfStream)
            {
                Korisnik k = Korisnik.Ucitaj(sr);
                korisnici.Add(k);
            }
            sr.Close();
            return korisnici;
        }
        public void Ukloni()
        {
            List<Korisnik> svi = Korisnik.SviKorisnici();
            StreamWriter sw = new StreamWriter(Korisnik.DATOTEKA, false);
            foreach (Korisnik k in svi)
            {
                if (k.id == this.id) continue;
                k.Upisi(sw);
            }
            sw.Close();
        }
        public void Sacuvaj()
        {
            List<Korisnik> svi = Korisnik.SviKorisnici();
            StreamWriter sw = new StreamWriter(Korisnik.DATOTEKA, false);
            foreach(Korisnik k in svi)
            {
                if (k.id == this.id) this.Upisi(sw);
                else k.Upisi(sw);
            }
            sw.Close();
        }
    }
}
