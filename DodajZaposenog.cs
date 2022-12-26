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
    public partial class DodajZaposleog : Form
    {
        private bool zatvoriBezPitanja = false;
        public DodajZaposleog()
        {
            InitializeComponent();
        }

        private void izadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajZaposleog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (zatvoriBezPitanja) return;
            DialogResult odg = MessageBox.Show("Da li ste sigurni da želite da izađete? Promene možda neće biti sačuvane", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odg == DialogResult.No)
                e.Cancel = true;
        }

        private void sacuvaj_Click(object sender, EventArgs e)
        {
            bool dodat = Korisnik.DodajNovog(imeTB.Text, prezimeTB.Text, korisnickoImeTB.Text, lozinkaTB.Text, ulogaCB.SelectedItem.ToString(), datumZaposljavanjaMC.SelectionStart, (int)dnevnicaNUD.Value);
            if (!dodat) return;
            MessageBox.Show("Korisnik uspešno kreiran");
            zatvoriBezPitanja = true;
            this.Close();
        }

    }
}
