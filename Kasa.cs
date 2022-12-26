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
    public partial class Kasa : Form
    {
        private Korisnik korisnik;
        public Kasa(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void Kasa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult odg = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odg == DialogResult.Yes)
                Application.Exit();
            e.Cancel = true;
        }

    }
}
