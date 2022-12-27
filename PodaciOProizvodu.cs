using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodavnica
{
    public partial class PodaciOProizvodu : Form
    {
        private Proizvod proizvod;
        private bool zatvoriBezPitanja = false;
        public PodaciOProizvodu(Proizvod proizvod)
        {
            InitializeComponent();
            this.proizvod = proizvod;
        }
        private void PrikaziProizvod()
        {
            idTB.Text = proizvod.ID.ToString();
            nazivTB.Text = proizvod.Naziv;
            kolicinaNUD.Value = proizvod.Kolicina;
            cenaNUD.Value = (decimal)proizvod.Cena;
            slika.Image = Image.FromFile(proizvod.Slika);
        }
        private void PodaciOProizvodu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (zatvoriBezPitanja) return;
            DialogResult odg = MessageBox.Show("Da li ste sigurni da želite da izađete? Promene možda neće biti sačuvane", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odg == DialogResult.No)
                e.Cancel = true;
        }


        private void izadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sacuvaj_Click(object sender, EventArgs e)
        {
            proizvod.Sacuvaj();
            MessageBox.Show("Podaci o proizvodu uspešno sačuvani");
            zatvoriBezPitanja = true;
            this.Close();
        }

        private void PodaciOProizvodu_Load(object sender, EventArgs e)
        {
            PrikaziProizvod();
        }

        private void ukoni_Click(object sender, EventArgs e)
        {
            proizvod.Ukloni();
            MessageBox.Show("Proizvod uklonjen");
            zatvoriBezPitanja = true;
            this.Close();
        }

        private void nazivTB_TextChanged(object sender, EventArgs e)
        {
            proizvod.Naziv = nazivTB.Text;
            PrikaziProizvod();
        }

        private void kolicinaNUD_ValueChanged(object sender, EventArgs e)
        {
            proizvod.Kolicina = (int)kolicinaNUD.Value;
            PrikaziProizvod();
        }

        private void cenaNUD_ValueChanged(object sender, EventArgs e)
        {
            proizvod.Cena = (double)cenaNUD.Value;
            PrikaziProizvod();
        }
    }
}
