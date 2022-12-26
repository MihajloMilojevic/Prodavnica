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
    public partial class PodaciOZaposlenom : Form
    {
        private Korisnik zaposleni;
        private bool zatvoriBezPitanja = false;
        public PodaciOZaposlenom(Korisnik zaposleni)
        {
            InitializeComponent();
            this.zaposleni = zaposleni;
        }
        private void PrikaziZaposlenog()
        {
            idTB.Text = zaposleni.ID.ToString();
            imeTB.Text = zaposleni.Ime;
            prezimeTB.Text = zaposleni.Prezime;
            korisnickoImeTB.Text = zaposleni.KorisnickoIme;
            ulogaCB.SelectedItem = zaposleni.Uloga;
            datumZaposljenjaTB.Text = zaposleni.DatumZaposljenja.ToString("dd.MM.yyyy.");
            dnevnicaNUD.Value = zaposleni.Dnevnicna;
            daniRadaTB.Text = (DateTime.Now - zaposleni.DatumZaposljenja).Days.ToString();
            plataTB.Text = (int.Parse(daniRadaTB.Text) * dnevnicaNUD.Value).ToString();
        }
        private void PodaciOZaposlenom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (zatvoriBezPitanja) return;
            DialogResult odg = MessageBox.Show("Da li ste sigurni da želite da izađete? Promene možda neće biti sačuvane", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odg == DialogResult.No)
                e.Cancel = true;
        }

        private void PodaciOZaposlenom_Load(object sender, EventArgs e)
        {
            PrikaziZaposlenog();
        }

        private void imeTB_TextChanged(object sender, EventArgs e)
        {
            zaposleni.Ime = imeTB.Text;
            PrikaziZaposlenog();
        }

        private void prezimeTB_TextChanged(object sender, EventArgs e)
        {
            zaposleni.Prezime = prezimeTB.Text;
            PrikaziZaposlenog();
        }

        private void korisnickoImeTB_TextChanged(object sender, EventArgs e)
        {
            zaposleni.KorisnickoIme = korisnickoImeTB.Text;
            PrikaziZaposlenog();
        }

        private void ulogaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            zaposleni.Uloga = ulogaCB.SelectedItem.ToString();
            PrikaziZaposlenog();
        }

        private void dnevnicaNUD_ValueChanged(object sender, EventArgs e)
        {
            zaposleni.Dnevnicna = (int)dnevnicaNUD.Value;
            PrikaziZaposlenog();
        }

        private void izadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sacuvaj_Click(object sender, EventArgs e)
        {
            zaposleni.Sacuvaj();
            MessageBox.Show("Podaci o korisniku uspešno sačuvani");
            zatvoriBezPitanja = true;
            this.Close();
        }

        private void otpusi_Click(object sender, EventArgs e)
        {
            zaposleni.Ukloni();
            MessageBox.Show("Zaposleni otpušten :(");
            zatvoriBezPitanja = true;
            this.Close();
        }
    }
}
