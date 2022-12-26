using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Prodavnica
{
    internal class Korisnik
    {
        private string ime, prezime, korisnickoIme, lozinka;
        private int id;
        public Korisnik() { }
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
            return k;
        }
        public static bool DodajNovog(string ime, string prezime, string korisnickoIme, string lozinka)
        {
            try
            {
                StreamReader sr = new StreamReader("korisnici.txt");
                int poslednjiId = 0;
                while(!sr.EndOfStream)
                {
                    Korisnik k = Korisnik.Ucitaj(sr);
                    poslednjiId = k.ID;
                    if(k.korisnickoIme == korisnickoIme)
                    {
                        throw new Exception("Korisnik već postoji");
                    }
                }
                // upisi novog korinsika
                return true;
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
