using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prodavnica
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            string korisnickoIme = korisnickoImeTB.Text;
            string lozinka = lozinkaTB.Text;

            lozinkaTB.Text = String.Empty;

            Korisnik k = Korisnik.Prijava(korisnickoIme, lozinka);
            if (k == null) return;
            MessageBox.Show("Zdravo, " + k.Ime + " " + k.Prezime);
            this.Hide();
            switch(k.Uloga)
            {
                case "admin":
                    (new Administracija(k)).ShowDialog();
                    break;
                case "kasa":
                    (new Kasa(k)).ShowDialog();
                    break;
                case "magacin":
                    (new Magacin(k)).ShowDialog();
                    break;
                default:
                    this.Show();
                    return;
            }
            this.Close();
        }

        private void Prijava_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult odg = MessageBox.Show("Da li ste sigurni da želite da izađete?", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odg == DialogResult.No)
                e.Cancel = true;
        }

    }
}
