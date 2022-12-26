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
    public partial class Administracija : Form
    {
        private Korisnik korisnik;
        private List<Korisnik> korisnici;
        public Administracija(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void Administracija_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult odg = MessageBox.Show("Da li ste sigurni da želite da se odjavite?", "Odjava", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odg == DialogResult.No)
                e.Cancel = true;
        }
        private void PrikaziKorisnike()
        {
            korisnici = Korisnik.SviKorisnici();
            tabela.Rows.Clear();
            foreach (Korisnik k in korisnici)
                tabela.Rows.Add(k.KorisnickoIme, k.ID, k.Ime, k.Prezime, k.Uloga);
        }
        private void Administracija_Load(object sender, EventArgs e)
        {
            PrikaziKorisnike();
        }

        private void tabela_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > korisnici.Count) return;
            new PodaciOZaposlenom(korisnici[e.RowIndex]).ShowDialog();
            PrikaziKorisnike();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            (new DodajZaposleog()).ShowDialog();
            PrikaziKorisnike();
        }
    }
}
