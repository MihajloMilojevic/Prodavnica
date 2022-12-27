using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Prodavnica
{
    public class Proizvod
    {
        public static string FOLDER = "proizvodi";
        public static string DATOTEKA { get { return FOLDER + "\\" + "proizvodi.txt"; } }
        private int id, kolicina;
        private double cena;
        private string naziv, slika;
        public Proizvod() { }
        public Proizvod(int id, string naziv, string slika, int kolicina, double cena)
        {
            this.id = id;
            this.naziv = naziv;
            this.slika = slika;
            this.kolicina = kolicina;
            this.cena = cena;
        }
        public int ID 
        {
            get { return id; }
        }
        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }
        public double Cena 
        {
            get { return cena; }
            set { cena = value; }
        }
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        public string Slika
        {
            get { return slika; }
            set { slika = value; }
        }
        public void Upisi(StreamWriter sw)
        {
            sw.WriteLine(id);
            sw.WriteLine(naziv);
            sw.WriteLine(slika);
            sw.WriteLine(kolicina);
            sw.WriteLine("{0:0.00}", cena);
        }
        public static Proizvod Ucitaj(StreamReader sr)
        {
            Proizvod p = new Proizvod();
            p.id = int.Parse(sr.ReadLine());
            p.naziv = sr.ReadLine();
            p.slika = sr.ReadLine();
            p.kolicina = int.Parse(sr.ReadLine());
            p.cena = double.Parse(sr.ReadLine());
            return p;
        }
        public static List<Proizvod> SviProizvodi()
        {
            List<Proizvod> proizvodi = new List<Proizvod>();
            StreamReader sr = new StreamReader(Proizvod.DATOTEKA);
            while (!sr.EndOfStream)
            {
                Proizvod p = Proizvod.Ucitaj(sr);
                proizvodi.Add(p);
            }
            sr.Close();
            return proizvodi;
        }
        public static int PoslednjiID()
        {
            int id = 0;
            StreamReader sr = new StreamReader(Proizvod.DATOTEKA);
            while (!sr.EndOfStream)
            {
                Proizvod p = Proizvod.Ucitaj(sr);
                id = p.id;
            }
            sr.Close();
            return id;
        }
        public void Ukloni()
        {
            List<Proizvod> svi = Proizvod.SviProizvodi();
            StreamWriter sw = new StreamWriter(Proizvod.DATOTEKA, false);
            foreach (Proizvod p in svi)
            {
                if (p.id == this.id) continue;
                p.Upisi(sw);
            }
            sw.Close();
        }
        public void Sacuvaj()
        {
            List<Proizvod> svi = Proizvod.SviProizvodi();
            StreamWriter sw = new StreamWriter(Proizvod.DATOTEKA, false);
            foreach (Proizvod p in svi)
            {
                if (p.id == this.id) this.Upisi(sw);
                else p.Upisi(sw);
            }
            sw.Close();
        }
        public static bool DodajNov(string naziv, string slika, int kolicina, double cena )
        {
            try
            {
                List<Proizvod> svi = Proizvod.SviProizvodi();
                foreach(Proizvod pr in svi) if (pr.naziv == naziv) throw new Exception("Proizvod već postoji");
                string putanja = Proizvod.FOLDER + @"\" + naziv + "." + slika.Split('.').Last();
                File.Copy(slika, putanja);
                Proizvod p = new Proizvod(Proizvod.PoslednjiID() + 1, naziv, putanja, kolicina, cena);
                StreamWriter sw = new StreamWriter(Proizvod.DATOTEKA, true);
                p.Upisi(sw);
                sw.Close();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
