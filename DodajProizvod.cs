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
    public partial class DodajProizvod : Form
    {
        private bool zatvoriBezPitanja = false;
        private string slika;
        public DodajProizvod()
        {
            InitializeComponent();
        }

        private void izadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajProizvod_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (zatvoriBezPitanja) return;
            DialogResult odg = MessageBox.Show("Da li ste sigurni da želite da izađete? Promene možda neće biti sačuvane", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odg == DialogResult.No)
                e.Cancel = true;
        }

        private void sacuvaj_Click(object sender, EventArgs e)
        {
            bool dodat = Proizvod.DodajNov(nazivTB.Text, slika, (int)kolicinaNUD.Value, (double)cenaNUD.Value);
            if (!dodat) return;
            MessageBox.Show("Proizvod uspešno dodat");
            zatvoriBezPitanja = true;
            this.Close();
        }

        private void odaberiSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog dijalog = new OpenFileDialog();
            if (dijalog.ShowDialog() != DialogResult.OK) return;
            slika = dijalog.FileName;
            slikaPrikaz.Image = Image.FromFile(slika);
            slikaPrikaz.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
