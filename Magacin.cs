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
    public partial class Magacin : Form
    {
        private Korisnik korisnik;
        private List<Proizvod> proizvodi;
        public Magacin(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void Magacin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult odg = MessageBox.Show("Da li ste sigurni da želite da se odjavite?", "Odjava", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odg == DialogResult.No)
                e.Cancel = true;
        }
        private void PrikaziProizvode()
        {
            proizvodi = Proizvod.SviProizvodi();
            tabela.Rows.Clear();
            foreach (Proizvod p in proizvodi)
                tabela.Rows.Add(p.ID, p.Naziv, p.Cena.ToString("0.00"), p.Kolicina.ToString());
        }
        private void Magacin_Load(object sender, EventArgs e)
        {
            PrikaziProizvode();
        }

        private void tabela_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > proizvodi.Count) return;
            new PodaciOProizvodu(proizvodi[e.RowIndex]).ShowDialog();
            PrikaziProizvode();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            (new DodajProizvod()).ShowDialog();
            PrikaziProizvode();
        }
    }
}
