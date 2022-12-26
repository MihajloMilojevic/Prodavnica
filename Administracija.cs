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
        public Administracija(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void Administracija_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult odg = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odg == DialogResult.No)
                e.Cancel = true;
        }
        private void PrikaziKorisnike()
        {
            List<Korisnik> korisnici = Korisnik.SviKorisnici();
            tabela.Rows.Clear();
            foreach (Korisnik k in korisnici)
                tabela.Rows.Add(k.ID, k.Ime, k.Prezime, k.Uloga, (DateTime.Now - k.PocetakUgovora).Days, (k.KrajUgovora - DateTime.Now).Days);
        }
        private void Administracija_Load(object sender, EventArgs e)
        {
            tabela.Width = panel1.Width;
            PrikaziKorisnike();
        }

    }
}
